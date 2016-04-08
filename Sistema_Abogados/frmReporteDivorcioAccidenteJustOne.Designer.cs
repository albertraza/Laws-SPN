namespace Sistema_Abogados
{
    partial class frmReporteDivorcioAccidenteJustOne
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
            this.ReporteDivorcioAccidenteJustOne1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AbogadosDBDataSet = new Sistema_Abogados.AbogadosDBDataSet();
            this.ReporteDivorcioAccidenteJustOneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteDivorcioAccidenteJustOneTableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.ReporteDivorcioAccidenteJustOneTableAdapter();
            this.ReporteDivorcioAccidenteJustOne1TableAdapter = new Sistema_Abogados.AbogadosDBDataSetTableAdapters.ReporteDivorcioAccidenteJustOne1TableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDivorcioAccidenteJustOne1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDivorcioAccidenteJustOneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReporteDivorcioAccidenteJustOne1BindingSource
            // 
            this.ReporteDivorcioAccidenteJustOne1BindingSource.DataMember = "ReporteDivorcioAccidenteJustOne1";
            this.ReporteDivorcioAccidenteJustOne1BindingSource.DataSource = this.AbogadosDBDataSet;
            // 
            // AbogadosDBDataSet
            // 
            this.AbogadosDBDataSet.DataSetName = "AbogadosDBDataSet";
            this.AbogadosDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReporteDivorcioAccidenteJustOneBindingSource
            // 
            this.ReporteDivorcioAccidenteJustOneBindingSource.DataMember = "ReporteDivorcioAccidenteJustOne";
            this.ReporteDivorcioAccidenteJustOneBindingSource.DataSource = this.AbogadosDBDataSet;
            // 
            // ReporteDivorcioAccidenteJustOneTableAdapter
            // 
            this.ReporteDivorcioAccidenteJustOneTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteDivorcioAccidenteJustOne1TableAdapter
            // 
            this.ReporteDivorcioAccidenteJustOne1TableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(937, 517);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReporteDivorcioAccidenteJustOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 517);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteDivorcioAccidenteJustOne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.frmReporteDivorcioAccidenteJustOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDivorcioAccidenteJustOne1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbogadosDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteDivorcioAccidenteJustOneBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource ReporteDivorcioAccidenteJustOneBindingSource;
        private AbogadosDBDataSet AbogadosDBDataSet;
        private AbogadosDBDataSetTableAdapters.ReporteDivorcioAccidenteJustOneTableAdapter ReporteDivorcioAccidenteJustOneTableAdapter;
        private System.Windows.Forms.BindingSource ReporteDivorcioAccidenteJustOne1BindingSource;
        private AbogadosDBDataSetTableAdapters.ReporteDivorcioAccidenteJustOne1TableAdapter ReporteDivorcioAccidenteJustOne1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}