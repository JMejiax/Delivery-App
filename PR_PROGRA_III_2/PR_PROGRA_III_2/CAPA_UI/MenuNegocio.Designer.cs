namespace CAPA_UI
{
    partial class MenuNegocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
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
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.lblFrase2 = new System.Windows.Forms.Label();
            this.lblFrase3 = new System.Windows.Forms.Label();
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
            this.pnlVentanas.Controls.Add(this.lblFrase2);
            this.pnlVentanas.Controls.Add(this.lblFrase3);
            this.pnlVentanas.Controls.Add(this.lblFrase1);
            this.pnlVentanas.Controls.Add(this.pictureBox2);
            this.pnlVentanas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlVentanas.Location = new System.Drawing.Point(0, 0);
            this.pnlVentanas.Name = "pnlVentanas";
            this.pnlVentanas.Size = new System.Drawing.Size(934, 486);
            this.pnlVentanas.TabIndex = 3;
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
            this.btnAbrirBarraLateral.TabIndex = 9;
            this.btnAbrirBarraLateral.Text = ">";
            this.btnAbrirBarraLateral.UseVisualStyleBackColor = false;
            this.btnAbrirBarraLateral.Click += new System.EventHandler(this.btnAbrirBarraLateral_Click_1);
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
            this.pnlMenuLateral.TabIndex = 8;
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
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 35);
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
            this.pnlBtnCliente.Controls.Add(this.btnArticulos);
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
            this.pnlEliminar.Location = new System.Drawing.Point(0, 228);
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
            this.btnConfig.Location = new System.Drawing.Point(0, 178);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(200, 44);
            this.btnConfig.TabIndex = 4;
            this.btnConfig.Text = "     Configurar perfil";
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
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
            this.btnHistorialPedidos.Location = new System.Drawing.Point(0, 123);
            this.btnHistorialPedidos.Name = "btnHistorialPedidos";
            this.btnHistorialPedidos.Size = new System.Drawing.Size(200, 44);
            this.btnHistorialPedidos.TabIndex = 3;
            this.btnHistorialPedidos.Text = "     Reportes";
            this.btnHistorialPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorialPedidos.UseVisualStyleBackColor = true;
            this.btnHistorialPedidos.Click += new System.EventHandler(this.btnHistorialPedidos_Click);
            // 
            // btnArticulos
            // 
            this.btnArticulos.FlatAppearance.BorderSize = 0;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.ForeColor = System.Drawing.Color.White;
            this.btnArticulos.Image = global::CAPA_UI.Properties.Resources.boleta_de_calificaciones;
            this.btnArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.Location = new System.Drawing.Point(0, 71);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(200, 46);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "     Articulos";
            this.btnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArticulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnArticulos_Click);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.FlatAppearance.BorderSize = 0;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPedido.Image = global::CAPA_UI.Properties.Resources.pedido_en_linea;
            this.btnNuevoPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPedido.Location = new System.Drawing.Point(0, 16);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(200, 46);
            this.btnNuevoPedido.TabIndex = 0;
            this.btnNuevoPedido.Text = "     Aceptar Pedidos";
            this.btnNuevoPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoPedido.UseVisualStyleBackColor = true;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
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
            this.btnCliente.Text = "Menu Negocio";
            this.btnCliente.UseVisualStyleBackColor = true;
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
            // lblFrase2
            // 
            this.lblFrase2.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblFrase2.Location = new System.Drawing.Point(24, 123);
            this.lblFrase2.Name = "lblFrase2";
            this.lblFrase2.Size = new System.Drawing.Size(385, 35);
            this.lblFrase2.TabIndex = 6;
            this.lblFrase2.Text = "Te estuvimos esperando";
            this.lblFrase2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrase3
            // 
            this.lblFrase3.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblFrase3.Location = new System.Drawing.Point(24, 169);
            this.lblFrase3.Name = "lblFrase3";
            this.lblFrase3.Size = new System.Drawing.Size(427, 35);
            this.lblFrase3.TabIndex = 7;
            this.lblFrase3.Text = "Hay clientes esperando su comida!";
            this.lblFrase3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrase1
            // 
            this.lblFrase1.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblFrase1.Location = new System.Drawing.Point(23, 83);
            this.lblFrase1.Name = "lblFrase1";
            this.lblFrase1.Size = new System.Drawing.Size(227, 35);
            this.lblFrase1.TabIndex = 5;
            this.lblFrase1.Text = "Bienvenido";
            this.lblFrase1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CAPA_UI.Properties.Resources._1019;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(934, 486);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // MenuNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.pnlVentanas);
            this.Name = "MenuNegocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuNegocio";
            this.Load += new System.EventHandler(this.MenuNegocio_Load);
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
        private System.Windows.Forms.Label lblFrase1;
        private System.Windows.Forms.Label lblFrase2;
        private System.Windows.Forms.Label lblFrase3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAbrirBarraLateral;
        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlBtnCliente;
        private System.Windows.Forms.Panel pnlEliminar;
        private System.Windows.Forms.Button btnEliminarCuenta;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnHistorialPedidos;
        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblNombreApp;
    }
}