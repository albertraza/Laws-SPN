namespace Sistema_Abogados
{
    partial class frmFacturaVenta
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
            this.FacturaVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbogadosDBDataSet = new Sistema_Abogados.AbogadosDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaVentaTableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.FacturaVentaTableAdapter();
            this.FacturaVenta1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaVenta1TableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.FacturaVenta1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaVentaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaVenta1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturaVentaBindingSource
            // 
            this.FacturaVentaBindingSource.DataMember = "FacturaVenta";
            this.FacturaVentaBindingSource.DataSource = this.AbogadosDBDataSet;
            // 
            // AbogadosDBDataSet
            // 
            this.AbogadosDBDataSet.DataSetName = "AbogadosDBDataSet";
            this.AbogadosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FacturaVenta1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Abogados.FacturaVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(902, 548);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturaVentaTableAdapter
            // 
            this.FacturaVentaTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaVenta1BindingSource
            // 
            this.FacturaVenta1BindingSource.DataMember = "FacturaVenta1";
            this.FacturaVenta1BindingSource.DataSource = this.AbogadosDBDataSet;
            // 
            // FacturaVenta1TableAdapter
            // 
            this.FacturaVenta1TableAdapter.ClearBeforeFill = true;
            // 
            // frmFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 548);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFacturaVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura Ventas";
            this.Load += new System.EventHandler(this.frmFacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaVentaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaVenta1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaVentaBindingSource;
        private AbogadosDBDataSet AbogadosDBDataSet;
        private AbogadosDBDataSetTableAdapters.FacturaVentaTableAdapter FacturaVentaTableAdapter;
        private System.Windows.Forms.BindingSource FacturaVenta1BindingSource;
        private AbogadosDBDataSetTableAdapters.FacturaVenta1TableAdapter FacturaVenta1TableAdapter;
    }
}