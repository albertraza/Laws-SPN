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
    public partial class frmAlquilerSearch : Form
    {
        // method for cleaing all inputs.
        private void clear()
        {
            txtApellidoCliente.Clear();
            txtApellidoGaran.Clear();
            txtApellidoInqui.Clear();
            txtID.Clear();
            txtNombreCli.Clear();
            txtNombreGarante.Clear();
            txtNombreInqui.Clear();
            dgvAlquiler.DataSource = alquiler.listAll();
        }
        public frmAlquilerSearch()
        {
            InitializeComponent();
        }
        // when form is loaded.
        private void frmAlquilerSearch_Load(object sender, EventArgs e)
        {
            try
            {
                dgvAlquiler.DataSource = alquiler.listAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when buscar button is clicked.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string ID, Nc, ac, ni, ai, ng, ag;
            if(txtApellidoCliente.Text == string.Empty)
            {
                ac = "";
            }
            else
            {
                ac = txtApellidoCliente.Text;
            }
            if(txtApellidoGaran.Text == string.Empty)
            {
                ag = "";
            }
            else
            {
                ag = txtApellidoGaran.Text;
            }
            if(txtApellidoInqui.Text == string.Empty)
            {
                ai = "";
            }
            else
            {
                ai = txtApellidoInqui.Text;
            }
            if(txtID.Text == string.Empty)
            {
                ID = "";
            }
            else
            {
                ID = txtID.Text;
            }
            if(txtNombreCli.Text == string.Empty)
            {
                Nc = "";
            }
            else
            {
                Nc = txtNombreCli.Text;
            }
            if(txtNombreGarante.Text == string.Empty)
            {
                ng = "";
            }
            else
            {
                ng = txtNombreGarante.Text;
            }
            if(txtNombreInqui.Text == string.Empty)
            {
                ni = "";
            }
            else
            {
                ni = txtNombreInqui.Text;
            }
            try
            {
                dgvAlquiler.DataSource = alquiler.search(ID, ni, ai, Nc, ac, ng, ag);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when Limpiar button is clicked.
        private void bntLimpiar_Click(object sender, EventArgs e)
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
