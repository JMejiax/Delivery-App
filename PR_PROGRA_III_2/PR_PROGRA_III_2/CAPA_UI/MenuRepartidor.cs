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
    public partial class MenuRepartidor : Form
    {
        #region Variables
        private Form activeForm = null;
        UsuarioLN usuarioLN = new UsuarioLN();
        public static Repartidor _Repartidor;
        #endregion Variables

        public MenuRepartidor(Repartidor rep)
        {
            _Repartidor = rep;
            InitializeComponent();
        }

        private void MenuRepartidor_Load(object sender, EventArgs e)
        {
            LabelsTransparentes();
            OcultarMenuLateral();
        }

        private void btnAbrirBarraLateral_Click_1(object sender, EventArgs e)
        {
            if (pnlMenuLateral.Visible == false)
                AbrirMenuLateral();
            else
                OcultarMenuLateral();
        }

        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Close();
            Login log = new Login();
            log.Show();
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
            lblFrase1.Parent = pictureBox1;
            lblFrase1.BackColor = Color.Transparent;
            lblFrase2.Parent = pictureBox1;
            lblFrase2.BackColor = Color.Transparent;
            lblFrase3.Parent = pictureBox1;
        }

        #endregion Funciones

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

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            int result = (int)MessageBox.Show(this, "Está seguro que desea eliminar la cuenta?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == 6)
                try
                {
                    usuarioLN.EliminarUsuario(_Repartidor.Id);
                    MessageBox.Show(this, "Cuenta eliminada exitosamente", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login log = new Login();
                    Close();
                    log.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Hubo un problema al eliminar su cuenta, intentelo más tarde", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Repartidor_Configurar rc = null;
            if (rc == null)
            {
                rc = new Repartidor_Configurar();
                openChildForm(rc);
            }
            else
                rc.Show();
            OcultarMenuLateral();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            Repartidor_AceptarEntregas rae = null;
            if (rae == null)
            {
                rae = new Repartidor_AceptarEntregas();
                openChildForm(rae);
            }
            else
                rae.Show();
            OcultarMenuLateral();
        }

        private void btnHistorialPedidos_Click(object sender, EventArgs e)
        {
            Repartidor_Reportes rr = null;
            if (rr == null)
            {
                rr = new Repartidor_Reportes();
                openChildForm(rr);
            }
            else
                rr.Show();
            OcultarMenuLateral();
        }
    }
}
