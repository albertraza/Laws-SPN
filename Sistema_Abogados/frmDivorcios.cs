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
        // clientes object declaration.
        clientes pDemandante, pDemandado;
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
            txtPrecio.Enabled = false;
            txtTotalPagar.Enabled = false;
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
            pbDemandado.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
            pbDemandante.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
            txtTotalPagar.Clear();
        }
        public frmDivorcios()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmDivorcios_Load(object sender, EventArgs e)
        {
            try {
                clearInputs();
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
            string ID, cedula;
            // verify if the id is empty.
            if (txtIDDemandante.Text == string.Empty)
            {
                ID = "";
            }
            else
            {
                ID = txtIDDemandante.Text;
            }
            if (txtCedulaDemandante.MaskCompleted)
            {
                cedula = txtCedulaDemandante.Text;
            }
            else
            {
                cedula = "";
            }
            try
            {
                if (clientes.getCustomerObject(ID, cedula) != null)
                {
                    clientes pClientes = clientes.getCustomerObject(ID, cedula);
                    if (pClientes.Status == "Demandante")
                    {
                        cID1 = pClientes.ID;
                        pDemandante = pClientes;
                        pbDemandante.Image = Image.FromFile(pClientes.Image);
                        txtNameDemandante.Text = pClientes.Nombre;
                        txtLastNameDemandante.Text = pClientes.Apellido;
                        txtPhoneDemandante.Text = pClientes.Telefono;
                        txtCellphoneDemandante.Text = pClientes.Celular;
                        txtCedulaDemandante.Text = pClientes.Cedula;
                    }
                    else
                    {
                        MessageBox.Show("El cliente no se ha seleccionado como un demandante, seleccione uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSearchDemandante.Focus();
                    }
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
        // when buscar label is clicked on demandado.
        private void lblSearchDemandado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string ID, cedula;
            // valdate if texbox is empty.
            if (txtIDDemandado.Text == string.Empty)
            {
                ID = "";
            }
            else
            {
                ID = txtIDDemandado.Text;
            }
            if (txtCedulaDemandado.MaskCompleted)
            {
                cedula = txtCedulaDemandado.Text;
            }
            else
            {
                cedula = "";
            }
            try
            {
                if (clientes.getCustomerObject(ID, cedula) != null)
                {
                    clientes pClientes = clientes.getCustomerObject(ID, cedula);
                    if (pClientes.Status == "Demandado")
                    {
                        pDemandado = pClientes;
                        cID2 = pClientes.ID;
                        pbDemandado.Image = Image.FromFile(pClientes.Image);
                        txtNameDemandado.Text = pClientes.Nombre;
                        txtLastNameDemandado.Text = pClientes.Apellido;
                        txtPhoneDemandado.Text = pClientes.Telefono;
                        txtCellphoneDemandado.Text = pClientes.Celular;
                        txtCedulaDemandado.Text = pClientes.Cedula;
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado un demandado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSearchDemandado.Focus();
                    }
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
            pbDemandante.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
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
            pbDemandado.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
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
                    if (clientes.getCustomerObject(pCustomer.pCustSelectedID, "") != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(pCustomer.pCustSelectedID, "");
                        if (pClientes.Status == "Demandante")
                        {
                            pDemandante = pClientes;
                            cID1 = pClientes.ID;
                            pbDemandante.Image = Image.FromFile(pClientes.Image);
                            txtIDDemandante.Text = pClientes.ID;
                            txtNameDemandante.Text = pClientes.Nombre;
                            txtLastNameDemandante.Text = pClientes.Apellido;
                            txtPhoneDemandante.Text = pClientes.Telefono;
                            txtCellphoneDemandante.Text = pClientes.Celular;
                            txtCedulaDemandante.Text = pClientes.Cedula;
                        }
                        else
                        {
                            MessageBox.Show("El cliente no ha sido registrado como un demandante, seleccione uno diferente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnSearchDemandante.Focus();
                        }
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
                    if (clientes.getCustomerObject(pCustomer.pCustSelectedID, "") != null)
                    {
                        clientes pClientes = clientes.getCustomerObject(pCustomer.pCustSelectedID, "");
                        if (pClientes.Status == "Demandado")
                        {
                            pDemandado = pClientes;
                            cID2 = pClientes.ID;
                            pbDemandado.Image = Image.FromFile(pClientes.Image);
                            txtIDDemandado.Text = pClientes.ID;
                            txtNameDemandado.Text = pClientes.Nombre;
                            txtLastNameDemandado.Text = pClientes.Apellido;
                            txtPhoneDemandado.Text = pClientes.Telefono;
                            txtCellphoneDemandado.Text = pClientes.Celular;
                            txtCedulaDemandado.Text = pClientes.Cedula;
                        }
                        else
                        {
                            MessageBox.Show("El cliente no ha sido registrado como un demandado, seleccione uno diferente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnSearchDemandado.Focus();
                        }
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
        // when calcular button is clicked.
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("El precio esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
            }
            else if(txtHonorarios.Text == string.Empty)
            {
                MessageBox.Show("El Honorario esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHonorarios.Focus();
            }
            else if(txtAbono.Text == string.Empty)
            {
                MessageBox.Show("El abono esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAbono.Focus();
            }
            else
            {
                if (Convert.ToDouble(txtPrecio.Text) <= 0)
                {
                    MessageBox.Show("El precio a cobrar no debe ser 0 o menor de 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrecio.Focus();
                }
                else if (Convert.ToDouble(txtHonorarios.Text) <= 0)
                {
                    MessageBox.Show("Los honorarios no deben ser igual a 0 o menor de 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHonorarios.Focus();
                }
                else if (Convert.ToDouble(txtAbono.Text) <= 0)
                {
                    MessageBox.Show("El abono no debe ser igual o menor de 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAbono.Focus();
                }
                else
                {
                    txtTotalPagar.Text = (Convert.ToDouble(txtPrecio.Text) + Convert.ToDouble(txtHonorarios.Text)).ToString("f2");
                }
            }
        }

        private void rbCedulaE_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCedulaE.Checked == true)
            {
                lblCedula.Text = "Cedula:";
                txtCedulaDemandante.Mask = "000-0000000-0";
            }
            else
            {
                lblCedula.Text = "Pasaporte:";
                txtCedulaDemandante.Mask = "SE-000-0000";
            }
        }

        private void rbPasaporteE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaE.Checked == true)
            {
                lblCedula.Text = "Cedula:";
                txtCedulaDemandante.Mask = "000-0000000-0";
            }
            else
            {
                lblCedula.Text = "Pasaporte:";
                txtCedulaDemandante.Mask = "SE-000-0000";
            }
        }

        private void rbCedulaO_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCedulaO.Checked == true)
            {
                txtCedulaDemandado.Mask = "000-0000000-0";
                lblCedulaDemandado.Text = "Cedula:";
            }
            else
            {
                txtCedulaDemandado.Mask = "SE-000-0000";
                lblCedulaDemandado.Text = "Pasaporte:";
            }
        }

        private void rbPasaporteO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaO.Checked == true)
            {
                txtCedulaDemandado.Mask = "000-0000000-0";
                lblCedulaDemandado.Text = "Cedula:";
            }
            else
            {
                txtCedulaDemandado.Mask = "SE-000-0000";
                lblCedulaDemandado.Text = "Pasaporte:";
            }
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
            else if(cID1 == cID2)
            {
                MessageBox.Show("El demandante y el demandado son los mismos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Convert.ToDouble(txtAbono.Text) == 0)
            {
                MessageBox.Show("El Abono no puede estar en 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAbono.Focus();
            }
            else if(txtTotalPagar.Text == string.Empty)
            {
                MessageBox.Show("No se ha calculado la totalidad a pagar", "Mensualidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCalcular.Focus();
            }
            else
            {
                try
                {
                    if(divorcios.register("4", cID2, cID1, txtTotalPagar.Text, txtHonorarios.Text, txtAbono.Text) > 0)
                    {
                        MessageBox.Show("Registrado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        facturacion.registerDivorciosAccidente(cID1, "4", divorcios.getID(txtAbono.Text, pDemandante.Nombre, pDemandante.Apellido, pDemandado.Nombre, pDemandado.Apellido, pDemandante.Cedula, pDemandado.Cedula), txtTotalPagar.Text, txtAbono.Text);
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
