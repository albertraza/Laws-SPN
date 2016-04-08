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

        public string ID { get; set; }

        private void frmReporteDivorcioAccidenteJustOne_Load(object sender, EventArgs e)
        {
            ShowReport();
            reportViewer1.RefreshReport();
        }
        private void ShowReport()
        {
            DataTable dtCasoDivorcio = reportes.reporteCasoDivorcio(ID);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = "ReporteCasoDivorcio.rdlc";
            ReportDataSource ds = new ReportDataSource("CasoDivorcio", dtCasoDivorcio);
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(FacturasSubreport);
            reportViewer1.Refresh();
        }
        private void FacturasSubreport (object sender, SubreportProcessingEventArgs e)
        {
            int NumeroCaso = Convert.ToInt32(e.Parameters["NumeroCaso"].Values[0].ToString());
            DataTable dtFacturasDivorcio = reportes.reporteFacturasDivorcio(NumeroCaso.ToString());
            ReportDataSource ds = new ReportDataSource("FacturasDivorcios", dtFacturasDivorcio);
            e.DataSources.Add(ds);
        }
    }
}
