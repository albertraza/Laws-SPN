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
                // load the default image.
                pbImage.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
                // make the focus on Nombre input.
                txtName.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when Guardar button is clicked.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Input validation
            if(txtName.Text == string.Empty)
            {
                MessageBox.Show("Nombre vacio, digite un numero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if(txtLastName.Text == string.Empty)
            {
                MessageBox.Show("Apellido vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
            }
            else if(txtID.Text == string.Empty)
            {
                MessageBox.Show("Cedula vacia, Digite una cedula valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
            else if(To == null)
            {
                MessageBox.Show("No se ha seleccionado una Imagen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectImage.Focus();
            }
            else
            {
                // if all values are filled.
                // fill all Objects Data.
                clientes c = new clientes();
                c.Nombre = txtName.Text;
                c.Apellido = txtLastName.Text;
                c.Cedula = txtID.Text;
                c.Fecha_Registro = DateTime.Now.Date.ToString("MM/dd/yyyy");
                // verify if Client Status
                if(rbDemandado.Checked)
                {
                    c.Status = "Demandado";
                    // result true due a radio button is checked
                    result = true;
                }
                else if(rbDemandante.Checked == true)
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
                try {
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
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // when Seleccionar Imagen is Clicked.
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
