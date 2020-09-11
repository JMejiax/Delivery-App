namespace CAPA_UI
{
    partial class MenuCliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlVentanas = new System.Windows.Forms.Panel();
            this.btnAbrirBarraLateral = new System.Windows.Forms.Button();
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlBtnCliente = new System.Windows.Forms.Panel();
            this.pnlEliminar = new System.Windows.Forms.Panel();
            this.btnEliminarCuenta = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnHistorialPedidos = new System.Windows.Forms.Button();
            this.btnPedidoActual = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.lblFrase3 = new System.Windows.Forms.Label();
            this.lblFrase2 = new System.Windows.Forms.Label();
            this.lblFrase1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlVentanas.SuspendLayout();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlBtnCliente.SuspendLayout();
            this.pnlEliminar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlVentanas
            // 
            this.pnlVentanas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.pnlVentanas.Controls.Add(this.btnAbrirBarraLateral);
            this.pnlVentanas.Controls.Add(this.pnlMenuLateral);
            this.pnlVentanas.Controls.Add(this.lblFrase3);
            this.pnlVentanas.Controls.Add(this.lblFrase2);
            this.pnlVentanas.Controls.Add(this.lblFrase1);
            this.pnlVentanas.Controls.Add(this.pictureBox2);
            this.pnlVentanas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVentanas.Location = new System.Drawing.Point(0, 0);
            this.pnlVentanas.Name = "pnlVentanas";
            this.pnlVentanas.Size = new System.Drawing.Size(934, 486);
            this.pnlVentanas.TabIndex = 2;
            // 
            // btnAbrirBarraLateral
            // 
            this.btnAbrirBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.btnAbrirBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAbrirBarraLateral.FlatAppearance.BorderSize = 0;
            this.btnAbrirBarraLateral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirBarraLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirBarraLateral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAbrirBarraLateral.Location = new System.Drawing.Point(200, 0);
            this.btnAbrirBarraLateral.Name = "btnAbrirBarraLateral";
            this.btnAbrirBarraLateral.Size = new System.Drawing.Size(23, 486);
            this.btnAbrirBarraLateral.TabIndex = 2;
            this.btnAbrirBarraLateral.Text = ">";
            this.btnAbrirBarraLateral.UseVisualStyleBackColor = false;
            this.btnAbrirBarraLateral.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAbrirBarraLateral_MouseClick);
            // 
            // pnlMenuLateral
            // 
            this.pnlMenuLateral.AutoScroll = true;
            this.pnlMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.pnlMenuLateral.Controls.Add(this.btnCerrarSesion);
            this.pnlMenuLateral.Controls.Add(this.pnlBtnCliente);
            this.pnlMenuLateral.Controls.Add(this.btnCliente);
            this.pnlMenuLateral.Controls.Add(this.pnlLogo);
            this.pnlMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuLateral.Name = "pnlMenuLateral";
            this.pnlMenuLateral.Size = new System.Drawing.Size(200, 486);
            this.pnlMenuLateral.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 2;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(197)))), ((int)(((byte)(161)))));
            this.btnCerrarSesion.Location = new System.Drawing.Point(0, 444);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 42);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click_1);
            // 
            // pnlBtnCliente
            // 
            this.pnlBtnCliente.Controls.Add(this.pnlEliminar);
            this.pnlBtnCliente.Controls.Add(this.btnConfig);
            this.pnlBtnCliente.Controls.Add(this.btnHistorialPedidos);
            this.pnlBtnCliente.Controls.Add(this.btnPedidoActual);
            this.pnlBtnCliente.Controls.Add(this.btnNuevoPedido);
            this.pnlBtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBtnCliente.Location = new System.Drawing.Point(0, 151);
            this.pnlBtnCliente.Name = "pnlBtnCliente";
            this.pnlBtnCliente.Size = new System.Drawing.Size(200, 293);
            this.pnlBtnCliente.TabIndex = 2;
            // 
            // pnlEliminar
            // 
            this.pnlEliminar.Controls.Add(this.btnEliminarCuenta);
            this.pnlEliminar.Location = new System.Drawing.Point(0, 210);
            this.pnlEliminar.Name = "pnlEliminar";
            this.pnlEliminar.Size = new System.Drawing.Size(200, 49);
            this.pnlEliminar.TabIndex = 7;
            // 
            // btnEliminarCuenta
            // 
            this.btnEliminarCuenta.FlatAppearance.BorderSize = 0;
            this.btnEliminarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCuenta.ForeColor = System.Drawing.Color.Red;
            this.btnEliminarCuenta.Image = global::CAPA_UI.Properties.Resources.eliminar;
            this.btnEliminarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCuenta.Location = new System.Drawing.Point(0, 0);
            this.btnEliminarCuenta.Name = "btnEliminarCuenta";
            this.btnEliminarCuenta.Size = new System.Drawing.Size(200, 44);
            this.btnEliminarCuenta.TabIndex = 5;
            this.btnEliminarCuenta.Text = "        Eliminar cuenta";
            this.btnEliminarCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCuenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarCuenta.UseVisualStyleBackColor = true;
            this.btnEliminarCuenta.Click += new System.EventHandler(this.btnEliminarCuenta_Click);
            this.btnEliminarCuenta.MouseLeave += new System.EventHandler(this.btnEliminarCuenta_MouseLeave);
            this.btnEliminarCuenta.MouseHover += new System.EventHandler(this.btnEliminarCuenta_MouseHover);
            // 
            // btnConfig
            // 
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.Image = global::CAPA_UI.Properties.Resources.base_de_datos;
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.Location = new System.Drawing.Point(0, 160);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(200, 44);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "     Configurar perfil";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.button1_Click);
            this.btnConfig.MouseHover += new System.EventHandler(this.btnConfig_MouseHover);
            // 
            // btnHistorialPedidos
            // 
            this.btnHistorialPedidos.FlatAppearance.BorderSize = 0;
            this.btnHistorialPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPedidos.ForeColor = System.Drawing.Color.White;
            this.btnHistorialPedidos.Image = global::CAPA_UI.Properties.Resources.seo_report;
            this.btnHistorialPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialPedidos.Location = new System.Drawing.Point(0, 110);
            this.btnHistorialPedidos.Name = "btnHistorialPedidos";
            this.btnHistorialPedidos.Size = new System.Drawing.Size(200, 44);
            this.btnHistorialPedidos.TabIndex = 3;
            this.btnHistorialPedidos.Text = "     Reportes";
            this.btnHistorialPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorialPedidos.UseVisualStyleBackColor = true;
            this.btnHistorialPedidos.Click += new System.EventHandler(this.btnHistorialPedidos_Click);
            // 
            // btnPedidoActual
            // 
            this.btnPedidoActual.FlatAppearance.BorderSize = 0;
            this.btnPedidoActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidoActual.ForeColor = System.Drawing.Color.White;
            this.btnPedidoActual.Image = global::CAPA_UI.Properties.Resources.boleta_de_calificaciones;
            this.btnPedidoActual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidoActual.Location = new System.Drawing.Point(0, 58);
            this.btnPedidoActual.Name = "btnPedidoActual";
            this.btnPedidoActual.Size = new System.Drawing.Size(200, 46);
            this.btnPedidoActual.TabIndex = 1;
            this.btnPedidoActual.Text = "     Calificar Pedido";
            this.btnPedidoActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPedidoActual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPedidoActual.UseVisualStyleBackColor = true;
            this.btnPedidoActual.Click += new System.EventHandler(this.btnPedidoActual_Click_1);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.FlatAppearance.BorderSize = 0;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPedido.Image = global::CAPA_UI.Properties.Resources.pedido_en_linea;
            this.btnNuevoPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPedido.Location = new System.Drawing.Point(3, 6);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(200, 46);
            this.btnNuevoPedido.TabIndex = 0;
            this.btnNuevoPedido.Text = "     Nuevo Pedido";
            this.btnNuevoPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click_1);
            // 
            // btnCliente
            // 
            this.btnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCliente.FlatAppearance.BorderSize = 2;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(197)))), ((int)(((byte)(161)))));
            this.btnCliente.Location = new System.Drawing.Point(0, 116);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(200, 35);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "Menu Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click_1);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblNombreApp);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 116);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(197)))), ((int)(((byte)(161)))));
            this.lblNombreApp.Location = new System.Drawing.Point(0, 0);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(200, 113);
            this.lblNombreApp.TabIndex = 0;
            this.lblNombreApp.Text = "Express ";
            this.lblNombreApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFrase3
            // 
            this.lblFrase3.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblFrase3.Location = new System.Drawing.Point(25, 183);
            this.lblFrase3.Name = "lblFrase3";
            this.lblFrase3.Size = new System.Drawing.Size(385, 35);
            this.lblFrase3.TabIndex = 6;
            this.lblFrase3.Text = "Empezá a pedir ya!";
            this.lblFrase3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrase2
            // 
            this.lblFrase2.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblFrase2.Location = new System.Drawing.Point(25, 134);
            this.lblFrase2.Name = "lblFrase2";
            this.lblFrase2.Size = new System.Drawing.Size(385, 35);
            this.lblFrase2.TabIndex = 5;
            this.lblFrase2.Text = "Te estuvimos esperando";
            this.lblFrase2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrase1
            // 
            this.lblFrase1.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblFrase1.Location = new System.Drawing.Point(24, 81);
            this.lblFrase1.Name = "lblFrase1";
            this.lblFrase1.Size = new System.Drawing.Size(227, 35);
            this.lblFrase1.TabIndex = 3;
            this.lblFrase1.Text = "Bienvenido";
            this.lblFrase1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::CAPA_UI.Properties.Resources._1019;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(934, 486);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // MenuCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.pnlVentanas);
            this.Name = "MenuCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delivery";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.pnlVentanas.ResumeLayout(false);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlBtnCliente.ResumeLayout(false);
            this.pnlEliminar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlVentanas;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlBtnCliente;
        private System.Windows.Forms.Button btnHistorialPedidos;
        private System.Windows.Forms.Button btnPedidoActual;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.Button btnAbrirBarraLateral;
        private System.Windows.Forms.Label lblFrase1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblFrase3;
        private System.Windows.Forms.Label lblFrase2;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Button btnEliminarCuenta;
    }
}

