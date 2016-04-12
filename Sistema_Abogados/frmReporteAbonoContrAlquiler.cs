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
        public string fechaDesde { get; set; }
        public string fechaHasta { get; set; }
        public string report { get; set; }

        private void frmReporteAbonoContrAlquiler_Load(object sender, EventArgs e)
        {
            if (report == null) report = "";

            switch (report) {

                case "Caso":
                    ShowReportCase();
                    this.reportViewer1.RefreshReport();
                    break;

                case "Abono":
                    ShowReportAbono();
                    this.reportViewer1.RefreshReport();
                    break;
                case "Cotizacion":
                    ShowCotizacion();
                    this.reportViewer1.RefreshReport();
                    break;
                default:
                    MessageBox.Show("No se reconoce el servicio de reporte a utilizar, la aplicacion de cerrara", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    break;
            }
        }
        private void ShowReportCase()
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
        private void ShowReportAbono()
        {
            DataTable dtAbonoAlquiler = reportes.reporteAbonoContrAlquiler(fechaDesde, fechaHasta);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = "ReporteAbonoContrAlquiler.rdlc";
            ReportDataSource ds = new ReportDataSource("Abono", dtAbonoAlquiler);
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.Refresh();
        }
        private void ShowCotizacion()
        {
            DataTable dtCotizacion = reportes.cotizacionAlquiler(ID);
            reportViewer1.Reset();
            reportViewer1.LocalReport.ReportPath = "CotizacionAlquiler.rdlc";
            ReportDataSource ds = new ReportDataSource("Cotizacion", dtCotizacion);
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.Refresh();
        }
    }
}
