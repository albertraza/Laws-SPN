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
    public partial class frmReporteAbonoDivorciosAccidente : Form
    {
        public frmReporteAbonoDivorciosAccidente()
        {
            InitializeComponent();
        }

        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }

        private void frmReporteAbonoDivorciosAccidente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AbogadosDBDataSet.ReporteDivorcioAccidenteDates' table. You can move, or remove it, as needed.
            this.ReporteDivorcioAccidenteDatesTableAdapter.Fill(this.AbogadosDBDataSet.ReporteDivorcioAccidenteDates, fechaDesde, fechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
