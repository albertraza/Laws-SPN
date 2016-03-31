namespace Sistema_Abogados
{
    partial class frmFacturaDivorciosAccidente
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
            this.FacturaDivorciosAccidentesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbogadosDBDataSet = new Sistema_Abogados.AbogadosDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FacturaDivorciosAccidentesTableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.FacturaDivorciosAccidentesTableAdapter();
            this.FacturaDivorciosAccidentes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaDivorciosAccidentes1TableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.FacturaDivorciosAccidentes1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDivorciosAccidentesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDivorciosAccidentes1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FacturaDivorciosAccidentesBindingSource
            // 
            this.FacturaDivorciosAccidentesBindingSource.DataMember = "FacturaDivorciosAccidentes";
            this.FacturaDivorciosAccidentesBindingSource.DataSource = this.AbogadosDBDataSet;
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
            reportDataSource1.Value = this.FacturaDivorciosAccidentes1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Abogados.FacturaDivorciosAccidente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(898, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // FacturaDivorciosAccidentesTableAdapter
            // 
            this.FacturaDivorciosAccidentesTableAdapter.ClearBeforeFill = true;
            // 
            // FacturaDivorciosAccidentes1BindingSource
            // 
            this.FacturaDivorciosAccidentes1BindingSource.DataMember = "FacturaDivorciosAccidentes1";
            this.FacturaDivorciosAccidentes1BindingSource.DataSource = this.AbogadosDBDataSet;
            // 
            // FacturaDivorciosAccidentes1TableAdapter
            // 
            this.FacturaDivorciosAccidentes1TableAdapter.ClearBeforeFill = true;
            // 
            // frmFacturaDivorciosAccidente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 540);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFacturaDivorciosAccidente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura Divorcio Accidente";
            this.Load += new System.EventHandler(this.frmFacturaDivorciosAccidente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDivorciosAccidentesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaDivorciosAccidentes1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaDivorciosAccidentesBindingSource;
        private AbogadosDBDataSet AbogadosDBDataSet;
        private AbogadosDBDataSetTableAdapters.FacturaDivorciosAccidentesTableAdapter FacturaDivorciosAccidentesTableAdapter;
        private System.Windows.Forms.BindingSource FacturaDivorciosAccidentes1BindingSource;
        private AbogadosDBDataSetTableAdapters.FacturaDivorciosAccidentes1TableAdapter FacturaDivorciosAccidentes1TableAdapter;
    }
}