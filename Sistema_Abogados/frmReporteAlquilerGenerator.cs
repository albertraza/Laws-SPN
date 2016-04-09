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
    public partial class frmReporteAlquilerGenerator : Form
    {
        // variable for storing the Case ID.
        string ID, fechaDes, fechaHas;

        public frmReporteAlquilerGenerator()
        {
            InitializeComponent();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            try {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void frmReporteAlquilerGenerator_Load(object sender, EventArgs e)
        {
            try
            {
                rbAbono.Checked = true;
                rbCedulaCli.Checked = true;
                rbCedulaIn.Checked = true;
                dgvCasos.DataSource = facturacion.listAllRent();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbCedulaCli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaCli.Checked)
            {
                txtCedulaCl.Mask = "000-0000000-0";
            }
            else
            {
                txtCedulaCl.Mask = "SE-000-0000";
            }
        }

        private void rbPasaporte_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaCli.Checked)
            {
                txtCedulaCl.Mask = "000-0000000-0";
            }
            else
            {
                txtCedulaCl.Mask = "SE-000-0000";
            }
        }

        private void rbCedulaIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaIn.Checked)
            {
                txtCedulaIn.Mask = "000-0000000-0";
            }
            else
            {
                txtCedulaIn.Mask = "SE-000-0000";
            }
        }

        private void rbPasaporteIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaIn.Checked)
            {
                txtCedulaIn.Mask = "000-0000000-0";
            }
            else
            {
                txtCedulaIn.Mask = "SE-000-0000";
            }
        }

        private void gbCaso_Enter(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCedulaCl.Clear();
            txtCedulaIn.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedulaCLi, cedulaIn;
            if (txtCedulaCl.MaskCompleted)
            {
                cedulaCLi = txtCedulaCl.Text;
            }
            else
            {
                cedulaCLi = "";
            }
            if (txtCedulaIn.MaskCompleted)
            {
                cedulaIn = txtCedulaIn.Text;
            }
            else
            {
                cedulaIn = "";
            }
            try
            {
                dgvCasos.DataSource = facturacion.searchRent(cedulaCLi, cedulaIn, "");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if(dgvCasos.SelectedRows.Count == 1)
            {
                ID = dgvCasos.CurrentRow.Cells[2].Value.ToString();
                dgvReporte.DataSource = reportes.reporteCasoAlquiler(ID);
            }
            else
            {
                MessageBox.Show("Seleccione un caso de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (rbAbono.Checked)
            {

            }
            else
            {
                frmReporteAbonoContrAlquiler pReporte = new frmReporteAbonoContrAlquiler();
                pReporte.ID = ID;
                pReporte.ShowDialog();
            }
        }

        private void rbAbono_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbono.Checked)
            {
                gbDates.Enabled = true;
                gbCaso.Enabled = false;
            }
            else
            {
                gbDates.Enabled = false;
                gbCaso.Enabled = true;
            }
        }

        private void rbCaso_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAbono.Checked)
            {
                gbDates.Enabled = true;
                gbCaso.Enabled = false;
            }
            else
            {
                gbDates.Enabled = false;
                gbCaso.Enabled = true;
            }
        }
    }
}
