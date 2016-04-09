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
        string fechaDesde, fechaHasta, ID;
        public frmReporteVentasGenerator()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (rbAbono.Checked)
            {
                frmReporteAbonoContrVenta pReporte = new frmReporteAbonoContrVenta();
                pReporte.fechaDesde = Convert.ToDateTime(fechaDesde);
                pReporte.fechaHasta = Convert.ToDateTime(fechaHasta);
                pReporte.ShowDialog();
            }
            else
            {
                frmReporteVentasJustOne pReporte = new frmReporteVentasJustOne();
                pReporte.ID = ID;
                pReporte.ShowDialog();
            }
        }

        private void rbAbono_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbono.Checked)
            {
                gbFechas.Enabled = true;
                gbCasos.Enabled = false;
            }
            else
            {
                gbFechas.Enabled = false;
                gbCasos.Enabled = true;
            }
        }

        private void rbCaso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbono.Checked)
            {
                gbFechas.Enabled = true;
                gbCasos.Enabled = false;
            }
            else
            {
                gbFechas.Enabled = false;
                gbCasos.Enabled = true;
            }
        }

        private void frmReporteVentasGenerator_Load(object sender, EventArgs e)
        {
            try {
                dgvCasos.DataSource = facturacion.listAllVentas();
                rbCedulaVe.Checked = true;
                rbCedulaCo.Checked = true;
                rbAbono.Checked = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedulaVe, cedulaCo;
            if (txtCedulaCo.MaskCompleted)
            {
                cedulaCo = txtCedulaCo.Text;
            }
            else
            {
                cedulaCo = "";
            }
            if (txtCedulaVe.MaskCompleted)
            {
                cedulaVe = txtCedulaVe.Text;
            }
            else
            {
                cedulaVe = "";
            }
            try
            {
                dgvCasos.DataSource = facturacion.searchVentas(cedulaVe, cedulaCo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedulaCo.Clear();
            txtCedulaVe.Clear();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (dgvCasos.SelectedRows.Count == 1)
            {
                ID = dgvCasos.CurrentRow.Cells[2].Value.ToString();
                dgvReporte.DataSource = reportes.reporteCasoVenta(ID);
            }
            else
            {
                MessageBox.Show("Seleccione un caso de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrearReporte_Click(object sender, EventArgs e)
        {
            try
            {
                fechaDesde = dtpDesde.Value.Date.ToString("yyyy-MM-dd");
                fechaHasta = dtpHasta.Value.Date.ToString("yyyy-MM-dd");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
