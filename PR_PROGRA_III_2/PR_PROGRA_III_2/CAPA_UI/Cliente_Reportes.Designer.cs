namespace CAPA_UI
{
    partial class Cliente_Reportes
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
            this.PA_ReportePedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSPedidos = new CAPA_UI.DSPedidos();
            this.PA_ReporteCuponesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSCuponesUsado = new CAPA_UI.DSCuponesUsado();
            this.tabMenuReportes = new System.Windows.Forms.Panel();
            this.btnReporteCupones = new System.Windows.Forms.Button();
            this.btnReportePedidos = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabReportePedidos = new System.Windows.Forms.TabPage();
            this.rvPedidos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEstadosPedido = new System.Windows.Forms.Button();
            this.cbNegocios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAtrasTab1 = new System.Windows.Forms.Button();
            this.tabReporteCupones = new System.Windows.Forms.TabPage();
            this.btnAtrasTab2 = new System.Windows.Forms.Button();
            this.rvCuponesUsados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PA_ReporteCuponesTableAdapter = new CAPA_UI.DSCuponesUsadoTableAdapters.PA_ReporteCuponesTableAdapter();
            this.PA_ReportePedidosTableAdapter = new CAPA_UI.DSPedidosTableAdapters.PA_ReportePedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReportePedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCuponesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCuponesUsado)).BeginInit();
            this.tabMenuReportes.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabReportePedidos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabReporteCupones.SuspendLayout();
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
            // tabMenuReportes
            // 
            this.tabMenuReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabMenuReportes.Controls.Add(this.btnReporteCupones);
            this.tabMenuReportes.Controls.Add(this.btnReportePedidos);
            this.tabMenuReportes.Location = new System.Drawing.Point(71, 63);
            this.tabMenuReportes.Name = "tabMenuReportes";
            this.tabMenuReportes.Size = new System.Drawing.Size(808, 406);
            this.tabMenuReportes.TabIndex = 0;
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
            this.btnReportePedidos.Location = new System.Drawing.Point(53, 133);
            this.btnReportePedidos.Name = "btnReportePedidos";
            this.btnReportePedidos.Size = new System.Drawing.Size(316, 134);
            this.btnReportePedidos.TabIndex = 2;
            this.btnReportePedidos.Text = "Reporte de Pedidos";
            this.btnReportePedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReportePedidos.UseVisualStyleBackColor = true;
            this.btnReportePedidos.Click += new System.EventHandler(this.btnReportePedidos_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabReportePedidos);
            this.tabControl1.Controls.Add(this.tabReporteCupones);
            this.tabControl1.Location = new System.Drawing.Point(-11, -28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 535);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabPage1.Controls.Add(this.tabMenuReportes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(965, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tabReportePedidos
            // 
            this.tabReportePedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabReportePedidos.Controls.Add(this.rvPedidos);
            this.tabReportePedidos.Controls.Add(this.panel1);
            this.tabReportePedidos.Location = new System.Drawing.Point(4, 22);
            this.tabReportePedidos.Name = "tabReportePedidos";
            this.tabReportePedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabReportePedidos.Size = new System.Drawing.Size(965, 509);
            this.tabReportePedidos.TabIndex = 1;
            this.tabReportePedidos.Text = "tabPage2";
            // 
            // rvPedidos
            // 
            this.rvPedidos.BackColor = System.Drawing.Color.Gray;
            reportDataSource1.Name = "DataSetPedidos";
            reportDataSource1.Value = this.PA_ReportePedidosBindingSource;
            this.rvPedidos.LocalReport.DataSources.Add(reportDataSource1);
            this.rvPedidos.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformePedidos.rdlc";
            this.rvPedidos.Location = new System.Drawing.Point(6, 108);
            this.rvPedidos.Name = "rvPedidos";
            this.rvPedidos.ServerReport.BearerToken = null;
            this.rvPedidos.Size = new System.Drawing.Size(909, 372);
            this.rvPedidos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEstadosPedido);
            this.panel1.Controls.Add(this.cbNegocios);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAtrasTab1);
            this.panel1.Location = new System.Drawing.Point(19, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 88);
            this.panel1.TabIndex = 10;
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
            this.btnEstadosPedido.Click += new System.EventHandler(this.btnInfoEstadosPedido_Click);
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
            // tabReporteCupones
            // 
            this.tabReporteCupones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.tabReporteCupones.Controls.Add(this.btnAtrasTab2);
            this.tabReporteCupones.Controls.Add(this.rvCuponesUsados);
            this.tabReporteCupones.Location = new System.Drawing.Point(4, 22);
            this.tabReporteCupones.Name = "tabReporteCupones";
            this.tabReporteCupones.Padding = new System.Windows.Forms.Padding(3);
            this.tabReporteCupones.Size = new System.Drawing.Size(965, 509);
            this.tabReporteCupones.TabIndex = 2;
            this.tabReporteCupones.Text = "tabPage2";
            // 
            // btnAtrasTab2
            // 
            this.btnAtrasTab2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(104)))), ((int)(((byte)(105)))));
            this.btnAtrasTab2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasTab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAtrasTab2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            this.btnAtrasTab2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAtrasTab2.Location = new System.Drawing.Point(734, 448);
            this.btnAtrasTab2.Name = "btnAtrasTab2";
            this.btnAtrasTab2.Size = new System.Drawing.Size(172, 39);
            this.btnAtrasTab2.TabIndex = 8;
            this.btnAtrasTab2.Text = "Atrás";
            this.btnAtrasTab2.UseVisualStyleBackColor = false;
            this.btnAtrasTab2.Click += new System.EventHandler(this.btnAtrasTab2_Click);
            // 
            // rvCuponesUsados
            // 
            this.rvCuponesUsados.BackColor = System.Drawing.Color.Gray;
            this.rvCuponesUsados.DocumentMapWidth = 38;
            reportDataSource2.Name = "DSCupones";
            reportDataSource2.Value = this.PA_ReporteCuponesBindingSource;
            this.rvCuponesUsados.LocalReport.DataSources.Add(reportDataSource2);
            this.rvCuponesUsados.LocalReport.ReportEmbeddedResource = "CAPA_UI.InformeCupones.rdlc";
            this.rvCuponesUsados.Location = new System.Drawing.Point(19, 18);
            this.rvCuponesUsados.Name = "rvCuponesUsados";
            this.rvCuponesUsados.ServerReport.BearerToken = null;
            this.rvCuponesUsados.Size = new System.Drawing.Size(887, 424);
            this.rvCuponesUsados.TabIndex = 0;
            // 
            // PA_ReporteCuponesTableAdapter
            // 
            this.PA_ReporteCuponesTableAdapter.ClearBeforeFill = true;
            // 
            // PA_ReportePedidosTableAdapter
            // 
            this.PA_ReportePedidosTableAdapter.ClearBeforeFill = true;
            // 
            // Cliente_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(953, 486);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cliente_Reportes";
            this.Text = "Cliente_Reportes";
            this.Load += new System.EventHandler(this.Cliente_Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReportePedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PA_ReporteCuponesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSCuponesUsado)).EndInit();
            this.tabMenuReportes.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabReportePedidos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabReporteCupones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tabMenuReportes;
        private System.Windows.Forms.Button btnReporteCupones;
        private System.Windows.Forms.Button btnReportePedidos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabReportePedidos;
        private System.Windows.Forms.TabPage tabReporteCupones;
        private Microsoft.Reporting.WinForms.ReportViewer rvCuponesUsados;
        private System.Windows.Forms.BindingSource PA_ReporteCuponesBindingSource;
        private DSCuponesUsado DSCuponesUsado;
        private DSCuponesUsadoTableAdapters.PA_ReporteCuponesTableAdapter PA_ReporteCuponesTableAdapter;
        private System.Windows.Forms.Button btnAtrasTab2;
        private Microsoft.Reporting.WinForms.ReportViewer rvPedidos;
        private System.Windows.Forms.Button btnAtrasTab1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbNegocios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEstadosPedido;
        private System.Windows.Forms.BindingSource PA_ReportePedidosBindingSource;
        private DSPedidos DSPedidos;
        private DSPedidosTableAdapters.PA_ReportePedidosTableAdapter PA_ReportePedidosTableAdapter;
    }
}