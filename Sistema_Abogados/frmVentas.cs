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
    public partial class frmVentas : Form
    {
        // variables for storing customer ID.
        private string vID = null, cID = null;
        // method for listing all thisngs for selling.
        private void listThings()
        {
            cbInmueble.Items.Clear();
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT * FROM servicesSeller", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbInmueble.Items.Add(re["Ventas"]);
                }
                con.Close();
            }
        }
        // disable all inputs.
        private void disableInputs()
        {
            txtCedulaBuy.Enabled = false;
            txtCedulaSeller.Enabled = false;
            txtCelularBuy.Enabled = false;
            txtCelularSeller.Enabled = false;
            txtLastNameBuy.Enabled = false;
            txtLastNameSeller.Enabled = false;
            txtNameBuy.Enabled = false;
            txtNameSeller.Enabled = false;
            txtPhoneBuy.Enabled = false;
            txtPhoneSeller.Enabled = false;
            txtIDSeller.Focus();
        }
        // method for cleaning everything.
        private void cleanEverything()
        {
            txtAbono.Clear();
            txtCedulaBuy.Clear();
            txtCedulaSeller.Clear();
            txtCelularBuy.Clear();
            txtCelularSeller.Clear();
            txtDescripcion.Clear();
            txtHonorarios.Clear();
            txtIDBuy.Clear();
            txtIDSeller.Clear();
            txtLastNameBuy.Clear();
            txtLastNameSeller.Clear();
            txtMatricula.Clear();
            txtNameBuy.Clear();
            txtNameSeller.Clear();
            txtPhoneBuy.Clear();
            txtPhoneSeller.Clear();
            txtPrecioVenta.Clear();
            listThings();
            cID = null;
            vID = null;
        }
        public frmVentas()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmVentas_Load(object sender, EventArgs e)
        {
            try
            {
                listThings();
                disableInputs();
                ControlBox = false;
                txtMatricula.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when cancelar button is clicked.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmMenu().Show();
        }
        // when cb is cliked.
        private void cbInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescripcion.Clear();
            txtDescripcion.Text = cbInmueble.Text + "- ";
            if(cbInmueble.Text == "Vehiculos")
            {
                txtMatricula.Enabled = true;
            }
            else
            {
                txtMatricula.Enabled = false;
            }
        }
        // when buscar label is clicked.
        private void lblSearchSeller_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtIDSeller.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado el ID del vendedor, Digte uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDSeller.Focus();
            }
            else
            {
                try
                {
                    if (clientes.getCustomerObject(txtIDSeller.Text) != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(txtIDSeller.Text);
                        vID = pClientes.ID;
                        txtNameSeller.Text = pClientes.Nombre;
                        txtLastNameSeller.Text = pClientes.Apellido;
                        txtCedulaSeller.Text = pClientes.Cedula;
                        txtCelularSeller.Text = pClientes.Celular;
                        txtPhoneSeller.Text = pClientes.Telefono;
                    }
                    else
                    {
                        MessageBox.Show("No existe el vendedor, digite un ID valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDSeller.Clear();
                        txtIDSeller.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // when buscar label is clicked.
        private void lblSearchBuy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtIDBuy.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado el ID del comprador, Digte uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDSeller.Focus();
            }
            else
            {
                try
                {
                    if (clientes.getCustomerObject(txtIDBuy.Text) != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(txtIDBuy.Text);
                        cID = pClientes.ID;
                        txtNameBuy.Text = pClientes.Nombre;
                        txtLastNameBuy.Text = pClientes.Apellido;
                        txtCedulaBuy.Text = pClientes.Cedula;
                        txtCelularBuy.Text = pClientes.Celular;
                        txtPhoneBuy.Text = pClientes.Telefono;
                    }
                    else
                    {
                        MessageBox.Show("No existe el comprador, digite un ID valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDBuy.Clear();
                        txtIDBuy.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // when buscar button is clicked.
        private void btnSearchSeller_Click(object sender, EventArgs e)
        {
            frmCustomerSearch pCustomer = new frmCustomerSearch();
            pCustomer.type = true;
            pCustomer.Text = "Buscar Vendedor";
            pCustomer.ShowDialog();
            if(pCustomer.pCustSelectedID != null)
            {
                try
                {
                    if (clientes.getCustomerObject(pCustomer.pCustSelectedID) != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(pCustomer.pCustSelectedID);
                        vID = pClientes.ID;
                        txtIDSeller.Text = pClientes.ID;
                        txtNameSeller.Text = pClientes.Nombre;
                        txtLastNameSeller.Text = pClientes.Apellido;
                        txtCedulaSeller.Text = pClientes.Cedula;
                        txtCelularSeller.Text = pClientes.Celular;
                        txtPhoneSeller.Text = pClientes.Telefono;
                    }
                    else
                    {
                        MessageBox.Show("No existe el vendedor, digite un ID valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDSeller.Clear();
                        txtIDSeller.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se selecciono un Vendedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // when limpiar todo button is clicked.
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            try
            {
                cleanEverything();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when guardar button is clicked.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // variable for validating mask texbox.
            bool inputs = true;
            // inputs valiadations.
            if (vID == null)
            {
                MessageBox.Show("No se ha cargado el vendedor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDSeller.Focus();
            }
            else if(cID == null)
            {
                MessageBox.Show("No se ha cargado el comprador", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDBuy.Focus();
            }
            else if (cbInmueble.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado un inmueble", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbInmueble.Focus();
            }
            else if(txtHonorarios.Text == string.Empty)
            {
                MessageBox.Show("Los honorarios estan vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHonorarios.Focus();
            }
            else if(txtAbono.Text == string.Empty)
            {
                MessageBox.Show("El abono no se ha registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAbono.Focus();
            }
            else if(txtPrecioVenta.Text == string.Empty)
            {
                MessageBox.Show("El Precio de venta esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioVenta.Focus();
            }
            else if(txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("La descripcion no se ha completado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
            }
            else
            {
                if(cbInmueble.Text == string.Empty)
                {
                    MessageBox.Show("No se ha seleccionado un inmueble", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbInmueble.Focus();
                }
                else
                {
                    // when all inputs are filled.
                    try {
                        // verify the combobox status.
                        if (cbInmueble.Text == "Vehiculo" && txtMatricula.MaskCompleted)
                        {
                            if (ventas.register(vID, cID, txtDescripcion.Text + " " + txtMatricula.Text, txtPrecioVenta.Text, txtHonorarios.Text, txtAbono.Text, "5") > 0)
                            {
                                MessageBox.Show("Registrado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cleanEverything();
                                disableInputs();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            // if it is not focus on vehiculos.
                            if (ventas.register(vID, cID, txtDescripcion.Text, txtPrecioVenta.Text, txtHonorarios.Text, txtAbono.Text, "5") > 0)
                            {
                                MessageBox.Show("Registrado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cleanEverything();
                                disableInputs();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // when buscar button is clicked.
        private void btnSearchBuy_Click(object sender, EventArgs e)
        {
            frmCustomerSearch pComprador = new frmCustomerSearch();
            pComprador.type = true;
            pComprador.Text = "Buscar Comprador";
            pComprador.ShowDialog();
            if(pComprador.pCustSelectedID != null)
            {
                try
                {
                    if (clientes.getCustomerObject(pComprador.pCustSelectedID) != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(pComprador.pCustSelectedID);
                        cID = pClientes.ID;
                        txtIDBuy.Text = pClientes.ID;
                        txtNameBuy.Text = pClientes.Nombre;
                        txtLastNameBuy.Text = pClientes.Apellido;
                        txtCedulaBuy.Text = pClientes.Cedula;
                        txtCelularBuy.Text = pClientes.Celular;
                        txtPhoneBuy.Text = pClientes.Telefono;
                    }
                    else
                    {
                        MessageBox.Show("No existe el comprador, digite un ID valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDBuy.Clear();
                        txtIDBuy.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se selecciono un comprador", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
