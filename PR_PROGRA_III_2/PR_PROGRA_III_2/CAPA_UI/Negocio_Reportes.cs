using CAPA_ENTIDADES.Clases;
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
    public partial class Negocio_Reportes : Form
    {
        Negocio _Negocio = MenuNegocio._Negocio;
        DateTime fechaInicio;
        DateTime fechaFinal;

        public Negocio_Reportes()
        {
            InitializeComponent();
        }
        private void Negocio_Reportes_Load(object sender, EventArgs e)
        {
            
        }

        private void btnReporteRecaudacion_Click(object sender, EventArgs e)
        {
            tabReportes.SelectedIndex = 1;
        }

        private void btnReporteCupones_Click(object sender, EventArgs e)
        {
            this.PA_ReporteCuponesAplicadosTableAdapter.Fill(this.DSCuponesAplicados.PA_ReporteCuponesAplicados, _Negocio.Id);

            this.rpvCuponesAplicados.RefreshReport();

            tabReportes.SelectedIndex = 2;
        }

        private void btnReporteComentarios_Click(object sender, EventArgs e)
        {
            this.PA_ReporteCmentariosMalosTableAdapter.Fill(this.DSComentariosMalos.PA_ReporteCmentariosMalos, _Negocio.Id);

            this.rpvComentarios.RefreshReport();

            tabReportes.SelectedIndex = 3;
        }

        private void btnAtrasTab2_Click(object sender, EventArgs e)
        {
            tabReportes.SelectedIndex = 0;
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            fechaInicio = dtpFechaInicio.Value;
            fechaFinal = dtpFechaFinal.Value;

            this.PA_ReporteRecaudacionPorFechaTableAdapter.Fill(this.DSRecaudacion.PA_ReporteRecaudacionPorFecha, _Negocio.Id, fechaInicio, fechaFinal);
            this.rpvRecaudacion.RefreshReport();
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            fechaInicio = dtpFechaInicio.Value;
            fechaFinal = dtpFechaFinal.Value;

            this.PA_ReporteRecaudacionPorFechaTableAdapter.Fill(this.DSRecaudacion.PA_ReporteRecaudacionPorFecha, _Negocio.Id, fechaInicio, fechaFinal);
            this.rpvRecaudacion.RefreshReport();
        }

        private void btnAtrasTab3_Click(object sender, EventArgs e)
        {
            tabReportes.SelectedIndex = 0;
        }

        private void btnAtrasTab4_Click(object sender, EventArgs e)
        {
            tabReportes.SelectedIndex = 0;
        }
    }
}
