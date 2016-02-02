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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // If texBoxes are Empty Show some messages.
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Nombre de usuario vacio, digite uno valido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (txtPasswrd.Text == string.Empty)
            {
                MessageBox.Show("Contraseña vacia, digite una contraseña valida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPasswrd.Focus();
            }
            else
            {
                // If all texBoxes are filled.
                if (usuarios.checkUser(txtName.Text, txtPasswrd.Text))
                {
                    MessageBox.Show("Aceptado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrecto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Clear();
                    txtPasswrd.Clear();
                    txtName.Focus();
                }
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPasswrd.Focus();
            }
        }

        private void txtPasswrd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                // If texBoxes are Empty Show some messages.
                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("Nombre de usuario vacio, digite uno valido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                }
                else if (txtPasswrd.Text == string.Empty)
                {
                    MessageBox.Show("Contraseña vacia, digite una contraseña valida", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPasswrd.Focus();
                }
                else
                {
                    // If all texBoxes are filled.
                    if (usuarios.checkUser(txtName.Text, txtPasswrd.Text))
                    {
                        MessageBox.Show("Aceptado", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrecto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtName.Clear();
                        txtPasswrd.Clear();
                        txtName.Focus();
                    }
                }
            }
        }
    }
}
