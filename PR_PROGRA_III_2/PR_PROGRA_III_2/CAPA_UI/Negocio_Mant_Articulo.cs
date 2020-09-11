using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Factory;
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
using log4net;

namespace CAPA_UI
{
    public partial class Negocio_Mant_Articulo : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        List<Image> ListaImagenesOriginales = new List<Image>();
        ArticuloLN articuloLN = new ArticuloLN();
        Negocio _Negocio = MenuNegocio._Negocio;
        Articulo articulo;

        public Negocio_Mant_Articulo()
        {
            InitializeComponent();
        }

        private void Negocio_Mant_Articulo_Load(object sender, EventArgs e)
        {
            Refrescar();
            dtpFechaV.MinDate = DateTime.Now;
            dtpFechaV2.MinDate = DateTime.Now;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnGuardar.Text = "Guardar";
            tabControl.SelectedIndex = 2;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            articulo = (Articulo)dgvArticulos.SelectedRows[0].DataBoundItem;
            SetCampos(articulo);
            btnGuardar.Text = "Modificar";
            tabControl.SelectedIndex = 2;           
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
            LimpiarCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 0)
            {
                Articulo art = (Articulo)dgvArticulos.SelectedRows[0].DataBoundItem;
                int resul = (int)MessageBox.Show(this, "Está seguro que desea eliminar este articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resul == 6)
                {
                    articuloLN.Eliminar(art.Id);
                    log.Info("El negocio: " + _Negocio.Nombre + " elimino un producto/cupon");
                }
                Refrescar();
            }
            else
                MessageBox.Show(this, "Debe seleccionar el articulo que desea eliminar", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {
            lblArticulo.Text = "Producto";
            tabTipoArticulo.SelectedIndex = 0;
        }

        private void rbDescuento_CheckedChanged(object sender, EventArgs e)
        {
            lblArticulo.Text = "Cupon de descuento";
            tabTipoArticulo.SelectedIndex = 1;

        }

        private void rbProdGratis_CheckedChanged(object sender, EventArgs e)
        {
            lblArticulo.Text = "Cupon Producto Gratis";
            tabTipoArticulo.SelectedIndex = 2;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowser = new OpenFileDialog();
            fileBrowser.InitialDirectory = @"C:\";
            fileBrowser.RestoreDirectory = true;
            fileBrowser.Title = "Buscar imagenes";
            fileBrowser.DefaultExt = "png";
            fileBrowser.Filter = "Imagenes (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            fileBrowser.CheckFileExists = true;
            fileBrowser.CheckPathExists = true;

            if (fileBrowser.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagen = fileBrowser.FileName;
                    
                    pbImagen.Image = new Bitmap(imagen);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnGenerarQR_Click(object sender, EventArgs e)
        {
            string token = Util.GenerarToken();
            pbQR.Image = Util.GenerarQR(token);
            Console.WriteLine("{0} codigo generado", token);
        }

        private void btnGenerarQR2_Click(object sender, EventArgs e)
        {
            string token = Util.GenerarToken();
            pbQR2.Image = Util.GenerarQR(token);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnGuardar.Text.Equals("Guardar"))
                {
                    if (Validar())
                    {
                        FactoryArticulo fArticulo = new FactoryArticulo();
                        ArticuloLN articuloLN = new ArticuloLN();
                        Articulo _Articulo = null;

                        // Obtener las propiedades generales
                        string nombre = txtNombre.Text;
                        string descripcion = txtDescripcion.Text;
                        Image imagen = pbImagen.Image;

                        // Crear el objeto articulo dependiendo de los seleccionado por el usuario
                        if (rbProducto.Checked)
                        {
                            _Articulo = fArticulo.CrearArticulo(TipoArticulo.Producto);

                            // Obtener las propiedades unicas
                            double precio = Convert.ToDouble(txtPrecio.Text);

                            _Articulo.Nombre = nombre;
                            _Articulo.Descripcion = descripcion;
                            _Articulo.Fotografia = imagen;

                            (_Articulo as Producto).Precio = precio;

                            // Insertar el producto a la base de datos
                            articuloLN.InsertarProducto((_Articulo as Producto), _Negocio.Id);
                        }

                        if (rbDescuento.Checked)
                        {
                            _Articulo = fArticulo.CrearArticulo(TipoArticulo.CuponDescuento);

                            // Obtener las propiedades unicas
                            string codigoQRDesc = Util.DecodificarQR(pbQR.Image);
                            DateTime fechaV = dtpFechaV.Value;
                            double porcenteje = Convert.ToDouble(txtPorcentaje.Text);

                            _Articulo.Nombre = nombre;
                            _Articulo.Descripcion = descripcion;
                            _Articulo.Fotografia = imagen;

                            (_Articulo as CupoDescuento).FechaVencimiento = fechaV;
                            (_Articulo as CupoDescuento).Codigo_QR = codigoQRDesc;
                            (_Articulo as CupoDescuento).PorcentajeDescuento = porcenteje;

                            // Insertar el producto a la base de datos
                            articuloLN.InsertarCuponDescuento((_Articulo as CupoDescuento), _Negocio.Id);
                        }

                        if (rbProductoGratis.Checked)
                        {
                            _Articulo = fArticulo.CrearArticulo(TipoArticulo.CuponProductoGratis);

                            // Obtener las propiedades unicas
                            string codigoQRGratis = Util.DecodificarQR(pbQR2.Image);
                            DateTime fechaV = dtpFechaV2.Value;
                            int productoId = (int)cmbProductos.SelectedValue;

                            _Articulo.Nombre = nombre;
                            _Articulo.Descripcion = descripcion;
                            _Articulo.Fotografia = imagen;

                            (_Articulo as CuponProductoGratis).FechaVencimiento = fechaV;
                            (_Articulo as CuponProductoGratis).Codigo_QR = codigoQRGratis;
                            (_Articulo as CuponProductoGratis).IDProducto = productoId;

                            // Insertar el producto a la base de datos
                            articuloLN.InsertarCuponProd((_Articulo as CuponProductoGratis), _Negocio.Id);
                        }

                        MessageBox.Show(this, "Agregado exitosamente", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        log.Info("El negocio: " + _Negocio.Nombre + " agrego un nuevo producto");

                        Refrescar();
                    }
                    else
                        MessageBox.Show(this, "Ocurrió un error al validar los campos, asegurese de que todos los campos esten correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Validar())
                    {
                        // Obtener las propiedades generales
                        string nombre = txtNombre.Text;
                        string descripcion = txtDescripcion.Text;
                        Image imagen = pbImagen.Image;

                        // Crear el objeto articulo dependiendo de los seleccionado por el usuario
                        if (rbProducto.Checked)
                        {
                            // Obtener las propiedades unicas
                            double precio = Convert.ToDouble(txtPrecio.Text);

                            articulo.Nombre = nombre;
                            articulo.Descripcion = descripcion;
                            articulo.Fotografia = imagen;

                            (articulo as Producto).Precio = precio;

                            // Insertar el producto a la base de datos
                            articuloLN.ActualizarProducto((articulo as Producto));
                        }

                        if (rbDescuento.Checked)
                        {
                            // Obtener las propiedades unicas
                            string codigoQRDesc = Util.DecodificarQR(pbQR.Image);
                            DateTime fechaV = dtpFechaV.Value;
                            double porcenteje = Convert.ToDouble(txtPorcentaje.Text);

                            articulo.Nombre = nombre;
                            articulo.Descripcion = descripcion;
                            articulo.Fotografia = imagen;

                            (articulo as CupoDescuento).FechaVencimiento = fechaV;
                            (articulo as CupoDescuento).Codigo_QR = codigoQRDesc;
                            (articulo as CupoDescuento).PorcentajeDescuento = porcenteje;

                            // Insertar el producto a la base de datos
                            articuloLN.ActualizarCuponDescuento((articulo as CupoDescuento));
                        }

                        if (rbProductoGratis.Checked)
                        {
                            // Obtener las propiedades unicas
                            string codigoQRGratis = Util.DecodificarQR(pbQR2.Image);
                            DateTime fechaV = dtpFechaV2.Value;
                            int productoId = (int)cmbProductos.SelectedValue;

                            articulo.Nombre = nombre;
                            articulo.Descripcion = descripcion;
                            articulo.Fotografia = imagen;

                            (articulo as CuponProductoGratis).FechaVencimiento = fechaV;
                            (articulo as CuponProductoGratis).Codigo_QR = codigoQRGratis;
                            (articulo as CuponProductoGratis).IDProducto = productoId;

                            // Insertar el producto a la base de datos
                            articuloLN.ActualizarCuponProd((articulo as CuponProductoGratis));
                        }

                        MessageBox.Show(this, "Actualizado exitosamente", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        log.Info("El negocio: " + _Negocio.Nombre + " modifico un producto");

                        Refrescar();
                    }
                    else
                        MessageBox.Show(this, "Ocurrió un error al validar los campos, asegurese de que todos los campos esten correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimpiarCampos();
                tabControl.SelectedIndex = 0;
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Ocurrió un error al validar los campos, asegurese de que todos los campos esten correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("No se pudo guardar/actualizar el producto\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }

        private void Refrescar()
        {
            // Llenar DGV
            ListaImagenesOriginales.Clear();
            List<Articulo> lista = articuloLN.ObtenerArticulosPorNegocioId(_Negocio.Id);
            List<Articulo> listaFiltrada = new List<Articulo>();

            foreach (Articulo art in lista)
            {
                if (art.Activo)
                    listaFiltrada.Add(art);
            }

            dgvArticulos.DataSource = listaFiltrada;
            dgvArticulos.Columns["UsuarioId"].Visible = false;
            dgvArticulos.Columns["Activo"].Visible = false;

            // Cambiar el tamaño de las imagenes
            foreach (DataGridViewRow row in dgvArticulos.Rows)
            {
                Image imagen = (Image)row.Cells["Fotografia"].Value;
                ListaImagenesOriginales.Add(imagen);
                row.Cells["Fotografia"].Value = Util.CambiarTamanoImagen(imagen, 60, 50);
            }


            // Llenar Combobox
            List<Producto> listaProductos = new List<Producto>();

            foreach (Articulo prod in listaFiltrada)
            {
                if (prod is Producto)
                    if ((prod as Producto).Activo)
                        listaProductos.Add(prod as Producto);
            }
            cmbProductos.DataSource = listaProductos;
            cmbProductos.DisplayMember = "Nombre";
            cmbProductos.ValueMember = "Id";
        }

        private bool Validar()
        {
            if (txtNombre.Text.Equals("")  || txtDescripcion.Text.Equals("") || pbImagen.Image == null)
                return false;

            if (rbProducto.Checked)
            {
                if (txtPrecio.Text.Equals(""))
                    return false;
            }

            if (rbDescuento.Checked)
            {
                if (txtPorcentaje.Text.Equals("") || pbQR.Image == null)
                    return false;
            }

            if (rbProductoGratis.Checked)
            {
                if (cmbProductos.SelectedIndex == -1 || pbQR2.Image == null)
                    return false;
            }

            return true;
        }

        private void SetCampos(Articulo art)
        {
            pnlTipoArticulo.Enabled = false;

            txtNombre.Text = art.Nombre;
            txtDescripcion.Text = art.Descripcion;
            pbImagen.Image = ListaImagenesOriginales[dgvArticulos.SelectedRows[0].Index];

            if (art is Producto)
            {
                lblArticulo.Text = "Producto";
                rbProducto.Checked = true;
                tabTipoArticulo.SelectedIndex = 0;
                txtPrecio.Text = (art as Producto).Precio.ToString();
            }

            if (art is CupoDescuento)
            {
                lblArticulo.Text = "Cupón de descuento";
                rbDescuento.Checked = true;
                tabTipoArticulo.SelectedIndex = 1;
                txtPorcentaje.Text = ((art as CupoDescuento).PorcentajeDescuento*100).ToString();
                dtpFechaV.Value = (art as CupoDescuento).FechaVencimiento;
                pbQR.Image = Util.GenerarQR((art as CupoDescuento).Codigo_QR);
            }

            if (art is CuponProductoGratis)
            {
                lblArticulo.Text = "Cupón de Producto Gratis";
                rbProductoGratis.Checked = true;
                tabTipoArticulo.SelectedIndex = 2;
                cmbProductos.SelectedValue = (art as CuponProductoGratis).IDProducto;
                dtpFechaV2.Value = (art as CuponProductoGratis).FechaVencimiento;
                pbQR2.Image = Util.GenerarQR((art as CuponProductoGratis).Codigo_QR);
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            pbImagen.Image = null;
            txtPrecio.Text = "";
            txtPorcentaje.Text = "";
            dtpFechaV.Value = DateTime.Now;
            pbQR.Image = null;
            cmbProductos.SelectedIndex = -1;
            dtpFechaV2.Value = DateTime.Now;
            pbQR2.Image = null;
            pnlTipoArticulo.Enabled = true;
        }
    }
}
