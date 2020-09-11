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
using log4net;

namespace CAPA_UI
{
    public partial class MenuAdmin : Form
    {
        #region Variables
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private int contAbrirPnlBtn1 = 0;
        private Form activeForm = null;
        public static Admin _Admin;
        #endregion Variables

        public MenuAdmin(Admin admin)
        {
            InitializeComponent();
            _Admin = admin;
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            pnlReportes.Visible = false;
            LabelsTransparentes();
        }

        private void btnAbrirBarraLateral_Click(object sender, EventArgs e)
        {
            if (pnlMenuLateral.Visible == false)
                AbrirMenuLateral();
            else
                OcultarMenuLateral();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Admin_Crear_Usuario cu = null;
            if (cu == null)
            {
                cu = new Admin_Crear_Usuario();
                openChildForm(cu);
            }
            else
                cu.Show();
            OcultarMenuLateral();
        }

        private void btnRoporteCliente_Click(object sender, EventArgs e)
        {
            Admin_Reportes_Cliente ventana = null;
            if (ventana == null)
            {
                ventana = new Admin_Reportes_Cliente();
                openChildForm(ventana);
            }
            else
                ventana.Show();
            OcultarMenuLateral();
        }

        private void btnRoporteNegocio_Click(object sender, EventArgs e)
        {
            Admin_Reportes_Negocio ventana = null;
            if (ventana == null)
            {
                ventana = new Admin_Reportes_Negocio();
                openChildForm(ventana);
            }
            else
                ventana.Show();
            OcultarMenuLateral();
        }

        private void btnRoporteRepartidor_Click(object sender, EventArgs e)
        {
            Admin_Reportes_Repartidor ventana = null;
            if (ventana == null)
            {
                ventana = new Admin_Reportes_Repartidor();
                openChildForm(ventana);
            }
            else
                ventana.Show();
            OcultarMenuLateral();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
            Login log = new Login();
            log.Show();
        }

        #region Funciones

        /// <summary>
        /// Abre una ventana dentro de un panel
        /// </summary>
        /// <param Form="childForm">La ventana que desea abrir</param>
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

        /// <summary>
        /// Cierre una venta abierta en el panel
        /// </summary>
        ///<param Form="childForm">La ventana que desea cerrar</param>
        private void closeChildForm(Form childForm)
        {
            try
            {
                childForm.Hide();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "No hay ninguna ventana abierta\n " + e.Message, "Problema encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Oculta el menú lateral
        /// </summary>
        public void OcultarMenuLateral()
        {
            pnlMenuLateral.Visible = false;
            btnAbrirBarraLateral.Text = ">";
        }

        /// <summary>
        /// Muestra el menú lateral
        /// </summary>
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
            lblFrase3.BackColor = Color.Transparent;
        }


        #endregion FUNCIONES

        #region ABRIR PANEL REPORTES

        private void btnReportes_MouseHover(object sender, EventArgs e)
        {
            pnlReportes.Visible = true;
        }

        private void pnlReportes_MouseHover(object sender, EventArgs e)
        {
            pnlReportes.Visible = true;
        }

        private void pnlReportes_MouseLeave(object sender, EventArgs e)
        {
            pnlReportes.Visible = true;
        }

        private void btnRoporteCliente_MouseHover(object sender, EventArgs e)
        {
            pnlReportes.Visible = true;
        }

        private void btnRoporteNegocio_MouseHover(object sender, EventArgs e)
        {
            pnlReportes.Visible = true;
        }

        private void btnRoporteRepartidor_MouseHover(object sender, EventArgs e)
        {
            pnlReportes.Visible = true;
        }

        private void btnRoporteRepartidor_MouseLeave(object sender, EventArgs e)
        {
            pnlReportes.Visible = false;
        }
        #endregion ABRIR PANEL REPORTES

       
    }
}
