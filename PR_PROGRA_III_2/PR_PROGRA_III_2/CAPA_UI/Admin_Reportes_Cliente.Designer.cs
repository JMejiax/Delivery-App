namespace CAPA_UI
{
    partial class Admin_Reportes_Cliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PA_ReportePedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSPedidos = new CAPA_UI.DSPedidos();
            this.PA_ReporteCuponesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSCuponesUsado = new CAPA_UI.DSCuponesUsado();
            this.tabReporteCliente = new System.Windows.Forms.TabControl();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.dvgClientes = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMenuReportes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtrasTab1 = new System.Windows.Forms.Button();
            this.btnReporteCupones = new System.Windows.Forms.Button();
            this.btnReportePedidos = new System.Windows.Forms.Button();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.rvPedidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEstadosPedido = new System.Windows.Forms.Button();
            this.cbNegocios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtrasTab3 = new System.Windows.Forms.Button();
            this.tabCupones = new System.Windows.Forms.TabPage();
            this.btnAtrasTab2 = new System.Windows.Forms.Button();
            this.rvCupones = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_ReportePedidosTableAdapter = new CAPA_UI.DSPedidosTableAdapters.PA_ReportePedidosTableAdapter();
            this.PA_ReporteCuponesTableAdapter = new CAPA_UI.DSCuponesUsadoTableAdapters.PA_ReporteCuponesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReportePedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCuponesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCuponesUsado)).BeginInit();
            this.tabReporteCliente.SuspendLayout();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).BeginInit();
            this.tabMenuReportes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabCupones.SuspendLayout();
            this.SuspendLayout();
            // 
            // PA_ReportePedidosBindingSource
            // 
            this.PA_ReportePedidosBindingSource.DataMember = "PA_ReportePedidos";
            this.PA_ReportePedidosBindingSource.DataSource = this.DSPedidos;
            // 
            // DSPedidos
            // 
            this.DSPedidos.DataSetName = "DSPedidos";
            this.DSPedidos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteCuponesBindingSource
            // 
            this.PA_ReporteCuponesBindingSource.DataMember = "PA_ReporteCupones";
            this.PA_ReporteCuponesBindingSource.DataSource = this.DSCuponesUsado;
            // 
            // DSCuponesUsado
            // 
            this.DSCuponesUsado.DataSetName = "DSCuponesUsado";
            this.DSCuponesUsado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabReporteCliente
            // 
            this.tabReporteCliente.Controls.Add(this.tabClientes);
            this.tabReporteCliente.Controls.Add(this.tabMenuReportes);
            this.tabReporteCliente.Controls.Add(this.tabPedidos);
            this.tabReporteCliente.Controls.Add(this.tabCupones);
            this.tabReporteCliente.Location = new System.Drawing.Point(-24, -28);
            this.tabReporteCliente.Name = "tabReporteCliente";
            this.tabReporteCliente.SelectedIndex = 0;
            this.tabReporteCliente.Size = new System.Drawing.Size(1045, 589);
            this.tabReporteCliente.TabIndex = 0;
            // 
            // tabClientes
            // 
            this.tabClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabClientes.Controls.Add(this.dvgClientes);
            this.tabClientes.Controls.Add(this.btnSiguiente);
            this.tabClientes.Controls.Add(this.label3);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(1037, 563);
            this.tabClientes.TabIndex = 0;
            this.tabClientes.Text = "tabPage1";
            // 
            // dvgClientes
            // 
            this.dvgClientes.AllowUserToAddRows = false;
            this.dvgClientes.AllowUserToDeleteRows = false;
            this.dvgClientes.AllowUserToResizeColumns = false;
            this.dvgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.dvgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgClientes.ColumnHeadersHeight = 35;
            this.dvgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellidos,
            this.Cedula,
            this.Numero,
            this.Correo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgClientes.EnableHeadersVisualStyles = false;
            this.dvgClientes.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dvgClientes.Location = new System.Drawing.Point(89, 79);
            this.dvgClientes.MultiSelect = false;
            this.dvgClientes.Name = "dvgClientes";
            this.dvgClientes.ReadOnly = true;
            this.dvgClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgClientes.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgClientes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgClientes.RowTemplate.Height = 30;
            this.dvgClientes.RowTemplate.ReadOnly = true;
            this.dvgClientes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgClientes.Size = new System.Drawing.Size(743, 285);
            this.dvgClientes.TabIndex = 67;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "NumeroTelefono";
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnSiguiente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSiguiente.Location = new System.Drawing.Point(660, 370);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(172, 39);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(334, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Seleccione el cliente";
            // 
            // tabMenuReportes
            // 
            this.tabMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabMenuReportes.Controls.Add(this.panel1);
            this.tabMenuReportes.Location = new System.Drawing.Point(4, 22);
            this.tabMenuReportes.Name = "tabMenuReportes";
            this.tabMenuReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuReportes.Size = new System.Drawing.Size(1037, 563);
            this.tabMenuReportes.TabIndex = 1;
            this.tabMenuReportes.Text = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAtrasTab1);
            this.panel1.Controls.Add(this.btnReporteCupones);
            this.panel1.Controls.Add(this.btnReportePedidos);
            this.panel1.Location = new System.Drawing.Point(53, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 406);
            this.panel1.TabIndex = 1;
            // 
            // btnAtrasTab1
            // 
            this.btnAtrasTab1.FlatAppearance.BorderSize = 2;
            this.btnAtrasTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasTab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab1.Image = global::CAPA_UI.Properties.Resources.regreso;
            this.btnAtrasTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasTab1.Location = new System.Drawing.Point(268, 218);
            this.btnAtrasTab1.Name = "btnAtrasTab1";
            this.btnAtrasTab1.Size = new System.Drawing.Size(290, 134);
            this.btnAtrasTab1.TabIndex = 4;
            this.btnAtrasTab1.Text = "       Regresar";
            this.btnAtrasTab1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtrasTab1.UseVisualStyleBackColor = true;
            this.btnAtrasTab1.Click += new System.EventHandler(this.btnAtrasTab1_Click);
            // 
            // btnReporteCupones
            // 
            this.btnReporteCupones.FlatAppearance.BorderSize = 2;
            this.btnReporteCupones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCupones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnReporteCupones.Image = global::CAPA_UI.Properties.Resources.cupon;
            this.btnReporteCupones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteCupones.Location = new System.Drawing.Point(469, 53);
            this.btnReporteCupones.Name = "btnReporteCupones";
            this.btnReporteCupones.Size = new System.Drawing.Size(290, 134);
            this.btnReporteCupones.TabIndex = 3;
            this.btnReporteCupones.Text = "Reporte de Cupones";
            this.btnReporteCupones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteCupones.UseVisualStyleBackColor = true;
            this.btnReporteCupones.Click += new System.EventHandler(this.btnReporteCupones_Click);
            // 
            // btnReportePedidos
            // 
            this.btnReportePedidos.FlatAppearance.BorderSize = 2;
            this.btnReportePedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnReportePedidos.Image = global::CAPA_UI.Properties.Resources.orden;
            this.btnReportePedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportePedidos.Location = new System.Drawing.Point(48, 53);
            this.btnReportePedidos.Name = "btnReportePedidos";
            this.btnReportePedidos.Size = new System.Drawing.Size(316, 134);
            this.btnReportePedidos.TabIndex = 2;
            this.btnReportePedidos.Text = "Reporte de Pedidos";
            this.btnReportePedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePedidos.UseVisualStyleBackColor = true;
            this.btnReportePedidos.Click += new System.EventHandler(this.btnReportePedidos_Click);
            // 
            // tabPedidos
            // 
            this.tabPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabPedidos.Controls.Add(this.rvPedidos);
            this.tabPedidos.Controls.Add(this.panel2);
            this.tabPedidos.Location = new System.Drawing.Point(4, 22);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(1037, 563);
            this.tabPedidos.TabIndex = 2;
            this.tabPedidos.Text = "tabPage3";
            // 
            // rvPedidos
            // 
            this.rvPedidos.BackColor = System.Drawing.Color.Gray;
            reportDataSource1.Name = "DataSetPedidos";
            reportDataSource1.Value = this.PA_ReportePedidosBindingSource;
            this.rvPedidos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPedidos.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformePedidos.rdlc";
            this.rvPedidos.Location = new System.Drawing.Point(69, 112);
            this.rvPedidos.Name = "rvPedidos";
            this.rvPedidos.ServerReport.BearerToken = null;
            this.rvPedidos.Size = new System.Drawing.Size(863, 319);
            this.rvPedidos.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEstadosPedido);
            this.panel2.Controls.Add(this.cbNegocios);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnAtrasTab3);
            this.panel2.Location = new System.Drawing.Point(61, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 88);
            this.panel2.TabIndex = 11;
            // 
            // btnEstadosPedido
            // 
            this.btnEstadosPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnEstadosPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadosPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadosPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEstadosPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnEstadosPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEstadosPedido.Location = new System.Drawing.Point(502, 28);
            this.btnEstadosPedido.Name = "btnEstadosPedido";
            this.btnEstadosPedido.Size = new System.Drawing.Size(172, 39);
            this.btnEstadosPedido.TabIndex = 14;
            this.btnEstadosPedido.Text = "Info. Estados Pedido";
            this.btnEstadosPedido.UseVisualStyleBackColor = false;
            this.btnEstadosPedido.Click += new System.EventHandler(this.btnEstadosPedido_Click);
            // 
            // cbNegocios
            // 
            this.cbNegocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.cbNegocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNegocios.ForeColor = System.Drawing.SystemColors.Window;
            this.cbNegocios.FormattingEnabled = true;
            this.cbNegocios.Location = new System.Drawing.Point(7, 41);
            this.cbNegocios.Name = "cbNegocios";
            this.cbNegocios.Size = new System.Drawing.Size(178, 26);
            this.cbNegocios.TabIndex = 13;
            this.cbNegocios.SelectedIndexChanged += new System.EventHandler(this.cbNegocios_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Filtrar por negocio";
            // 
            // btnAtrasTab3
            // 
            this.btnAtrasTab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.btnAtrasTab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab3.Location = new System.Drawing.Point(680, 28);
            this.btnAtrasTab3.Name = "btnAtrasTab3";
            this.btnAtrasTab3.Size = new System.Drawing.Size(172, 39);
            this.btnAtrasTab3.TabIndex = 9;
            this.btnAtrasTab3.Text = "Atrás";
            this.btnAtrasTab3.UseVisualStyleBackColor = false;
            this.btnAtrasTab3.Click += new System.EventHandler(this.btnAtrasTab3_Click);
            // 
            // tabCupones
            // 
            this.tabCupones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabCupones.Controls.Add(this.btnAtrasTab2);
            this.tabCupones.Controls.Add(this.rvCupones);
            this.tabCupones.Location = new System.Drawing.Point(4, 22);
            this.tabCupones.Name = "tabCupones";
            this.tabCupones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCupones.Size = new System.Drawing.Size(1037, 563);
            this.tabCupones.TabIndex = 3;
            this.tabCupones.Text = "tabPage4";
            // 
            // btnAtrasTab2
            // 
            this.btnAtrasTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnAtrasTab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab2.Location = new System.Drawing.Point(757, 388);
            this.btnAtrasTab2.Name = "btnAtrasTab2";
            this.btnAtrasTab2.Size = new System.Drawing.Size(172, 39);
            this.btnAtrasTab2.TabIndex = 9;
            this.btnAtrasTab2.Text = "Atrás";
            this.btnAtrasTab2.UseVisualStyleBackColor = false;
            this.btnAtrasTab2.Click += new System.EventHandler(this.btnAtrasTab2_Click);
            // 
            // rvCupones
            // 
            this.rvCupones.BackColor = System.Drawing.Color.Gray;
            reportDataSource2.Name = "DSCupones";
            reportDataSource2.Value = this.PA_ReporteCuponesBindingSource;
            this.rvCupones.LocalReport.DataSources.Add(reportDataSource2);
            this.rvCupones.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeCupones.rdlc";
            this.rvCupones.Location = new System.Drawing.Point(58, 18);
            this.rvCupones.Name = "rvCupones";
            this.rvCupones.ServerReport.BearerToken = null;
            this.rvCupones.Size = new System.Drawing.Size(871, 364);
            this.rvCupones.TabIndex = 0;
            // 
            // PA_ReportePedidosTableAdapter
            // 
            this.PA_ReportePedidosTableAdapter.ClearBeforeFill = true;
            // 
            // PA_ReporteCuponesTableAdapter
            // 
            this.PA_ReporteCuponesTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Reportes_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(958, 447);
            this.Controls.Add(this.tabReporteCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Reportes_Cliente";
            this.Text = "Admin_Reportes_Cliente";
            this.Load += new System.EventHandler(this.Admin_Reportes_Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReportePedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCuponesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCuponesUsado)).EndInit();
            this.tabReporteCliente.ResumeLayout(false);
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).EndInit();
            this.tabMenuReportes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabCupones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReporteCliente;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabMenuReportes;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TabPage tabCupones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteCupones;
        private System.Windows.Forms.Button btnReportePedidos;
        private Microsoft.Reporting.WinForms.ReportViewer rvPedidos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEstadosPedido;
        private System.Windows.Forms.ComboBox cbNegocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtrasTab3;
        private Microsoft.Reporting.WinForms.ReportViewer rvCupones;
        private System.Windows.Forms.Button btnAtrasTab2;
        private System.Windows.Forms.DataGridView dvgClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.BindingSource PA_ReportePedidosBindingSource;
        private DSPedidos DSPedidos;
        private DSPedidosTableAdapters.PA_ReportePedidosTableAdapter PA_ReportePedidosTableAdapter;
        private System.Windows.Forms.Button btnAtrasTab1;
        private System.Windows.Forms.BindingSource PA_ReporteCuponesBindingSource;
        private DSCuponesUsado DSCuponesUsado;
        private DSCuponesUsadoTableAdapters.PA_ReporteCuponesTableAdapter PA_ReporteCuponesTableAdapter;
    }
}