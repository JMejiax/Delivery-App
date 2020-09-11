using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Utilitarios;
using CAPA_LN;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using log4net;

namespace CAPA_UI
{
    public partial class Negocio_Configurar : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Negocio _Negocio = MenuNegocio._Negocio;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        public Negocio_Configurar()
        {
            InitializeComponent();
        }

        private void Negocio_Configurar_Load(object sender, EventArgs e)
        {
            tabCrearUsuario.SelectedIndex = 0;
            fechaVencimiento.MinDate = DateTime.Now;
            MapConfig();
            SetCampos();
        }

        #region ACTUALIZAR USUARIO
        // Este metodo se debe de llamar en el panel de Ubicación ya que es el ultimos paso para registrarse
        /// <summary>
        /// Guarda el Usuario en la base de datos
        /// </summary>
        public void ActualizarCliente()
        {
            // información general
            string correo = txtCorreo.Text;
            string contrasenna = txtContrasenna.Text;
            string nombre = txtNombre.Text;
            string telefono = txtTelefono.Text;
            string cedula = txtCedula.Text;

            // Tarjeta
            string numeroTarjeta = txtTarjeta.Text;
            string cvv = txtCVV.Text;
            DateTime fechaV = fechaVencimiento.Value;
            TipoTarjeta tipoTarjeta = (rbVisa.Checked) ? TipoTarjeta.VISA : TipoTarjeta.MASTERCARD;

            // Ubicación 
            double lat = Convert.ToDouble(txtLat.Text.Replace('.', ','));
            double lng = Convert.ToDouble(txtLng.Text.Replace('.', ','));
            string direccion = txtDireccion.Text;

            if (PagoFactura.ValidarTarjeta(numeroTarjeta) && Correo1.ValidarCorreo(correo))
            {
                // Instancia a las clases logicas de la CAPA_LN
                UsuarioLN usuarioLN = new UsuarioLN();
                DireccionLN direccionLN = new DireccionLN();
                TarjetaLN tarjetaLN = new TarjetaLN();

                // Actualizar Datos
                _Negocio._Direccion.latitud = lat.ToString().Replace(',', '.');
                _Negocio._Direccion.longitud = lng.ToString().Replace(',', '.');
                _Negocio._Direccion.Descripcion = direccion;

                _Negocio._Tarjeta.cvv = cvv;
                _Negocio._Tarjeta.numero = numeroTarjeta;
                _Negocio._Tarjeta.FechaVencimiento = fechaV;
                _Negocio._Tarjeta._TipoTarjeta = tipoTarjeta;

                _Negocio.Cedula = cedula;
                _Negocio.Nombre = nombre;
                _Negocio.NumeroTelefono = telefono;
                _Negocio.Correo = correo;
                _Negocio.Contrasenna = contrasenna;

                // Actualizar la Direccion
                direccionLN.ActualizarDireccion(_Negocio._Direccion);

                // Actualizar la Tarjeta
                tarjetaLN.ActualizarTarjeta(_Negocio._Tarjeta);

                // Actualizar el Negocio
                usuarioLN.ActualizarNegocio(_Negocio);
            }
            else
            {
                MessageBox.Show(this, "La tarjeta de credito o el correo es invalido", "Problema encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                throw new FormatException();
            }

        }

        /// <summary>
        /// Valida si todos los campos fueron llenados por el usuario
        /// </summary>
        public bool ValidarCampos()
        {
            if (txtCorreo.Text.Equals("") || txtContrasenna.Text.Equals("") || txtNombre.Text.Equals("")
                 || !txtTelefono.MaskFull || !txtTarjeta.MaskFull || !txtCVV.MaskFull
                 || txtLat.Text.Equals("") || txtLng.Text.Equals("") || txtDireccion.Text.Equals(""))
                return false;
            return true;
        }

        public void SetCampos()
        {
            // Configurar los campos de texto con las propiedades del cliente
            txtCorreo.Text = _Negocio.Correo;
            txtContrasenna.Text = _Negocio.Contrasenna;
            txtNombre.Text = _Negocio.Nombre;
            txtTelefono.Text = _Negocio.NumeroTelefono;
            txtCedula.Text = _Negocio.Cedula;
            txtTarjeta.Text = _Negocio._Tarjeta.numero;
            txtCVV.Text = _Negocio._Tarjeta.cvv;
            fechaVencimiento.Value = _Negocio._Tarjeta.FechaVencimiento;
            rbVisa.Checked = (_Negocio._Tarjeta._TipoTarjeta.Equals(TipoTarjeta.VISA));
            rbMastercard.Checked = (_Negocio._Tarjeta._TipoTarjeta.Equals(TipoTarjeta.MASTERCARD));
            txtLat.Text = _Negocio._Direccion.latitud;
            txtLng.Text = _Negocio._Direccion.longitud;
            txtDireccion.Text = _Negocio._Direccion.Descripcion;
        }

        #endregion ACTUALIZAR USUARIO

        #region CONFIGURACION DEL MAPA
        public void MapConfig()
        {
            // Coordenadas cliente
            double latInicial = Convert.ToDouble(_Negocio._Direccion.latitud.Replace('.', ','));
            double lngInicial = Convert.ToDouble(_Negocio._Direccion.longitud.Replace('.', ','));

            // Generar mapa
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyCNF0mD-Lk0Dtal7CoFJ_9H4q1jTp3XcqY";
            map.DragButton = MouseButtons.Left;
            map.CanDragMap = true;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(latInicial, lngInicial);
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 9;
            map.AutoScroll = true;

            // Marcador
            markerOverlay = new GMapOverlay("Ubicación");
            marker = new GMarkerGoogle(new PointLatLng(latInicial, lngInicial), GMarkerGoogleType.green);

            // Se agrega al overlay
            markerOverlay.Markers.Add(marker);
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = string.Format("Ubicación: \nLatitud: {0}, Longitud: {1} ", latInicial, lngInicial);

            // Se agrega el overlay al map
            map.Overlays.Add(markerOverlay);


        }

        private void map_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Obtener longitud y latitud
            double lat = map.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = map.FromLocalToLatLng(e.X, e.Y).Lng;

            // Agregar a los textboxs
            txtLat.Text = lat.ToString();
            txtLng.Text = lng.ToString();

            // Mover el marcador a la nueva posición
            marker.Position = new PointLatLng(lat, lng);

        }

