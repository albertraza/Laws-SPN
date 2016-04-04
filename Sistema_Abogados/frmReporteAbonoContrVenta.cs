﻿using System;
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
    public partial class frmReporteAbonoContrVenta : Form
    {
        public frmReporteAbonoContrVenta()
        {
            InitializeComponent();
        }

        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }

        private void frmReporteAbonoContrVenta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AbogadosDBDataSet.AbonosContrVenta' table. You can move, or remove it, as needed.
            this.AbonosContrVentaTableAdapter.Fill(this.AbogadosDBDataSet.AbonosContrVenta, fechaDesde, fechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
