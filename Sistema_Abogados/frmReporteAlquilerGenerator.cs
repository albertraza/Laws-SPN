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
    public partial class frmReporteAlquilerGenerator : Form
    {
        public frmReporteAlquilerGenerator()
        {
            InitializeComponent();
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            try {
                dgvReporte.DataSource = reportes.ReporteAbonoContrAlquiler(dtpDesde.Value.Date.ToString("yyyy-MM-dd"), dtpHasta.Value.ToString("yyyy-MM-dd"));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }
    }
}
