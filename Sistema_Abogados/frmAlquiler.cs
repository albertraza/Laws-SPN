using System;
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
    public partial class frmAlquiler : Form
    {
        // variables for saving ID's.
        private string cID = null, iID = null, gID = null;
        // menthod for disabling all inputs
        private void disableControls()
        {
            txtCellphoneGaran.Enabled = false;
            txtCellphoneInqui.Enabled = false;
            txtCustCell.Enabled = false;
            txtCustLastName.Enabled = false;
            txtCustName.Enabled = false;
            txtCustPhone.Enabled = false;
            txtLastNameGaran.Enabled = false;
            txtLastNameInqui.Enabled = false;
            txtNameGaran.Enabled = false;
            txtNameInqui.Enabled = false;
            txtPhoneGaran.Enabled = false;
            txtPhoneInqui.Enabled = false;
        }
        private void clearAll()
        {
            txtAbono.Clear();
            txtAddress.Clear();
            txtCellphoneGaran.Clear();
            txtCellphoneInqui.Clear();
            txtCustCell.Clear();
            txtCustID.Clear();
            txtCustLastName.Clear();
            txtCustName.Clear();
            txtCustPhone.Clear();
            txtDeposito.Clear();
            txtDetails.Clear();
            txtHonorarios.Clear();
            txtIDGaran.Clear();
            txtIDInqui.Clear();
            txtLastNameGaran.Clear();
            txtLastNameInqui.Clear();
            txtNameGaran.Clear();
            txtNameInqui.Clear();
            txtPhoneGaran.Clear();
            txtPhoneInqui.Clear();
            txtPriceRent.Clear();
            cID = null;
            iID = null;
            gID = null;
            txtCustID.Focus();
        }
        // method for listing all Cities.
        private void listCities()
        {
            cbCities.Items.Clear();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT City FROM Cities", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbCities.Items.Add(re["City"]);
                }
                con.Close();
            }
        }
        public frmAlquiler()
        {
            InitializeComponent();
        }

        private void txtCustNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCustCell_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchInqui_Click(object sender, EventArgs e)
        {
            frmCustomerSearch pSearch = new frmCustomerSearch();
            pSearch.type = true;
            pSearch.Text = "Busqueda de Inquilino";
            pSearch.pGetStatus = "Inquilino";
            pSearch.ShowDialog();
            if(pSearch.pCustSelectedID != null)
            {
                // assign the ID value to the variable.
                iID = pSearch.pCustSelectedID;
                // load the customer.
                clientes pClientes = clientes.getCustomerObject(pSearch.pCustSelectedID);
                if (pClientes.Status == "Inquilino")
                {
                    txtIDInqui.Text = pClientes.ID;
                    pbInquilino.Image = Image.FromFile(pClientes.Image);
                    txtNameInqui.Text = pClientes.Nombre;
                    txtLastNameInqui.Text = pClientes.Apellido;
                    txtPhoneInqui.Text = pClientes.Telefono;
                    txtCellphoneInqui.Text = pClientes.Celular;
                }
                else
                {
                    MessageBox.Show("El cliente no esta clasificado exitosamente, seleccione un Inquilino de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSearchInqui.Focus();
                }
            }
            else
            {
                MessageBox.Show("No se selecciono un inquilino", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // when Form is loaded.
        private void frmAlquiler_Load(object sender, EventArgs e)
        {
            try {
                ControlBox = false;
                disableControls();
                servicios pServicios = servicios.getServiceInfo("3");
                txtPriceRent.Text = Convert.ToDouble(pServicios.Precio).ToString("f2");
                txtAbono.Text = Convert.ToDouble(pServicios.Abono).ToString("f2");
                listCities();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gbInfoAlqui_Enter(object sender, EventArgs e)
        {

        }

        private void txtPriceRent_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // when Buscar Inquilino is clicked.
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDInqui.Text))
            {
                MessageBox.Show("El ID del Inquilino esta vacio, digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDInqui.Focus();
            }
            else
            {
                if (clientes.getCustomerObject(txtIDInqui.Text) != null)
                {
                    // assign the ID value to the variable.
                    iID = txtIDInqui.Text;
                    // load the customer.
                    clientes pClientes = clientes.getCustomerObject(txtIDInqui.Text);
                    if (pClientes.Status == "Inquilino")
                    {
                        txtNameInqui.Text = pClientes.Nombre;
                        pbInquilino.Image = Image.FromFile(pClientes.Image);
                        txtLastNameInqui.Text = pClientes.Apellido;
                        txtPhoneInqui.Text = pClientes.Telefono;
                        txtCellphoneInqui.Text = pClientes.Celular;
                    }
                    else
                    {
                        MessageBox.Show("El cliente seleccionado no ha sido clasificado correctamente, seleccione un Inquilino", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSearchInqui.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("EL Inquilino no existe, digite un ID valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        // when buscar label is clicked on garante.
        private void lblSearchGara_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIDGaran.Text))
            {
                MessageBox.Show("El ID del Garante esta vacio, digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDGaran.Focus();
            }
            else
            {
                if (clientes.getCustomerObject(txtIDGaran.Text) != null)
                {
                    // assign the ID value to the variable.
                    gID = txtIDGaran.Text;
                    // load the customer.
                    clientes pClientes = clientes.getCustomerObject(txtIDGaran.Text);
                    if (pClientes.Status == "Garante")
                    {
                        txtNameGaran.Text = pClientes.Nombre;
                        pbGarante.Image = Image.FromFile(pClientes.Image);
                        txtLastNameGaran.Text = pClientes.Apellido;
                        txtPhoneGaran.Text = pClientes.Telefono;
                        txtCellphoneGaran.Text = pClientes.Celular;
                    }
                    else
                    {
                        MessageBox.Show("No se selecciono un garante, seleccione uno correcto de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSearchGaran.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("EL Garante no existe, digite un ID valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        // when buscar cliente is clicked.
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerSearch pc = new frmCustomerSearch();
            pc.type = true;
            pc.Text = "Busqueda de Clientes";
            pc.pGetStatus = "Cliente";
            pc.ShowDialog();

            if(pc.pCustSelectedID != null)
            {
                // assign the ID value to the variable.
                cID = pc.pCustSelectedID;
                // load the customer.
                clientes pClientes = clientes.getCustomerObject(pc.pCustSelectedID);
                if (pClientes.Status == "Cliente")
                {
                    txtCustID.Text = pClientes.ID;
                    pbCliente.Image = Image.FromFile(pClientes.Image);
                    txtCustName.Text = pClientes.Nombre;
                    txtCustLastName.Text = pClientes.Apellido;
                    txtCustPhone.Text = pClientes.Telefono;
                    txtCustCell.Text = pClientes.Celular;
                }
                else
                {
                    MessageBox.Show("El cliente seleccionado no esta correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSearchCustomer.Focus();
                }
            }
            else
            {
                MessageBox.Show("NO se selecciono el cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // when buscar Garante is clicked.
        private void btnSearchGaran_Click(object sender, EventArgs e)
        {
            frmCustomerSearch pSearch = new frmCustomerSearch();
            pSearch.type = true;
            pSearch.Text = "Busqueda de Garantes";
            pSearch.pGetStatus = "Garante";
            pSearch.ShowDialog();
            if(pSearch.pCustSelectedID != null)
            {
                // assign the ID value to the variable.
                gID = pSearch.pCustSelectedID;
                // load the customer.
                clientes pClientes = clientes.getCustomerObject(pSearch.pCustSelectedID);
                if (pClientes.Status == "Garante")
                {
                    txtIDGaran.Text = pClientes.ID;
                    pbGarante.Image = Image.FromFile(pClientes.Image);
                    txtNameGaran.Text = pClientes.Nombre;
                    txtLastNameGaran.Text = pClientes.Apellido;
                    txtPhoneGaran.Text = pClientes.Telefono;
                    txtCellphoneGaran.Text = pClientes.Celular;
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado el garante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSearchGaran.Focus();
                }
            }
        }
        // when Guardar button is clicked.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // validate users input.
            if(cID == null)
            {
                MessageBox.Show("No se ha seleccionado un Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustID.Focus();
            }
            else if(iID == null)
            {
                MessageBox.Show("No se ha seleccionado un Inquilino", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDInqui.Focus();
            }
            else if(gID == null)
            {
                MessageBox.Show("No se ha seleccionado un Garante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDGaran.Focus();
            }
            else if(txtDetails.Text == string.Empty)
            {
                MessageBox.Show("Complete el detalle del Inmueble a rentar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDetails.Focus();
            }
            else if(txtHonorarios.Text == string.Empty)
            {
                MessageBox.Show("Digite el Honorario a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHonorarios.Focus();
            }
            else if(txtPriceRent.Text == string.Empty)
            {
                MessageBox.Show("Escriba la renta para el inmueble", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPriceRent.Focus();
            }
            else if(txtAbono.Text == string.Empty)
            {
                MessageBox.Show("Digite el Abono a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAbono.Focus();
            }
            else if(cbCities.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un Sector", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbCities.Focus();
            }
            else if(txtDeposito.Text == string.Empty)
            {
                MessageBox.Show("El Deposito esta vacio, Digite un deposito valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeposito.Focus();
            }
            else if(cID == iID && iID == gID && gID == cID)
            {
                MessageBox.Show("No se pueden registrar todos los datos iguales", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(cID == iID)
            {
                MessageBox.Show("El cliente y el Inquilino son las mismas personas, Seleccione diferentes clientes", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(iID == gID)
            {
                MessageBox.Show("El Inquilino Ademas del Garante son los mismos, Seleccione diferentes clientes", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(gID == cID)
            {
                MessageBox.Show("El Cliente y el Garante son los mismos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // if all inputs are filled.
                try
                {
                    // execute method for registering the data on databse
                    if (alquiler.register(cID, iID, gID, "3", txtPriceRent.Text, txtHonorarios.Text, txtDetails.Text, txtAddress.Text, sectores.getCityID(cbCities.Text), txtDeposito.Text, txtAbono.Text) > 0)
                    {
                        MessageBox.Show("Registrado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearAll();
                        listCities();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Registrar, Intentelo Nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // when Limpiar button is clicked on Clientes.
        private void btnClearCustomer_Click(object sender, EventArgs e)
        {
            txtCustCell.Clear();
            txtCustID.Clear();
            txtCustPhone.Clear();
            txtCustLastName.Clear();
            txtCustName.Clear();
            txtCustID.Focus();
            cID = null;
        }
        // when Limpiar button is clicked on Inquilinos.
        private void btnClearInqui_Click(object sender, EventArgs e)
        {
            txtIDInqui.Clear();
            txtNameInqui.Clear();
            txtLastNameInqui.Clear();
            txtPhoneInqui.Clear();
            txtCellphoneInqui.Clear();
            txtIDInqui.Focus();
            iID = null;
        }
        // when Limpiar buttin is clicked on Garante.
        private void btnClearGaran_Click(object sender, EventArgs e)
        {
            txtIDGaran.Clear();
            txtNameGaran.Clear();
            txtLastNameGaran.Clear();
            txtPhoneGaran.Clear();
            txtCellphoneGaran.Clear();
            txtIDGaran.Focus();
            gID = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
            listCities();
        }

        // when cancelar button is clicked.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMenu().Show();
        }
        // when buscar label is clicked on clientes.
        private void lblSearchCust_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustID.Text))
            {
                MessageBox.Show("El ID del cliente esta vacio, digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCustID.Focus();
            }
            else
            {
                if (clientes.getCustomerObject(txtCustID.Text) != null)
                {
                    // assign the ID value to the variable.
                    cID = txtCustID.Text;
                    // load the customer.
                    clientes pClientes = clientes.getCustomerObject(txtCustID.Text);
                    if (pClientes.Status == "Cliente")
                    {
                        txtCustName.Text = pClientes.Nombre;
                        pbCliente.Image = Image.FromFile(pClientes.Image);
                        txtCustLastName.Text = pClientes.Apellido;
                        txtCustPhone.Text = pClientes.Telefono;
                        txtCustCell.Text = pClientes.Celular;
                    }
                    else
                    {
                        MessageBox.Show("El usuario a seleccionar no esta clasificado como cliente, digite otro ID", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSearchCustomer.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("EL Cliente no existe, digite un ID valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
