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
    public partial class frmFacturaAlquiler : Form
    {
        public frmFacturaAlquiler()
        {
            InitializeComponent();
        }
        // variable for getting Factura ID.
        public int getID { get; set; }
        // ******************************************** //
        private void frmFacturaAlquiler_Load(object sender, EventArgs e)
        {
            try
            {
                this.FacturaAlquilerTableAdapter.Fill(this.AbogadosDBDataSet.FacturaAlquiler, getID);

                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
