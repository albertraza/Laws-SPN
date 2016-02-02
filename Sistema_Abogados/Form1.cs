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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DBcomun.getConnection();
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int c = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            lblMessage.Text = "Cargando sistema, espere por favor ... " + " ";
            string m = c.ToString();
            lblMessage.Text = lblMessage.Text + " " + m + "%";
            pbProgress.Value = c;
            if (c == 100)
            {
                timer1.Stop();
            }
        }
    }
}
