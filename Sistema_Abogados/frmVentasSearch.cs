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
    public partial class frmVentasSearch : Form
    {
        // method for cleaning every input.
        private void clean()
        {
            txtApellidoCo.Clear();
            txtApellidoVe.Clear();
            txtId.Clear();
            txtNombreCo.Clear();
            txtNombreVen.Clear();
            dgvVentas.DataSource = ventas.listAll();
        }
        public frmVentasSearch()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmVentasSearch_Load(object sender, EventArgs e)
        {
            try
            {
                dgvVentas.DataSource = ventas.listAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when buscar button is cliked.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string nombrec, apellidoc, nombrev, apellidov, id;
            if(txtApellidoCo.Text == string.Empty)
            {
                apellidoc = "";
            }
            else
            {
                apellidoc = txtApellidoCo.Text;
            }
            if(txtApellidoVe.Text == string.Empty)
            {
                apellidov = "";
            }
            else
            {
                apellidov = txtApellidoVe.Text;
            }
            if(txtId.Text == string.Empty)
            {
                id = "";
            }
            else
            {
                id = txtId.Text;
            }
            if(txtNombreCo.Text == string.Empty)
            {
                nombrec = "";
            }
            else
            {
                nombrec = txtNombreCo.Text;
            }
            if(txtNombreVen.Text == string.Empty)
            {
                nombrev = "";
            }
            else
            {
                nombrev = txtNombreVen.Text;
            }
            try
            {
                dgvVentas.DataSource = ventas.search(nombrev, apellidov, nombrec, apellidoc, id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                clean();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
