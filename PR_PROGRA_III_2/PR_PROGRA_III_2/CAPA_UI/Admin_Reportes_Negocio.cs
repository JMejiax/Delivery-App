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
    public partial class Admin_Reportes_Negocio : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Negocio _Negocio = null;
        DateTime fechaInicio;
        DateTime fechaFinal;

        public Admin_Reportes_Negocio()
        {
            InitializeComponent();
        }

        private void Admin_Reportes_Negocio_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                _Negocio = (Negocio)dvgNegocios.SelectedRows[0].DataBoundItem;
                tabReporteNegocio.SelectedIndex = 1;
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

        private void btnReporteRecaudacion_Click(object sender, EventArgs e)
        {
            try
            {
                fechaInicio = dtpFechaInicio.Value;
                fechaFinal = dtpFechaFinal.Value;

                this.PA_ReporteRecaudacionPorFechaTableAdapter.Fill(this.DSRecaudacion.PA_ReporteRecaudacionPorFecha, _Negocio.Id, fechaInicio, fechaFinal);

                this.rpvRecaudacion.RefreshReport();

                tabReporteNegocio.SelectedIndex = 3;
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

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                fechaInicio = dtpFechaInicio.Value;
                fechaFinal = dtpFechaFinal.Value;

                this.PA_ReporteRecaudacionPorFechaTableAdapter.Fill(this.DSRecaudacion.PA_ReporteRecaudacionPorFecha, _Negocio.Id, fechaInicio, fechaFinal);

                this.rpvRecaudacion.RefreshReport();
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

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                fechaInicio = dtpFechaInicio.Value;
                fechaFinal = dtpFechaFinal.Value;

                this.PA_ReporteRecaudacionPorFechaTableAdapter.Fill(this.DSRecaudacion.PA_ReporteRecaudacionPorFecha, _Negocio.Id, fechaInicio, fechaFinal);

                this.rpvRecaudacion.RefreshReport();
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

        private void btnAtrasTab2_Click(object sender, EventArgs e)
        {
            tabReporteNegocio.SelectedIndex = 1;
        }

        private void btnReporteCupones_Click(object sender, EventArgs e)
        {
            try
            {
                this.PA_ReporteCuponesAplicadosTableAdapter.Fill(this.DSCuponesAplicados.PA_ReporteCuponesAplicados, _Negocio.Id);

                rpvCuponesAplicados.RefreshReport();

                tabReporteNegocio.SelectedIndex = 2;
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
            tabReporteNegocio.SelectedIndex = 1;
        }

        private void btnReporteComentarios_Click(object sender, EventArgs e)
        {
            try
            {

                this.PA_ReporteCmentariosMalosTableAdapter.Fill(this.DSComentariosMalos.PA_ReporteCmentariosMalos, _Negocio.Id);

                tabReporteNegocio.SelectedIndex = 4;

                rpvComentarios.RefreshReport();
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

        private void btnAtrasTab4_Click(object sender, EventArgs e)
        {
            tabReporteNegocio.SelectedIndex = 1;
        }

        private void btnAtrasTab1_Click(object sender, EventArgs e)
        {
            tabReporteNegocio.SelectedIndex = 0;
        }

        private void Refrescar()
        {
            UsuarioLN usuarioLN = new UsuarioLN();
            List<Negocio> listaNegocios = usuarioLN.ObtenerListaNegocios();

            dvgNegocios.DataSource = listaNegocios;

            dvgNegocios.Columns["_Direccion"].Visible = false;
            dvgNegocios.Columns["_Tarjeta"].Visible = false;
            dvgNegocios.Columns["Activo"].Visible = false;
            dvgNegocios.Columns["Contrasenna"].Visible = false;
        }

        
    }
}
