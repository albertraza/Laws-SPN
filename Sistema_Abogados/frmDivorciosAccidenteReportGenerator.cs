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
    public partial class frmDivorciosAccidenteReportGenerator : Form
    {
        public frmDivorciosAccidenteReportGenerator()
        {
            InitializeComponent();
        }

        private void rbCedulaE_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCedulaE.Checked == true)
            {
                txtCedulaE.Mask = "000-0000000-0";
                lblCedulaDemandante.Text = "Cedula:";
            }
            else
            {
                txtCedulaE.Mask = "SE-000-0000";
                lblCedulaDemandante.Text = "Pasaporte:";
            }
        }

        private void rbPasaporteE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaE.Checked == true)
            {
                txtCedulaE.Mask = "000-0000000-0";
                lblCedulaDemandante.Text = "Cedula:";
            }
            else
            {
                txtCedulaE.Mask = "SE-000-0000";
                lblCedulaDemandante.Text = "Pasaporte:";
            }
        }

        private void rbCedulaO_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCedulaO.Checked == true)
            {
                lblCedulaO.Text = "Cedula:";
                txtCedulaO.Mask = "000-0000000-0";
            }
            else
            {
                lblCedulaO.Text = "Pasaporte:";
                txtCedulaO.Mask = "SE-000-0000";
            }
        }

        private void rbPasaporteO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaO.Checked == true)
            {
                lblCedulaO.Text = "Cedula:";
                txtCedulaO.Mask = "000-0000000-0";
            }
            else
            {
                lblCedulaO.Text = "Pasaporte:";
                txtCedulaO.Mask = "SE-000-0000";
            }
        }

        private void frmDivorciosAccidenteReportGenerator_Load(object sender, EventArgs e)
        {
            rbCedulaE.Checked = true;
            rbCedulaO.Checked = true;
        }

        private void rbAbono_CheckedChanged(object sender, EventArgs e)
        {
            if(rbAbono.Checked == true)
            {
                gbFechas.Enabled = true;
                gbInformacion.Enabled = false;
            }
            else
            {
                gbFechas.Enabled = false;
                gbInformacion.Enabled = true;
            }
        }
    }
}
