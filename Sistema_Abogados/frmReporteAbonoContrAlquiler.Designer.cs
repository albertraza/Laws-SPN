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
            this.AbonoContratoAlquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbogadosDBDataSet = new Sistema_Abogados.AbogadosDBDataSet();
            this.AbonoContratoAlquilerTableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.AbonoContratoAlquilerTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AbonoContratoAlquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AbonoContratoAlquilerBindingSource
            // 
            this.AbonoContratoAlquilerBindingSource.DataMember = "AbonoContratoAlquiler";
            this.AbonoContratoAlquilerBindingSource.DataSource = this.AbogadosDBDataSet;
            // 
            // AbogadosDBDataSet
            // 
            this.AbogadosDBDataSet.DataSetName = "AbogadosDBDataSet";
            this.AbogadosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AbonoContratoAlquilerTableAdapter
            // 
            this.AbonoContratoAlquilerTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(906, 511);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReporteAbonoContrAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 511);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteAbonoContrAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporteAbonoContrAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AbonoContratoAlquilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource AbonoContratoAlquilerBindingSource;
        private AbogadosDBDataSet AbogadosDBDataSet;
        private AbogadosDBDataSetTableAdapters.AbonoContratoAlquilerTableAdapter AbonoContratoAlquilerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}