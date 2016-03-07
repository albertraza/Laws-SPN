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
    public partial class frmDivorcios : Form
    {
        // variables for storing customers ID's.
        private string cID1 = null, cID2 = null;
        // method for disabling all inputs.
        private void disableInputs()
        {
            txtCedulaDemandado.Enabled = false;
            txtCedulaDemandante.Enabled = false;
            txtCellphoneDemandado.Enabled = false;
            txtCellphoneDemandante.Enabled = false;
            txtHonorarios.Enabled = false;
            txtLastNameDemandado.Enabled = false;
            txtLastNameDemandante.Enabled = false;
            txtNameDemandado.Enabled = false;
            txtNameDemandante.Enabled = false;
            txtPhoneDemandado.Enabled = false;
            txtPhoneDemandante.Enabled = false;
            txtIDDemandante.Focus();
            txtAbono.Enabled = false;
            txtPrecio.Enabled = false;
        }
        // method for cleaning evrything.
        private void clearInputs()
        {
            txtAbono.Clear();
            txtCedulaDemandado.Clear();
            txtCedulaDemandante.Clear();
            txtCellphoneDemandado.Clear();
            txtCellphoneDemandante.Clear();
            txtHonorarios.Clear();
            txtIDDemandado.Clear();
            txtIDDemandante.Clear();
            txtLastNameDemandado.Clear();
            txtLastNameDemandante.Clear();
            txtNameDemandado.Clear();
            txtNameDemandante.Clear();
            txtPhoneDemandado.Clear();
            txtPhoneDemandante.Clear();
            txtPrecio.Clear();
            txtIDDemandante.Focus();
            cID1 = null;
            cID2 = null;
        }
        public frmDivorcios()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmDivorcios_Load(object sender, EventArgs e)
        {
            try {
                ControlBox = false;
                disableInputs();
                servicios pser = servicios.getServiceInfo("4");
                txtAbono.Text = Convert.ToDouble(pser.Abono).ToString("f2");
                txtPrecio.Text = Convert.ToDouble(pser.Precio).ToString("f2");
                txtHonorarios.Text = Convert.ToDouble(pser.Precio).ToString("f2");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when cancelar button is cliked.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            new frmMenu().Show();
        }
        // when label buscar is clicked on Demandado.
        private void lblSearchDemandante_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // verify if the id is empty.
            if(txtIDDemandante.Text == string.Empty)
            {
                MessageBox.Show("El ID del demandante esta vacio, Digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDDemandante.Focus();
            }
            else
            {
                try {
                    if (clientes.getCustomerObject(txtIDDemandante.Text) != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(txtIDDemandante.Text);
                        cID1 = pClientes.ID;
                        txtNameDemandante.Text = pClientes.Nombre;
                        txtLastNameDemandante.Text = pClientes.Apellido;
                        txtPhoneDemandante.Text = pClientes.Telefono;
                        txtCellphoneDemandante.Text = pClientes.Celular;
                        txtCedulaDemandante.Text = pClientes.Cedula;
                    }
                    else
                    {
                        MessageBox.Show("El cliente no existe, digite un id valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDDemandante.Clear();
                        txtIDDemandante.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // when buscar label is clicked on demandado.
        private void lblSearchDemandado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // valdate if texbox is empty.
            if(txtIDDemandado.Text == string.Empty)
            {
                MessageBox.Show("El ID esta vacio, digite uno valido", "Mendaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDDemandado.Focus();
            }
            else
            {
                try {
                    if (clientes.getCustomerObject(txtIDDemandado.Text) != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(txtIDDemandado.Text);
                        cID2 = pClientes.ID;
                        txtNameDemandado.Text = pClientes.Nombre;
                        txtLastNameDemandado.Text = pClientes.Apellido;
                        txtPhoneDemandado.Text = pClientes.Telefono;
                        txtCellphoneDemandado.Text = pClientes.Celular;
                        txtCedulaDemandado.Text = pClientes.Cedula;
                    }
                    else
                    {
                        MessageBox.Show("No existe el cliente, digite un id valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDDemandado.Clear();
                        txtIDDemandado.Focus();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // when Limpiar button is clicked on Demandante
        private void btnClearDemandante_Click(object sender, EventArgs e)
        {
            txtIDDemandante.Clear();
            txtIDDemandante.Focus();
            txtNameDemandante.Clear();
            txtLastNameDemandante.Clear();
            txtPhoneDemandante.Clear();
            txtCellphoneDemandante.Clear();
            txtCedulaDemandante.Clear();
            cID1 = null;
        }
        // when Limpiar button is clickec on Demandado.
        private void btnClearDemandado_Click(object sender, EventArgs e)
        {
            txtIDDemandado.Clear();
            txtIDDemandado.Focus();
            txtNameDemandado.Clear();
            txtLastNameDemandado.Clear();
            txtPhoneDemandado.Clear();
            txtCellphoneDemandado.Clear();
            txtCedulaDemandado.Clear();
            cID2 = null;
        }
        // when buscar demandante button is clicked.
        private void btnSearchDemandante_Click(object sender, EventArgs e)
        {
            frmCustomerSearch pCustomer = new frmCustomerSearch();
            pCustomer.type = true;
            pCustomer.Text = "Busqueda Demandante";
            pCustomer.pGetStatus = "Demandante";
            pCustomer.ShowDialog();
            if(pCustomer.pCustSelectedID != null)
            {
                try
                {
                    if (clientes.getCustomerObject(pCustomer.pCustSelectedID) != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(pCustomer.pCustSelectedID);
                        cID1 = pClientes.ID;
                        txtIDDemandante.Text = pClientes.ID;
                        txtNameDemandante.Text = pClientes.Nombre;
                        txtLastNameDemandante.Text = pClientes.Apellido;
                        txtPhoneDemandante.Text = pClientes.Telefono;
                        txtCellphoneDemandante.Text = pClientes.Celular;
                        txtCedulaDemandante.Text = pClientes.Cedula;
                    }
                    else
                    {
                        MessageBox.Show("El cliente no existe, digite un id valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDDemandante.Clear();
                        txtIDDemandante.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se selecciono el Demandante, Intentelo nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // when buscar demandado button is clicked.
        private void btnSearchDemandado_Click(object sender, EventArgs e)
        {
            frmCustomerSearch pCustomer = new frmCustomerSearch();
            pCustomer.type = true;
            pCustomer.Text = "Busqueda Demandados";
            pCustomer.pGetStatus = "Demandado";
            pCustomer.ShowDialog();
            if (pCustomer.pCustSelectedID != null)
            {
                try
                {
                    if (clientes.getCustomerObject(pCustomer.pCustSelectedID) != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(pCustomer.pCustSelectedID);
                        cID2 = pClientes.ID;
                        txtIDDemandado.Text = pClientes.ID;
                        txtNameDemandado.Text = pClientes.Nombre;
                        txtLastNameDemandado.Text = pClientes.Apellido;
                        txtPhoneDemandado.Text = pClientes.Telefono;
                        txtCellphoneDemandado.Text = pClientes.Celular;
                        txtCedulaDemandado.Text = pClientes.Cedula;
                    }
                    else
                    {
                        MessageBox.Show("No existe el cliente, digite un id valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtIDDemandado.Clear();
                        txtIDDemandado.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se selecciono el Demandado, Intentelo nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // when limpiar todo is clicked.
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearInputs();
            disableInputs();
        }

        private void gbInfomacionPagos_Enter(object sender, EventArgs e)
        {

        }
        // when Modificar button is clicked.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtPrecio.Enabled = true;
            txtHonorarios.Enabled = true;
            txtAbono.Enabled = true;
        }
        // when Registrar Button is clicked.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(cID1 == null)
            {
                MessageBox.Show("No se ha cargado un Demandante", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDDemandante.Focus();
            }
            else if(cID2 == null)
            {
                MessageBox.Show("No se ha cargado un demandado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIDDemandado.Focus();
            }
            else if(txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("El precio esta vacio, digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
            }
            else if(txtHonorarios.Text == string.Empty)
            {
                MessageBox.Show("Los Honorarios estan vacios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHonorarios.Focus();
            }
            else if(txtAbono.Text == string.Empty)
            {
                MessageBox.Show("El Abono esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAbono.Focus();
            }
            else
            {
                try
                {
                    if(divorcios.register("4", cID2, cID1, txtPrecio.Text, txtHonorarios.Text, txtAbono.Text) > 0)
                    {
                        MessageBox.Show("Registrado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearInputs();
                        disableInputs();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo Registrar, Intentelo Nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
