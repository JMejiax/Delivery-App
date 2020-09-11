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

namespace CAPA_UI
{
    public partial class Repartidor_Reportes : Form
    {
        public Repartidor_Reportes()
        {
            InitializeComponent();
        }

        private void Repartidor_Reportes_Load(object sender, EventArgs e)
        {
            llenarCb();
        }

        private void btnReportePedidos_Click(object sender, EventArgs e)
        {
            Negocio _Negocio = (Negocio)cbNegocios.SelectedItem;

            this.PA_ReporteEntregasTableAdapter.Fill(this.DSEntregas.PA_ReporteEntregas, _Negocio.Id, MenuRepartidor._Repartidor.Id);

            this.reportViewer1.RefreshReport();

            tabReportes.SelectedIndex = 1;
        }

        private void cbNegocios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Negocio _Negocio = (Negocio)cbNegocios.SelectedItem;

            this.PA_ReporteEntregasTableAdapter.Fill(this.DSEntregas.PA_ReporteEntregas, _Negocio.Id, MenuRepartidor._Repartidor.Id);

            this.reportViewer1.RefreshReport();
        }

        private void btnEstadosPedido_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "En espera = esperando por ser preparado por el negocio." +
                "\nListo = preparado por el negocio, esperando repartidor." +
                "\nEn camino = aceptado por el repartidor, en camino a ser entregado." +
                "\nEntregado = el pedido ya fue entregado al cliente.", "Estados de un pedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAtrasTab1_Click(object sender, EventArgs e)
        {
            tabReportes.SelectedIndex = 0;
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

        private void cbNegocios2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Negocio _Negocio = (Negocio)cbNegocios2.SelectedItem;

            this.PA_ReporteComentariosNegativosRepartidorTableAdapter.Fill(this.DSCalificacionRepartidor.PA_ReporteComentariosNegativosRepartidor, _Negocio.Id, MenuRepartidor._Repartidor.Id);

            this.reportViewer2.RefreshReport();
        }

        private void btnAtras2_Click(object sender, EventArgs e)
        {
            tabReportes.SelectedIndex = 0;
        }

        private void btnReporteCupones_Click(object sender, EventArgs e)
        {
            Negocio _Negocio = (Negocio)cbNegocios2.SelectedItem;

            this.PA_ReporteComentariosNegativosRepartidorTableAdapter.Fill(this.DSCalificacionRepartidor.PA_ReporteComentariosNegativosRepartidor, _Negocio.Id, MenuRepartidor._Repartidor.Id);

            this.reportViewer2.RefreshReport();

            tabReportes.SelectedIndex = 2;
        }
    }
}
