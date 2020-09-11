using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDADES.Clases;
using CAPA_ENTIDADES.Utilitarios;
using CAPA_LN;
using GMap.NET;
using log4net;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace CAPA_UI
{
    public partial class Admin_Crear_Usuario : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        GMarkerGoogle marker;
        GMapOverlay markerOverlay;

        // San Rafael de Poás
        double latInicial = 10.089771;
        double lngInicial = -84.257006;

        public Admin_Crear_Usuario()
        {
            InitializeComponent();
        }

        private void Admin_Crear_Usuario_Load(object sender, EventArgs e)
        {
            tabCrearUsuario.SelectedIndex = 1;
            fechaVencimiento.MinDate = DateTime.Now;
            fechaVencimiento.Value = DateTime.Now;

            cbTipoBici.DataSource = Enum.GetValues(typeof(TipoBicicleta));

            MapConfig();
        }

        #region PANEL INFORMACION GENERAL

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (rbRepartidor.Checked)
                tabCrearUsuario.SelectedIndex = 0;
            else
                tabCrearUsuario.SelectedIndex = 2;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void rbNegocio_CheckedChanged(object sender, EventArgs e)
        {
            txtApellidos.Enabled = false;
            txtApellidos.Text = "NO DISPONIBLE";
            lblCedula.Text = "Cédula Jurídica";
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            txtApellidos.Enabled = true;
            txtApellidos.Text = "";
            lblCedula.Text = "Cédula";
        }

        private void rbRepartidor_CheckedChanged(object sender, EventArgs e)
        {
            txtApellidos.Enabled = true;
            txtApellidos.Text = "";
            lblCedula.Text = "Cédula";
        }

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

        #endregion PANEL INFORMACION GENERAL

        #region PANEL INFO EXTRA
        private void btnCancelarTrans_Click(object sender, EventArgs e)
        {
            tabCrearUsuario.SelectedIndex = 1;
        }

        private void btnSiguienteTrans_Click(object sender, EventArgs e)
        {
            tabCrearUsuario.SelectedIndex = 2;
        }

        private void rbBicicleta_CheckedChanged(object sender, EventArgs e)
        {
            pnlExtrasB.Visible = true;
            pnlExtrasMC.Visible = false;
        }

        private void rbMotocicleta_CheckedChanged(object sender, EventArgs e)
        {
            pnlExtrasB.Visible = false;
            pnlExtrasMC.Visible = true;
        }

        private void rbCarro_CheckedChanged(object sender, EventArgs e)
        {
            pnlExtrasB.Visible = false;
            pnlExtrasMC.Visible = true;
        }

        #endregion PANEL INFO EXTRA

        #region PANEL UBICACION
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    GuardarUsuario();
                    MessageBox.Show(this, "Usuario creado con éxito, bienvenido", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    log.Info("Usuario nuevo creado");
                    
                    Close();
                }
                else
                {
                    MessageBox.Show(this, "Debe llenar todos los campos", "Problema encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(this, "Hubo un problema al guardar el usuario, intente más tarde", "Problema encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("No se pudo guardar el usuario\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());
            }
        }

        private void btnCancelarUbi_Click(object sender, EventArgs e)
        {
            if (rbCliente.Checked || rbNegocio.Checked)
                tabCrearUsuario.SelectedIndex = 1;
            else tabCrearUsuario.SelectedIndex = 0;
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

        public void MapConfig()
        {
            // Generar mapa
            map.DragButton = MouseButtons.Left;
            map.CanDragMap = true;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Position = new PointLatLng(latInicial, lngInicial);
            map.MinZoom = 0;
            map.MaxZoom = 24;
            map.Zoom = 11;
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

        #endregion PANEL UBICACION

        #region GUARDAR USUARIO

        // Este metodo se debe de llamar en el panel de Ubicación ya que es el ultimos paso para registrarse
        /// <summary>
        /// Guarda el Usuario en la base de datos
        /// </summary>
        public void GuardarUsuario()
        {
            TransporteLN transporteLN = new TransporteLN();
            // Información extra
            string marca = "";
            string modelo = "";
            string color = "";
            string placa = "";
            bool alDia = false;
            TipoTransporte tipoTransporte;
            TipoBicicleta tipoBicicleta;
            Transporte trans = null;

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

            // Ubicación 
            double lat = Convert.ToDouble(txtLat.Text);
            double lng = Convert.ToDouble(txtLng.Text);
            string direccion = txtDireccion.Text;

            // Tipo de usuario
            TipoUsuario tipoUsuario = (rbRepartidor.Checked) ? TipoUsuario.Repartidor : (rbCliente.Checked) ? TipoUsuario.Cliente : TipoUsuario.Negocio;

            // Tipo Transporte
            if (tipoUsuario == TipoUsuario.Repartidor)
            {
                tipoTransporte = (rbBicicleta.Checked) ? TipoTransporte.Bicicleta : (rbCarro.Checked) ? TipoTransporte.Automovil : TipoTransporte.Motocicleta;

                marca = txtMarca.Text;
                modelo = txtModelo.Text;
                color = txtColor.Text;

                if (rbCarro.Checked || rbMotocicleta.Checked)
                {
                    placa = txtPlaca.Text;
                    alDia = cbAldia.Checked;
                    if (rbCarro.Checked)
                        trans = new Automovil()
                        {
                            Marca = marca,
                            Modelo = modelo,
                            Color = color,
                            Placa = placa,
                            AlDia = alDia
                        };
                    else
                        trans = new Motocicleta()
                        {
                            Marca = marca,
                            Modelo = modelo,
                            Color = color,
                            Placa = placa,
                            AlDia = alDia
                        };
                }
                else
                {
                    tipoBicicleta = (TipoBicicleta)cbTipoBici.SelectedItem;
                    // Guardar Transporte
                    trans = new Bicicleta()
                    {
                        Marca = marca,
                        Modelo = modelo,
                        Color = color,
                        _TipoBicicleta = tipoBicicleta
                    };
                }
            }


            if (PagoFactura.ValidarTarjeta(numeroTarjeta) && Correo1.ValidarCorreo(correo))
            {
                // Instancia a las clases logicas de la CAPA_LN
                UsuarioLN usuarioLN = new UsuarioLN();
                DireccionLN direccionLN = new DireccionLN();
                TarjetaLN tarjetaLN = new TarjetaLN();

                // Guardar la Direccion
                Direccion _Direccion = new Direccion()
                {
                    latitud = lat.ToString(),
                    longitud = lng.ToString(),
                    Descripcion = direccion
                };

                direccionLN.InsertarDireccion(_Direccion);

                // Guardar la tarjeta
                Tarjeta _Tarjeta = new Tarjeta()
                {
                    cvv = cvv,
                    numero = numeroTarjeta,
                    FechaVencimiento = fechaV,
                    _TipoTarjeta = tipoTarjeta
                };

                tarjetaLN.InsertarTarjeta(_Tarjeta);

                // Guardar Usuario
                switch (tipoUsuario.ToString().ToLower())
                {
                    case "cliente":
                        Cliente _Cliente = new Cliente()
                        {
                            Cedula = cedula,
                            Nombre = nombre,
                            Apellidos = apellidos,
                            NumeroTelefono = telefono,
                            _Direccion = _Direccion,
                            Correo = correo,
                            Contrasenna = contrasenna,
                            _Tarjeta = _Tarjeta,
                            Activo = true
                        };

                        usuarioLN.IngresarCliente(_Cliente);
                        break;
                    case "repartidor":
                        // Guardar Transporte
                        if (rbBicicleta.Checked)
                            transporteLN.IngresarBicicleta(trans as Bicicleta);
                        if (rbCarro.Checked)
                            transporteLN.IngresarAuto(trans as Automovil);
                        if (rbMotocicleta.Checked)
                            transporteLN.IngresarMoto(trans as Motocicleta);
                        // Guardar Repartidor
                        Repartidor _Repartidor = new Repartidor()
                        {
                            Cedula = cedula,
                            Nombre = nombre,
                            Apellidos = apellidos,
                            NumeroTelefono = telefono,
                            _Direccion = _Direccion,
                            Correo = correo,
                            Contrasenna = contrasenna,
                            _Tarjeta = _Tarjeta,
                            _Transporte = trans,
                            Activo = true
                        };
                        usuarioLN.IngresarRepartidor(_Repartidor);
                        break;
                    case "negocio":
                        Negocio _Negocio = new Negocio()
                        {
                            Cedula = cedula,
                            Nombre = nombre,
                            NumeroTelefono = telefono,
                            _Direccion = _Direccion,
                            Correo = correo,
                            Contrasenna = contrasenna,
                            _Tarjeta = _Tarjeta,
                            Activo = true
                        };

                        usuarioLN.IngresarNegocio(_Negocio);
                        break;
                }
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
                || txtLat.Text.Equals("") || txtLng.Text.Equals("") || txtDireccion.Text.Equals(""))
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


        #endregion GUARDAR USUARIO

    }
}
