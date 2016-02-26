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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // when menu Salir del sistema is clicked this piece of code is executed.
            if (MessageBox.Show("Seguro que desea salir del sistema?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // updating form properties for better desing.
            ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // add frmAbout call when clicked.
            Hide();
            new frmAbout().ShowDialog();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmUserRegistration().Show();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmSearchUser().Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmCustomerRegistration().Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCustomerSearch pc = new frmCustomerSearch();
            pc.type = false;
            pc.Show();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmServicesRegistration().Show();
        }

        private void serviciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmSearchServices().Show();
        }

        private void arquilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new frmAlquiler().ShowDialog();
        }
    }
}