        #endregion CONFIGURACION DEL MAPA

        #region BOTONES
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    ActualizarCliente();
                    MessageBox.Show(this, "Usuario actualizado con éxito", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    log.Info("El negocio: " + _Negocio.Nombre + " actualizo sus datos");
                    
                    Close();
                }
                else
                {
                    MessageBox.Show(this, "Debe llenar todos los campos", "Problema encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Hubo un problema al actualizar el usuario, intente más tarde", "Problema encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("No se pudo actualizar el usuario\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }

        private void btnCancelarUbi_Click(object sender, EventArgs e)
        {
            tabCrearUsuario.SelectedIndex = 0;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            tabCrearUsuario.SelectedIndex = 1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion BOTONES

        #region VALIDAR TARJETA
        private void rbVisa_CheckedChanged(object sender, EventArgs e)
        {
            error.Clear();
            if (rbVisa.Checked && !txtTarjeta.Text.StartsWith("4"))
                error.SetError(txtTarjeta, "La tarjeta no es Visa");
        }

        private void rbMastercard_CheckedChanged(object sender, EventArgs e)
        {
            error.Clear();
            if (rbMastercard.Checked && !txtTarjeta.Text.StartsWith("5"))
                error.SetError(txtTarjeta, "La tarjeta no es Mastercard");
        }

        private void txtTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (rbMastercard.Checked && !txtTarjeta.Text.StartsWith("5"))
                error.SetError(txtTarjeta, "La tarjeta no es Mastercard");
            if (rbVisa.Checked && !txtTarjeta.Text.StartsWith("4"))
                error.SetError(txtTarjeta, "La tarjeta no es Visa");
        }

        #endregion VALIDAR TARJETA
    }
}
