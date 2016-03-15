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
    public partial class frmSearchFacturas : Form
    {
        //method for cleaning all inputs.
        private void cleanInpust()
        {
            txtApellido.Clear();
            txtCedula.Clear();
            txtNombre.Clear();
            txtNumeroCaso.Clear();
            txtPasaporte.Clear();
            rbDivorcioAccidente.Checked = true;
            rbCedula.Checked = true;
            if(rbDivorcioAccidente.Checked == true)
            {
                dgvFacturas.DataSource = factura.listAllDivorciosAccidenteFacturas();
            }
            else if(rbVentas.Checked == true)
            {
                dgvFacturas.DataSource = factura.listAllVentafacturas();
            }
            else if(rbAlquiler.Checked == true)
            {
                dgvFacturas.DataSource = factura.listAllRentFacturas();
            }
            txtNumeroCaso.Focus();
        }
        public frmSearchFacturas()
        {
            InitializeComponent();
        }
        // when cbCedula is clicked.
        private void cbCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedula.Checked)
            {
                txtCedula.Enabled = true;
                txtCedula.Focus();
                txtPasaporte.Enabled = false;
                txtPasaporte.Clear();
            }
            else
            {
                txtPasaporte.Enabled = true;
                txtPasaporte.Focus();
                txtCedula.Enabled = false;
                txtCedula.Clear();
            }
        }
        // when cbPasaporte is checked.
        private void cbPasaporte_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedula.Checked)
            {
                txtCedula.Enabled = true;
                txtCedula.Focus();
                txtPasaporte.Enabled = false;
                txtPasaporte.Clear();
            }
            else
            {
                txtPasaporte.Enabled = true;
                txtPasaporte.Focus();
                txtCedula.Enabled = false;
                txtCedula.Clear();
            }
        }
        // when rbCedula is checked.
        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedula.Checked)
            {
                txtCedula.Enabled = true;
                txtCedula.Focus();
                txtPasaporte.Enabled = false;
                txtPasaporte.Clear();
            }
            else
            {
                txtPasaporte.Enabled = true;
                txtPasaporte.Focus();
                txtCedula.Enabled = false;
                txtCedula.Clear();
            }
        }
        // when rbPasaporte is checked.
        private void rbPasaporte_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedula.Checked)
            {
                txtCedula.Enabled = true;
                txtCedula.Focus();
                txtPasaporte.Enabled = false;
                txtPasaporte.Clear();
            }
            else
            {
                txtPasaporte.Enabled = true;
                txtPasaporte.Focus();
                txtCedula.Enabled = false;
                txtCedula.Clear();
            }
        }
        // when form is loaded.
        private void frmSearchFacturas_Load(object sender, EventArgs e)
        {
            try
            {
                cleanInpust();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when divorcios checked is changed.
        private void rbDivorcioAccidente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturas.DataSource = factura.listAllDivorciosAccidenteFacturas();
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturas.DataSource = factura.listAllVentafacturas();
                }
                else if (rbAlquiler.Checked == true)
                {
                    dgvFacturas.DataSource = factura.listAllRentFacturas();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when ventas rb is checked.
        private void rbVentas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturas.DataSource = factura.listAllDivorciosAccidenteFacturas();
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturas.DataSource = factura.listAllVentafacturas();
                }
                else if (rbAlquiler.Checked == true)
                {
                    dgvFacturas.DataSource = factura.listAllRentFacturas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when alquiler rb is checked.
        private void rbAlquiler_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturas.DataSource = factura.listAllDivorciosAccidenteFacturas();
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturas.DataSource = factura.listAllVentafacturas();
                }
                else if (rbAlquiler.Checked == true)
                {
                    dgvFacturas.DataSource = factura.listAllRentFacturas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when buscar button is clicked.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string Ncaso, nombre, apellido, cedulaPasaporte;
            if(txtApellido.Text == string.Empty)
            {
                apellido = "";
            }
            else
            {
                apellido = txtApellido.Text;
            }
            if(txtNombre.Text == string.Empty)
            {
                nombre = "";
            }
            else
            {
                nombre = txtNombre.Text;
            }
            if(rbCedula.Checked == true)
            {
                if (txtCedula.MaskCompleted)
                {
                    cedulaPasaporte = txtCedula.Text;
                }
                else
                {
                    cedulaPasaporte = "";
                }
            }
            else
            {
                if (txtPasaporte.MaskCompleted)
                {
                    cedulaPasaporte = txtPasaporte.Text;
                }
                else
                {
                    cedulaPasaporte = "";
                }
            }
            if(txtNumeroCaso.Text == string.Empty)
            {
                Ncaso = "";
            }
            else
            {
                Ncaso = txtNumeroCaso.Text;
            }
            try
            {
                if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturas.DataSource = factura.searchFacturasDivorciosAccidente(Ncaso, cedulaPasaporte, nombre, apellido);
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturas.DataSource = factura.searchFacturasVenta(Ncaso, cedulaPasaporte, nombre, apellido);
                }
                else if (rbAlquiler.Checked == true)
                {
                    dgvFacturas.DataSource = factura.searchFacturasRent(Ncaso, cedulaPasaporte, nombre, apellido);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when limpiar button is clicked.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                cleanInpust();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when imprimir button is clicked.
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbDivorcioAccidente.Checked == true)
                {
                    if (dgvFacturas.SelectedRows.Count == 1)
                    {
                        frmFacturaDivorciosAccidente pFactura = new frmFacturaDivorciosAccidente();
                        pFactura.getID = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[0].Value);
                        pFactura.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una factura de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rbVentas.Checked == true)
                {
                    if (dgvFacturas.SelectedRows.Count == 1)
                    {
                        frmFacturaVenta pFac = new frmFacturaVenta();
                        pFac.getID = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[0].Value);
                        pFac.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una factura de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rbAlquiler.Checked == true)
                {
                    if (dgvFacturas.SelectedRows.Count == 1)
                    {
                        frmFacturaAlquiler pFactura = new frmFacturaAlquiler();
                        pFactura.getID = Convert.ToInt32(dgvFacturas.CurrentRow.Cells[0].Value);
                        pFactura.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una factura de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
