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
    public partial class frmFacturaVenta : Form
    {
        public frmFacturaVenta()
        {
            InitializeComponent();
        }
        // create new variable for storing the ID.
        private int ID;
        // create a public propertie for setting the ID.
        public int getID
        {
            get { return ID; }
            set { ID = value; }
        }

        private void frmFacturaVenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AbogadosDBDataSet.FacturaVenta' table. You can move, or remove it, as needed.
            this.FacturaVentaTableAdapter.Fill(this.AbogadosDBDataSet.FacturaVenta, ID);

            this.reportViewer1.RefreshReport();
        }
    }
}
