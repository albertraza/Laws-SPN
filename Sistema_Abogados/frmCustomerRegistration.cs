using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public partial class frmCustomerRegistration : Form
    {
        // variable for validating Radiobuttons.
        private bool result;
        // variables for storing filepaths.
        private string From, To;
        // method for cleaning the inputs
        private void clearInputs()
        {
            txtID.Clear();
            txtLastName.Clear();
            txtName.Clear();
            txtName.Focus();
            rbDemandado.Checked = false;
            rbDemandante.Checked = false;
            pbImage.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
            txtAddress.Clear();
            txtCellphone.Clear();
            txtEmail.Clear();
            txtOcupation.Clear();
            txtPhone.Clear();
            txtPassport.Clear();
            rbCedula.Checked = true;
            txtID.Focus();
            listCities();
            lblSave.Visible = false;
        }
        // method for listing all cities.
        private void listCities()
        {
            using(SqlConnection con = DBcomun.getConnection())
            {
                cbSector.Items.Clear();
                SqlCommand comand = new SqlCommand("SELECT * FROM cities", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbSector.Items.Add(re["City"]);
                }
                con.Close();
            }
        }
        public frmCustomerRegistration()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmCustomerRegistration_Load(object sender, EventArgs e)
        {
            // make try catch exception for next piece of code.
            try
            {
                // clear everything when form loads.
                clearInputs();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when Guardar button is clicked.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // variable for evaluating cb for documents.
            bool validationStatus;
            // Input validation for users input.
            if(rbCedula.Checked)
            {
                if(!txtID.MaskCompleted)
                {
                    MessageBox.Show("La cedula esta vacia, digite una valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtID.Focus();
                    validationStatus = false;
                }
                else
                {
                    validationStatus = true;
                }
            }
            else
            {
                if(!txtPassport.MaskCompleted)
                {
                    MessageBox.Show("El Pasaporte esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassport.Focus();
                    validationStatus = false;
                }
                else
                {
                    validationStatus = true;
                }
            }
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Nombre vacio, digite un numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Apellido vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
            }
            else if (To == null)
            {
                MessageBox.Show("No se ha seleccionado una Imagen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectImage.Focus();
            }
            else if (txtAddress.Text == string.Empty)
            {
                MessageBox.Show("La direccion esta vacia, Digite una valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
            }
            else if (!txtPhone.MaskCompleted)
            {
                MessageBox.Show("El telefono esta vacia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
            }
            else if (!txtCellphone.MaskCompleted)
            {
                MessageBox.Show("El Celular esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtEmail.Text == string.Empty)
            {
                MessageBox.Show("El E-mail esta vacio, digite uno valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else if (txtOcupation.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado la Ocupacion", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOcupation.Focus();
            }
            else if (cbSector.Text == string.Empty)
            {
                MessageBox.Show("No se ha seleccionado un sector", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSector.Focus();
            }
            else
            {
                // if all values are filled.
                if (validationStatus)
                {
                    // fill all Objects Data.
                    clientes c = new clientes();
                    c.Nombre = txtName.Text;
                    c.Apellido = txtLastName.Text;
                    c.Fecha_Registro = DateTime.Now.Date.ToString("MM/dd/yyyy");
                    c.Ocupacion = txtOcupation.Text;
                    c.Sector = cbSector.Text;
                    c.Telefono = txtPhone.Text;
                    c.Celular = txtCellphone.Text;
                    c.Direccion = txtAddress.Text;
                    c.E_Mail = txtEmail.Text;
                    // verify which document will be used.
                    if (rbCedula.Checked)
                    {
                        if (txtID.Text != string.Empty) c.Cedula = txtID.Text;
                    }
                    else
                    {
                        if (txtPassport.Text != string.Empty) c.Cedula = txtPassport.Text;
                    }
                    // verify if Client Status
                    if (rbDemandado.Checked)
                    {
                        c.Status = "Demandado";
                        // result true due a radio button is checked
                        result = true;
                    }
                    else if (rbDemandante.Checked == true)
                    {
                        c.Status = "Demandante";
                        // result true due a radio button is checked
                        result = true;
                    }
                    else
                    {
                        // result set to false because any of the radio buttons are checked.
                        result = false;
                        MessageBox.Show("No se ha seleccionado el Status del Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // make a try cacth extatement.
                    try
                    {
                        // validate result value.
                        if (result)
                        {
                            // if result is true. all inputs are filled.
                            // execute method for registering users.
                            if (clientes.customerRegistration(c, To) > 0)
                            {
                                MessageBox.Show("Registrado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                File.Copy(From, To, true);
                                clearInputs();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo registrar el Cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // when Limpiar button is clicked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                clearInputs();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when button cancelar is clicked.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        // when cedula cb is checked.
        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtPassport.Enabled = false;
            txtID.Focus();
            txtPassport.Clear();
        }
        // when cb pasaporte is checked.
        private void rbPassport_CheckedChanged(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtPassport.Enabled = true;
            txtPassport.Focus();
            txtID.Clear();
        }
        // when nuevo label is clicked.
        private void lblNew_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // change cb Style for enabling writting on it.
            cbSector.DropDownStyle = ComboBoxStyle.Simple;
            cbSector.Focus();
            // make appear the label for saving changes.
            lblSave.Visible = true;
            // enable false this label.
            this.Enabled = false;
        }
        // when Guardar label is clicked.
        private void lblSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(cbSector.Text == string.Empty)
            {
                MessageBox.Show("El sector esta vacio, Digite y guarde el nuevo sector", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSector.Focus();
            }
            else
            {
                try {
                    if (sectores.cityVerification(cbSector.Text))
                    {
                        MessageBox.Show("El Sector ya ha sido Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbSector.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                    else
                    {
                        if (sectores.registerCity(cbSector.Text) > 0)
                        {
                            MessageBox.Show("Sector Registrado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cbSector.DropDownStyle = ComboBoxStyle.DropDownList;
                            listCities();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el Sector", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // when Seleccionar Imagen button is clicked.
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // let's open a file dialog for selecting the images.
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            // verify the file path.
            if (!Directory.Exists(@"C:\FactoriadeProyectos\sistema-oficina-abogados\Images"))
            {
                // if the file path does not exist try to create the directory.
                Directory.CreateDirectory(@"C:\FactoriadeProyectos\sistema-oficina-abogados\Images");
            }
            // create the filepath where the pictures are going to be saved.
            To = @"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\" + Path.GetFileName(open.FileName);
            // get the filepath for saving the source filepath.
            From = open.FileName;

            // try to open the Image.
            try
            {
                // open de Image file form the filepath.
                pbImage.Image = Image.FromFile(open.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
