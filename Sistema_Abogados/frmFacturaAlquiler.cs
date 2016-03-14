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
        private int ID;
        public int getID
        {
            get { return ID; }
            set { ID = value; }
        }
        // ******************************************** //
        private void frmFacturaAlquiler_Load(object sender, EventArgs e)
        {
            this.FacturaAlquilerTableAdapter.Fill(this.AbogadosDBDataSet.FacturaAlquiler, ID);

            this.reportViewer1.RefreshReport();
        }
    }
}
