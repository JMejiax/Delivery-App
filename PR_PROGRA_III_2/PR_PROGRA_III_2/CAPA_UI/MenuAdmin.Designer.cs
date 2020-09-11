namespace CAPA_UI
{
    partial class MenuAdmin
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
            this.pnlMenuLateral = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pnlBtnCliente = new System.Windows.Forms.Panel();
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnRoporteRepartidor = new System.Windows.Forms.Button();
            this.btnRoporteNegocio = new System.Windows.Forms.Button();
            this.btnRoporteCliente = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.btnAbrirBarraLateral = new System.Windows.Forms.Button();
            this.pnlVentanas = new System.Windows.Forms.Panel();
            this.lblFrase3 = new System.Windows.Forms.Label();
            this.lblFrase2 = new System.Windows.Forms.Label();
            this.lblFrase1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlMenuLateral.SuspendLayout();
            this.pnlBtnCliente.SuspendLayout();
            this.pnlReportes.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlVentanas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.pnlMenuLateral.TabIndex = 2;
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
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pnlBtnCliente
            // 
            this.pnlBtnCliente.Controls.Add(this.pnlReportes);
            this.pnlBtnCliente.Controls.Add(this.btnReportes);
            this.pnlBtnCliente.Controls.Add(this.btnCrearUsuario);
            this.pnlBtnCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBtnCliente.Location = new System.Drawing.Point(0, 151);
            this.pnlBtnCliente.Name = "pnlBtnCliente";
            this.pnlBtnCliente.Size = new System.Drawing.Size(200, 293);
            this.pnlBtnCliente.TabIndex = 2;
            // 
            // pnlReportes
            // 
            this.pnlReportes.Controls.Add(this.btnRoporteRepartidor);
            this.pnlReportes.Controls.Add(this.btnRoporteNegocio);
            this.pnlReportes.Controls.Add(this.btnRoporteCliente);
            this.pnlReportes.Location = new System.Drawing.Point(0, 139);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(200, 139);
            this.pnlReportes.TabIndex = 4;
            this.pnlReportes.MouseLeave += new System.EventHandler(this.pnlReportes_MouseLeave);
            this.pnlReportes.MouseHover += new System.EventHandler(this.pnlReportes_MouseHover);
            // 
            // btnRoporteRepartidor
            // 
            this.btnRoporteRepartidor.FlatAppearance.BorderSize = 0;
            this.btnRoporteRepartidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoporteRepartidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoporteRepartidor.ForeColor = System.Drawing.Color.White;
            this.btnRoporteRepartidor.Image = global::CAPA_UI.Properties.Resources.caja;
            this.btnRoporteRepartidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoporteRepartidor.Location = new System.Drawing.Point(0, 89);
            this.btnRoporteRepartidor.Name = "btnRoporteRepartidor";
            this.btnRoporteRepartidor.Size = new System.Drawing.Size(200, 35);
            this.btnRoporteRepartidor.TabIndex = 4;
            this.btnRoporteRepartidor.Text = "     Repartidor";
            this.btnRoporteRepartidor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoporteRepartidor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoporteRepartidor.UseVisualStyleBackColor = true;
            this.btnRoporteRepartidor.Click += new System.EventHandler(this.btnRoporteRepartidor_Click);
            this.btnRoporteRepartidor.MouseLeave += new System.EventHandler(this.btnRoporteRepartidor_MouseLeave);
            this.btnRoporteRepartidor.MouseHover += new System.EventHandler(this.btnRoporteRepartidor_MouseHover);
            // 
            // btnRoporteNegocio
            // 
            this.btnRoporteNegocio.FlatAppearance.BorderSize = 0;
            this.btnRoporteNegocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoporteNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoporteNegocio.ForeColor = System.Drawing.Color.White;
            this.btnRoporteNegocio.Image = global::CAPA_UI.Properties.Resources.tienda;
            this.btnRoporteNegocio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoporteNegocio.Location = new System.Drawing.Point(0, 45);
            this.btnRoporteNegocio.Name = "btnRoporteNegocio";
            this.btnRoporteNegocio.Size = new System.Drawing.Size(200, 38);
            this.btnRoporteNegocio.TabIndex = 3;
            this.btnRoporteNegocio.Text = "     Negocio";
            this.btnRoporteNegocio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoporteNegocio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoporteNegocio.UseVisualStyleBackColor = true;
            this.btnRoporteNegocio.Click += new System.EventHandler(this.btnRoporteNegocio_Click);
            this.btnRoporteNegocio.MouseHover += new System.EventHandler(this.btnRoporteNegocio_MouseHover);
            // 
            // btnRoporteCliente
            // 
            this.btnRoporteCliente.FlatAppearance.BorderSize = 0;
            this.btnRoporteCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoporteCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoporteCliente.ForeColor = System.Drawing.Color.White;
            this.btnRoporteCliente.Image = global::CAPA_UI.Properties.Resources.revision;
            this.btnRoporteCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoporteCliente.Location = new System.Drawing.Point(0, 3);
            this.btnRoporteCliente.Name = "btnRoporteCliente";
            this.btnRoporteCliente.Size = new System.Drawing.Size(200, 36);
            this.btnRoporteCliente.TabIndex = 2;
            this.btnRoporteCliente.Text = "     Cliente";
            this.btnRoporteCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoporteCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRoporteCliente.UseVisualStyleBackColor = true;
            this.btnRoporteCliente.Click += new System.EventHandler(this.btnRoporteCliente_Click);
            this.btnRoporteCliente.MouseHover += new System.EventHandler(this.btnRoporteCliente_MouseHover);
            // 
            // btnReportes
            // 
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.White;
            this.btnReportes.Image = global::CAPA_UI.Properties.Resources.seo_report;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(0, 89);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(200, 44);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "     Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.MouseHover += new System.EventHandler(this.btnReportes_MouseHover);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.Image = global::CAPA_UI.Properties.Resources.base_de_datos;
            this.btnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCrearUsuario.Location = new System.Drawing.Point(0, 22);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(200, 46);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "     Crear Usuario";
            this.btnCrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
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
            this.btnCliente.Text = "Menu Admin";
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
            this.btnAbrirBarraLateral.TabIndex = 3;
            this.btnAbrirBarraLateral.Text = ">";
            this.btnAbrirBarraLateral.UseVisualStyleBackColor = false;
            this.btnAbrirBarraLateral.Click += new System.EventHandler(this.btnAbrirBarraLateral_Click);
            // 
            // pnlVentanas
            // 
            this.pnlVentanas.Controls.Add(this.lblFrase3);
            this.pnlVentanas.Controls.Add(this.lblFrase2);
            this.pnlVentanas.Controls.Add(this.lblFrase1);
            this.pnlVentanas.Controls.Add(this.pictureBox1);
            this.pnlVentanas.Location = new System.Drawing.Point(0, 0);
            this.pnlVentanas.Name = "pnlVentanas";
            this.pnlVentanas.Size = new System.Drawing.Size(935, 486);
            this.pnlVentanas.TabIndex = 4;
            // 
            // lblFrase3
            // 
            this.lblFrase3.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase3.ForeColor = System.Drawing.Color.Transparent;
            this.lblFrase3.Location = new System.Drawing.Point(24, 184);
            this.lblFrase3.Name = "lblFrase3";
            this.lblFrase3.Size = new System.Drawing.Size(385, 35);
            this.lblFrase3.TabIndex = 12;
            this.lblFrase3.Text = "este lugar o añadir usuarios";
            this.lblFrase3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrase2
            // 
            this.lblFrase2.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase2.ForeColor = System.Drawing.Color.Transparent;
            this.lblFrase2.Location = new System.Drawing.Point(24, 135);
            this.lblFrase2.Name = "lblFrase2";
            this.lblFrase2.Size = new System.Drawing.Size(426, 35);
            this.lblFrase2.TabIndex = 11;
            this.lblFrase2.Text = "Es hora de empezar a administrar";
            this.lblFrase2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFrase1
            // 
            this.lblFrase1.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase1.ForeColor = System.Drawing.Color.Transparent;
            this.lblFrase1.Location = new System.Drawing.Point(23, 82);
            this.lblFrase1.Name = "lblFrase1";
            this.lblFrase1.Size = new System.Drawing.Size(227, 35);
            this.lblFrase1.TabIndex = 10;
            this.lblFrase1.Text = "Bienvenido";
            this.lblFrase1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CAPA_UI.Properties.Resources._1019;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(935, 486);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(934, 486);
            this.Controls.Add(this.btnAbrirBarraLateral);
            this.Controls.Add(this.pnlMenuLateral);
            this.Controls.Add(this.pnlVentanas);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdmin";
            this.Load += new System.EventHandler(this.MenuAdmin_Load);
            this.pnlMenuLateral.ResumeLayout(false);
            this.pnlBtnCliente.ResumeLayout(false);
            this.pnlReportes.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlVentanas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLateral;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pnlBtnCliente;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblNombreApp;
        private System.Windows.Forms.Button btnAbrirBarraLateral;
        private System.Windows.Forms.Panel pnlReportes;
        private System.Windows.Forms.Panel pnlVentanas;
        private System.Windows.Forms.Button btnRoporteRepartidor;
        private System.Windows.Forms.Button btnRoporteNegocio;
        private System.Windows.Forms.Button btnRoporteCliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFrase3;
        private System.Windows.Forms.Label lblFrase2;
        private System.Windows.Forms.Label lblFrase1;
    }
}