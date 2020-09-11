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
using CAPA_LN;

namespace CAPA_UI
{
    public partial class MenuCliente : Form
    {
        #region Variables
        private int contAbrirPnlBtn1 = 0;
        private Form activeForm = null;
        public static Cliente _Cliente;
        #endregion Variables
        public MenuCliente(Cliente cliente)
        {
            _Cliente = cliente;
            InitializeComponent();
        }

        #region Botones
        /// <summary>
        /// Abre las opciones del cliente en el menu lateral
        /// </summary>
        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            if (contAbrirPnlBtn1 % 2 == 0)
                pnlBtnCliente.Show();
            else
                pnlBtnCliente.Hide();
            contAbrirPnlBtn1++;
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            OcultarMenuLateral();
            LabelsTransparentes();
        }

        /// <summary>
        /// Abre la ventana encargada de crear un nuevo pedido
        /// </summary>
        private void btnNuevoPedido_Click_1(object sender, EventArgs e)
        {
            
            Cliente_NuevoPedido np = null;
            if (np == null)
            {
                np = new Cliente_NuevoPedido();
                openChildForm(np);
            }
            else
                np.Show();
            OcultarMenuLateral();
        }

        /// <summary>
        /// Abre la ventana encargada de ver el pedido actual
        /// </summary>
        private void btnPedidoActual_Click_1(object sender, EventArgs e)
        {
            Cliente_PedidoActual pa = null;
            if (pa == null)
            {
                pa = new Cliente_PedidoActual();
                openChildForm(pa);
            }
            else
                pa.Show();
            OcultarMenuLateral();
        }

        /// <summary>
        /// Abre la ventana encargada de ver los reportes
        /// </summary>
        private void btnHistorialPedidos_Click(object sender, EventArgs e)
        {
            Cliente_Reportes r = null;
            if (r == null)
            {
                r = new Cliente_Reportes();
                openChildForm(r);
            }
            else
                r.Show();
            OcultarMenuLateral();
        }

        /// <summary>
        /// Abre y cierra el menú lateral
        /// </summary>
        private void btnAbrirBarraLateral_MouseClick(object sender, MouseEventArgs e)
        {
            if (pnlMenuLateral.Visible == false)
                AbrirMenuLateral();
            else
                OcultarMenuLateral();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Cliente_Configurar cc = null;
            if (cc == null)
            {
                cc = new Cliente_Configurar(_Cliente);
                openChildForm(cc);
            }
            else
                cc.Show();
            OcultarMenuLateral();
        }
        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            int result = (int)MessageBox.Show(this, "¿Está seguro que desea eliminar su cuenta?", "Permiso requerido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == 6)
            {
                UsuarioLN usuarioLN = new UsuarioLN();
                Login log = new Login();
                usuarioLN.EliminarUsuario(_Cliente.Id);
                Close();
                log.Show();
            }
        }
        private void btnCerrarSesion_Click_1(object sender, EventArgs e)
        {
            Close();
            Login log = new Login();
            log.Show();
        }

        #endregion Botones

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
            lblFrase1.Parent = pictureBox2;
            lblFrase1.BackColor = Color.Transparent;
            lblFrase2.Parent = pictureBox2;
            lblFrase2.BackColor = Color.Transparent;
            lblFrase3.Parent = pictureBox2;
            lblFrase3.BackColor = Color.Transparent;
        }

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

        #endregion Funciones

        
    }
}
