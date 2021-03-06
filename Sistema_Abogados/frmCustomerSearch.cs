﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public partial class frmCustomerSearch : Form
    {
        // variable for getting customers Status.
        public string pGetStatus
        {
            get { return Status; }
            set { Status = value; }
        }
        private string Status;
        // variable for sending customer ID.
        public string pCustSelectedID { get; set; }
        // method for loading all users status.
        private void listAllStatus()
        {
            cbStatus.Items.Clear();
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT * FROM customerStatus", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbStatus.Items.Add(re["Status"]);
                }
                con.Close();
            }
        }
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
            rbCedula.Checked = true;
            // make a try catch.
            try
            {
                if (type)
                {
                    btnSelect.Visible = true;
                    if (Status == null)
                    {
                        Status = "";
                    }
                    // load custom customer list.
                    dgvClientes.DataSource = clientes.searchCustomers("", "", "", "", Status, "");
                }
                else
                {
                    btnSelect.Visible = false;
                    // load all customers on a list.
                    listAllStatus();
                    dgvClientes.DataSource = clientes.listAllCustomers();
                }
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

        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedula.Checked)
            {
                txtCedula.Mask = "000-0000000-0";
                txtCedula.Focus();
                txtCedula.Clear();
            }
            else
            {
                txtCedula.Mask = "SE-000-0000";
                txtCedula.Focus();
                txtCedula.Clear();
            }
        }

        private void rbPasaporte_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedula.Checked)
            {
                txtCedula.Mask = "000-0000000-0";
                txtCedula.Focus();
                txtCedula.Clear();
            }
            else
            {
                txtCedula.Mask = "SE-000-0000";
                txtCedula.Focus();
                txtCedula.Clear();
            }
        }
    }
}
