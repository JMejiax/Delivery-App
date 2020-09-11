using CAPA_DATOS;
using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Gestores;
using CAPA_ENTIDADES.Facade;
using CAPA_ENTIDADES.Utilitarios;
using CAPA_LN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using GMap.NET.MapProviders;
using log4net;

namespace CAPA_UI
{
    public partial class Cliente_NuevoPedido : Form
    {
        #region VARIABLES
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        Cupon _Cupon;
        public static Negocio _Negocio;
        public static FacadePedido fPedido;
        public static GestorFactura _Factura;
        List<Producto> lista;

        #endregion VARIABLES
        public Cliente_NuevoPedido()
        {
            InitializeComponent();
        }

        private void Cliente_NuevoPedido_Load(object sender, EventArgs e)
        {
            List<Negocio> ListaNegocios = UsuarioDB.ObtenerNegocios();

            dgvNegocios.DataSource = ListaNegocios;

            // Quitar la informacion irrelevante para el usuario
            dgvNegocios.Columns["Contrasenna"].Visible = false;
            dgvNegocios.Columns["Id"].Visible = false;
            dgvNegocios.Columns["_Direccion"].Visible = false;
            dgvNegocios.Columns["_Tarjeta"].Visible = false;
            dgvNegocios.Columns["Activo"].Visible = false;

            // Validar si tiene facturas pendiente
            try
            {
                FacturaLN facturaLN = new FacturaLN();
                Factura fac = facturaLN.ObtenerFacturaSinCalificar(MenuCliente._Cliente.Id);

                if (fac.Estado_Calificacion.ToLower().Equals("sin calificar"))
                {
                    MessageBox.Show(this, "Usted cuenta con una orden en proceso, podrá pedir cuando se cancele la orden actual", "Orden en camino!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSeleccionar.Enabled = false;
                }
            }catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("El cliente no cuenta con facturas pendientes\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }
        #region SELECCION PEDIDO
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            // Llenar dgv con los productos del negocio seleccionado
            string correo = dgvNegocios.SelectedRows[0].Cells[6].Value.ToString();
            _Negocio = (Negocio)UsuarioDB.SeleccionarPorCorreo(correo);

            List<Producto> lista = new List<Producto>();

            foreach (Articulo prod in _Negocio.ListaProductos)
            {
                if (prod is Producto)
                    if ((prod as Producto).Activo)
                        lista.Add((prod as Producto));
            }

            dgvArticulos.DataSource = lista;
            dgvArticulos.Columns["Precio"].DisplayIndex = 6;

            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UsuarioId"].Visible = false;
            dgvArticulos.Columns["Activo"].Visible = false;
            dgvArticulos.Columns["Cantidad"].Visible = false;

            // Cambiar el tamaño de las imagenes
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                Image imagen = (Image)row.Cells["Fotografia"].Value;
                row.Cells["Fotografia"].Value = Util.CambiarTamanoImagen(imagen, 60, 50);
            }

        }
        private void dgvArticulos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Obetener el producto de la base de datos y agregarlo a la lista
            Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            listaPedido.Items.Add(articulo);
            listaPedido.DisplayMember = "Nombre";

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (listaPedido.SelectedItem != null)
                listaPedido.Items.RemoveAt(listaPedido.SelectedIndex);
            
        }

        #endregion SELECCION PEDIDO

