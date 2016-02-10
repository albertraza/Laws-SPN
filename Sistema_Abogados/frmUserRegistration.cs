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
    public partial class frmUserRegistration : Form
    {
        // method for cleaning the values.
        private void Clear()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtPasswordVerification.Text = "";
            cbUserLevel.Text = "";
            txtName.Focus();
            pbImage.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
        }
        // method for loading all user levels on the combobox.
        private void LoadLevels()
        {
            using (SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("SELECT levels FROM UserLevel", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbUserLevel.Items.Add(re["levels"]);
                }
                con.Close();
            }
        }
        public frmUserRegistration()
        {
            InitializeComponent();
        }
        // string variable where file path will be stored.
        private string To = null;
        private string From = null;

        // when seleccionar imagen is clicked
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            // create an open file diadlog object for selecting the image.
            OpenFileDialog opnfl = new OpenFileDialog();
            opnfl.ShowDialog();
            // verify if the file path exist.
            if (!Directory.Exists(@"C:\FactoriadeProyectos\sistema-oficina-abogados\images"))
            {
                // if not create the folder in this file path.
                Directory.CreateDirectory(@"C:\FactoriadeProyectos\sistema-oficina-abogados\images");
            }
            // create file path where the images are going to be copied.
            To = @"C:\FactoriadeProyectos\sistema-oficina-abogados\images\" + Path.GetFileName(opnfl.FileName);
            From = opnfl.FileName;
            // create try from using the image.
            try
            {
                // for watching the image on  the form.
                pbImage.Image = Image.FromFile(opnfl.FileName);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // when Limpiar button is clicked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                // call the clear method to be executed.
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // when Main Form is loaded.
        private void frmUserRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                // have the default image to be shown in the picture box.
                pbImage.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
                txtName.Focus();
                // call the LoadLevels method for populating the combobox.
                LoadLevels();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // when Cancelar button is clicked.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // show a message box for asking if form will be closed.
            if(MessageBox.Show("Esta seguro que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        // when Registrar button is clicked.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // text boxes validation.
            if(txtName.Text == string.Empty)
            {
                MessageBox.Show("El Nombre de Usuario esta vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if(txtPassword.Text == string.Empty)
            {
                MessageBox.Show("La Contraseña del Usuario esta vacia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else if(txtPasswordVerification.Text == string.Empty)
            {
                MessageBox.Show("No se ha completado la repeticion de la contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPasswordVerification.Focus();
            }
            else if(cbUserLevel.Text == string.Empty)
            {
                MessageBox.Show("Seleccione un nivel de usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUserLevel.Focus();
            }
            else if(To == null)
            {
                MessageBox.Show("No se ha seleccionado una imagen para registrar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSelectImage.Focus();
            }
            else
            {
                // if all texboxes are fully filled validate the password.
                if(txtPassword.Text == txtPasswordVerification.Text)
                {
                    // if validation is performed true.
                    try
                    {
                        if (usuarios.registerUser(txtName.Text, txtPassword.Text, To, cbUserLevel.Text) > 0)
                        {
                            MessageBox.Show("Registrado Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            File.Copy(From, To, true);
                            From = null;
                            To = null;
                            Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar, Intentelo nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // if validation is performed false.
                    MessageBox.Show("Las contraseñas no coinciden, digitelas nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPasswordVerification.Clear();
                    txtPassword.Focus();
                }
            }
        }
    }
}
