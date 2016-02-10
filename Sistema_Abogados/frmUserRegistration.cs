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
        public frmUserRegistration()
        {
            InitializeComponent();
        }
        // string variable where file path will be stored.
        private string To;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
