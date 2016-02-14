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
    public partial class frmSearchServices : Form
    {
        // method for cleaning all inputs.
        private void cleanInputs()
        {
            txtDescription.Clear();
            txtID.Clear();
            txtPre_bono.Clear();
            txtPrice.Clear();
            txtService.Clear();
            txtID.Focus();
            dgvServices.DataSource = servicios.listAllServices();
        }
        public frmSearchServices()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmSearchServices_Load(object sender, EventArgs e)
        {
            // make a try catch.
            try
            {
                // clean all inputs.
                cleanInputs();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when buscar button is clicked.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // declare all variables that will be used.
            string id, service, description, price, pre_bono;
            // evaluate all inputs values and assig then to the variables created above.
            if(txtID.Text == string.Empty)
            {
                id = "";
            }
            else
            {
                id = txtID.Text;
            }
            if(txtService.Text == string.Empty)
            {
                service = "";
            }
            else
            {
                service = txtService.Text;
            }
            if(txtDescription.Text == string.Empty)
            {
                description = "";
            }
            else
            {
                description = txtDescription.Text;
            }
            if(txtPrice.Text == string.Empty)
            {
                price = "";
            }
            else
            {
                price = txtPrice.Text;
            }
            if(txtPre_bono.Text == string.Empty)
            {
                pre_bono = "";
            }
            else
            {
                pre_bono = txtPre_bono.Text;
            }
            // end input evaliation //
            // make a try catch.
            try
            {
                // execute the search engine and overchargue then with the parameters.
                dgvServices.DataSource = servicios.searchServices(id, service, description, price, pre_bono);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when limpiar button is cliked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            // make a try catch.
            try
            {
                // clear all inputs.
                cleanInputs();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
