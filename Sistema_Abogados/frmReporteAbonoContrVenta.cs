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
    public partial class frmReporteAbonoContrVenta : Form
    {
        public frmReporteAbonoContrVenta()
        {
            InitializeComponent();
        }

        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }

        private void frmReporteAbonoContrVenta_Load(object sender, EventArgs e)
        {
            ShowReport();

            this.reportViewer1.RefreshReport();
        }
        private void ShowReport()
        {
            DataTable dtAbonoVenta = reportes.reporteAbonoVenta(fechaDesde.ToString("yyyy-MM-dd"), fechaHasta.ToString("yyyy-MM-dd"));
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = "ReporteAbonoVenta.rdlc";
            ReportDataSource ds = new ReportDataSource("Abono", dtAbonoVenta);
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.Refresh();
        }
    }
}
