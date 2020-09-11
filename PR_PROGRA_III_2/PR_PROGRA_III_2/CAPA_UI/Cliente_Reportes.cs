using CAPA_ENTIDADES.Clases;
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
    public partial class Cliente_Reportes : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Cliente_Reportes()
        {
            InitializeComponent();
        }

        private void Cliente_Reportes_Load(object sender, EventArgs e)
        {
            llenarCb();

        }

        private void btnReporteCupones_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si tiene facturas pendiente
                FacturaLN facturaLN = new FacturaLN();

                if (facturaLN.ObtenerFacturaSinCalificar(MenuCliente._Cliente.Id) != null)
                {

                    // TODO: esta línea de código carga datos en la tabla 'DSCuponesUsado.PA_ReporteCupones' Puede moverla o quitarla según sea necesario.
                    this.PA_ReporteCuponesTableAdapter.Fill(this.DSCuponesUsado.PA_ReporteCupones, MenuCliente._Cliente.Id);

                    this.rvCuponesUsados.RefreshReport();

                    tabControl1.SelectedIndex = 2;

                }
                else
                {
                    this.PA_ReporteCuponesTableAdapter.Fill(this.DSCuponesUsado.PA_ReporteCupones, MenuCliente._Cliente.Id);

                    this.rvCuponesUsados.RefreshReport();

                    tabControl1.SelectedIndex = 2;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Usted no tiene ninguna factura registrada", "Sin facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("No se pudo llenar un report viewer\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }

        }

        private void btnReportePedidos_Click(object sender, EventArgs e)
        {
            // Validar si tiene facturas pendiente
            try
            {
                FacturaLN facturaLN = new FacturaLN();

                if (facturaLN.ObtenerFacturaSinCalificar(MenuCliente._Cliente.Id) != null)
                {

                    tabControl1.SelectedIndex = 1;

                }
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Usted no tiene ninguna factura registrada", "Sin facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("No se pudo llenar un report viewer\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());

            }
        }

        private void btnAtrasTab2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        public void llenarCb()
        {
            UsuarioLN usuarioLN = new UsuarioLN();
            List<Negocio> listaNegocios = usuarioLN.ObtenerListaNegocios();
            cbNegocios.DataSource = listaNegocios;
            cbNegocios.DisplayMember = "Nombre";
            cbNegocios.ValueMember = "Id";
        }

        private void btnAtrasTab1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void cbNegocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Negocio _Negocio = (Negocio)cbNegocios.SelectedItem;
                // TODO: esta línea de código carga datos en la tabla 'DSPedidos.PA_ReportePedidos' Puede moverla o quitarla según sea necesario.
                this.PA_ReportePedidosTableAdapter.Fill(this.DSPedidos.PA_ReportePedidos, _Negocio.Id, MenuCliente._Cliente.Id);
                this.rvPedidos.RefreshReport();
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("No se pudo llenar un report viewer\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }

        private void btnInfoEstadosPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "En espera = esperando por ser preparado por el negocio." +
                "\nListo = preparado por el negocio, esperando repartidor." +
                "\nEn camino = aceptado por el repartidor, en camino a ser entregado." +
                "\nEntregado = el pedido ya fue entregado al cliente.", "Estados de un pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
