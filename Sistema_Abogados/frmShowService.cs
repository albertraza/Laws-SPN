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
    public partial class frmShowService : Form
    {
        // create the cariable for storing the service ID.
        private string ID;
        // declare a getter for updating ID value.
        public string getID
        {
            get { return ID; }
            set { ID = value; }
        }
        // end getter declaration.
        // end declarations. //
        public frmShowService()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmShowService_Load(object sender, EventArgs e)
        {
            // validate ID value.
            if(ID != null)
            {
                // execute  the method for getting service info.
                if(servicios.getServiceInfo(ID) != null)
                {
                    // if was found something with the id.
                    servicios pServices = servicios.getServiceInfo(ID);
                    lblService.Text = pServices.Servicio;
                    txtDescription.Text = pServices.Descripcion;
                    lblPrice.Text = pServices.Precio;
                    lblPre_bono.Text = pServices.Abono;
                    lblPre_bono.ForeColor = Color.Yellow;
                    // disable the texbox.
                    txtDescription.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Servicio no encontrado, digite un ID valido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // If ID is found NULL. do something...
            }
        }
        // when Atras label is clicked.
        private void lblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
