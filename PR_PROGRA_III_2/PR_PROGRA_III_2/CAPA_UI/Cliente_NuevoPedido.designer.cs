namespace CAPA_UI
{
    partial class Cliente_NuevoPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNegocios = new System.Windows.Forms.TabPage();
            this.dgvNegocios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.btnCancelarTab2 = new System.Windows.Forms.Button();
            this.btnSiguienteTab2 = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.listaPedido = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabDetalleFactura = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.CancelarPedido = new System.Windows.Forms.Button();
            this.btnAceptarPedido = new System.Windows.Forms.Button();
            this.btnValidarCupon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtCostoTotalDolares = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCostoTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescuentoCupon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCostoExpress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCostoNormal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCupon = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabNegocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegocios)).BeginInit();
            this.tabProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.tabDetalleFactura.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNegocios);
            this.tabControl1.Controls.Add(this.tabProductos);
            this.tabControl1.Controls.Add(this.tabDetalleFactura);
            this.tabControl1.Location = new System.Drawing.Point(-6, -27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabNegocios
            // 
            this.tabNegocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabNegocios.Controls.Add(this.dgvNegocios);
            this.tabNegocios.Controls.Add(this.label1);
            this.tabNegocios.Controls.Add(this.btnCancelarPedido);
            this.tabNegocios.Controls.Add(this.btnSeleccionar);
            this.tabNegocios.Controls.Add(this.label20);
            this.tabNegocios.Location = new System.Drawing.Point(4, 22);
            this.tabNegocios.Name = "tabNegocios";
            this.tabNegocios.Padding = new System.Windows.Forms.Padding(3);
            this.tabNegocios.Size = new System.Drawing.Size(922, 498);
            this.tabNegocios.TabIndex = 0;
            this.tabNegocios.Text = "tabPage1";
            // 
            // dgvNegocios
            // 
            this.dgvNegocios.AllowUserToAddRows = false;
            this.dgvNegocios.AllowUserToDeleteRows = false;
            this.dgvNegocios.AllowUserToResizeColumns = false;
            this.dgvNegocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNegocios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.dgvNegocios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNegocios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNegocios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNegocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNegocios.ColumnHeadersHeight = 35;
            this.dgvNegocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.Nombre,
            this.Telefono,
            this.Correo,
            this.Puntaje});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNegocios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNegocios.EnableHeadersVisualStyles = false;
            this.dgvNegocios.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvNegocios.Location = new System.Drawing.Point(92, 88);
            this.dgvNegocios.MultiSelect = false;
            this.dgvNegocios.Name = "dgvNegocios";
            this.dgvNegocios.ReadOnly = true;
            this.dgvNegocios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNegocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNegocios.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvNegocios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNegocios.RowTemplate.Height = 30;
            this.dgvNegocios.RowTemplate.ReadOnly = true;
            this.dgvNegocios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNegocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNegocios.Size = new System.Drawing.Size(698, 299);
            this.dgvNegocios.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(89, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "*Seleccione un restaurante para ver su catalogo de productos";
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancelarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnCancelarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelarPedido.Location = new System.Drawing.Point(693, 393);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(97, 39);
            this.btnCancelarPedido.TabIndex = 50;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnSeleccionar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSeleccionar.Location = new System.Drawing.Point(585, 393);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(102, 39);
            this.btnSeleccionar.TabIndex = 49;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label20.Location = new System.Drawing.Point(354, 43);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 24);
            this.label20.TabIndex = 47;
            this.label20.Text = "Lista de Negocios";
            // 
            // tabProductos
            // 
            this.tabProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabProductos.Controls.Add(this.btnCancelarTab2);
            this.tabProductos.Controls.Add(this.btnSiguienteTab2);
            this.tabProductos.Controls.Add(this.btnQuitar);
            this.tabProductos.Controls.Add(this.listaPedido);
            this.tabProductos.Controls.Add(this.label4);
            this.tabProductos.Controls.Add(this.label3);
            this.tabProductos.Controls.Add(this.dgvArticulos);
            this.tabProductos.Controls.Add(this.label2);
            this.tabProductos.Location = new System.Drawing.Point(4, 22);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(922, 498);
            this.tabProductos.TabIndex = 1;
            this.tabProductos.Text = "tabPage2";
            // 
            // btnCancelarTab2
            // 
            this.btnCancelarTab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancelarTab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnCancelarTab2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelarTab2.Location = new System.Drawing.Point(375, 396);
            this.btnCancelarTab2.Name = "btnCancelarTab2";
            this.btnCancelarTab2.Size = new System.Drawing.Size(104, 39);
            this.btnCancelarTab2.TabIndex = 75;
            this.btnCancelarTab2.Text = "Atrás";
            this.btnCancelarTab2.UseVisualStyleBackColor = true;
            this.btnCancelarTab2.Click += new System.EventHandler(this.btnCancelarTab2_Click);
            // 
            // btnSiguienteTab2
            // 
            this.btnSiguienteTab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguienteTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguienteTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSiguienteTab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnSiguienteTab2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSiguienteTab2.Location = new System.Drawing.Point(485, 396);
            this.btnSiguienteTab2.Name = "btnSiguienteTab2";
            this.btnSiguienteTab2.Size = new System.Drawing.Size(104, 39);
            this.btnSiguienteTab2.TabIndex = 74;
            this.btnSiguienteTab2.Text = "Siguiente";
            this.btnSiguienteTab2.UseVisualStyleBackColor = true;
            this.btnSiguienteTab2.Click += new System.EventHandler(this.btnSiguienteTab2_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnQuitar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnQuitar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuitar.Location = new System.Drawing.Point(629, 396);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(162, 39);
            this.btnQuitar.TabIndex = 69;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // listaPedido
            // 
            this.listaPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.listaPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listaPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPedido.ForeColor = System.Drawing.Color.White;
            this.listaPedido.FormattingEnabled = true;
            this.listaPedido.ItemHeight = 18;
            this.listaPedido.Location = new System.Drawing.Point(629, 74);
            this.listaPedido.Name = "listaPedido";
            this.listaPedido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listaPedido.Size = new System.Drawing.Size(162, 306);
            this.listaPedido.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(647, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Orden Actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(61, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "*Doble click sobre el producto que desea";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToAddRows = false;
            this.dgvArticulos.AllowUserToDeleteRows = false;
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvArticulos.ColumnHeadersHeight = 35;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvArticulos.EnableHeadersVisualStyles = false;
            this.dgvArticulos.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvArticulos.Location = new System.Drawing.Point(64, 74);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvArticulos.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvArticulos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvArticulos.RowTemplate.Height = 55;
            this.dgvArticulos.RowTemplate.ReadOnly = true;
            this.dgvArticulos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(525, 316);
            this.dgvArticulos.TabIndex = 65;
            this.dgvArticulos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArticulos_CellMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(243, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "Lista de Productos";
            // 
            // tabDetalleFactura
            // 
            this.tabDetalleFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabDetalleFactura.Controls.Add(this.label15);
            this.tabDetalleFactura.Controls.Add(this.label14);
            this.tabDetalleFactura.Controls.Add(this.label12);
            this.tabDetalleFactura.Controls.Add(this.CancelarPedido);
            this.tabDetalleFactura.Controls.Add(this.btnAceptarPedido);
            this.tabDetalleFactura.Controls.Add(this.btnValidarCupon);
            this.tabDetalleFactura.Controls.Add(this.panel3);
            this.tabDetalleFactura.Controls.Add(this.panel2);
            this.tabDetalleFactura.Controls.Add(this.label5);
            this.tabDetalleFactura.Location = new System.Drawing.Point(4, 22);
            this.tabDetalleFactura.Name = "tabDetalleFactura";
            this.tabDetalleFactura.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalleFactura.Size = new System.Drawing.Size(922, 498);
            this.tabDetalleFactura.TabIndex = 2;
            this.tabDetalleFactura.Text = "tabPage1";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(95, 363);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(239, 16);
            this.label15.TabIndex = 82;
            this.label15.Text = "** Una vez validado, no lo puede quitar";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(95, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(260, 16);
            this.label14.TabIndex = 81;
            this.label14.Text = "* Solo puede canjear un cupón por pedido";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label12.Location = new System.Drawing.Point(92, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(667, 36);
            this.label12.TabIndex = 80;
            this.label12.Text = "Información del pedido";
            // 
            // CancelarPedido
            // 
            this.CancelarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.CancelarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.CancelarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CancelarPedido.Location = new System.Drawing.Point(574, 285);
            this.CancelarPedido.Name = "CancelarPedido";
            this.CancelarPedido.Size = new System.Drawing.Size(200, 39);
            this.CancelarPedido.TabIndex = 79;
            this.CancelarPedido.Text = "Cancelar Pedido";
            this.CancelarPedido.UseVisualStyleBackColor = true;
            this.CancelarPedido.Click += new System.EventHandler(this.CancelarPedido_Click);
            // 
            // btnAceptarPedido
            // 
            this.btnAceptarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnAceptarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAceptarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAceptarPedido.Location = new System.Drawing.Point(574, 240);
            this.btnAceptarPedido.Name = "btnAceptarPedido";
            this.btnAceptarPedido.Size = new System.Drawing.Size(200, 39);
            this.btnAceptarPedido.TabIndex = 78;
            this.btnAceptarPedido.Text = "Aceptar Pedido";
            this.btnAceptarPedido.UseVisualStyleBackColor = true;
            this.btnAceptarPedido.Click += new System.EventHandler(this.btnAceptarPedido_Click);
            // 
            // btnValidarCupon
            // 
            this.btnValidarCupon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidarCupon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidarCupon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnValidarCupon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnValidarCupon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnValidarCupon.Location = new System.Drawing.Point(574, 195);
            this.btnValidarCupon.Name = "btnValidarCupon";
            this.btnValidarCupon.Size = new System.Drawing.Size(200, 39);
            this.btnValidarCupon.TabIndex = 77;
            this.btnValidarCupon.Text = "Validar Cupon";
            this.btnValidarCupon.UseVisualStyleBackColor = true;
            this.btnValidarCupon.Click += new System.EventHandler(this.btnValidarCupon_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.txtCostoTotalDolares);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtCostoTotal);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtDescuentoCupon);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtImpuesto);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtCostoExpress);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtCostoNormal);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(98, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(470, 193);
            this.panel3.TabIndex = 76;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(227, 164);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(184, 1);
            this.panel9.TabIndex = 85;
            // 
            // txtCostoTotalDolares
            // 
            this.txtCostoTotalDolares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtCostoTotalDolares.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoTotalDolares.Enabled = false;
            this.txtCostoTotalDolares.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtCostoTotalDolares.Location = new System.Drawing.Point(227, 138);
            this.txtCostoTotalDolares.Name = "txtCostoTotalDolares";
            this.txtCostoTotalDolares.Size = new System.Drawing.Size(184, 13);
            this.txtCostoTotalDolares.TabIndex = 84;
            this.txtCostoTotalDolares.Text = "$180";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label13.Location = new System.Drawing.Point(224, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 16);
            this.label13.TabIndex = 83;
            this.label13.Text = "Costo Total (Dólares)";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(227, 108);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(184, 1);
            this.panel8.TabIndex = 82;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(10, 164);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(184, 1);
            this.panel7.TabIndex = 82;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(10, 108);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(184, 1);
            this.panel6.TabIndex = 81;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(227, 55);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 1);
            this.panel5.TabIndex = 81;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(6, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(184, 1);
            this.panel4.TabIndex = 81;
            // 
            // txtCostoTotal
            // 
            this.txtCostoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtCostoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoTotal.Enabled = false;
            this.txtCostoTotal.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtCostoTotal.Location = new System.Drawing.Point(10, 138);
            this.txtCostoTotal.Name = "txtCostoTotal";
            this.txtCostoTotal.Size = new System.Drawing.Size(184, 13);
            this.txtCostoTotal.TabIndex = 69;
            this.txtCostoTotal.Text = "¢180";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label10.Location = new System.Drawing.Point(7, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 16);
            this.label10.TabIndex = 68;
            this.label10.Text = "Costo Total";
            // 
            // txtDescuentoCupon
            // 
            this.txtDescuentoCupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtDescuentoCupon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuentoCupon.Enabled = false;
            this.txtDescuentoCupon.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtDescuentoCupon.Location = new System.Drawing.Point(227, 82);
            this.txtDescuentoCupon.Name = "txtDescuentoCupon";
            this.txtDescuentoCupon.Size = new System.Drawing.Size(184, 13);
            this.txtDescuentoCupon.TabIndex = 67;
            this.txtDescuentoCupon.Text = "¢0";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label9.Location = new System.Drawing.Point(224, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "Descuento(Cupón)";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImpuesto.Enabled = false;
            this.txtImpuesto.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtImpuesto.Location = new System.Drawing.Point(227, 29);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(184, 13);
            this.txtImpuesto.TabIndex = 65;
            this.txtImpuesto.Text = "¢15";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label8.Location = new System.Drawing.Point(224, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "Impuesto";
            // 
            // txtCostoExpress
            // 
            this.txtCostoExpress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtCostoExpress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoExpress.Enabled = false;
            this.txtCostoExpress.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtCostoExpress.Location = new System.Drawing.Point(10, 82);
            this.txtCostoExpress.Name = "txtCostoExpress";
            this.txtCostoExpress.Size = new System.Drawing.Size(184, 13);
            this.txtCostoExpress.TabIndex = 63;
            this.txtCostoExpress.Text = "¢50";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(7, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 62;
            this.label7.Text = "Costo Normal";
            // 
            // txtCostoNormal
            // 
            this.txtCostoNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtCostoNormal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoNormal.Enabled = false;
            this.txtCostoNormal.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtCostoNormal.Location = new System.Drawing.Point(6, 29);
            this.txtCostoNormal.Name = "txtCostoNormal";
            this.txtCostoNormal.Size = new System.Drawing.Size(184, 13);
            this.txtCostoNormal.TabIndex = 61;
            this.txtCostoNormal.Text = "¢120";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label6.Location = new System.Drawing.Point(7, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "Costo Express";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtCupon);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(574, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 58);
            this.panel2.TabIndex = 75;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(6, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 1);
            this.panel1.TabIndex = 80;
            // 
            // txtCupon
            // 
            this.txtCupon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtCupon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCupon.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtCupon.Location = new System.Drawing.Point(6, 25);
            this.txtCupon.Name = "txtCupon";
            this.txtCupon.Size = new System.Drawing.Size(184, 13);
            this.txtCupon.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 60;
            this.label11.Text = "Canjear Cupón";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label5.Location = new System.Drawing.Point(101, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 74;
            this.label5.Text = "Detalle Orden";
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "NumeroTelefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Puntaje
            // 
            this.Puntaje.DataPropertyName = "PuntajeTotal";
            this.Puntaje.HeaderText = "Puntaje";
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.ReadOnly = true;
            // 
            // Cliente_NuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(911, 486);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente_NuevoPedido";
            this.Load += new System.EventHandler(this.Cliente_NuevoPedido_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabNegocios.ResumeLayout(false);
            this.tabNegocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNegocios)).EndInit();
            this.tabProductos.ResumeLayout(false);
            this.tabProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.tabDetalleFactura.ResumeLayout(false);
            this.tabDetalleFactura.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNegocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarPedido;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.Button btnSiguienteTab2;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.ListBox listaPedido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabDetalleFactura;
        private System.Windows.Forms.Button CancelarPedido;
        private System.Windows.Forms.Button btnAceptarPedido;
        private System.Windows.Forms.Button btnValidarCupon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCostoTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescuentoCupon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCostoExpress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCostoNormal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCupon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelarTab2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvNegocios;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtCostoTotalDolares;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
    }
}