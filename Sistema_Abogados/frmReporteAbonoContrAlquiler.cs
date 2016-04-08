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
    public partial class frmReporteAbonoContrAlquiler : Form
    {
        public frmReporteAbonoContrAlquiler()
        {
            InitializeComponent();
        }

        public DateTime fechaDe { get; set; }
        public DateTime fechaHa { get; set; }

        private void frmReporteAbonoContrAlquiler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AbogadosDBDataSet.AbonoContratoAlquiler' table. You can move, or remove it, as needed.
            this.AbonoContratoAlquilerTableAdapter.Fill(this.AbogadosDBDataSet.AbonoContratoAlquiler, fechaDe, fechaHa);

            this.reportViewer1.RefreshReport();
        }
    }
}
