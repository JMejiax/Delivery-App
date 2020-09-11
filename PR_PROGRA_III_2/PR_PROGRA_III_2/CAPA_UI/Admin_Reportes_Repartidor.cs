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
    public partial class Admin_Reportes_Repartidor : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Repartidor _Repartidor = null;

        public Admin_Reportes_Repartidor()
        {
            InitializeComponent();
        }

        private void Admin_Reportes_Repartidor_Load(object sender, EventArgs e)
        {
            Refrescar();
            llenarCb();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            _Repartidor = (Repartidor)dvgNegocios.SelectedRows[0].DataBoundItem;
            tabReportesRepartidor.SelectedIndex = 1;
        }

        private void btnReportePedidos_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio neg = (Negocio)cbNegocios.SelectedItem;

                this.PA_ReporteEntregasTableAdapter.Fill(this.DSEntregas.PA_ReporteEntregas, neg.Id, _Repartidor.Id);

                rpvEntregas.RefreshReport();

                tabReportesRepartidor.SelectedIndex = 2;
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

        private void cbNegocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Negocio neg = (Negocio)cbNegocios.SelectedItem;

                this.PA_ReporteEntregasTableAdapter.Fill(this.DSEntregas.PA_ReporteEntregas, neg.Id, _Repartidor.Id);

                rpvEntregas.RefreshReport();
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

        private void btnEstadosPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "En espera = esperando por ser preparado por el negocio." +
                "\nListo = preparado por el negocio, esperando repartidor." +
                "\nEn camino = aceptado por el repartidor, en camino a ser entregado." +
                "\nEntregado = el pedido ya fue entregado al cliente.", "Estados de un pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAtrasTab2_Click(object sender, EventArgs e)
        {
            tabReportesRepartidor.SelectedIndex = 1;
        }

        private void btnReporteCupones_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio neg = (Negocio)cbNegocios.SelectedItem;

                this.PA_ReporteComentariosNegativosRepartidorTableAdapter.Fill(this.DSCalificacionRepartidor.PA_ReporteComentariosNegativosRepartidor, neg.Id, _Repartidor.Id);

                rpvComent.RefreshReport();

                tabReportesRepartidor.SelectedIndex = 3;
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

        private void cbNegocios2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Negocio neg = (Negocio)cbNegocios.SelectedItem;

                this.PA_ReporteComentariosNegativosRepartidorTableAdapter.Fill(this.DSCalificacionRepartidor.PA_ReporteComentariosNegativosRepartidor, neg.Id, _Repartidor.Id);

                rpvComent.RefreshReport();

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

        private void btnAtras2_Click(object sender, EventArgs e)
        {
            tabReportesRepartidor.SelectedIndex = 1;
        }

        private void btnAtrasTab1_Click(object sender, EventArgs e)
        {
            tabReportesRepartidor.SelectedIndex = 0;
        }

        private void Refrescar()
        {
            UsuarioLN usuarioLN = new UsuarioLN();
            List<Repartidor> ListaRep = new List<Repartidor>();

            List<Usuario> lista = usuarioLN.SeleccionarTodos();
            foreach (Usuario u in lista)
            {
                if (u is Repartidor)
                    ListaRep.Add(u as Repartidor);
            }

            dvgNegocios.DataSource = ListaRep;

            dvgNegocios.Columns["_Direccion"].Visible = false;
            dvgNegocios.Columns["_Tarjeta"].Visible = false;
            dvgNegocios.Columns["_Transporte"].Visible = false;
            dvgNegocios.Columns["Activo"].Visible = false;
            dvgNegocios.Columns["Contrasenna"].Visible = false;

        }

        public void llenarCb()
        {
            UsuarioLN usuarioLN = new UsuarioLN();
            List<Negocio> listaNegocios = usuarioLN.ObtenerListaNegocios();
            cbNegocios.DataSource = listaNegocios;
            cbNegocios.DisplayMember = "Nombre";
            cbNegocios.ValueMember = "Id";
            cbNegocios2.DataSource = listaNegocios;
            cbNegocios2.DisplayMember = "Nombre";
            cbNegocios2.ValueMember = "Id";
        }

        
    }
}
