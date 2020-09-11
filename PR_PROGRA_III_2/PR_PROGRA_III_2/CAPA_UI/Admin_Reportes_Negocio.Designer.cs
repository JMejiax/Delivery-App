namespace CAPA_UI
{
    partial class Admin_Reportes_Negocio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PA_ReporteRecaudacionPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSRecaudacion = new CAPA_UI.DSRecaudacion();
            this.PA_ReporteCmentariosMalosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSComentariosMalos = new CAPA_UI.DSComentariosMalos();
            this.PA_ReporteCuponesAplicadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSCuponesAplicados = new CAPA_UI.DSCuponesAplicados();
            this.tabReporteNegocio = new System.Windows.Forms.TabControl();
            this.tabNegocios = new System.Windows.Forms.TabPage();
            this.dvgNegocios = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabMenuReportes = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtrasTab1 = new System.Windows.Forms.Button();
            this.btnReporteComentarios = new System.Windows.Forms.Button();
            this.btnReporteCupones = new System.Windows.Forms.Button();
            this.btnReporteRecaudacion = new System.Windows.Forms.Button();
            this.tabCupones = new System.Windows.Forms.TabPage();
            this.btnAtrasTab3 = new System.Windows.Forms.Button();
            this.rpvCuponesAplicados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabRecaudacion = new System.Windows.Forms.TabPage();
            this.rpvRecaudacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAtrasTab2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFrase2 = new System.Windows.Forms.Label();
            this.tabComentarios = new System.Windows.Forms.TabPage();
            this.btnAtrasTab4 = new System.Windows.Forms.Button();
            this.rpvComentarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_ReporteRecaudacionPorFechaTableAdapter = new CAPA_UI.DSRecaudacionTableAdapters.PA_ReporteRecaudacionPorFechaTableAdapter();
            this.PA_ReporteCmentariosMalosTableAdapter = new CAPA_UI.DSComentariosMalosTableAdapters.PA_ReporteCmentariosMalosTableAdapter();
            this.PA_ReporteCuponesAplicadosTableAdapter = new CAPA_UI.DSCuponesAplicadosTableAdapters.PA_ReporteCuponesAplicadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteRecaudacionPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSRecaudacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCmentariosMalosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSComentariosMalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCuponesAplicadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCuponesAplicados)).BeginInit();
            this.tabReporteNegocio.SuspendLayout();
            this.tabNegocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNegocios)).BeginInit();
            this.tabMenuReportes.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabCupones.SuspendLayout();
            this.tabRecaudacion.SuspendLayout();
            this.tabComentarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // PA_ReporteRecaudacionPorFechaBindingSource
            // 
            this.PA_ReporteRecaudacionPorFechaBindingSource.DataMember = "PA_ReporteRecaudacionPorFecha";
            this.PA_ReporteRecaudacionPorFechaBindingSource.DataSource = this.DSRecaudacion;
            // 
            // DSRecaudacion
            // 
            this.DSRecaudacion.DataSetName = "DSRecaudacion";
            this.DSRecaudacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteCmentariosMalosBindingSource
            // 
            this.PA_ReporteCmentariosMalosBindingSource.DataMember = "PA_ReporteCmentariosMalos";
            this.PA_ReporteCmentariosMalosBindingSource.DataSource = this.DSComentariosMalos;
            // 
            // DSComentariosMalos
            // 
            this.DSComentariosMalos.DataSetName = "DSComentariosMalos";
            this.DSComentariosMalos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteCuponesAplicadosBindingSource
            // 
            this.PA_ReporteCuponesAplicadosBindingSource.DataMember = "PA_ReporteCuponesAplicados";
            this.PA_ReporteCuponesAplicadosBindingSource.DataSource = this.DSCuponesAplicados;
            // 
            // DSCuponesAplicados
            // 
            this.DSCuponesAplicados.DataSetName = "DSCuponesAplicados";
            this.DSCuponesAplicados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabReporteNegocio
            // 
            this.tabReporteNegocio.Controls.Add(this.tabNegocios);
            this.tabReporteNegocio.Controls.Add(this.tabMenuReportes);
            this.tabReporteNegocio.Controls.Add(this.tabCupones);
            this.tabReporteNegocio.Controls.Add(this.tabRecaudacion);
            this.tabReporteNegocio.Controls.Add(this.tabComentarios);
            this.tabReporteNegocio.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabReporteNegocio.Location = new System.Drawing.Point(-40, -63);
            this.tabReporteNegocio.Name = "tabReporteNegocio";
            this.tabReporteNegocio.SelectedIndex = 0;
            this.tabReporteNegocio.Size = new System.Drawing.Size(1063, 593);
            this.tabReporteNegocio.TabIndex = 0;
            // 
            // tabNegocios
            // 
            this.tabNegocios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabNegocios.Controls.Add(this.dvgNegocios);
            this.tabNegocios.Controls.Add(this.btnSiguiente);
            this.tabNegocios.Controls.Add(this.label3);
            this.tabNegocios.Location = new System.Drawing.Point(4, 22);
            this.tabNegocios.Name = "tabNegocios";
            this.tabNegocios.Padding = new System.Windows.Forms.Padding(3);
            this.tabNegocios.Size = new System.Drawing.Size(1055, 567);
            this.tabNegocios.TabIndex = 0;
            this.tabNegocios.Text = "tabPage1";
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNegocios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dvgNegocios.ColumnHeadersHeight = 35;
            this.dvgNegocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cedula,
            this.Nombre,
            this.Numero,
            this.Correo,
            this.Puntaje});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNegocios.DefaultCellStyle = dataGridViewCellStyle6;
            this.dvgNegocios.EnableHeadersVisualStyles = false;
            this.dvgNegocios.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dvgNegocios.Location = new System.Drawing.Point(120, 116);
            this.dvgNegocios.MultiSelect = false;
            this.dvgNegocios.Name = "dvgNegocios";
            this.dvgNegocios.ReadOnly = true;
            this.dvgNegocios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNegocios.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dvgNegocios.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dvgNegocios.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dvgNegocios.RowTemplate.Height = 40;
            this.dvgNegocios.RowTemplate.ReadOnly = true;
            this.dvgNegocios.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgNegocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgNegocios.Size = new System.Drawing.Size(743, 285);
            this.dvgNegocios.TabIndex = 70;
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
            this.btnSiguiente.Location = new System.Drawing.Point(691, 407);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(172, 39);
            this.btnSiguiente.TabIndex = 69;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(365, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 68;
            this.label3.Text = "Seleccione el negocio";
            // 
            // tabMenuReportes
            // 
            this.tabMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabMenuReportes.Controls.Add(this.panel1);
            this.tabMenuReportes.Location = new System.Drawing.Point(4, 22);
            this.tabMenuReportes.Name = "tabMenuReportes";
            this.tabMenuReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuReportes.Size = new System.Drawing.Size(1055, 567);
            this.tabMenuReportes.TabIndex = 1;
            this.tabMenuReportes.Text = "tabPage2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAtrasTab1);
            this.panel1.Controls.Add(this.btnReporteComentarios);
            this.panel1.Controls.Add(this.btnReporteCupones);
            this.panel1.Controls.Add(this.btnReporteRecaudacion);
            this.panel1.Location = new System.Drawing.Point(98, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 384);
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
            this.btnAtrasTab1.Location = new System.Drawing.Point(456, 206);
            this.btnAtrasTab1.Name = "btnAtrasTab1";
            this.btnAtrasTab1.Size = new System.Drawing.Size(290, 134);
            this.btnAtrasTab1.TabIndex = 5;
            this.btnAtrasTab1.Text = "       Regresar";
            this.btnAtrasTab1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtrasTab1.UseVisualStyleBackColor = true;
            this.btnAtrasTab1.Click += new System.EventHandler(this.btnAtrasTab1_Click);
            // 
            // btnReporteComentarios
            // 
            this.btnReporteComentarios.FlatAppearance.BorderSize = 2;
            this.btnReporteComentarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteComentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnReporteComentarios.Image = global::CAPA_UI.Properties.Resources.orden;
            this.btnReporteComentarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteComentarios.Location = new System.Drawing.Point(33, 206);
            this.btnReporteComentarios.Name = "btnReporteComentarios";
            this.btnReporteComentarios.Size = new System.Drawing.Size(316, 134);
            this.btnReporteComentarios.TabIndex = 4;
            this.btnReporteComentarios.Text = "Reporte de Comentarios";
            this.btnReporteComentarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteComentarios.UseVisualStyleBackColor = true;
            this.btnReporteComentarios.Click += new System.EventHandler(this.btnReporteComentarios_Click);
            // 
            // btnReporteCupones
            // 
            this.btnReporteCupones.FlatAppearance.BorderSize = 2;
            this.btnReporteCupones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteCupones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteCupones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnReporteCupones.Image = global::CAPA_UI.Properties.Resources.cupon;
            this.btnReporteCupones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteCupones.Location = new System.Drawing.Point(456, 34);
            this.btnReporteCupones.Name = "btnReporteCupones";
            this.btnReporteCupones.Size = new System.Drawing.Size(290, 134);
            this.btnReporteCupones.TabIndex = 3;
            this.btnReporteCupones.Text = "Reporte de Cupones";
            this.btnReporteCupones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteCupones.UseVisualStyleBackColor = true;
            this.btnReporteCupones.Click += new System.EventHandler(this.btnReporteCupones_Click);
            // 
            // btnReporteRecaudacion
            // 
            this.btnReporteRecaudacion.FlatAppearance.BorderSize = 2;
            this.btnReporteRecaudacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteRecaudacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteRecaudacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnReporteRecaudacion.Image = global::CAPA_UI.Properties.Resources.orden;
            this.btnReporteRecaudacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteRecaudacion.Location = new System.Drawing.Point(33, 34);
            this.btnReporteRecaudacion.Name = "btnReporteRecaudacion";
            this.btnReporteRecaudacion.Size = new System.Drawing.Size(316, 134);
            this.btnReporteRecaudacion.TabIndex = 2;
            this.btnReporteRecaudacion.Text = "Reporte de recaudación";
            this.btnReporteRecaudacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteRecaudacion.UseVisualStyleBackColor = true;
            this.btnReporteRecaudacion.Click += new System.EventHandler(this.btnReporteRecaudacion_Click);
            // 
            // tabCupones
            // 
            this.tabCupones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabCupones.Controls.Add(this.btnAtrasTab3);
            this.tabCupones.Controls.Add(this.rpvCuponesAplicados);
            this.tabCupones.Location = new System.Drawing.Point(4, 22);
            this.tabCupones.Name = "tabCupones";
            this.tabCupones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCupones.Size = new System.Drawing.Size(1055, 567);
            this.tabCupones.TabIndex = 2;
            // 
            // btnAtrasTab3
            // 
            this.btnAtrasTab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnAtrasTab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab3.Location = new System.Drawing.Point(813, 55);
            this.btnAtrasTab3.Name = "btnAtrasTab3";
            this.btnAtrasTab3.Size = new System.Drawing.Size(154, 39);
            this.btnAtrasTab3.TabIndex = 15;
            this.btnAtrasTab3.Text = "Atrás";
            this.btnAtrasTab3.UseVisualStyleBackColor = false;
            this.btnAtrasTab3.Click += new System.EventHandler(this.btnAtrasTab3_Click);
            // 
            // rpvCuponesAplicados
            // 
            this.rpvCuponesAplicados.BackColor = System.Drawing.Color.Gray;
            reportDataSource4.Name = "DSCuponesApli";
            reportDataSource4.Value = this.PA_ReporteCuponesAplicadosBindingSource;
            this.rpvCuponesAplicados.LocalReport.DataSources.Add(reportDataSource4);
            this.rpvCuponesAplicados.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeCuponesAplicados.rdlc";
            this.rpvCuponesAplicados.Location = new System.Drawing.Point(87, 100);
            this.rpvCuponesAplicados.Name = "rpvCuponesAplicados";
            this.rpvCuponesAplicados.ServerReport.BearerToken = null;
            this.rpvCuponesAplicados.Size = new System.Drawing.Size(880, 337);
            this.rpvCuponesAplicados.TabIndex = 14;
            // 
            // tabRecaudacion
            // 
            this.tabRecaudacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabRecaudacion.Controls.Add(this.rpvRecaudacion);
            this.tabRecaudacion.Controls.Add(this.btnAtrasTab2);
            this.tabRecaudacion.Controls.Add(this.label2);
            this.tabRecaudacion.Controls.Add(this.label1);
            this.tabRecaudacion.Controls.Add(this.dtpFechaFinal);
            this.tabRecaudacion.Controls.Add(this.dtpFechaInicio);
            this.tabRecaudacion.Controls.Add(this.lblFrase2);
            this.tabRecaudacion.Location = new System.Drawing.Point(4, 22);
            this.tabRecaudacion.Name = "tabRecaudacion";
            this.tabRecaudacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecaudacion.Size = new System.Drawing.Size(1055, 567);
            this.tabRecaudacion.TabIndex = 3;
            this.tabRecaudacion.Text = "tabPage4";
            // 
            // rpvRecaudacion
            // 
            this.rpvRecaudacion.BackColor = System.Drawing.Color.Gray;
            reportDataSource5.Name = "DSRecaudado";
            reportDataSource5.Value = this.PA_ReporteRecaudacionPorFechaBindingSource;
            this.rpvRecaudacion.LocalReport.DataSources.Add(reportDataSource5);
            this.rpvRecaudacion.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeRecaudacion.rdlc";
            this.rpvRecaudacion.Location = new System.Drawing.Point(76, 111);
            this.rpvRecaudacion.Name = "rpvRecaudacion";
            this.rpvRecaudacion.ServerReport.BearerToken = null;
            this.rpvRecaudacion.Size = new System.Drawing.Size(883, 332);
            this.rpvRecaudacion.TabIndex = 19;
            // 
            // btnAtrasTab2
            // 
            this.btnAtrasTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnAtrasTab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab2.Location = new System.Drawing.Point(800, 59);
            this.btnAtrasTab2.Name = "btnAtrasTab2";
            this.btnAtrasTab2.Size = new System.Drawing.Size(154, 39);
            this.btnAtrasTab2.TabIndex = 18;
            this.btnAtrasTab2.Text = "Atrás";
            this.btnAtrasTab2.UseVisualStyleBackColor = false;
            this.btnAtrasTab2.Click += new System.EventHandler(this.btnAtrasTab2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(598, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 35);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hasta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(427, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 33);
            this.label1.TabIndex = 16;
            this.label1.Text = "Desde";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(666, 71);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(91, 22);
            this.dtpFechaFinal.TabIndex = 15;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(501, 71);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(91, 22);
            this.dtpFechaInicio.TabIndex = 14;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // lblFrase2
            // 
            this.lblFrase2.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblFrase2.Location = new System.Drawing.Point(71, 63);
            this.lblFrase2.Name = "lblFrase2";
            this.lblFrase2.Size = new System.Drawing.Size(345, 35);
            this.lblFrase2.TabIndex = 13;
            this.lblFrase2.Text = "Seleccione el rango de fechas:";
            this.lblFrase2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabComentarios
            // 
            this.tabComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabComentarios.Controls.Add(this.btnAtrasTab4);
            this.tabComentarios.Controls.Add(this.rpvComentarios);
            this.tabComentarios.Location = new System.Drawing.Point(4, 22);
            this.tabComentarios.Name = "tabComentarios";
            this.tabComentarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabComentarios.Size = new System.Drawing.Size(1055, 567);
            this.tabComentarios.TabIndex = 4;
            this.tabComentarios.Text = "tabPage1";
            // 
            // btnAtrasTab4
            // 
            this.btnAtrasTab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnAtrasTab4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab4.Location = new System.Drawing.Point(789, 54);
            this.btnAtrasTab4.Name = "btnAtrasTab4";
            this.btnAtrasTab4.Size = new System.Drawing.Size(154, 39);
            this.btnAtrasTab4.TabIndex = 16;
            this.btnAtrasTab4.Text = "Atrás";
            this.btnAtrasTab4.UseVisualStyleBackColor = false;
            this.btnAtrasTab4.Click += new System.EventHandler(this.btnAtrasTab4_Click);
            // 
            // rpvComentarios
            // 
            this.rpvComentarios.BackColor = System.Drawing.Color.Gray;
            reportDataSource6.Name = "DSMalosComentarios";
            reportDataSource6.Value = this.PA_ReporteCmentariosMalosBindingSource;
            this.rpvComentarios.LocalReport.DataSources.Add(reportDataSource6);
            this.rpvComentarios.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeComentariosMalos.rdlc";
            this.rpvComentarios.Location = new System.Drawing.Point(71, 99);
            this.rpvComentarios.Name = "rpvComentarios";
            this.rpvComentarios.ServerReport.BearerToken = null;
            this.rpvComentarios.Size = new System.Drawing.Size(872, 338);
            this.rpvComentarios.TabIndex = 15;
            // 
            // PA_ReporteRecaudacionPorFechaTableAdapter
            // 
            this.PA_ReporteRecaudacionPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // PA_ReporteCmentariosMalosTableAdapter
            // 
            this.PA_ReporteCmentariosMalosTableAdapter.ClearBeforeFill = true;
            // 
            // PA_ReporteCuponesAplicadosTableAdapter
            // 
            this.PA_ReporteCuponesAplicadosTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_Reportes_Negocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(942, 508);
            this.Controls.Add(this.tabReporteNegocio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Reportes_Negocio";
            this.Text = "Admin_Reportes_Negocio";
            this.Load += new System.EventHandler(this.Admin_Reportes_Negocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteRecaudacionPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSRecaudacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCmentariosMalosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSComentariosMalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCuponesAplicadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCuponesAplicados)).EndInit();
            this.tabReporteNegocio.ResumeLayout(false);
            this.tabNegocios.ResumeLayout(false);
            this.tabNegocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgNegocios)).EndInit();
            this.tabMenuReportes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabCupones.ResumeLayout(false);
            this.tabRecaudacion.ResumeLayout(false);
            this.tabComentarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReporteNegocio;
        private System.Windows.Forms.TabPage tabNegocios;
        private System.Windows.Forms.TabPage tabMenuReportes;
        private System.Windows.Forms.TabPage tabCupones;
        private System.Windows.Forms.TabPage tabRecaudacion;
        private System.Windows.Forms.TabPage tabComentarios;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvgNegocios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteComentarios;
        private System.Windows.Forms.Button btnReporteCupones;
        private System.Windows.Forms.Button btnReporteRecaudacion;
        private System.Windows.Forms.Button btnAtrasTab1;
        private System.Windows.Forms.Button btnAtrasTab2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFrase2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvRecaudacion;
        private System.Windows.Forms.Button btnAtrasTab4;
        private Microsoft.Reporting.WinForms.ReportViewer rpvComentarios;
        private System.Windows.Forms.Button btnAtrasTab3;
        private Microsoft.Reporting.WinForms.ReportViewer rpvCuponesAplicados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.BindingSource PA_ReporteRecaudacionPorFechaBindingSource;
        private DSRecaudacion DSRecaudacion;
        private DSRecaudacionTableAdapters.PA_ReporteRecaudacionPorFechaTableAdapter PA_ReporteRecaudacionPorFechaTableAdapter;
        private System.Windows.Forms.BindingSource PA_ReporteCmentariosMalosBindingSource;
        private DSComentariosMalos DSComentariosMalos;
        private DSComentariosMalosTableAdapters.PA_ReporteCmentariosMalosTableAdapter PA_ReporteCmentariosMalosTableAdapter;
        private System.Windows.Forms.BindingSource PA_ReporteCuponesAplicadosBindingSource;
        private DSCuponesAplicados DSCuponesAplicados;
        private DSCuponesAplicadosTableAdapters.PA_ReporteCuponesAplicadosTableAdapter PA_ReporteCuponesAplicadosTableAdapter;
    }
}