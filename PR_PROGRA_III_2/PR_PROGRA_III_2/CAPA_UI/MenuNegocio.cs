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
    public partial class MenuNegocio : Form
    {
        private Form activeForm = null;
        public static Negocio _Negocio = null;
        public MenuNegocio(Negocio neg)
        {
            InitializeComponent();
            _Negocio = neg;
        }
        #region Funciones
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlVentanas.Controls.Add(childForm);
            pnlVentanas.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void closeChildForm(Form childForm)
        {
            try
            {
                childForm.Hide();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "No hay ninguna ventana abierta\n " + e.Message, "Problema econtrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void OcultarMenuLateral()
        {
            pnlMenuLateral.Visible = false;
            btnAbrirBarraLateral.Text = ">";
        }
        public void AbrirMenuLateral()
        {
            pnlMenuLateral.Visible = true;
            btnAbrirBarraLateral.Text = "<";
        }

        /// <summary>
        /// Asocia los labels a la imagen de fondo para que queden transparante
        /// </summary>
        public void LabelsTransparentes()
        {
            lblFrase1.Parent = pictureBox2;
            lblFrase1.BackColor = Color.Transparent;
            lblFrase2.Parent = pictureBox2;
            lblFrase2.BackColor = Color.Transparent;
            lblFrase3.Parent = pictureBox2;
            lblFrase3.BackColor = Color.Transparent;
        }


        #endregion Funciones

        #region Botones
        private void MenuNegocio_Load(object sender, EventArgs e)
        {
            OcultarMenuLateral();
            LabelsTransparentes();
        }

        private void btnAbrirBarraLateral_Click_1(object sender, EventArgs e)
        {
            if (pnlMenuLateral.Visible == false)
                AbrirMenuLateral();
            else
                OcultarMenuLateral();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            Negocio_AceptarPedido nap = null;
            if (nap == null)
            {
                nap = new Negocio_AceptarPedido();
                openChildForm(nap);
            }
            else
                nap.Show();
            OcultarMenuLateral();
        }
        private void btnHistorialPedidos_Click(object sender, EventArgs e)
        {
            Negocio_Reportes nr = null;
            if (nr == null)
            {
                nr = new Negocio_Reportes();
                openChildForm(nr);
            }
            else
                nr.Show();
            OcultarMenuLateral();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Close();
            Login log = new Login();
            log.Show();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Negocio_Configurar nc = null;
            if (nc == null)
            {
                nc = new Negocio_Configurar();
                openChildForm(nc);
            }
            else
                nc.Show();
            OcultarMenuLateral();
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            int result = (int)MessageBox.Show(this, "¿Está seguro que desea eliminar su cuenta?", "Permiso requerido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == 6)
            {
                UsuarioLN usuarioLN = new UsuarioLN();
                Login log = new Login();
                usuarioLN.EliminarUsuario(_Negocio.Id);
                Close();
                log.Show();
            }
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Negocio_Mant_Articulo mant_Articulo = null;
            if (mant_Articulo == null)
            {
                mant_Articulo = new Negocio_Mant_Articulo();
                openChildForm(mant_Articulo);
            }
            else
                mant_Articulo.Show();
            OcultarMenuLateral();
        }
        #endregion Botones

        #region MOSTRAR BOTON ELIMINAR CUENTA

        private void btnConfig_MouseHover(object sender, EventArgs e)
        {
            pnlEliminar.Visible = true;
        }

        private void btnEliminarCuenta_MouseHover(object sender, EventArgs e)
        {
            pnlEliminar.Visible = true;
        }

        private void btnEliminarCuenta_MouseLeave(object sender, EventArgs e)
        {
            pnlEliminar.Visible = false;
        }





        #endregion MOSTRAR BOTON ELIMINAR CUENTA

    }
}
