using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Utilitarios;
using CAPA_LN;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
    public partial class Repartidor_Configurar : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Repartidor _Repartidor = MenuRepartidor._Repartidor;
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        public Repartidor_Configurar()
        {
            InitializeComponent();
        }

        private void Repartidor_Configurar_Load(object sender, EventArgs e)
        {
            pnlTipoTranporte.Enabled = false;
            pnlCuentas.Enabled = false;

            tabCrearUsuario.SelectedIndex = 1;
            fechaVencimiento.MinDate = DateTime.Now;

            cbTipoBici.DataSource = Enum.GetValues(typeof(TipoBicicleta));

            MapConfig();
            SetCampos();
        }

        #region ACTUALIZAR USUARIO
        // Este metodo se debe de llamar en el panel de Ubicación ya que es el ultimos paso para registrarse
        /// <summary>
        /// Guarda el Usuario en la base de datos
        /// </summary>
        public void ActualizarRepartidor()
        {
            // información general
            string correo = txtCorreo.Text;
            string contrasenna = txtContrasenna.Text;
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string telefono = txtTelefono.Text;
            string cedula = txtCedula.Text;

            // Tarjeta
            string numeroTarjeta = txtTarjeta.Text;
            string cvv = txtCVV.Text;
            DateTime fechaV = fechaVencimiento.Value;
            TipoTarjeta tipoTarjeta = (rbVisa.Checked) ? TipoTarjeta.VISA : TipoTarjeta.MASTERCARD;

            // Información transporte
            string marca = "", modelo = "", color = "", placa = "";
            bool alDia = false;
            TipoBicicleta tipoBicicleta = TipoBicicleta.BMX;
            TipoTransporte tipoTransporte = (rbBicicleta.Checked) ? TipoTransporte.Bicicleta : (rbCarro.Checked) ? TipoTransporte.Automovil : TipoTransporte.Motocicleta ;

            switch (tipoTransporte)
            {
                case TipoTransporte.Bicicleta:
                    marca = txtMarca.Text;
                    modelo = txtModelo.Text;
                    color = txtColor.Text;
                    tipoBicicleta = (TipoBicicleta)cbTipoBici.SelectedItem;
                    break;
                case TipoTransporte.Automovil:
                case TipoTransporte.Motocicleta:
                    marca = txtMarca.Text;
                    modelo = txtModelo.Text;
                    color = txtColor.Text;
                    placa = txtPlaca.Text;
                    alDia = cbAldia.Checked;
                    break;
            }

            // Ubicación 
            double lat = Convert.ToDouble(txtLat.Text.Replace('.', ','));
            double lng = Convert.ToDouble(txtLng.Text.Replace('.', ','));
            string direccion = txtDireccion.Text;

            if (PagoFactura.ValidarTarjeta(numeroTarjeta) && Correo1.ValidarCorreo(correo))
            {
                // Instancia a las clases logicas de la CAPA_LN
                UsuarioLN usuarioLN = new UsuarioLN();
                TarjetaLN tarjetaLN = new TarjetaLN();
                DireccionLN direccionLN = new DireccionLN();
                TransporteLN transporteLN = new TransporteLN();

                // Actualizar Datos
                _Repartidor._Direccion.latitud = lat.ToString().Replace(',', '.');
                _Repartidor._Direccion.longitud = lng.ToString().Replace(',', '.');
                _Repartidor._Direccion.Descripcion = direccion;

                _Repartidor._Tarjeta.cvv = cvv;
                _Repartidor._Tarjeta.numero = numeroTarjeta;
                _Repartidor._Tarjeta.FechaVencimiento = fechaV;
                _Repartidor._Tarjeta._TipoTarjeta = tipoTarjeta;

                _Repartidor.Cedula = cedula;
                _Repartidor.Nombre = nombre;
                _Repartidor.Apellidos = apellidos;
                _Repartidor.NumeroTelefono = telefono;
                _Repartidor.Correo = correo;
                _Repartidor.Contrasenna = contrasenna;

                // Actualizar la Direccion
                direccionLN.ActualizarDireccion(_Repartidor._Direccion);

                // Actualizar la Tarjeta
                tarjetaLN.ActualizarTarjeta(_Repartidor._Tarjeta);

                // Actualizar transporte
                if (rbBicicleta.Checked) {
                    // Asignar propiedades
                    (_Repartidor._Transporte as Bicicleta).Marca = marca;
                    (_Repartidor._Transporte as Bicicleta).Color = color;
                    (_Repartidor._Transporte as Bicicleta).Modelo = modelo;
                    (_Repartidor._Transporte as Bicicleta)._TipoBicicleta = tipoBicicleta;
                    transporteLN.ActualizarBicicleta(_Repartidor._Transporte as Bicicleta); 
                }
                if (rbCarro.Checked)
                {
                    (_Repartidor._Transporte as Automovil).Marca = marca;
                    (_Repartidor._Transporte as Automovil).Color = color;
                    (_Repartidor._Transporte as Automovil).Modelo = modelo;
                    (_Repartidor._Transporte as Automovil).Placa = placa;
                    (_Repartidor._Transporte as Automovil).AlDia = alDia;
                    transporteLN.ActualizarAuto(_Repartidor._Transporte as Automovil);
                }
                if (rbMotocicleta.Checked)
                {
                    (_Repartidor._Transporte as Motocicleta).Marca = marca;
                    (_Repartidor._Transporte as Motocicleta).Color = color;
                    (_Repartidor._Transporte as Motocicleta).Modelo = modelo;
                    (_Repartidor._Transporte as Motocicleta).Placa = placa;
                    (_Repartidor._Transporte as Motocicleta).AlDia = alDia;
                    transporteLN.ActualizarMoto(_Repartidor._Transporte as Motocicleta);
                }

                // Actualizar el Negocio
                usuarioLN.ActualizarRepartidor(_Repartidor);
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
                || txtApellidos.Text.Equals("") || !txtTelefono.MaskFull || !txtTarjeta.MaskFull || !txtCVV.MaskFull
                && txtLat.Text.Equals("") || txtLng.Text.Equals("") || txtDireccion.Text.Equals(""))
                return false;
            if (rbRepartidor.Checked)
            {
                if (txtMarca.Text.Equals("") || txtColor.Text.Equals("") || txtModelo.Text.Equals(""))
                    return false;
                if (rbCarro.Checked || rbCarro.Checked)
                {
                    if (txtPlaca.Text.Equals(""))
                        return false;
                }
            }
            return true;
        }

        public void SetCampos()
        {
            // Configurar los campos de texto con las propiedades del cliente
            txtCorreo.Text = _Repartidor.Correo;
            txtContrasenna.Text = _Repartidor.Contrasenna;
            txtNombre.Text = _Repartidor.Nombre;
            txtApellidos.Text = _Repartidor.Apellidos;
            txtTelefono.Text = _Repartidor.NumeroTelefono;
            txtCedula.Text = _Repartidor.Cedula;
            txtTarjeta.Text = _Repartidor._Tarjeta.numero;
            txtCVV.Text = _Repartidor._Tarjeta.cvv;
            fechaVencimiento.Value = _Repartidor._Tarjeta.FechaVencimiento;
            rbVisa.Checked = (_Repartidor._Tarjeta._TipoTarjeta.Equals(TipoTarjeta.VISA));
            rbMastercard.Checked = (_Repartidor._Tarjeta._TipoTarjeta.Equals(TipoTarjeta.MASTERCARD));
            txtLat.Text = _Repartidor._Direccion.latitud;
            txtLng.Text = _Repartidor._Direccion.longitud;
            txtDireccion.Text = _Repartidor._Direccion.Descripcion;

            if (_Repartidor._Transporte is Bicicleta)
            {
                pnlExtrasB.Visible = true;
                pnlExtrasMC.Visible = false;
                rbBicicleta.Checked = true;
                txtMarca.Text = _Repartidor._Transporte.Marca;
                txtModelo.Text = _Repartidor._Transporte.Modelo;
                txtColor.Text = _Repartidor._Transporte.Color;
                cbTipoBici.SelectedItem = (_Repartidor._Transporte as Bicicleta)._TipoBicicleta;
            }
            if (_Repartidor._Transporte is Automovil)
            {
                rbCarro.Checked = true;
                pnlExtrasB.Visible = false;
                pnlExtrasMC.Visible = true;
                txtMarca.Text = _Repartidor._Transporte.Marca;
                txtModelo.Text = _Repartidor._Transporte.Modelo;
                txtColor.Text = _Repartidor._Transporte.Color;
                txtPlaca.Text = (_Repartidor._Transporte as Automovil).Placa;
                cbAldia.Checked = (_Repartidor._Transporte as Automovil).AlDia;
            }

            if(_Repartidor._Transporte is Motocicleta)
            {
                rbMotocicleta.Checked = true;
                pnlExtrasB.Visible = false;
                pnlExtrasMC.Visible = true;
                txtMarca.Text = _Repartidor._Transporte.Marca;
                txtModelo.Text = _Repartidor._Transporte.Modelo;
                txtColor.Text = _Repartidor._Transporte.Color;
                txtPlaca.Text = (_Repartidor._Transporte as Motocicleta).Placa;
                cbAldia.Checked = (_Repartidor._Transporte as Motocicleta).AlDia;
            }
        }

        #endregion ACTUALIZAR USUARIO

        #region CONFIGURACION DEL MAPA
        public void MapConfig()
        {
            // Coordenadas cliente
            double latInicial = Convert.ToDouble(_Repartidor._Direccion.latitud.Replace('.', ','));
            double lngInicial = Convert.ToDouble(_Repartidor._Direccion.longitud.Replace('.', ','));

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

        #region VALIDAR TIPOTARJETA
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
        #endregion VALIDAR TIPOTARJETA

        #region BOTONES
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            tabCrearUsuario.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSiguienteTrans_Click(object sender, EventArgs e)
        {
            tabCrearUsuario.SelectedIndex = 2;
        }

        private void btnCancelarTrans_Click(object sender, EventArgs e)
        {
            tabCrearUsuario.SelectedIndex = 1;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    ActualizarRepartidor();
                    MessageBox.Show(this, "Usuario actualizado con éxito", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    log.Info("El repartidor: " + _Repartidor.Correo + " actualizo sus datos");

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
        #endregion BOTONES
    }
}
