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
    public partial class frmServicesRegistration : Form
    {
        // method for cleaning all inputs.
        private void clearInputs()
        {
            txtDescription.Clear();
            txtPreBonus.Clear();
            txtPrice.Clear();
            txtServices.Clear();
            txtServices.Focus();
        }
        public frmServicesRegistration()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmServicesRegistration_Load(object sender, EventArgs e)
        {
            // clear all inputs.
            clearInputs();
        }
        // when Guardar button is clicked.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // validate empty inputs.
            if(txtServices.Text == string.Empty)
            {
                MessageBox.Show("Nombre del Servicio vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtServices.Focus();
            }
            else if(txtDescription.Text == string.Empty)
            {
                MessageBox.Show("Descripcion vacia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
            }
            else if(txtPrice.Text == string.Empty)
            {
                MessageBox.Show("Precio del servicio vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
            }
            else if(txtPreBonus.Text == string.Empty)
            {
                MessageBox.Show("Abono vacio", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPreBonus.Focus();
            }
            else
            {
                // if all inputs are filled.
                // create an instance of servicios class.
                servicios pServicios = new servicios();
                pServicios.Servicio = txtServices.Text;
                pServicios.Descripcion = txtDescription.Text;
                pServicios.Precio = txtPrice.Text;
                pServicios.Abono = txtPreBonus.Text;
                // end of object ///
                // make a try catch.
                try {
                    // now let's execute the registration method.
                    if (servicios.registerService(pServicios) > 0)
                    {
                        MessageBox.Show("Registrado con Exito", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // clear all inputs if registration is successfull.
                        clearInputs();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar, Intentelo nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // when Limpiar button in clicked.
        private void btnClear_Click(object sender, EventArgs e)
        {
            // clean all inputs.
            clearInputs();
        }
        // when Cancelar button is pressed.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // close the form.
            Close();
        }
    }
}
