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
    public partial class frmShowCustomers : Form
    {
        // declare variables for storing ID data.
        private string ID;
        public string getID
        {
            get { return ID; }
            set { ID = value; }
        }
        // end variables declaration.
        public frmShowCustomers()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmShowCustomers_Load(object sender, EventArgs e)
        {
            if (ID != null)
            {
                // disable all textboxes.
                txtFechaRegistro.Enabled = false;
                txtID.Enabled = false;
                txtLastName.Enabled = false;
                txtName.Enabled = false;
                txtStatus.Enabled = false;
                try
                {
                    if (clientes.getCustomerObject(ID).Image != null)
                    {
                        // if image exists try to show the image.
                        try {
                            pbImage.Image = Image.FromFile(clientes.getCustomerObject(ID).Image);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            pbImage.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
                        }
                    }
                    else
                    {
                        // if does not
                        // show the default image.
                        pbImage.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
                    }
                    // fill all customer data from database.
                    txtFechaRegistro.Text = Convert.ToDateTime(clientes.getCustomerObject(ID).Fecha_Registro).ToString("dd/MM/yyyy");
                    txtID.Text = clientes.getCustomerObject(ID).ID;
                    txtLastName.Text = clientes.getCustomerObject(ID).Apellido;
                    txtName.Text = clientes.getCustomerObject(ID).Nombre;
                    txtStatus.Text = clientes.getCustomerObject(ID).Status;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Id is null.
                // disable all textboxes.
                txtFechaRegistro.Enabled = false;
                txtID.Enabled = false;
                txtLastName.Enabled = false;
                txtName.Enabled = false;
                txtStatus.Enabled = false;
                try
                {
                    // load the default image.
                    pbImage.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // when Atras label is clicked.
        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
