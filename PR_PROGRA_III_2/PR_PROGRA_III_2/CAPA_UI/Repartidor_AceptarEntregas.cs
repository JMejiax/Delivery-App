using CAPA_ENTIDADES.Clases;
using CAPA_LN;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json.Bson;
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
    public partial class Repartidor_AceptarEntregas : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        Repartidor _Repartidor = MenuRepartidor._Repartidor;
        FacturaLN facturaLN = new FacturaLN();
        Cliente _Cliente = null;
        Negocio _Negocio = null;
        Factura _FacturaActual = null;

        public Repartidor_AceptarEntregas()
        {
            InitializeComponent();
        }

        private void Repartidor_AceptarEntregas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void btnEntregarPedido_Click(object sender, EventArgs e)
        {
            int resul = (int)MessageBox.Show(this, "Una vez que acepte no puede cancelar la entrega, desea continuar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resul == 6)
            {                
                int index = dgvPedidos.SelectedRows[0].Index;
                _Cliente = (Cliente)dgvPedidos.Rows[index].Cells["_Cliente"].Value;
                _Negocio = (Negocio)dgvPedidos.Rows[index].Cells["_Negocio"].Value;


                _FacturaActual = (Factura)dgvPedidos.SelectedRows[0].DataBoundItem;
                _FacturaActual.Estado_Pedido = "En camino";


                // Añadir al repartidor a la factura
                _FacturaActual._Repartidor = _Repartidor;
                facturaLN.RelacionarRepartidor(_FacturaActual, -1.0d, "");

                // Actualizar Factura - Estado pedido
                facturaLN.CambiarEstadoFactura(_FacturaActual.Id, _FacturaActual.Estado_Pedido);

                txtNombreCliente.Text = _Cliente.Nombre + " " + _Cliente.Apellidos;
                txtPagoPorExpress.Text = "₡" + _FacturaActual.CostoExpress();
                txtDireccion.Text = _Cliente._Direccion.Descripcion;
                lblTelefonoCliente.Text = _Cliente.NumeroTelefono;

                ConfigurarMapa();

                Refrescar();

                tabEntregas.SelectedIndex = 1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            _FacturaActual.Estado_Pedido = "Entregado";

            // Actualizar Factura - Estado pedido
            facturaLN.CambiarEstadoFactura(_FacturaActual.Id, _FacturaActual.Estado_Pedido);

            MessageBox.Show(this, "Gracias por llevar el pedido, su pago llegará en unos minutos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            log.Info("El repartidor: " + _Repartidor.Correo + " entrgo un pedido");

            Close();


        }

        private void Refrescar()
        {
            List<Factura> listaFacturas = facturaLN.ObtenerFacturasListas();


            dgvPedidos.DataSource = listaFacturas;

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

        private void ConfigurarMapa()
        {
            try
            {
                // Coordenadas cliente
                double latInicialC = Convert.ToDouble(_Cliente._Direccion.latitud.Replace('.', ','));
                double lngInicialC = Convert.ToDouble(_Cliente._Direccion.longitud.Replace('.', ','));

                // Coordenadas Negocio
                double latInicialN = Convert.ToDouble(_Negocio._Direccion.latitud.Replace('.', ','));
                double lngInicialN = Convert.ToDouble(_Negocio._Direccion.longitud.Replace('.', ','));

                // Crear coordenadas
                PointLatLng ubicacionNegocio = new PointLatLng(latInicialN, lngInicialN);
                PointLatLng ubicacionCliente = new PointLatLng(latInicialC, lngInicialC);

                // Generar mapa
                GMapProviders.GoogleMap.ApiKey = "AIzaSyALlQ_GJmwmh_emic32WuT80iRpSrSpqJM";
                GMaps.Instance.Mode = AccessMode.ServerOnly;

                map.DragButton = MouseButtons.Left;
                map.CanDragMap = true;
                map.MapProvider = GMapProviders.GoogleMap;
                map.Position = ubicacionNegocio;
                map.MinZoom = 0;
                map.MaxZoom = 24;
                map.Zoom = 14;
                map.AutoScroll = true;

                // Marcador
                markerOverlay = new GMapOverlay("Ubicación Negocio");
                marker = new GMarkerGoogle(ubicacionNegocio, GMarkerGoogleType.green);

                // Se agrega al overlay
                markerOverlay.Markers.Add(marker);
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("\nUbicación Negocio: \nLatitud: {0}\nLongitud: {1} \n", latInicialN, lngInicialN);

                // Se agrega el overlay al map
                map.Overlays.Add(markerOverlay);

                // Marcador
                markerOverlay = new GMapOverlay("Ubicación Cliente");
                marker = new GMarkerGoogle(ubicacionCliente, GMarkerGoogleType.green);

                // Se agrega al overlay
                markerOverlay.Markers.Add(marker);
                marker.ToolTipMode = MarkerTooltipMode.Always;
                marker.ToolTipText = string.Format("\nUbicación Cliente: \nLatitud: {0}\nLongitud: {1} \n", latInicialC, lngInicialC);

                // Se agrega el overlay al map
                map.Overlays.Add(markerOverlay);



                // Trazar ruta
                GMapOverlay capaRutas = new GMapOverlay("Ruta");

                var rutaObtenida = GoogleMapProvider.Instance.GetRoute(ubicacionNegocio, ubicacionCliente, false, false, 14);
                GMapRoute route = new GMapRoute(rutaObtenida.Points, "Ruta Pedido");
                route.Stroke = new Pen(Color.Green, 5);

                capaRutas.Routes.Add(route);

                map.Overlays.Add(capaRutas);

            }
            catch (Exception error)
            {
                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("No se pudo trazar la ruta entre el negocio y cliente\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }

    }
}
