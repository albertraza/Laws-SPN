using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Sistema_Abogados
{
    public partial class frmReporteDivorcioAccidenteJustOne : Form
    {
        public frmReporteDivorcioAccidenteJustOne()
        {
            InitializeComponent();
        }

        public int ID { get; set; }

        private void frmReporteDivorcioAccidenteJustOne_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AbogadosDBDataSet.ReporteDivorcioAccidenteJustOne1' table. You can move, or remove it, as needed.
            this.ReporteDivorcioAccidenteJustOne1TableAdapter.Fill(this.AbogadosDBDataSet.ReporteDivorcioAccidenteJustOne1, ID);

            this.reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);

            this.reportViewer1.RefreshReport();
        }
        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            e.DataSources.Add(new ReportDataSource("DataSet1",(object) AbogadosDBDataSet.ReporteDivorcioAccidenteJustOne2));
        }
    }
}
