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
    public partial class frmReporteAbonoContrAlquiler : Form
    {
        public frmReporteAbonoContrAlquiler()
        {
            InitializeComponent();
        }

        public string ID { get; set; }

        private void frmReporteAbonoContrAlquiler_Load(object sender, EventArgs e)
        {
            ShowReport();
            this.reportViewer1.RefreshReport();
        }
        private void ShowReport()
        {
            DataTable dtCasoAlquiler = reportes.reporteCasoAlquiler(ID);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = "ReporteCasoAlquiler.rdlc";
            ReportDataSource ds = new ReportDataSource("CasoAlquiler", dtCasoAlquiler);
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(FacturasSub);
            reportViewer1.Refresh();
        }
        private void FacturasSub(object sender, SubreportProcessingEventArgs e)
        {
            string ID = e.Parameters["NumeroCaso"].Values[0].ToString();
            DataTable dtFacturas = reportes.reporteFacturasCasoAlquiler(ID);
            ReportDataSource ds = new ReportDataSource("FacturasAlquiler", dtFacturas);
            e.DataSources.Add(ds);
        }
    }
}
