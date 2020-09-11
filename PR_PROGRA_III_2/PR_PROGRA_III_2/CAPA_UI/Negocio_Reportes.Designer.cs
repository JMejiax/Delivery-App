namespace CAPA_UI
{
    partial class Negocio_Reportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabReportes = new System.Windows.Forms.TabControl();
            this.tabMenuReportes = new System.Windows.Forms.TabPage();
            this.tabRecaudacion = new System.Windows.Forms.TabPage();
            this.tabCuponesAplicados = new System.Windows.Forms.TabPage();
            this.tabComentarios = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporteCupones = new System.Windows.Forms.Button();
            this.btnReporteRecaudacion = new System.Windows.Forms.Button();
            this.btnReporteComentarios = new System.Windows.Forms.Button();
            this.rpvRecaudacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblFrase2 = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAtrasTab2 = new System.Windows.Forms.Button();
            this.DSRecaudacion = new CAPA_UI.DSRecaudacion();
            this.PA_ReporteRecaudacionPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_ReporteRecaudacionPorFechaTableAdapter = new CAPA_UI.DSRecaudacionTableAdapters.PA_ReporteRecaudacionPorFechaTableAdapter();
            this.rpvCuponesAplicados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAtrasTab3 = new System.Windows.Forms.Button();
            this.PA_ReporteCuponesAplicadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSCuponesAplicados = new CAPA_UI.DSCuponesAplicados();
            this.PA_ReporteCuponesAplicadosTableAdapter = new CAPA_UI.DSCuponesAplicadosTableAdapters.PA_ReporteCuponesAplicadosTableAdapter();
            this.rpvComentarios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAtrasTab4 = new System.Windows.Forms.Button();
            this.DSComentariosMalos = new CAPA_UI.DSComentariosMalos();
            this.PA_ReporteCmentariosMalosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_ReporteCmentariosMalosTableAdapter = new CAPA_UI.DSComentariosMalosTableAdapters.PA_ReporteCmentariosMalosTableAdapter();
            this.tabReportes.SuspendLayout();
            this.tabMenuReportes.SuspendLayout();
            this.tabRecaudacion.SuspendLayout();
            this.tabCuponesAplicados.SuspendLayout();
            this.tabComentarios.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSRecaudacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteRecaudacionPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCuponesAplicadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCuponesAplicados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSComentariosMalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCmentariosMalosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.tabMenuReportes);
            this.tabReportes.Controls.Add(this.tabRecaudacion);
            this.tabReportes.Controls.Add(this.tabCuponesAplicados);
            this.tabReportes.Controls.Add(this.tabComentarios);
            this.tabReportes.Location = new System.Drawing.Point(-21, -27);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.SelectedIndex = 0;
            this.tabReportes.Size = new System.Drawing.Size(1009, 537);
            this.tabReportes.TabIndex = 0;
            // 
            // tabMenuReportes
            // 
            this.tabMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabMenuReportes.Controls.Add(this.panel1);
            this.tabMenuReportes.Location = new System.Drawing.Point(4, 22);
            this.tabMenuReportes.Name = "tabMenuReportes";
            this.tabMenuReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuReportes.Size = new System.Drawing.Size(1001, 511);
            this.tabMenuReportes.TabIndex = 0;
            this.tabMenuReportes.Text = "tabPage1";
            // 
            // tabRecaudacion
            // 
            this.tabRecaudacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabRecaudacion.Controls.Add(this.btnAtrasTab2);
            this.tabRecaudacion.Controls.Add(this.label2);
            this.tabRecaudacion.Controls.Add(this.label1);
            this.tabRecaudacion.Controls.Add(this.dtpFechaFinal);
            this.tabRecaudacion.Controls.Add(this.dtpFechaInicio);
            this.tabRecaudacion.Controls.Add(this.lblFrase2);
            this.tabRecaudacion.Controls.Add(this.rpvRecaudacion);
            this.tabRecaudacion.Location = new System.Drawing.Point(4, 22);
            this.tabRecaudacion.Name = "tabRecaudacion";
            this.tabRecaudacion.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecaudacion.Size = new System.Drawing.Size(1001, 511);
            this.tabRecaudacion.TabIndex = 1;
            this.tabRecaudacion.Text = "tabPage2";
            // 
            // tabCuponesAplicados
            // 
            this.tabCuponesAplicados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabCuponesAplicados.Controls.Add(this.btnAtrasTab3);
            this.tabCuponesAplicados.Controls.Add(this.rpvCuponesAplicados);
            this.tabCuponesAplicados.Location = new System.Drawing.Point(4, 22);
            this.tabCuponesAplicados.Name = "tabCuponesAplicados";
            this.tabCuponesAplicados.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuponesAplicados.Size = new System.Drawing.Size(1001, 511);
            this.tabCuponesAplicados.TabIndex = 2;
            this.tabCuponesAplicados.Text = "tabPage3";
            // 
            // tabComentarios
            // 
            this.tabComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabComentarios.Controls.Add(this.btnAtrasTab4);
            this.tabComentarios.Controls.Add(this.rpvComentarios);
            this.tabComentarios.Location = new System.Drawing.Point(4, 22);
            this.tabComentarios.Name = "tabComentarios";
            this.tabComentarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabComentarios.Size = new System.Drawing.Size(1001, 511);
            this.tabComentarios.TabIndex = 3;
            this.tabComentarios.Text = "tabPage4";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReporteComentarios);
            this.panel1.Controls.Add(this.btnReporteCupones);
            this.panel1.Controls.Add(this.btnReporteRecaudacion);
            this.panel1.Location = new System.Drawing.Point(70, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 406);
            this.panel1.TabIndex = 1;
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
            // btnReporteComentarios
            // 
            this.btnReporteComentarios.FlatAppearance.BorderSize = 2;
            this.btnReporteComentarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteComentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnReporteComentarios.Image = global::CAPA_UI.Properties.Resources.orden;
            this.btnReporteComentarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporteComentarios.Location = new System.Drawing.Point(246, 214);
            this.btnReporteComentarios.Name = "btnReporteComentarios";
            this.btnReporteComentarios.Size = new System.Drawing.Size(316, 134);
            this.btnReporteComentarios.TabIndex = 4;
            this.btnReporteComentarios.Text = "Reporte de Comentarios";
            this.btnReporteComentarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporteComentarios.UseVisualStyleBackColor = true;
            this.btnReporteComentarios.Click += new System.EventHandler(this.btnReporteComentarios_Click);
            // 
            // rpvRecaudacion
            // 
            this.rpvRecaudacion.BackColor = System.Drawing.Color.Gray;
            reportDataSource1.Name = "DSRecaudado";
            reportDataSource1.Value = this.PA_ReporteRecaudacionPorFechaBindingSource;
            this.rpvRecaudacion.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvRecaudacion.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeRecaudacion.rdlc";
            this.rpvRecaudacion.Location = new System.Drawing.Point(29, 90);
            this.rpvRecaudacion.Name = "rpvRecaudacion";
            this.rpvRecaudacion.ServerReport.BearerToken = null;
            this.rpvRecaudacion.Size = new System.Drawing.Size(883, 332);
            this.rpvRecaudacion.TabIndex = 0;
            // 
            // lblFrase2
            // 
            this.lblFrase2.BackColor = System.Drawing.Color.Transparent;
            this.lblFrase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrase2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.lblFrase2.Location = new System.Drawing.Point(29, 27);
            this.lblFrase2.Name = "lblFrase2";
            this.lblFrase2.Size = new System.Drawing.Size(345, 35);
            this.lblFrase2.TabIndex = 7;
            this.lblFrase2.Text = "Seleccione el rango de fechas:";
            this.lblFrase2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(459, 35);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(91, 22);
            this.dtpFechaInicio.TabIndex = 8;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(624, 35);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(91, 22);
            this.dtpFechaFinal.TabIndex = 9;
            this.dtpFechaFinal.ValueChanged += new System.EventHandler(this.dtpFechaFinal_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(385, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "Desde";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(556, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAtrasTab2
            // 
            this.btnAtrasTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnAtrasTab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab2.Location = new System.Drawing.Point(758, 23);
            this.btnAtrasTab2.Name = "btnAtrasTab2";
            this.btnAtrasTab2.Size = new System.Drawing.Size(154, 39);
            this.btnAtrasTab2.TabIndex = 12;
            this.btnAtrasTab2.Text = "Atrás";
            this.btnAtrasTab2.UseVisualStyleBackColor = false;
            this.btnAtrasTab2.Click += new System.EventHandler(this.btnAtrasTab2_Click);
            // 
            // DSRecaudacion
            // 
            this.DSRecaudacion.DataSetName = "DSRecaudacion";
            this.DSRecaudacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteRecaudacionPorFechaBindingSource
            // 
            this.PA_ReporteRecaudacionPorFechaBindingSource.DataMember = "PA_ReporteRecaudacionPorFecha";
            this.PA_ReporteRecaudacionPorFechaBindingSource.DataSource = this.DSRecaudacion;
            // 
            // PA_ReporteRecaudacionPorFechaTableAdapter
            // 
            this.PA_ReporteRecaudacionPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // rpvCuponesAplicados
            // 
            this.rpvCuponesAplicados.BackColor = System.Drawing.Color.Gray;
            reportDataSource2.Name = "DSCuponesApli";
            reportDataSource2.Value = this.PA_ReporteCuponesAplicadosBindingSource;
            this.rpvCuponesAplicados.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvCuponesAplicados.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeCuponesAplicados.rdlc";
            this.rpvCuponesAplicados.Location = new System.Drawing.Point(29, 61);
            this.rpvCuponesAplicados.Name = "rpvCuponesAplicados";
            this.rpvCuponesAplicados.ServerReport.BearerToken = null;
            this.rpvCuponesAplicados.Size = new System.Drawing.Size(880, 369);
            this.rpvCuponesAplicados.TabIndex = 0;
            // 
            // btnAtrasTab3
            // 
            this.btnAtrasTab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnAtrasTab3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab3.Location = new System.Drawing.Point(755, 16);
            this.btnAtrasTab3.Name = "btnAtrasTab3";
            this.btnAtrasTab3.Size = new System.Drawing.Size(154, 39);
            this.btnAtrasTab3.TabIndex = 13;
            this.btnAtrasTab3.Text = "Atrás";
            this.btnAtrasTab3.UseVisualStyleBackColor = false;
            this.btnAtrasTab3.Click += new System.EventHandler(this.btnAtrasTab3_Click);
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
            // PA_ReporteCuponesAplicadosTableAdapter
            // 
            this.PA_ReporteCuponesAplicadosTableAdapter.ClearBeforeFill = true;
            // 
            // rpvComentarios
            // 
            this.rpvComentarios.BackColor = System.Drawing.Color.Gray;
            reportDataSource3.Name = "DSMalosComentarios";
            reportDataSource3.Value = this.PA_ReporteCmentariosMalosBindingSource;
            this.rpvComentarios.LocalReport.DataSources.Add(reportDataSource3);
            this.rpvComentarios.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeComentariosMalos.rdlc";
            this.rpvComentarios.Location = new System.Drawing.Point(29, 64);
            this.rpvComentarios.Name = "rpvComentarios";
            this.rpvComentarios.ServerReport.BearerToken = null;
            this.rpvComentarios.Size = new System.Drawing.Size(872, 363);
            this.rpvComentarios.TabIndex = 0;
            // 
            // btnAtrasTab4
            // 
            this.btnAtrasTab4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnAtrasTab4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab4.Location = new System.Drawing.Point(747, 19);
            this.btnAtrasTab4.Name = "btnAtrasTab4";
            this.btnAtrasTab4.Size = new System.Drawing.Size(154, 39);
            this.btnAtrasTab4.TabIndex = 14;
            this.btnAtrasTab4.Text = "Atrás";
            this.btnAtrasTab4.UseVisualStyleBackColor = false;
            this.btnAtrasTab4.Click += new System.EventHandler(this.btnAtrasTab4_Click);
            // 
            // DSComentariosMalos
            // 
            this.DSComentariosMalos.DataSetName = "DSComentariosMalos";
            this.DSComentariosMalos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteCmentariosMalosBindingSource
            // 
            this.PA_ReporteCmentariosMalosBindingSource.DataMember = "PA_ReporteCmentariosMalos";
            this.PA_ReporteCmentariosMalosBindingSource.DataSource = this.DSComentariosMalos;
            // 
            // PA_ReporteCmentariosMalosTableAdapter
            // 
            this.PA_ReporteCmentariosMalosTableAdapter.ClearBeforeFill = true;
            // 
            // Negocio_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(937, 447);
            this.Controls.Add(this.tabReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Negocio_Reportes";
            this.Text = "Negocio_Reportes";
            this.Load += new System.EventHandler(this.Negocio_Reportes_Load);
            this.tabReportes.ResumeLayout(false);
            this.tabMenuReportes.ResumeLayout(false);
            this.tabRecaudacion.ResumeLayout(false);
            this.tabCuponesAplicados.ResumeLayout(false);
            this.tabComentarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DSRecaudacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteRecaudacionPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCuponesAplicadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCuponesAplicados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSComentariosMalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCmentariosMalosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage tabMenuReportes;
        private System.Windows.Forms.TabPage tabRecaudacion;
        private System.Windows.Forms.TabPage tabCuponesAplicados;
        private System.Windows.Forms.TabPage tabComentarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteComentarios;
        private System.Windows.Forms.Button btnReporteCupones;
        private System.Windows.Forms.Button btnReporteRecaudacion;
        private Microsoft.Reporting.WinForms.ReportViewer rpvRecaudacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFrase2;
        private System.Windows.Forms.Button btnAtrasTab2;
        private System.Windows.Forms.BindingSource PA_ReporteRecaudacionPorFechaBindingSource;
        private DSRecaudacion DSRecaudacion;
        private DSRecaudacionTableAdapters.PA_ReporteRecaudacionPorFechaTableAdapter PA_ReporteRecaudacionPorFechaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvCuponesAplicados;
        private System.Windows.Forms.Button btnAtrasTab3;
        private System.Windows.Forms.BindingSource PA_ReporteCuponesAplicadosBindingSource;
        private DSCuponesAplicados DSCuponesAplicados;
        private DSCuponesAplicadosTableAdapters.PA_ReporteCuponesAplicadosTableAdapter PA_ReporteCuponesAplicadosTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rpvComentarios;
        private System.Windows.Forms.Button btnAtrasTab4;
        private System.Windows.Forms.BindingSource PA_ReporteCmentariosMalosBindingSource;
        private DSComentariosMalos DSComentariosMalos;
        private DSComentariosMalosTableAdapters.PA_ReporteCmentariosMalosTableAdapter PA_ReporteCmentariosMalosTableAdapter;
    }
}