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
    public partial class frmShowUser : Form
    {
        // setting up getter and setter for getting the value from the main form.
        public string getID
        {
            get { return ID; }
            set { ID = value; }
        }
        private string ID;
        public frmShowUser()
        {
            InitializeComponent();
        }

        private void frmShowUser_Load(object sender, EventArgs e)
        {
            if (ID != null)
            {
                try
                {
                    // load the user object from the database.
                    usuarios u = usuarios.getUser(ID);
                    // load the image for the object.
                    pbImage.Image = Image.FromFile(u.image);
                    // **** //
                    // then load the labels with the object info.
                    lblID.Text = u.id;
                    lblName.Text = u.nombre;
                    lblType.Text = u.nivel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // load the default image.
                try
                {
                    pbImage.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
