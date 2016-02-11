using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Abogados
{
    public partial class frmSearchUser : Form
    {
        // method for loading user type.
        private void loadUserTypes()
        {
            using(SqlConnection con = DBcomun.getConnection())
            {
                SqlCommand comand = new SqlCommand("select levels from UserLevel", con);
                SqlDataReader re = comand.ExecuteReader();
                while (re.Read())
                {
                    cbType.Items.Add(re["levels"]);
                }
                con.Close();
            }
        }
        public frmSearchUser()
        {
            InitializeComponent();
        }

        // when form is loaded.
        private void frmSearchUser_Load(object sender, EventArgs e)
        {
            try
            {
                // executing method loadUsertypes for populating the combobox.
                loadUserTypes();
                // executing method for loading all users on the table.
                dgvUsersTable.DataSource = usuarios.listAllUsers();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // when Buscar button is clicked.
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string id, name, level, password;
            // validate Id input.
            if(txtID.Text == string.Empty)
            {
                id = "";
            }
            else
            {
                id = txtID.Text;
            }
            // validate Name input.
            if(txtName.Text == string.Empty)
            {
                name = "";
            }
            else
            {
                name = txtName.Text;
            }
            // validate password input.
            if(txtPassword.Text == string.Empty)
            {
                password = "";
            }
            else
            {
                password = txtPassword.Text;
            }
            // validate type input.
            if(cbType.Text == string.Empty)
            {
                level = "";
            }
            else
            {
                level = cbType.Text;
            }

            // executing the search engine.
            try
            {
                dgvUsersTable.DataSource = usuarios.SearchEngineUsers(id, name, level, password);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
