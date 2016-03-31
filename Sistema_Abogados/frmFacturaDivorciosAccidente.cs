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
    public partial class frmFacturaDivorciosAccidente : Form
    {
        public frmFacturaDivorciosAccidente()
        {
            InitializeComponent();
        }
        // declare a new variable for storing the Factura ID.
        private int ID;
        // create new propertie for setting the ID value;
        public int getID
        {
            set { ID = value; }
            get { return ID; }
        }
        private void frmFacturaDivorciosAccidente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AbogadosDBDataSet.FacturaDivorciosAccidentes' table. You can move, or remove it, as needed.
            this.FacturaDivorciosAccidentes1TableAdapter.Fill(this.AbogadosDBDataSet.FacturaDivorciosAccidentes1, ID);

            this.reportViewer1.RefreshReport();
        }
    }
}
