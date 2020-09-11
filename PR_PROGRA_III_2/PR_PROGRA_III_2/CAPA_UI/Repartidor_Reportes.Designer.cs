namespace CAPA_UI
{
    partial class Repartidor_Reportes
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
            this.tabReportes = new System.Windows.Forms.TabControl();
            this.tabMenuReportes = new System.Windows.Forms.TabPage();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.tabComentarios = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReporteCupones = new System.Windows.Forms.Button();
            this.btnReportePedidos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEstadosPedido = new System.Windows.Forms.Button();
            this.cbNegocios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtrasTab1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbNegocios2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtras2 = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_ReporteEntregasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSEntregas = new CAPA_UI.DSEntregas();
            this.PA_ReporteEntregasTableAdapter = new CAPA_UI.DSEntregasTableAdapters.PA_ReporteEntregasTableAdapter();
            this.DSCalificacionRepartidor = new CAPA_UI.DSCalificacionRepartidor();
            this.PA_ReporteComentariosNegativosRepartidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PA_ReporteComentariosNegativosRepartidorTableAdapter = new CAPA_UI.DSCalificacionRepartidorTableAdapters.PA_ReporteComentariosNegativosRepartidorTableAdapter();
            this.tabReportes.SuspendLayout();
            this.tabMenuReportes.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.tabComentarios.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteEntregasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCalificacionRepartidor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteComentariosNegativosRepartidorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabReportes
            // 
            this.tabReportes.Controls.Add(this.tabMenuReportes);
            this.tabReportes.Controls.Add(this.tabPedidos);
            this.tabReportes.Controls.Add(this.tabComentarios);
            this.tabReportes.Location = new System.Drawing.Point(-20, -37);
            this.tabReportes.Name = "tabReportes";
            this.tabReportes.SelectedIndex = 0;
            this.tabReportes.Size = new System.Drawing.Size(997, 598);
            this.tabReportes.TabIndex = 0;
            // 
            // tabMenuReportes
            // 
            this.tabMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabMenuReportes.Controls.Add(this.panel1);
            this.tabMenuReportes.Location = new System.Drawing.Point(4, 22);
            this.tabMenuReportes.Name = "tabMenuReportes";
            this.tabMenuReportes.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenuReportes.Size = new System.Drawing.Size(989, 572);
            this.tabMenuReportes.TabIndex = 0;
            this.tabMenuReportes.Text = "tabPage1";
            // 
            // tabPedidos
            // 
            this.tabPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabPedidos.Controls.Add(this.reportViewer1);
            this.tabPedidos.Controls.Add(this.panel2);
            this.tabPedidos.Location = new System.Drawing.Point(4, 22);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(989, 572);
            this.tabPedidos.TabIndex = 1;
            this.tabPedidos.Text = "tabPage2";
            // 
            // tabComentarios
            // 
            this.tabComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabComentarios.Controls.Add(this.reportViewer2);
            this.tabComentarios.Controls.Add(this.panel3);
            this.tabComentarios.Location = new System.Drawing.Point(4, 22);
            this.tabComentarios.Name = "tabComentarios";
            this.tabComentarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabComentarios.Size = new System.Drawing.Size(989, 572);
            this.tabComentarios.TabIndex = 2;
            this.tabComentarios.Text = "tabPage3";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnReporteCupones);
            this.panel1.Controls.Add(this.btnReportePedidos);
            this.panel1.Location = new System.Drawing.Point(53, 59);
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
            this.btnReporteCupones.Location = new System.Drawing.Point(470, 133);
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
            this.btnReportePedidos.Location = new System.Drawing.Point(53, 133);
            this.btnReportePedidos.Name = "btnReportePedidos";
            this.btnReportePedidos.Size = new System.Drawing.Size(316, 134);
            this.btnReportePedidos.TabIndex = 2;
            this.btnReportePedidos.Text = "Reporte de Entregas";
            this.btnReportePedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePedidos.UseVisualStyleBackColor = true;
            this.btnReportePedidos.Click += new System.EventHandler(this.btnReportePedidos_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnEstadosPedido);
            this.panel2.Controls.Add(this.cbNegocios);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnAtrasTab1);
            this.panel2.Location = new System.Drawing.Point(28, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 88);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Filtrar por negocio";
            // 
            // btnAtrasTab1
            // 
            this.btnAtrasTab1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.btnAtrasTab1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab1.Location = new System.Drawing.Point(706, 28);
            this.btnAtrasTab1.Name = "btnAtrasTab1";
            this.btnAtrasTab1.Size = new System.Drawing.Size(172, 39);
            this.btnAtrasTab1.TabIndex = 9;
            this.btnAtrasTab1.Text = "Atrás";
            this.btnAtrasTab1.UseVisualStyleBackColor = false;
            this.btnAtrasTab1.Click += new System.EventHandler(this.btnAtrasTab1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Gray;
            this.reportViewer1.DocumentMapWidth = 69;
            reportDataSource1.Name = "DSEntregasRepartidor";
            reportDataSource1.Value = this.PA_ReporteEntregasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeEntregas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(36, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(871, 387);
            this.reportViewer1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbNegocios2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnAtras2);
            this.panel3.Location = new System.Drawing.Point(28, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 88);
            this.panel3.TabIndex = 12;
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
            // reportViewer2
            // 
            this.reportViewer2.BackColor = System.Drawing.Color.Gray;
            reportDataSource2.Name = "DSCalificacionesRep";
            reportDataSource2.Value = this.PA_ReporteComentariosNegativosRepartidorBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeComentariosRepartidor.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(36, 121);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(871, 374);
            this.reportViewer2.TabIndex = 13;
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
            // PA_ReporteEntregasTableAdapter
            // 
            this.PA_ReporteEntregasTableAdapter.ClearBeforeFill = true;
            // 
            // DSCalificacionRepartidor
            // 
            this.DSCalificacionRepartidor.DataSetName = "DSCalificacionRepartidor";
            this.DSCalificacionRepartidor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PA_ReporteComentariosNegativosRepartidorBindingSource
            // 
            this.PA_ReporteComentariosNegativosRepartidorBindingSource.DataMember = "PA_ReporteComentariosNegativosRepartidor";
            this.PA_ReporteComentariosNegativosRepartidorBindingSource.DataSource = this.DSCalificacionRepartidor;
            // 
            // PA_ReporteComentariosNegativosRepartidorTableAdapter
            // 
            this.PA_ReporteComentariosNegativosRepartidorTableAdapter.ClearBeforeFill = true;
            // 
            // Repartidor_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(924, 505);
            this.Controls.Add(this.tabReportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Repartidor_Reportes";
            this.Text = "Repartidor_Reportes";
            this.Load += new System.EventHandler(this.Repartidor_Reportes_Load);
            this.tabReportes.ResumeLayout(false);
            this.tabMenuReportes.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.tabComentarios.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteEntregasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCalificacionRepartidor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteComentariosNegativosRepartidorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabReportes;
        private System.Windows.Forms.TabPage tabMenuReportes;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TabPage tabComentarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReporteCupones;
        private System.Windows.Forms.Button btnReportePedidos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEstadosPedido;
        private System.Windows.Forms.ComboBox cbNegocios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAtrasTab1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbNegocios2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtras2;
        private System.Windows.Forms.BindingSource PA_ReporteEntregasBindingSource;
        private DSEntregas DSEntregas;
        private DSEntregasTableAdapters.PA_ReporteEntregasTableAdapter PA_ReporteEntregasTableAdapter;
        private System.Windows.Forms.BindingSource PA_ReporteComentariosNegativosRepartidorBindingSource;
        private DSCalificacionRepartidor DSCalificacionRepartidor;
        private DSCalificacionRepartidorTableAdapters.PA_ReporteComentariosNegativosRepartidorTableAdapter PA_ReporteComentariosNegativosRepartidorTableAdapter;
    }
}