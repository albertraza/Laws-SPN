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

        private void frmSearchUser_Load(object sender, EventArgs e)
        {
            try
            {
                // executing method loadUsertypes for populating the combobox.
                loadUserTypes();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
