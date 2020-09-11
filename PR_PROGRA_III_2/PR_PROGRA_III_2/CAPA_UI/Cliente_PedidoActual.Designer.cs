namespace CAPA_UI
{
    partial class Cliente_PedidoActual
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
            this.pnlSinPedidos = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPedido = new System.Windows.Forms.Panel();
            this.btnVerPedido = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAnnadir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtComentarioRepartidor = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.puntajeRepartidor = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtComentarioNegocio = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.puntajeNegocio = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlSinPedidos.SuspendLayout();
            this.pnlPedido.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntajeRepartidor)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.puntajeNegocio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSinPedidos
            // 
            this.pnlSinPedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSinPedidos.Controls.Add(this.label12);
            this.pnlSinPedidos.Controls.Add(this.label3);
            this.pnlSinPedidos.Controls.Add(this.label2);
            this.pnlSinPedidos.Controls.Add(this.label1);
            this.pnlSinPedidos.Controls.Add(this.label4);
            this.pnlSinPedidos.Location = new System.Drawing.Point(12, 12);
            this.pnlSinPedidos.Name = "pnlSinPedidos";
            this.pnlSinPedidos.Size = new System.Drawing.Size(887, 462);
            this.pnlSinPedidos.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(4, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(874, 35);
            this.label12.TabIndex = 8;
            this.label12.Text = "* Espera hasta que llegue el repartidor para calificar ;)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(874, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "junto con los mejores precios para vos...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(874, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "No pierdas tiempo, tenemos los mejores productos ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(879, 68);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parece que no tienes ningún pedido :(";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(874, 35);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pedí ya!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlPedido
            // 
            this.pnlPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPedido.Controls.Add(this.btnVerPedido);
            this.pnlPedido.Controls.Add(this.btnCancelar);
            this.pnlPedido.Controls.Add(this.btnAnnadir);
            this.pnlPedido.Controls.Add(this.panel2);
            this.pnlPedido.Controls.Add(this.panel1);
            this.pnlPedido.Controls.Add(this.label7);
            this.pnlPedido.Controls.Add(this.label6);
            this.pnlPedido.Controls.Add(this.label5);
            this.pnlPedido.Location = new System.Drawing.Point(12, 12);
            this.pnlPedido.Name = "pnlPedido";
            this.pnlPedido.Size = new System.Drawing.Size(887, 462);
            this.pnlPedido.TabIndex = 8;
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnVerPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnVerPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerPedido.Location = new System.Drawing.Point(747, 403);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(120, 39);
            this.btnVerPedido.TabIndex = 13;
            this.btnVerPedido.Text = "Ver Pedido";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(621, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 39);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "No Calificar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAnnadir
            // 
            this.btnAnnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnAnnadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAnnadir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAnnadir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAnnadir.Location = new System.Drawing.Point(495, 403);
            this.btnAnnadir.Name = "btnAnnadir";
            this.btnAnnadir.Size = new System.Drawing.Size(120, 39);
            this.btnAnnadir.TabIndex = 11;
            this.btnAnnadir.Text = "Calificar";
            this.btnAnnadir.UseVisualStyleBackColor = false;
            this.btnAnnadir.Click += new System.EventHandler(this.btnAnnadir_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtComentarioRepartidor);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.puntajeRepartidor);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(458, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 236);
            this.panel2.TabIndex = 10;
            // 
            // txtComentarioRepartidor
            // 
            this.txtComentarioRepartidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtComentarioRepartidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioRepartidor.ForeColor = System.Drawing.SystemColors.Window;
            this.txtComentarioRepartidor.Location = new System.Drawing.Point(15, 118);
            this.txtComentarioRepartidor.Name = "txtComentarioRepartidor";
            this.txtComentarioRepartidor.Size = new System.Drawing.Size(368, 96);
            this.txtComentarioRepartidor.TabIndex = 16;
            this.txtComentarioRepartidor.Text = "";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label10.Location = new System.Drawing.Point(11, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Comentario";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // puntajeRepartidor
            // 
            this.puntajeRepartidor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.puntajeRepartidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.puntajeRepartidor.DecimalPlaces = 1;
            this.puntajeRepartidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntajeRepartidor.ForeColor = System.Drawing.SystemColors.Info;
            this.puntajeRepartidor.Location = new System.Drawing.Point(15, 48);
            this.puntajeRepartidor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.puntajeRepartidor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.puntajeRepartidor.Name = "puntajeRepartidor";
            this.puntajeRepartidor.Size = new System.Drawing.Size(120, 21);
            this.puntajeRepartidor.TabIndex = 14;
            this.puntajeRepartidor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label11.Location = new System.Drawing.Point(11, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Puntaje ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtComentarioNegocio);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.puntajeNegocio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(39, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 236);
            this.panel1.TabIndex = 9;
            // 
            // txtComentarioNegocio
            // 
            this.txtComentarioNegocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtComentarioNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarioNegocio.ForeColor = System.Drawing.SystemColors.Window;
            this.txtComentarioNegocio.Location = new System.Drawing.Point(7, 115);
            this.txtComentarioNegocio.Name = "txtComentarioNegocio";
            this.txtComentarioNegocio.Size = new System.Drawing.Size(368, 96);
            this.txtComentarioNegocio.TabIndex = 12;
            this.txtComentarioNegocio.Text = "";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label9.Location = new System.Drawing.Point(3, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Comentario";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // puntajeNegocio
            // 
            this.puntajeNegocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.puntajeNegocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.puntajeNegocio.DecimalPlaces = 1;
            this.puntajeNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntajeNegocio.ForeColor = System.Drawing.SystemColors.Window;
            this.puntajeNegocio.Location = new System.Drawing.Point(7, 45);
            this.puntajeNegocio.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.puntajeNegocio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.puntajeNegocio.Name = "puntajeNegocio";
            this.puntajeNegocio.Size = new System.Drawing.Size(120, 21);
            this.puntajeNegocio.TabIndex = 10;
            this.puntajeNegocio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Puntaje ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(454, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(413, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Calificar Repartidor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label6.Location = new System.Drawing.Point(35, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(413, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Calificar Negocio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(18, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(879, 53);
            this.label5.TabIndex = 5;
            this.label5.Text = "Danos una retroalimentación de tu último pedido";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cliente_PedidoActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(911, 486);
            this.Controls.Add(this.pnlPedido);
            this.Controls.Add(this.pnlSinPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "Cliente_PedidoActual";
            this.Text = "Pedido Actual";
            this.Load += new System.EventHandler(this.Cliente_PedidoActual_Load);
            this.pnlSinPedidos.ResumeLayout(false);
            this.pnlPedido.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.puntajeRepartidor)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.puntajeNegocio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSinPedidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtComentarioRepartidor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown puntajeRepartidor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtComentarioNegocio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown puntajeNegocio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAnnadir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnVerPedido;
    }
}