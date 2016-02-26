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
    public partial class frmCustomerSearch : Form
    {
        // variable for sending customer ID.
        public string pCustSelectedID { get; set; }
        // for form style.
        public bool type { get; set; }
        // method for cleaning all values.
        private void clearInputs()
        {
            txtName.Focus();
            txtApellido.Clear();
            txtUserID.Clear();
            txtCedula.Clear();
            txtName.Clear();
            cbStatus.Text = "";
            dtpRegisterDate.Value = DateTime.Now;
            dgvClientes.DataSource = clientes.listAllCustomers();
        }
        public frmCustomerSearch()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmCustomerSearch_Load(object sender, EventArgs e)
        {
            // make a try catch.
            try
            {
                if (type)
                {
                    btnSelect.Visible = true;
                }
                else
                {
                    btnSelect.Visible = false;
                }
                // load all customers on a list.
                dgvClientes.DataSource = clientes.listAllCustomers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when Buscar button is clicked.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id, name, lastname, cedula, status, registerdate;

            // validate all users input for correct search criteria.
            if(txtName.Text == string.Empty)
            {
                name = "";
            }
            else
            {
                name = txtName.Text;
            }
            if(txtApellido.Text == string.Empty)
            {
                lastname = "";
            }
            else
            {
                lastname = txtApellido.Text;
            }
            if(txtCedula.Text == string.Empty)
            {
                cedula = "";
            }
            else
            {
                cedula = txtCedula.Text;
            }
            if(txtUserID.Text == string.Empty)
            {
                id = "";
            }
            else
            {
                id = txtUserID.Text;
            }
            if (dtpRegisterDate.Value.Date != DateTime.Today.Date)
            {
                registerdate = dtpRegisterDate.Value.Date.ToString();
            }
            else
            {
                registerdate = "";
            }
            if(cbStatus.Text == string.Empty)
            {
                status = "";
            }
            else
            {
                status = cbStatus.Text;
            }
            try
            {
                dgvClientes.DataSource = clientes.searchCustomers(id, name, lastname, cedula, status, registerdate);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when limpiar input is cliked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                clearInputs();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when Ver Cliente is clicked.
        private void btnShow_Click(object sender, EventArgs e)
        {
            // validate and take values from data grid view.
            if(dgvClientes.SelectedRows.Count == 1)
            {
                // declare a from object.
                frmShowCustomers c = new frmShowCustomers();
                // assig the values and save then on the form getter data.
                c.getID = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un cliente de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //when seleccionar button is clicked.
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(dgvClientes.SelectedRows.Count == 1)
            {
                pCustSelectedID = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