        #region FUNCIONALIDADES VENTANA Y CREACION DE PEDIDO-FACTURA
        private void btnSiguienteTab2_Click(object sender, EventArgs e)
        {
            // Obtener lista de pedido
            lista = new List<Producto>();
            var items = listaPedido.Items;
            foreach (var prod in items)
            {
                if (lista.Contains((Producto)prod))
                {
                    int i = lista.IndexOf((Producto)prod);
                    lista[i].Cantidad += 1;
                }
                else
                {
                    lista.Add((Producto)prod);
                    int i = lista.IndexOf((Producto)prod);
                    lista[i].Cantidad = 1;
                }

            }

            if (lista.Count > 0)
            {

                tabControl1.SelectedIndex = 2;

                // Crear Factura con Gestor
                _Factura = new GestorFactura();
                _Factura.AsignarNegocio(_Negocio);
                _Factura.AsignarCliente(MenuCliente._Cliente);
                _Factura.AsignarFecha(DateTime.Now);
                _Factura.AsignarEstadoFactura("Pendiente");
                _Factura.AsignarEstadoPedido("En espera");

                // Crear Pedido
                fPedido = new FacadePedido()
                {
                    ListaProductos = lista
                };

                // Asignar el pedido a la factura
                _Factura.AsignarPedido(fPedido);

                // Asignar valores a los textos de el panel con la iformacion del pedido
                txtCostoNormal.Text = "¢" + fPedido.CostoSinCupones();
                txtImpuesto.Text = "¢" + fPedido.ImpuestoVentas();
                txtCostoTotal.Text = "¢" + _Factura.CostoTotal();
                txtCostoExpress.Text = "¢" + _Factura.CostoExpress();
                txtCostoTotalDolares.Text = "$" + _Factura.CostoTotalDolares();
            }
            else
                MessageBox.Show(this, "Debe agregar productos a la lista", "Agregue productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnCancelarTab2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            listaPedido.Items.Clear();
        }

        private void CancelarPedido_Click(object sender, EventArgs e)
        {
            int resul = (int)MessageBox.Show(this, "Está seguro que desea cancelar la orden?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resul == 6)
            {
                _Factura = null;
                Close();
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValidarCupon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCupon.Text.Equals(""))
                    MessageBox.Show(this, "Ingrese un código QR", "Espacio vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    string qr = txtCupon.Text;
                    ArticuloLN articuloLN = new ArticuloLN();
                    _Cupon = articuloLN.ObtenerCupoPorQR(qr);

                    if (_Cupon != null && _Cupon.UsuarioId == _Negocio.Id)
                    {
                        btnValidarCupon.Enabled = false;
                        fPedido.AsignarCupon(_Cupon);

                        if (_Cupon is CupoDescuento)
                        {
                            txtDescuentoCupon.Text = "¢" + fPedido.DescuentoCupon();
                            // Actualizar Montos
                            txtCostoTotal.Text = "¢" + _Factura.CostoTotal();
                            txtCostoTotalDolares.Text = "$" + _Factura.CostoTotalDolares();
                            MessageBox.Show(this, "Se le ha hecho un descuento del : " + ((_Cupon as CupoDescuento).PorcentajeDescuento * 100) + "% a su orden", "Canjeo de cupón exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            log.Info("Se ha canjeado un cupon de descuento");
                        }

                        if (_Cupon is CuponProductoGratis)
                        {
                            bool existe = false;
                            int id = (_Cupon as CuponProductoGratis).IDProducto;
                            Producto prod = (Producto)articuloLN.ObtenerProducto(id);
                            foreach (var producto in lista)
                            {
                                if (producto.Id == prod.Id)
                                {
                                    producto.Cantidad += 1;
                                    existe = true;
                                }

                            }
                            if (!existe)
                            {
                                prod.Cantidad = 1;
                                fPedido.AgregarArticulo(prod);
                            }
                            txtDescuentoCupon.Text = "¢" + fPedido.DescuentoCupon();
                            MessageBox.Show(this, "Se ha agregado un: " + prod.Nombre + " a su orden", "Canjeo de producto exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            log.Info("Se ha canjeado un cupon de producto gratis");
                        }

                    }
                    else
                        MessageBox.Show(this, "No se encontró ningún cupón con el código QR brindado", "Cupón inválido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("No se pudo canjear un cupon\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }

        private void btnAceptarPedido_Click(object sender, EventArgs e)
        {
            int resul = (int)MessageBox.Show(this, "Está seguro que desea ordenar este pedido?", "Aceptar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // Gurdar todo en la base de datos para que despues aparezca el pedido en la app de Negocio
            if (resul == 6)
            {
                try
                {
                    // Agregar la factura
                    FacturaLN facturaLN = new FacturaLN();
                    _Factura.AsignarEstadoFactura("Pagado");
                    _Factura.AsignarEstadoPedido("En espera");
                    _Factura.AsignarEstadoCalificacion("Sin calificar");
                    facturaLN.IngresarFactura(_Factura.ObtenerFactura());

                    // Agregar detalle factura
                    PedidoLN pedidoLN = new PedidoLN();
                    foreach (Producto prod in lista)
                    {
                        pedidoLN.InsertarDetalleFactura(prod);
                    }

                    // Agregar cupon usado
                    if(_Cupon != null)
                        facturaLN.InsertarCuponUsado(MenuCliente._Cliente, _Cupon);

                    // Guardar el xml y pdf y adjuntarlos
                    string xml = _Factura.ObtenerXML();
                    _Factura.GenerarPDF();

                    // Crear xml
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(xml);
                    doc.Save("FacturaElectronica.xml");

                    List<string> files = new List<string>();
                    files.Add(@"FacturaElectronica.xml");
                    files.Add(@"FacturaElectronica.pdf");
                    //MenuCliente._Cliente.Correo
                    Correo1.EnviarCorreo(MenuCliente._Cliente.Correo, "Gracias por usar nuestro servicio express", "Delivery S.A | Compra exitosa", files);

                    // Se relaciona el cliente con la factura
                    facturaLN.RelacionarCliente(_Factura.ObtenerFactura());

                    // Se relaciona el negocio con la factura para que aparezca en el dgv de pedidos con valores nulos
                    facturaLN.RelacionarNegocio(_Factura.ObtenerFactura(), -1.0d, "");

                    MessageBox.Show(this, "La orden se ha generado con exito, gracias por su compra", "Compra exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    log.Info("El cliente: " + MenuCliente._Cliente.Correo + " ha realizado una orden");
                    
                    Close();

                }
                catch (Exception error)
                {
                    MessageBox.Show(this, "Algo no anda bien :c", "Ocurrió un error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    StringBuilder msg = new StringBuilder();

                    msg.AppendFormat("No se pudo crear la factura o Pedido\n");
                    msg.AppendFormat("Message: {0}\n", error.Message);
                    msg.AppendFormat("Source: {0}\n", error.Source);
                    msg.AppendFormat("Data: {0}\n", error.Data);

                    //Salvar el error en el log
                    log.Error(msg.ToString());

                }
                // La tabla FACTURA USUARIO, se inserta hasta que el cliente puntue a el negocio
            }
        }

        #endregion FUNCIONALIDADES VENTANA Y CREACION DE PEDIDO-FACTURA

    }
}
