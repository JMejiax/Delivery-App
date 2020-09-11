namespace CAPA_UI
{
    partial class Repartidor_AceptarEntregas
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
            this.tabEntregas = new System.Windows.Forms.TabControl();
            this.tabListaPedidos = new System.Windows.Forms.TabPage();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEntregarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tabRuta = new System.Windows.Forms.TabPage();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.pnlMapa = new System.Windows.Forms.Panel();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.label7 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtDireccion = new System.Windows.Forms.RichTextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtPagoPorExpress = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tabEntregas.SuspendLayout();
            this.tabListaPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            this.tabRuta.SuspendLayout();
            this.pnlMapa.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabEntregas
            // 
            this.tabEntregas.Controls.Add(this.tabListaPedidos);
            this.tabEntregas.Controls.Add(this.tabRuta);
            this.tabEntregas.Location = new System.Drawing.Point(-16, -32);
            this.tabEntregas.Name = "tabEntregas";
            this.tabEntregas.SelectedIndex = 0;
            this.tabEntregas.Size = new System.Drawing.Size(974, 577);
            this.tabEntregas.TabIndex = 0;
            // 
            // tabListaPedidos
            // 
            this.tabListaPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabListaPedidos.Controls.Add(this.dgvPedidos);
            this.tabListaPedidos.Controls.Add(this.btnEntregarPedido);
            this.tabListaPedidos.Controls.Add(this.label1);
            this.tabListaPedidos.Controls.Add(this.btnCancelar);
            this.tabListaPedidos.Controls.Add(this.label20);
            this.tabListaPedidos.Location = new System.Drawing.Point(4, 22);
            this.tabListaPedidos.Name = "tabListaPedidos";
            this.tabListaPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabListaPedidos.Size = new System.Drawing.Size(966, 551);
            this.tabListaPedidos.TabIndex = 0;
            this.tabListaPedidos.Text = "tabPage1";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPedidos.ColumnHeadersHeight = 35;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Telefono,
            this.IDFactura,
            this.Fecha});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPedidos.EnableHeadersVisualStyles = false;
            this.dgvPedidos.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvPedidos.Location = new System.Drawing.Point(111, 80);
            this.dgvPedidos.MultiSelect = false;
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPedidos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvPedidos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPedidos.RowTemplate.Height = 30;
            this.dgvPedidos.RowTemplate.ReadOnly = true;
            this.dgvPedidos.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedidos.Size = new System.Drawing.Size(698, 291);
            this.dgvPedidos.TabIndex = 88;
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
            // btnEntregarPedido
            // 
            this.btnEntregarPedido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEntregarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntregarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnEntregarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnEntregarPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEntregarPedido.Location = new System.Drawing.Point(556, 377);
            this.btnEntregarPedido.Name = "btnEntregarPedido";
            this.btnEntregarPedido.Size = new System.Drawing.Size(150, 39);
            this.btnEntregarPedido.TabIndex = 87;
            this.btnEntregarPedido.Text = "Entregar Pedido";
            this.btnEntregarPedido.UseVisualStyleBackColor = true;
            this.btnEntregarPedido.Click += new System.EventHandler(this.btnEntregarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(99, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "* Seleccione el pedido que desea entregar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancelar.Location = new System.Drawing.Point(712, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 39);
            this.btnCancelar.TabIndex = 85;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label20.Location = new System.Drawing.Point(374, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 24);
            this.label20.TabIndex = 83;
            this.label20.Text = "Lista de Ordenes";
            // 
            // tabRuta
            // 
            this.tabRuta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabRuta.Controls.Add(this.lblTelefonoCliente);
            this.tabRuta.Controls.Add(this.label25);
            this.tabRuta.Controls.Add(this.btnFinalizar);
            this.tabRuta.Controls.Add(this.label24);
            this.tabRuta.Controls.Add(this.pnlMapa);
            this.tabRuta.Controls.Add(this.label7);
            this.tabRuta.Controls.Add(this.panel13);
            this.tabRuta.Location = new System.Drawing.Point(4, 22);
            this.tabRuta.Name = "tabRuta";
            this.tabRuta.Padding = new System.Windows.Forms.Padding(3);
            this.tabRuta.Size = new System.Drawing.Size(966, 551);
            this.tabRuta.TabIndex = 1;
            this.tabRuta.Text = "tabPage2";
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoCliente.ForeColor = System.Drawing.Color.White;
            this.lblTelefonoCliente.Location = new System.Drawing.Point(347, 384);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(57, 16);
            this.lblTelefonoCliente.TabIndex = 25;
            this.lblTelefonoCliente.Text = "8888888";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(102, 384);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(248, 16);
            this.label25.TabIndex = 24;
            this.label25.Text = "*Cualquier duda puede llamar al cliente: ";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnFinalizar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnFinalizar.Location = new System.Drawing.Point(566, 373);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(210, 39);
            this.btnFinalizar.TabIndex = 22;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label24.Location = new System.Drawing.Point(101, 37);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(169, 24);
            this.label24.TabIndex = 21;
            this.label24.Text = "Ruta del Express";
            // 
            // pnlMapa
            // 
            this.pnlMapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMapa.Controls.Add(this.map);
            this.pnlMapa.Location = new System.Drawing.Point(105, 74);
            this.pnlMapa.Name = "pnlMapa";
            this.pnlMapa.Size = new System.Drawing.Size(455, 293);
            this.pnlMapa.TabIndex = 20;
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(3, 3);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(447, 285);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label7.Location = new System.Drawing.Point(562, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Información";
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel13.Controls.Add(this.txtDireccion);
            this.panel13.Controls.Add(this.label26);
            this.panel13.Controls.Add(this.panel17);
            this.panel13.Controls.Add(this.panel18);
            this.panel13.Controls.Add(this.txtPagoPorExpress);
            this.panel13.Controls.Add(this.txtNombreCliente);
            this.panel13.Controls.Add(this.label22);
            this.panel13.Controls.Add(this.label23);
            this.panel13.Location = new System.Drawing.Point(566, 74);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(210, 293);
            this.panel13.TabIndex = 18;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(16, 202);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(175, 73);
            this.txtDireccion.TabIndex = 21;
            this.txtDireccion.Text = "";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label26.Location = new System.Drawing.Point(13, 171);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 16);
            this.label26.TabIndex = 20;
            this.label26.Text = "Dirección exacta";
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.White;
            this.panel17.Location = new System.Drawing.Point(16, 155);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(175, 1);
            this.panel17.TabIndex = 19;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Location = new System.Drawing.Point(16, 91);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(175, 1);
            this.panel18.TabIndex = 18;
            // 
            // txtPagoPorExpress
            // 
            this.txtPagoPorExpress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtPagoPorExpress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagoPorExpress.Enabled = false;
            this.txtPagoPorExpress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagoPorExpress.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPagoPorExpress.Location = new System.Drawing.Point(16, 129);
            this.txtPagoPorExpress.Name = "txtPagoPorExpress";
            this.txtPagoPorExpress.Size = new System.Drawing.Size(175, 15);
            this.txtPagoPorExpress.TabIndex = 17;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombreCliente.Location = new System.Drawing.Point(16, 65);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(175, 15);
            this.txtNombreCliente.TabIndex = 15;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label22.Location = new System.Drawing.Point(13, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 16);
            this.label22.TabIndex = 16;
            this.label22.Text = "Pago por entrega";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label23.Location = new System.Drawing.Point(13, 40);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 16);
            this.label23.TabIndex = 14;
            this.label23.Text = "Nombre del cliente";
            // 
            // Repartidor_AceptarEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(895, 459);
            this.Controls.Add(this.tabEntregas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Repartidor_AceptarEntregas";
            this.Text = "Repartidor_AceptarPedido";
            this.Load += new System.EventHandler(this.Repartidor_AceptarEntregas_Load);
            this.tabEntregas.ResumeLayout(false);
            this.tabListaPedidos.ResumeLayout(false);
            this.tabListaPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            this.tabRuta.ResumeLayout(false);
            this.tabRuta.PerformLayout();
            this.pnlMapa.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabEntregas;
        private System.Windows.Forms.TabPage tabListaPedidos;
        private System.Windows.Forms.TabPage tabRuta;
        private System.Windows.Forms.Button btnEntregarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel pnlMapa;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.RichTextBox txtDireccion;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtPagoPorExpress;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}