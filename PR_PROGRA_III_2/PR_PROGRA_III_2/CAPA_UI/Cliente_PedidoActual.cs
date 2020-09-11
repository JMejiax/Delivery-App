using CAPA_DATOS;
using CAPA_ENTIDADES.Clases;
using CAPA_LN;
using GMap.NET.MapProviders;
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
    public partial class Cliente_PedidoActual : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        FacturaLN facturaLN = new FacturaLN();
        Factura UltimaFactura = null;

        public Cliente_PedidoActual()
        {
            InitializeComponent();
        }

        private void Cliente_PedidoActual_Load(object sender, EventArgs e)
        {
            try
            {
                UltimaFactura = facturaLN.ObtenerFacturaSinCalificar(MenuCliente._Cliente.Id);

                if (UltimaFactura != null && UltimaFactura.Estado_Pedido.ToLower().Equals("entregado"))
                {
                    pnlSinPedidos.Visible = false;
                    pnlPedido.Visible = true;
                }
                else
                {
                    pnlSinPedidos.Visible = true;
                    pnlPedido.Visible = false;
                }
            }
            catch (Exception error)
            {
                pnlSinPedidos.Visible = true;
                pnlPedido.Visible = false;

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("El cliente no tiene facturas para calificar\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            int resul = (int)MessageBox.Show(this, "Sino calificas ahora, no lo podrás hacer despues, estas seguro?", "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resul == 6)
            {
                facturaLN.CambiarEstadoCalificacion(UltimaFactura.Id, "Calificado");
                log.Info("El cliente no califico a los usuarios negocio y repartidor");
                Close();

            }
        }

        private void btnAnnadir_Click(object sender, EventArgs e)
        {
            try
            {
                double puntajeN = (double)puntajeNegocio.Value;
                double puntajeR = (double)puntajeRepartidor.Value;
                string comentarioN = txtComentarioNegocio.Text;
                string comentarioR = txtComentarioRepartidor.Text;

                facturaLN.ActualizarRelacionNegocio(UltimaFactura, puntajeN, comentarioN);
                facturaLN.ActualizarRelacionRepartidor(UltimaFactura, puntajeR, comentarioR);

                facturaLN.CambiarEstadoCalificacion(UltimaFactura.Id, "Calificado");

                MessageBox.Show(this, "Calificación añadida", "Gracias por ayudarnos a mejorar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                log.Info("El cliente realizo una calificacion al negocio y repartidor");
                
                Close();

            }catch (Exception error)
            {
                MessageBox.Show("ERROR");

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("No se pudo calificar a los usuarios\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }
    }
}
