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
        // cliente object for getting rent ID.
        clientes pInquilino, pCliente, pGarante;
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
            txtMensualidad.Enabled = false;
            txtTotalPagar.Enabled = false;
            txtISRContr.Enabled = false;
            txtITEBISContr.Enabled = false;
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
            txtComision.Clear();
            txtITEBISContr.Clear();
            txtISRContr.Clear();
            txtTotalPagar.Clear();
            cID = null;
            iID = null;
            gID = null;
            txtCustID.Focus();
            pbCliente.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
            pbGarante.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
            pbInquilino.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
            txtMensualidad.Clear();
            rbCedulaCli.Checked = true;
            rbCedulaGa.Checked = true;
            rbCedulaIn.Checked = true;
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
                clientes pClientes = clientes.getCustomerObject(pSearch.pCustSelectedID, "");
                if (pClientes.Status == "Inquilino")
                {
                    pInquilino = pClientes;
                    txtIDInqui.Text = pClientes.ID;
                    pbInquilino.Image = Image.FromFile(pClientes.Image);
                    txtNameInqui.Text = pClientes.Nombre;
                    txtLastNameInqui.Text = pClientes.Apellido;
                    txtPhoneInqui.Text = pClientes.Telefono;
                    txtCellphoneInqui.Text = pClientes.Celular;
                    txtCedulaIn.Text = pClientes.Cedula;
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
                clearAll();
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
            string ID, Cedula;
            if (string.IsNullOrEmpty(txtIDInqui.Text))
            {
                ID = "";
            }
            else
            {
                ID = txtIDInqui.Text;
            }
            if (txtCedulaIn.MaskCompleted)
            {
                Cedula = txtCedulaIn.Text;
            }
            else
            {
                Cedula = "";
            }
            if (clientes.getCustomerObject(txtIDInqui.Text, txtCedulaIn.Text) != null)
            {
                // assign the ID value to the variable.
                iID = txtIDInqui.Text;
                // load the customer.
                clientes pClientes = clientes.getCustomerObject(ID, Cedula);
                if (pClientes.Status == "Inquilino")
                {
                    pInquilino = pClientes;
                    txtNameInqui.Text = pClientes.Nombre;
                    pbInquilino.Image = Image.FromFile(pClientes.Image);
                    txtLastNameInqui.Text = pClientes.Apellido;
                    txtPhoneInqui.Text = pClientes.Telefono;
                    txtCellphoneInqui.Text = pClientes.Celular;
                    txtCedulaIn.Text = pClientes.Cedula;
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
        // when buscar label is clicked on garante.
        private void lblSearchGara_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ID, cedula;
            if (string.IsNullOrEmpty(txtIDGaran.Text))
            {
                ID = "";
            }
            else
            {
                ID = txtIDGaran.Text;
            }
            if (txtCedulaGa.MaskCompleted)
            {
                cedula = txtCedulaGa.Text;
            }
            else
            {
                cedula = "";
            }
            if (clientes.getCustomerObject(ID, cedula) != null)
            {
                // assign the ID value to the variable.
                gID = txtIDGaran.Text;
                // load the customer.
                clientes pClientes = clientes.getCustomerObject(ID, cedula);
                if (pClientes.Status == "Garante")
                {
                    pGarante = pClientes;
                    txtNameGaran.Text = pClientes.Nombre;
                    pbGarante.Image = Image.FromFile(pClientes.Image);
                    txtLastNameGaran.Text = pClientes.Apellido;
                    txtPhoneGaran.Text = pClientes.Telefono;
                    txtCellphoneGaran.Text = pClientes.Celular;
                    txtCedulaGa.Text = pClientes.Cedula;
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
                clientes pClientes = clientes.getCustomerObject(pc.pCustSelectedID, "");
                if (pClientes.Status == "Cliente")
                {
                    pCliente = pClientes;
                    txtCustID.Text = pClientes.ID;
                    pbCliente.Image = Image.FromFile(pClientes.Image);
                    txtCustName.Text = pClientes.Nombre;
                    txtCustLastName.Text = pClientes.Apellido;
                    txtCustPhone.Text = pClientes.Telefono;
                    txtCustCell.Text = pClientes.Celular;
                    txtCedulaClie.Text = pCliente.Cedula;
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
                clientes pClientes = clientes.getCustomerObject(pSearch.pCustSelectedID, "");
                if (pClientes.Status == "Garante")
                {
                    pGarante = pClientes;
                    txtIDGaran.Text = pClientes.ID;
                    pbGarante.Image = Image.FromFile(pClientes.Image);
                    txtNameGaran.Text = pClientes.Nombre;
                    txtLastNameGaran.Text = pClientes.Apellido;
                    txtPhoneGaran.Text = pClientes.Telefono;
                    txtCellphoneGaran.Text = pClientes.Celular;
                    txtCedulaGa.Text = pClientes.Cedula;
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
            else if(txtMensualidad.Text == string.Empty)
            {
                MessageBox.Show("No se ha calculado la mensualidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCalcular.Focus();
            }
            else if(Convert.ToDouble(txtTotalPagar.Text) <= 0)
            {
                MessageBox.Show("El Total a Pagar no puede estar en 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAbono.Focus();
            }
            else if(txtTotalPagar.Text == string.Empty)
            {
                MessageBox.Show("No se ha calculado el total a pagar, digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCalcular.Focus();
            }
            else
            {
                // if all inputs are filled.
                try
                {
                    // execute method for registering the data on databse
                    if (alquiler.register(cID, iID, gID, "3", txtMensualidad.Text , txtHonorarios.Text, txtDetails.Text, txtAddress.Text, sectores.getCityID(cbCities.Text), txtDeposito.Text, txtAbono.Text, txtPriceRent.Text, txtTotalPagar.Text) > 0)
                    {
                        MessageBox.Show("Registrado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        facturacion.registerRent(cID, "3", alquiler.getID(pInquilino.Nombre, pInquilino.Apellido, pCliente.Nombre, pCliente.Apellido, pGarante.Nombre, pGarante.Apellido, pInquilino.Cedula, pCliente.Cedula, pGarante.Cedula), txtMensualidad.Text, txtDeposito.Text, txtTotalPagar.Text);
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
            pbCliente.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
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
            pbInquilino.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
        }
        // when calcular button is cliked.
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(txtPriceRent.Text == string.Empty)
            {
                MessageBox.Show("El Alquiler esta vacio", "Menjase", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPriceRent.Focus();
            }
            else if(txtHonorarios.Text == string.Empty)
            {
                MessageBox.Show("El honorario esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHonorarios.Focus();
            }
            else if (txtDeposito.Text == string.Empty)
            {
                MessageBox.Show("El deposito esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeposito.Focus();
            }
            else if(txtComision.Text == string.Empty)
            {
                MessageBox.Show("La comision por el contrato de Alquiler esta vacia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtComision.Focus();
            }
            else if(txtAbono.Text == string.Empty)
            {
                MessageBox.Show("El abono esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAbono.Focus();
            }
            else
            {
                if (Convert.ToDouble(txtPriceRent.Text) <= 0)
                {
                    MessageBox.Show("El alquiler no debe ser menor o igual a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPriceRent.Focus();
                }
                else if (Convert.ToDouble(txtHonorarios.Text) <= 0)
                {
                    MessageBox.Show("El honorario no puede ser menor o igual a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHonorarios.Focus();
                }
                else if (Convert.ToDouble(txtDeposito.Text) <= 0)
                {
                    MessageBox.Show("El deposito debe ser mayor a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDeposito.Focus();
                }
                else if(Convert.ToDouble(txtComision.Text) <= 0)
                {
                    MessageBox.Show("La comision por contrato de alquiler no debe ser menor o igual a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtComision.Focus();
                }
                else
                {
                    txtMensualidad.Text = (Convert.ToDouble(txtPriceRent.Text) + Convert.ToDouble(txtHonorarios.Text)).ToString("f2");
                    txtTotalPagar.Text = ((Convert.ToDouble(txtPriceRent.Text) * Convert.ToDouble(txtDeposito.Text)) + (Convert.ToDouble(txtPriceRent.Text) * Convert.ToDouble(txtComision.Text))).ToString("f2");
                    txtITEBISContr.Text = (Convert.ToDouble(txtTotalPagar.Text) * 0.18).ToString("f2");
                    txtISRContr.Text = (Convert.ToDouble(txtTotalPagar.Text) * 0.10).ToString("f2");
                    txtTotalPagar.Text = (Convert.ToDouble(txtTotalPagar.Text) + Convert.ToDouble(txtISRContr.Text) + Convert.ToDouble(txtITEBISContr.Text)).ToString("f2");
                    txtTotalPagar.Text = (Convert.ToDouble(txtTotalPagar.Text) - Convert.ToDouble(txtAbono.Text)).ToString("f2");
                }
            }

        }

        private void rbCedulaCli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaCli.Checked == true)
            {
                txtCedulaClie.Mask = "000-0000000-0";
                lblCedula.Text = "Cedula:";
            }
            else
            {
                txtCedulaClie.Mask = "SE-000-0000";
                lblCedula.Text = "Pasaporte:";
            }
        }

        private void rbPasaporteCli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaCli.Checked == true)
            {
                txtCedulaClie.Mask = "000-0000000-0";
                lblCedula.Text = "Cedula:";
            }
            else
            {
                txtCedulaClie.Mask = "SE-000-0000";
                lblCedula.Text = "Pasaporte:";
            }
        }

        private void rbCedulaIn_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCedulaIn.Checked == true)
            {
                txtCedulaIn.Mask = "000-0000000-0";
                lblCedulaIn.Text = "Cedula:";
            }
            else
            {
                txtCedulaIn.Mask = "SE-000-0000";
                lblCedulaIn.Text = "Pasaporte:";
            }
        }

        private void rbPasaporteIn_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaIn.Checked == true)
            {
                txtCedulaIn.Mask = "000-0000000-0";
                lblCedulaIn.Text = "Cedula:";
            }
            else
            {
                txtCedulaIn.Mask = "SE-000-0000";
                lblCedulaIn.Text = "Pasaporte:";
            }
        }

        private void rbCedulaGa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCedulaGa.Checked == true)
            {
                txtCedulaGa.Mask = "000-0000000-0";
                lblCedulaGa.Text = "Cedula:";
            }
            else
            {
                txtCedulaGa.Mask = "SE-000-0000";
                lblCedulaGa.Text = "Pasaporte:";
            }
        }

        private void rbPasaporteGa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaGa.Checked == true)
            {
                txtCedulaGa.Mask = "000-0000000-0";
                lblCedulaGa.Text = "Cedula:";
            }
            else
            {
                txtCedulaGa.Mask = "SE-000-0000";
                lblCedulaGa.Text = "Pasaporte:";
            }
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

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
            pbGarante.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
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
            string ID, cedula;
            if (string.IsNullOrEmpty(txtCustID.Text))
            {
                ID = "";
            }
            else
            {
                ID = txtCustID.Text;
            }
            if (txtCedulaClie.MaskCompleted)
            {
                cedula = txtCedulaClie.Text;
            }
            else
            {
                cedula = "";
            }
            if (clientes.getCustomerObject(ID, cedula) != null)
            {
                // assign the ID value to the variable.
                cID = txtCustID.Text;
                // load the customer.
                clientes pClientes = clientes.getCustomerObject(ID, cedula);
                if (pClientes.Status == "Cliente")
                {
                    pCliente = pClientes;
                    txtCustName.Text = pClientes.Nombre;
                    pbCliente.Image = Image.FromFile(pClientes.Image);
                    txtCustLastName.Text = pClientes.Apellido;
                    txtCustPhone.Text = pClientes.Telefono;
                    txtCustCell.Text = pClientes.Celular;
                    txtCedulaClie.Text = pClientes.Cedula;
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
