using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Abogados
{
    public partial class frmReporteVentasGenerator : Form
    {
        string fechaDesde, fechaHasta;
        public frmReporteVentasGenerator()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmReporteAbonoContrVenta pReporte = new frmReporteAbonoContrVenta();
            pReporte.fechaDesde = Convert.ToDateTime(fechaDesde);
            pReporte.fechaHasta = Convert.ToDateTime(fechaHasta);
            pReporte.ShowDialog();
        }

        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
            try
            {
                fechaDesde = dtpDesde.Value.Date.ToString("yyyy-MM-dd");
                fechaHasta = dtpHasta.Value.Date.ToString("yyyy-MM-dd");
                dgvReporte.DataSource = reportes.ReporteAbonoContrVenta(fechaDesde, fechaHasta);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
