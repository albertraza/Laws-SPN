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
    public partial class frmReporteVentasJustOne : Form
    {
        public frmReporteVentasJustOne()
        {
            InitializeComponent();
        }

        public string ID { get; set; }

        private void frmReporteVentasJustOne_Load(object sender, EventArgs e)
        {
            ShowReport();
            this.reportViewer1.RefreshReport();
        }
        private void ShowReport()
        {
            DataTable dtCasoVenta = reportes.reporteCasoVenta(ID);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = "ReporteCasoVenta.rdlc";
            ReportDataSource ds = new ReportDataSource("CasoVenta", dtCasoVenta);
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(FacturasVentaSub);
            reportViewer1.Refresh();
        }
        private void FacturasVentaSub(object sender, SubreportProcessingEventArgs e)
        {
            int NumeroCaso = Convert.ToInt32(e.Parameters["NumeroCaso"].Values[0].ToString());
            DataTable dtFacturaVenta = reportes.reporteFacturasVenta(NumeroCaso.ToString());
            ReportDataSource ds = new ReportDataSource("FacturasVenta", dtFacturaVenta);
            e.DataSources.Add(ds);
        }
    }
}
