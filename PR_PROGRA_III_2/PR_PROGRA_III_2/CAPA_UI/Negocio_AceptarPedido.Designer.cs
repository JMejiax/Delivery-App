namespace CAPA_UI
{
    partial class Negocio_AceptarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFacturas = new System.Windows.Forms.TabPage();
            this.btnVerPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPedido = new System.Windows.Forms.TabPage();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFacturas);
            this.tabControl1.Controls.Add(this.tabPedido);
            this.tabControl1.Location = new System.Drawing.Point(-35, -37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(996, 541);
            this.tabControl1.TabIndex = 0;
            // 
            // tabFacturas
            // 
            this.tabFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabFacturas.Controls.Add(this.btnVerPedido);
            this.tabFacturas.Controls.Add(this.label1);
            this.tabFacturas.Controls.Add(this.btnCancelar);
            this.tabFacturas.Controls.Add(this.dgvPedidos);
            this.tabFacturas.Controls.Add(this.label20);
            this.tabFacturas.Location = new System.Drawing.Point(4, 22);
            this.tabFacturas.Name = "tabFacturas";
            this.tabFacturas.Padding = new System.Windows.Forms.Padding(3);
            this.tabFacturas.Size = new System.Drawing.Size(988, 515);
            this.tabFacturas.TabIndex = 0;
            this.tabFacturas.Text = "tabPage1";
            // 
            // btnVerPedido
            // 
            this.btnVerPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVerPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnVerPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnVerPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVerPedido.Location = new System.Drawing.Point(571, 383);
            this.btnVerPedido.Name = "btnVerPedido";
            this.btnVerPedido.Size = new System.Drawing.Size(150, 39);
            this.btnVerPedido.TabIndex = 77;
            this.btnVerPedido.Text = "Ver Pedido";
            this.btnVerPedido.UseVisualStyleBackColor = true;
            this.btnVerPedido.Click += new System.EventHandler(this.btnVerPedido_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(123, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 16);
            this.label1.TabIndex = 76;
            this.label1.Text = "* Seleccione una orden para ver los productos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(727, 383);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 39);
            this.btnCancelar.TabIndex = 75;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AllowUserToResizeColumns = false;
            this.dgvPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.dgvPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPedidos.ColumnHeadersHeight = 35;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Telefono,
            this.IDFactura,
            this.Fecha});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvPedidos.Location = new System.Drawing.Point(126, 78);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPedidos.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPedidos.RowTemplate.Height = 30;
            this.dgvPedidos.RowTemplate.ReadOnly = true;
            this.dgvPedidos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(698, 299);
            this.dgvPedidos.TabIndex = 73;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Cliente";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // IDFactura
            // 
            this.IDFactura.DataPropertyName = "Id";
            this.IDFactura.HeaderText = "Código Factura";
            this.IDFactura.Name = "IDFactura";
            this.IDFactura.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label20.Location = new System.Drawing.Point(397, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 24);
            this.label20.TabIndex = 72;
            this.label20.Text = "Lista de Ordenes";
            // 
            // tabPedido
            // 
            this.tabPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabPedido.Controls.Add(this.label3);
            this.tabPedido.Controls.Add(this.btnAtras);
            this.tabPedido.Controls.Add(this.btnFinalizar);
            this.tabPedido.Controls.Add(this.dgvDetalle);
            this.tabPedido.Controls.Add(this.label2);
            this.tabPedido.Location = new System.Drawing.Point(4, 22);
            this.tabPedido.Name = "tabPedido";
            this.tabPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedido.Size = new System.Drawing.Size(988, 515);
            this.tabPedido.TabIndex = 1;
            this.tabPedido.Text = "tabPage2";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtras.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtras.Location = new System.Drawing.Point(711, 387);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(97, 39);
            this.btnAtras.TabIndex = 78;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnFinalizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFinalizar.Location = new System.Drawing.Point(514, 387);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(191, 39);
            this.btnFinalizar.TabIndex = 77;
            this.btnFinalizar.Text = "Marcar como finalizado";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AllowUserToResizeColumns = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDetalle.ColumnHeadersHeight = 35;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDetalle.EnableHeadersVisualStyles = false;
            this.dgvDetalle.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvDetalle.Location = new System.Drawing.Point(110, 82);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDetalle.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvDetalle.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDetalle.RowTemplate.Height = 60;
            this.dgvDetalle.RowTemplate.ReadOnly = true;
            this.dgvDetalle.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(698, 299);
            this.dgvDetalle.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(381, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 75;
            this.label2.Text = "Lista de productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(107, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 16);
            this.label3.TabIndex = 79;
            this.label3.Text = "*Una vez que finalice el pedido marquelo como finalizado";
            // 
            // Negocio_AceptarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(895, 447);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Negocio_AceptarPedido";
            this.Text = "Negocio_AceptarPedido";
            this.Load += new System.EventHandler(this.Negocio_AceptarPedido_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFacturas.ResumeLayout(false);
            this.tabFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabPedido.ResumeLayout(false);
            this.tabPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFacturas;
        private System.Windows.Forms.Button btnVerPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label label3;
    }
}