namespace Sistema_Abogados
{
    partial class frmReporteAbonoContrVenta
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AbogadosDBDataSet = new Sistema_Abogados.AbogadosDBDataSet();
            this.AbonosContrVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbonosContrVentaTableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.AbonosContrVentaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonosContrVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AbonosContrVentaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Abogados.ReporteAbonoContrVentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(886, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // AbogadosDBDataSet
            // 
            this.AbogadosDBDataSet.DataSetName = "AbogadosDBDataSet";
            this.AbogadosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AbonosContrVentaBindingSource
            // 
            this.AbonosContrVentaBindingSource.DataMember = "AbonosContrVenta";
            this.AbonosContrVentaBindingSource.DataSource = this.AbogadosDBDataSet;
            // 
            // AbonosContrVentaTableAdapter
            // 
            this.AbonosContrVentaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteAbonoContrVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 538);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteAbonoContrVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporteAbonoContrVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonosContrVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AbonosContrVentaBindingSource;
        private AbogadosDBDataSet AbogadosDBDataSet;
        private AbogadosDBDataSetTableAdapters.AbonosContrVentaTableAdapter AbonosContrVentaTableAdapter;
    }
}