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
    public partial class Admin_Reportes_Cliente : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Cliente _Cliente = null;
        public Admin_Reportes_Cliente()
        {
            InitializeComponent();
        }

        private void Admin_Reportes_Cliente_Load(object sender, EventArgs e)
        {
            llenarCb();
            Refrescar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _Cliente = (Cliente)dvgClientes.SelectedRows[0].DataBoundItem;
            tabReporteCliente.SelectedIndex = 1;
        }

        private void btnAtrasTab1_Click(object sender, EventArgs e)
        {
            tabReporteCliente.SelectedIndex = 0;
        }

        private void btnReportePedidos_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio negocio = (Negocio)cbNegocios.SelectedItem;
                this.PA_ReportePedidosTableAdapter.Fill(this.DSPedidos.PA_ReportePedidos, negocio.Id, _Cliente.Id);
                this.rvPedidos.RefreshReport();

            }catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("Error al llenar un report viewer\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }

            tabReporteCliente.SelectedIndex = 2;
        }

        private void cbNegocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
            Negocio negocio = (Negocio)cbNegocios.SelectedItem;
            this.PA_ReportePedidosTableAdapter.Fill(this.DSPedidos.PA_ReportePedidos, negocio.Id, _Cliente.Id);
            this.rvPedidos.RefreshReport();
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("Error al llenar un report viewer\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }

        private void btnAtrasTab3_Click(object sender, EventArgs e)
        {
            tabReporteCliente.SelectedIndex = 1;
        }

        private void btnEstadosPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "En espera = esperando por ser preparado por el negocio." +
                "\nListo = preparado por el negocio, esperando repartidor." +
                "\nEn camino = aceptado por el repartidor, en camino a ser entregado." +
                "\nEntregado = el pedido ya fue entregado al cliente.", "Estados de un pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReporteCupones_Click(object sender, EventArgs e)
        {
            try
            {
                this.PA_ReporteCuponesTableAdapter.Fill(this.DSCuponesUsado.PA_ReporteCupones, _Cliente.Id);

                this.rvCupones.RefreshReport();
            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("Error al llenar un report viewer\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }

            tabReporteCliente.SelectedIndex = 3;
        }

        private void btnAtrasTab2_Click(object sender, EventArgs e)
        {
            tabReporteCliente.SelectedIndex = 1;
        }

        private void Refrescar()
        {
            UsuarioLN usuarioLN = new UsuarioLN();
            List<Cliente> ListaClientes = new List<Cliente>();

            List<Usuario> lista = usuarioLN.SeleccionarTodos();
            foreach (Usuario u in lista)
            {
                if (u is Cliente)
                    ListaClientes.Add(u as Cliente);
            }

            dvgClientes.DataSource = ListaClientes;

            dvgClientes.Columns["_Direccion"].Visible = false;
            dvgClientes.Columns["_Tarjeta"].Visible = false;
            dvgClientes.Columns["Activo"].Visible = false;
            dvgClientes.Columns["Contrasenna"].Visible = false;

        }

        public void llenarCb()
        {
            UsuarioLN usuarioLN = new UsuarioLN();
            List<Negocio> listaNegocios = usuarioLN.ObtenerListaNegocios();
            cbNegocios.DataSource = listaNegocios;
            cbNegocios.DisplayMember = "Nombre";
            cbNegocios.ValueMember = "Id";
        }

       
    }
}
