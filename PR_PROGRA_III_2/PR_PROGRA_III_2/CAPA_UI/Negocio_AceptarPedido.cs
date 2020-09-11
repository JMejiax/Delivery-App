using CAPA_ENTIDADES.Clases;
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
using log4net;

namespace CAPA_UI
{
    public partial class Negocio_AceptarPedido : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        FacturaLN facturaLN = new FacturaLN();
        Negocio _Negocio = MenuNegocio._Negocio;

        public Negocio_AceptarPedido()
        {
            InitializeComponent();
        }

        private void Negocio_AceptarPedido_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Factura facturaActual = (Factura)dgvPedidos.SelectedRows[0].DataBoundItem;
            facturaActual.Estado_Pedido = "Listo";

            // Actualizar Factura - Estado pedido
            facturaLN.CambiarEstadoFactura(facturaActual.Id, facturaActual.Estado_Pedido);

            MessageBox.Show(this, "En unos minutos pasará uno de nuestros repartidores a recoger la orden", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            log.Info("EL negocio:" + _Negocio.Nombre + " acepto un pedido");
            
            Close();
        }

        private void btnVerPedido_Click_1(object sender, EventArgs e)
        {
            try
            {
                int index = dgvPedidos.SelectedRows[0].Index;

                FacadePedido pedido = (FacadePedido)dgvPedidos.Rows[index].Cells["_PEDIDO"].Value;

                dgvDetalle.DataSource = pedido.ListaProductos;


                dgvDetalle.Columns["Precio"].Visible = false;
                dgvDetalle.Columns["Id"].Visible = false;
                dgvDetalle.Columns["UsuarioId"].Visible = false;
                dgvDetalle.Columns["Activo"].Visible = false;

                // Cambiar el tamaño de las imagenes
                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    Image imagen = (Image)row.Cells["Fotografia"].Value;
                    row.Cells["Fotografia"].Value = Util.CambiarTamanoImagen(imagen, 60, 55);
                }


                tabControl1.SelectedIndex = 1;
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Usted no cuenta con pedidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("Error al visualizar el detalle factura\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());

            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void Refrescar()
        {
            List<Factura> lista = new List<Factura>(); ;

            foreach(Factura fac in facturaLN.SeleccionarFacturaPorNegocioID(_Negocio.Id))
            {
                if (fac.Estado_Pedido.ToLower().Equals("en espera"))
                    lista.Add(fac);
            }

            dgvPedidos.DataSource = lista;

            dgvPedidos.Columns["_NEGOCIO"].Visible = false;
            dgvPedidos.Columns["_CLIENTE"].Visible = false;
            dgvPedidos.Columns["_PEDIDO"].Visible = false;
            dgvPedidos.Columns["_REPARTIDOR"].Visible = false;
            dgvPedidos.Columns["ESTADO_PEDIDO"].Visible = false;
            dgvPedidos.Columns["ESTADO_FACTURA"].Visible = false;
            dgvPedidos.Columns["ESTADO_CALIFICACION"].Visible = false;

            foreach (DataGridViewRow row in dgvPedidos.Rows)
            {
                Cliente cliente = (Cliente)row.Cells["_CLIENTE"].Value;
                row.Cells["Nombre"].Value = cliente.Nombre + " " + cliente.Apellidos;
                row.Cells["Telefono"].Value = cliente.NumeroTelefono;
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
