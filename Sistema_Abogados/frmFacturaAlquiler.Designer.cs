namespace Sistema_Abogados
{
    partial class frmFacturaAlquiler
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
            this.FacturaAlquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaAlquilerTableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.FacturaAlquilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaAlquilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FacturaAlquilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Abogados.FacturaAlquiler.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(913, 562);
            this.reportViewer1.TabIndex = 0;
            // 
            // AbogadosDBDataSet
            // 
            this.AbogadosDBDataSet.DataSetName = "AbogadosDBDataSet";
            this.AbogadosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturaAlquilerBindingSource
            // 
            this.FacturaAlquilerBindingSource.DataMember = "FacturaAlquiler";
            this.FacturaAlquilerBindingSource.DataSource = this.AbogadosDBDataSet;
            // 
            // FacturaAlquilerTableAdapter
            // 
            this.FacturaAlquilerTableAdapter.ClearBeforeFill = true;
            // 
            // frmFacturaAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 562);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFacturaAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura Alquiler";
            this.Load += new System.EventHandler(this.frmFacturaAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaAlquilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaAlquilerBindingSource;
        private AbogadosDBDataSet AbogadosDBDataSet;
        private AbogadosDBDataSetTableAdapters.FacturaAlquilerTableAdapter FacturaAlquilerTableAdapter;
    }
}