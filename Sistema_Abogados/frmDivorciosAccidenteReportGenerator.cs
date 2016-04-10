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
    public partial class frmDivorciosAccidenteReportGenerator : Form
    {
        private DateTime fechaDesde, fechaHasta;
        private int ID;
        public frmDivorciosAccidenteReportGenerator()
        {
            InitializeComponent();
        }

        private void rbCedulaE_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCedulaE.Checked == true)
            {
                txtCedulaE.Mask = "000-0000000-0";
                lblCedulaDemandante.Text = "Cedula:";
            }
            else
            {
                txtCedulaE.Mask = "SE-000-0000";
                lblCedulaDemandante.Text = "Pasaporte:";
            }
        }

        private void rbPasaporteE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaE.Checked == true)
            {
                txtCedulaE.Mask = "000-0000000-0";
                lblCedulaDemandante.Text = "Cedula:";
            }
            else
            {
                txtCedulaE.Mask = "SE-000-0000";
                lblCedulaDemandante.Text = "Pasaporte:";
            }
        }

        private void rbCedulaO_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCedulaO.Checked == true)
            {
                lblCedulaO.Text = "Cedula:";
                txtCedulaO.Mask = "000-0000000-0";
            }
            else
            {
                lblCedulaO.Text = "Pasaporte:";
                txtCedulaO.Mask = "SE-000-0000";
            }
        }

        private void rbPasaporteO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaO.Checked == true)
            {
                lblCedulaO.Text = "Cedula:";
                txtCedulaO.Mask = "000-0000000-0";
            }
            else
            {
                lblCedulaO.Text = "Pasaporte:";
                txtCedulaO.Mask = "SE-000-0000";
            }
        }

        private void frmDivorciosAccidenteReportGenerator_Load(object sender, EventArgs e)
        {
            rbCedulaE.Checked = true;
            rbCedulaO.Checked = true;
            try
            {
                dgvCasos.DataSource = facturacion.listAllDivorciosAccidentes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbAbono_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAbono.Checked == true)
            {
                gbFechas.Enabled = true;
                gbInformacion.Enabled = false;
            }
            else
            {
                gbFechas.Enabled = false;
                gbInformacion.Enabled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedulaE.Clear();
            txtCedulaO.Clear();
        }
        // when button buscar caso is clicked.
        private void btnBuscarCaso_Click(object sender, EventArgs e)
        {
            string cedulaE, cedulaO;
            if (txtCedulaE.MaskCompleted)
            {
                cedulaE = txtCedulaE.Text;
            }
            else
            {
                cedulaE = "";
            }
            if (txtCedulaO.MaskCompleted)
            {
                cedulaO = txtCedulaO.Text;
            }
            else
            {
                cedulaO = "";
            }
            try {
                dgvCasos.DataSource = facturacion.searchDivorciosAccidentes(cedulaE, cedulaO);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when generar reporte button is clicked on informacion casos.
        private void btnGenerarReporteCaso_Click(object sender, EventArgs e)
        {
            try {
                if (dgvCasos.SelectedRows.Count == 1)
                {
                    dgvPreviewReporte.DataSource = reportes.reporteCasoDivorcio(dgvCasos.CurrentRow.Cells[2].Value.ToString());
                    ID = Convert.ToInt32(dgvCasos.CurrentRow.Cells[2].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Selecciona un caso de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when btn generar reporte is clicked on fechas.
        private void btnGenerarReporteAbono_Click(object sender, EventArgs e)
        {
            try {
                string Desde, hasta;
                Desde = dtpDesde.Value.Date.ToString("yyyy-MM-dd");
                hasta = dtpHasta.Value.Date.ToString("yyyy-MM-dd");
                dgvPreviewReporte.DataSource = reportes.reporteAbonoCasoDivorcio(fechaDesde.ToString("yyyy-MM-dd"), fechaHasta.ToString("yyyy-MM-dd"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when btn Imprimir is clicked.
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(rbAbono.Checked == true)
            {
                fechaDesde = dtpDesde.Value.Date;
                fechaHasta = dtpHasta.Value.Date;
                frmReporteAbonoDivorciosAccidente pReporte = new frmReporteAbonoDivorciosAccidente();
                pReporte.fechaDesde = fechaDesde.ToString("yyyy-MM-dd");
                pReporte.fechaHasta = fechaHasta.ToString("yyyy-MM-dd");
                pReporte.ShowDialog();
            }
            else
            {
                frmReporteDivorcioAccidenteJustOne pReporte = new frmReporteDivorcioAccidenteJustOne();
                pReporte.ID = ID.ToString();
                pReporte.ShowDialog();
            }
        }
    }
}
