using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using CAPA_ENTIDADES.Clases;
using CAPA_LN;

namespace CAPA_UI
{
    public partial class Login : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioLN logica = new UsuarioLN();
            Usuario _Usuario = null;

            // CONSULTA EL USUARIO
            string correo = txtNombre.Text;
            string con = txtContrasenna.Text;
            _Usuario = logica.ConsultarUsuario(correo);
            try
            {
                if (_Usuario.Contrasenna.Equals(con))
                {
                    if (_Usuario is Cliente)
                    {
                        log.Info("Ingreso del usuario " + _Usuario.Correo);
                        Hide();
                        MenuCliente menu = new MenuCliente((Cliente)_Usuario);
                        menu.Show();
                    }
                    else if (_Usuario is Repartidor)
                    {
                        log.Info("Ingreso del usuario " + _Usuario.Correo);
                        Hide();
                        MenuRepartidor menu = new MenuRepartidor(_Usuario as Repartidor);
                        menu.Show();
                    }
                    else if (_Usuario is Negocio)
                    {
                        log.Info("Ingreso del usuario " + _Usuario.Correo);
                        Hide();
                        MenuNegocio menu = new MenuNegocio((Negocio)_Usuario);
                        menu.Show();
                    }
                    else
                    {
                        log.Info("Ingreso del usuario " + _Usuario.Correo);
                        Hide();
                        MenuAdmin menu = new MenuAdmin((Admin)_Usuario);
                        menu.Show();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Contraseña incorrecta", "Problema encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }catch(Exception error)
            {
                MessageBox.Show(this, "El usuario no existe", "Problema encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                StringBuilder msg = new StringBuilder();

                msg.AppendFormat("El usuario no existe\n");
                msg.AppendFormat("Message: {0}\n", error.Message);
                msg.AppendFormat("Source: {0}\n", error.Source);
                msg.AppendFormat("Data: {0}\n", error.Data);

                //Salvar el error en el log
                log.Error(msg.ToString());

            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            CrearUsuario cu = new CrearUsuario();
            cu.Show(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
