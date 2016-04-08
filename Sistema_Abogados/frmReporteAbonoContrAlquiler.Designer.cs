namespace Sistema_Abogados
{
    partial class frmReporteAbonoContrAlquiler
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
            this.AbonoContratoAlquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbonoContratoAlquilerTableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.AbonoContratoAlquilerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonoContratoAlquilerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AbonoContratoAlquilerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Sistema_Abogados.ReporteAbonoContrAlquiler.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(906, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // AbogadosDBDataSet
            // 
            this.AbogadosDBDataSet.DataSetName = "AbogadosDBDataSet";
            this.AbogadosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AbonoContratoAlquilerBindingSource
            // 
            this.AbonoContratoAlquilerBindingSource.DataMember = "AbonoContratoAlquiler";
            this.AbonoContratoAlquilerBindingSource.DataSource = this.AbogadosDBDataSet;
            // 
            // AbonoContratoAlquilerTableAdapter
            // 
            this.AbonoContratoAlquilerTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteAbonoContrAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 511);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteAbonoContrAlquiler";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporteAbonoContrAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbonoContratoAlquilerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AbonoContratoAlquilerBindingSource;
        private AbogadosDBDataSet AbogadosDBDataSet;
        private AbogadosDBDataSetTableAdapters.AbonoContratoAlquilerTableAdapter AbonoContratoAlquilerTableAdapter;
    }
}