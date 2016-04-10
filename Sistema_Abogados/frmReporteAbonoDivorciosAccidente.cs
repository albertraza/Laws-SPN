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
    public partial class frmReporteAbonoDivorciosAccidente : Form
    {
        public frmReporteAbonoDivorciosAccidente()
        {
            InitializeComponent();
        }

        public string fechaDesde { get; set; }
        public string fechaHasta { get; set; }

        private void frmReporteAbonoDivorciosAccidente_Load(object sender, EventArgs e)
        {
            ShowReport();
            this.reportViewer1.RefreshReport();
        }
        private void ShowReport()
        {
            DataTable dtAbonoDivorcios = reportes.reporteAbonoCasoDivorcio(fechaDesde, fechaHasta);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = "ReporteAbonoDivorcios.rdlc";
            ReportDataSource ds = new ReportDataSource("Abono", dtAbonoDivorcios);
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.Refresh();
        }
    }
}
