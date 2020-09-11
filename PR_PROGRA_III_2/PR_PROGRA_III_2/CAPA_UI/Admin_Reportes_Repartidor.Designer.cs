namespace CAPA_UI
{
    partial class Admin_Reportes_Repartidor
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
            this.PA_ReporteEntregasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSEntregas = new CAPA_UI.DSEntregas();
            this.PA_ReporteComentariosNegativosRepartidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSCalificacionRepartidor = new CAPA_UI.DSCalificacionRepartidor();
            this.tabReportesRepartidor = new System.Windows.Forms.TabControl();
            this.tabRepartidores = new System.Windows.Forms.TabPage();
            this.dvgNegocios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMenuReportes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtrasTab1 = new System.Windows.Forms.Button();
            this.btnReporteCupones = new System.Windows.Forms.Button();
            this.btnReportePedidos = new System.Windows.Forms.Button();
            this.tabEntregas = new System.Windows.Forms.TabPage();
            this.rpvEntregas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEstadosPedido = new System.Windows.Forms.Button();
            this.cbNegocios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabComentarios = new System.Windows.Forms.TabPage();
            this.rpvComent = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbNegocios2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtras2 = new System.Windows.Forms.Button();
            this.PA_ReporteEntregasTableAdapter = new CAPA_UI.DSEntregasTableAdapters.PA_ReporteEntregasTableAdapter();
            this.PA_ReporteComentariosNegativosRepartidorTableAdapter = new CAPA_UI.DSCalificacionRepartidorTableAdapters.PA_ReporteComentariosNegativosRepartidorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteEntregasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteComentariosNegativosRepartidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCalificacionRepartidor)).BeginInit();
            this.tabReportesRepartidor.SuspendLayout();
            this.tabRepartidores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNegocios)).BeginInit();
            this.tabMenuReportes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabEntregas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabComentarios.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PA_ReporteEntregasBindingSource
            // 
            this.PA_ReporteEntregasBindingSource.DataMember = "PA_ReporteEntregas";
            this.PA_ReporteEntregasBindingSource.DataSource = this.DSEntregas;
            // 
            // DSEntregas
            // 
            this.DSEntregas.DataSetName = "DSEntregas";
            this.DSEntregas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteComentariosNegativosRepartidorBindingSource
            // 
            this.PA_ReporteComentariosNegativosRepartidorBindingSource.DataMember = "PA_ReporteComentariosNegativosRepartidor";
            this.PA_ReporteComentariosNegativosRepartidorBindingSource.DataSource = this.DSCalificacionRepartidor;
            // 
            // DSCalificacionRepartidor
            // 
            this.DSCalificacionRepartidor.DataSetName = "DSCalificacionRepartidor";
            this.DSCalificacionRepartidor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabReportesRepartidor
            // 
            this.tabReportesRepartidor.Controls.Add(this.tabRepartidores);
            this.tabReportesRepartidor.Controls.Add(this.tabMenuReportes);
            this.tabReportesRepartidor.Controls.Add(this.tabEntregas);
            this.tabReportesRepartidor.Controls.Add(this.tabComentarios);
            this.tabReportesRepartidor.Location = new System.Drawing.Point(-24, -32);
            this.tabReportesRepartidor.Name = "tabReportesRepartidor";
            this.tabReportesRepartidor.SelectedIndex = 0;
            this.tabReportesRepartidor.Size = new System.Drawing.Size(1051, 566);
            this.tabReportesRepartidor.TabIndex = 0;
            // 
            // tabRepartidores
            // 
            this.tabRepartidores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabRepartidores.Controls.Add(this.dvgNegocios);
            this.tabRepartidores.Controls.Add(this.btnSiguiente);
            this.tabRepartidores.Controls.Add(this.label3);
            this.tabRepartidores.Location = new System.Drawing.Point(4, 22);
            this.tabRepartidores.Name = "tabRepartidores";
            this.tabRepartidores.Padding = new System.Windows.Forms.Padding(3);
            this.tabRepartidores.Size = new System.Drawing.Size(1043, 540);
            this.tabRepartidores.TabIndex = 0;
            this.tabRepartidores.Text = "tabPage1";
            // 
            // dvgNegocios
            // 
            this.dvgNegocios.AllowUserToAddRows = false;
            this.dvgNegocios.AllowUserToDeleteRows = false;
            this.dvgNegocios.AllowUserToResizeColumns = false;
            this.dvgNegocios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgNegocios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            this.dvgNegocios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dvgNegocios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dvgNegocios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNegocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgNegocios.ColumnHeadersHeight = 35;
            this.dvgNegocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cedula,
            this.Nombre,
            this.Apellidos,
            this.Numero,
            this.Correo,
            this.Puntaje});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNegocios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dvgNegocios.EnableHeadersVisualStyles = false;
            this.dvgNegocios.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dvgNegocios.Location = new System.Drawing.Point(117, 85);
            this.dvgNegocios.MultiSelect = false;
            this.dvgNegocios.Name = "dvgNegocios";
            this.dvgNegocios.ReadOnly = true;
            this.dvgNegocios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNegocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgNegocios.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgNegocios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dvgNegocios.RowTemplate.Height = 40;
            this.dvgNegocios.RowTemplate.ReadOnly = true;
            this.dvgNegocios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNegocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgNegocios.Size = new System.Drawing.Size(743, 285);
            this.dvgNegocios.TabIndex = 73;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 45;
            // 
            // Cedula
            // 
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 77;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.Apellidos.Width = 90;
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "NumeroTelefono";
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.Width = 85;
            // 
            // Correo
            // 
            this.Correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.Puntaje.Width = 80;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnSiguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnSiguiente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSiguiente.Location = new System.Drawing.Point(688, 376);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(172, 39);
            this.btnSiguiente.TabIndex = 72;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(362, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Seleccione el repartidor";
            // 
            // tabMenuReportes
            // 
            this.tabMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabMenuReportes.Controls.Add(this.panel1);
            this.tabMenuReportes.Location = new System.Drawing.Point(4, 22);
            this.tabMenuReportes.Name = "tabMenuReportes";
            this.tabMenuReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuReportes.Size = new System.Drawing.Size(1043, 540);
            this.tabMenuReportes.TabIndex = 1;
            this.tabMenuReportes.Text = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAtrasTab1);
            this.panel1.Controls.Add(this.btnReporteCupones);
            this.panel1.Controls.Add(this.btnReportePedidos);
            this.panel1.Location = new System.Drawing.Point(79, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 406);
            this.panel1.TabIndex = 2;
            // 
            // btnAtrasTab1
            // 
            this.btnAtrasTab1.FlatAppearance.BorderSize = 2;
            this.btnAtrasTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasTab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab1.Image = global::CAPA_UI.Properties.Resources.regreso;
            this.btnAtrasTab1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasTab1.Location = new System.Drawing.Point(258, 236);
            this.btnAtrasTab1.Name = "btnAtrasTab1";
            this.btnAtrasTab1.Size = new System.Drawing.Size(290, 134);
            this.btnAtrasTab1.TabIndex = 5;
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
            this.btnReporteCupones.Image = global::CAPA_UI.Properties.Resources.orden;
            this.btnReporteCupones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteCupones.Location = new System.Drawing.Point(467, 78);
            this.btnReporteCupones.Name = "btnReporteCupones";
            this.btnReporteCupones.Size = new System.Drawing.Size(290, 134);
            this.btnReporteCupones.TabIndex = 3;
            this.btnReporteCupones.Text = "Reporte de Calificaciones";
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
            this.btnReportePedidos.Location = new System.Drawing.Point(51, 78);
            this.btnReportePedidos.Name = "btnReportePedidos";
            this.btnReportePedidos.Size = new System.Drawing.Size(316, 134);
            this.btnReportePedidos.TabIndex = 2;
            this.btnReportePedidos.Text = "Reporte de Entregas";
            this.btnReportePedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePedidos.UseVisualStyleBackColor = true;
            this.btnReportePedidos.Click += new System.EventHandler(this.btnReportePedidos_Click);
            // 
            // tabEntregas
            // 
            this.tabEntregas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabEntregas.Controls.Add(this.rpvEntregas);
            this.tabEntregas.Controls.Add(this.panel2);
            this.tabEntregas.Location = new System.Drawing.Point(4, 22);
            this.tabEntregas.Name = "tabEntregas";
            this.tabEntregas.Padding = new System.Windows.Forms.Padding(3);
            this.tabEntregas.Size = new System.Drawing.Size(1043, 540);
            this.tabEntregas.TabIndex = 2;
            this.tabEntregas.Text = "tabPage3";
            // 
            // rpvEntregas
            // 
            this.rpvEntregas.BackColor = System.Drawing.Color.Gray;
            this.rpvEntregas.DocumentMapWidth = 69;
            reportDataSource1.Name = "DSEntregasRepartidor";
            reportDataSource1.Value = this.PA_ReporteEntregasBindingSource;
            this.rpvEntregas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvEntregas.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeEntregas.rdlc";
            this.rpvEntregas.Location = new System.Drawing.Point(60, 116);
            this.rpvEntregas.Name = "rpvEntregas";
            this.rpvEntregas.ServerReport.BearerToken = null;
            this.rpvEntregas.Size = new System.Drawing.Size(871, 323);
            this.rpvEntregas.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEstadosPedido);
            this.panel2.Controls.Add(this.cbNegocios);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(52, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 88);
            this.panel2.TabIndex = 12;
            // 
            // btnEstadosPedido
            // 
            this.btnEstadosPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnEstadosPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstadosPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadosPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEstadosPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnEstadosPedido.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEstadosPedido.Location = new System.Drawing.Point(528, 28);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(706, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "Atrás";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAtrasTab2_Click);
            // 
            // tabComentarios
            // 
            this.tabComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabComentarios.Controls.Add(this.rpvComent);
            this.tabComentarios.Controls.Add(this.panel3);
            this.tabComentarios.Location = new System.Drawing.Point(4, 22);
            this.tabComentarios.Name = "tabComentarios";
            this.tabComentarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabComentarios.Size = new System.Drawing.Size(1043, 540);
            this.tabComentarios.TabIndex = 3;
            this.tabComentarios.Text = "tabPage4";
            // 
            // rpvComent
            // 
            this.rpvComent.BackColor = System.Drawing.Color.Gray;
            reportDataSource2.Name = "DSCalificacionesRep";
            reportDataSource2.Value = this.PA_ReporteComentariosNegativosRepartidorBindingSource;
            this.rpvComent.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvComent.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeComentariosRepartidor.rdlc";
            this.rpvComent.Location = new System.Drawing.Point(75, 116);
            this.rpvComent.Name = "rpvComent";
            this.rpvComent.ServerReport.BearerToken = null;
            this.rpvComent.Size = new System.Drawing.Size(871, 323);
            this.rpvComent.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbNegocios2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btnAtras2);
            this.panel3.Location = new System.Drawing.Point(67, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 88);
            this.panel3.TabIndex = 13;
            // 
            // cbNegocios2
            // 
            this.cbNegocios2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.cbNegocios2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNegocios2.ForeColor = System.Drawing.SystemColors.Window;
            this.cbNegocios2.FormattingEnabled = true;
            this.cbNegocios2.Location = new System.Drawing.Point(7, 41);
            this.cbNegocios2.Name = "cbNegocios2";
            this.cbNegocios2.Size = new System.Drawing.Size(178, 26);
            this.cbNegocios2.TabIndex = 13;
            this.cbNegocios2.SelectedIndexChanged += new System.EventHandler(this.cbNegocios2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtrar por negocio";
            // 
            // btnAtras2
            // 
            this.btnAtras2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.btnAtras2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtras2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtras2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtras2.Location = new System.Drawing.Point(706, 28);
            this.btnAtras2.Name = "btnAtras2";
            this.btnAtras2.Size = new System.Drawing.Size(172, 39);
            this.btnAtras2.TabIndex = 9;
            this.btnAtras2.Text = "Atrás";
            this.btnAtras2.UseVisualStyleBackColor = false;
            this.btnAtras2.Click += new System.EventHandler(this.btnAtras2_Click);
            // 
            // PA_ReporteEntregasTableAdapter
            // 
            this.PA_ReporteEntregasTableAdapter.ClearBeforeFill = true;
            // 
            // PA_ReporteComentariosNegativosRepartidorTableAdapter
            // 
            this.PA_ReporteComentariosNegativosRepartidorTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Reportes_Repartidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(942, 441);
            this.Controls.Add(this.tabReportesRepartidor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Reportes_Repartidor";
            this.Text = "Admin_Reportes_Repartidor";
            this.Load += new System.EventHandler(this.Admin_Reportes_Repartidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteEntregasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteComentariosNegativosRepartidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCalificacionRepartidor)).EndInit();
            this.tabReportesRepartidor.ResumeLayout(false);
            this.tabRepartidores.ResumeLayout(false);
            this.tabRepartidores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNegocios)).EndInit();
            this.tabMenuReportes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabEntregas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabComentarios.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReportesRepartidor;
        private System.Windows.Forms.TabPage tabRepartidores;
        private System.Windows.Forms.TabPage tabMenuReportes;
        private System.Windows.Forms.TabPage tabEntregas;
        private System.Windows.Forms.TabPage tabComentarios;
        private System.Windows.Forms.DataGridView dvgNegocios;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteCupones;
        private System.Windows.Forms.Button btnReportePedidos;
        private System.Windows.Forms.Button btnAtrasTab1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEstadosPedido;
        private System.Windows.Forms.ComboBox cbNegocios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer rpvEntregas;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbNegocios2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAtras2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvComent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.BindingSource PA_ReporteEntregasBindingSource;
        private DSEntregas DSEntregas;
        private DSEntregasTableAdapters.PA_ReporteEntregasTableAdapter PA_ReporteEntregasTableAdapter;
        private System.Windows.Forms.BindingSource PA_ReporteComentariosNegativosRepartidorBindingSource;
        private DSCalificacionRepartidor DSCalificacionRepartidor;
        private DSCalificacionRepartidorTableAdapters.PA_ReporteComentariosNegativosRepartidorTableAdapter PA_ReporteComentariosNegativosRepartidorTableAdapter;
    }
}