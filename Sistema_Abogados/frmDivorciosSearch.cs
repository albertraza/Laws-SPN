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
    public partial class frmDivorciosSearch : Form
    {
        // method for cleaning all inputs.
        private void clear()
        {
            txtApellidoDemandado.Clear();
            txtApellidoDemandante.Clear();
            txtID.Clear();
            txtNombreDemandado.Clear();
            txtNombreDemandante.Clear();
            dgvDivorcios.DataSource = divorcios.listAll();
        }
        public frmDivorciosSearch()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmDivorciosSearch_Load(object sender, EventArgs e)
        {
            try
            {
                dgvDivorcios.DataSource = divorcios.listAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when buscar button is clicked.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ID, pNombreDemandante, pApellidoDemandante, pNombreDemandado, pApellidoDemandado;
            if(txtApellidoDemandado.Text == string.Empty)
            {
                pApellidoDemandado = "";
            }
            else
            {
                pApellidoDemandado = txtApellidoDemandado.Text;
            }
            if(txtApellidoDemandante.Text == string.Empty)
            {
                pApellidoDemandante = "";
            }
            else
            {
                pApellidoDemandante = txtApellidoDemandante.Text;
            }
            if(txtID.Text == string.Empty)
            {
                ID = "";
            }
            else
            {
                ID = txtID.Text;
            }
            if(txtNombreDemandado.Text == string.Empty)
            {
                pNombreDemandado = "";
            }
            else
            {
                pNombreDemandado = txtNombreDemandado.Text;
            }
            if(txtNombreDemandante.Text == string.Empty)
            {
                pNombreDemandante = "";
            }
            else
            {
                pNombreDemandante = txtNombreDemandante.Text;
            }
            try
            {
                dgvDivorcios.DataSource = divorcios.search(ID, pNombreDemandante, pApellidoDemandante, pNombreDemandado, pApellidoDemandado);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
