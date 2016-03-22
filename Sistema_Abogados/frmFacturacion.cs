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
    public partial class frmFacturacion : Form
    {
        // obj for loading data.
        private clientes pCliente;
        private servicios pService;
        private facturacionBaseObj pBaseObjfactura;
        private void cleanInputs()
        {
            pbCedula.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
            txtCedula.Clear();
            txtCantDevolver.Clear();
            txtCantPagar.Clear();
            txtCedula.Clear();
            txtMoneda.Clear();
            txtNumeroCaso.Clear();
            txtServicio.Clear();
            txtBalanceTotal.Clear();
            txtUltimoPago.Clear();
            txtITEBIS.Clear();
            txtImpSobreRenta.Clear();
            txtTotalaPagar.Clear();
            dbMensualidad.Checked = false;
            dbContrato.Checked = false;
            gbParametrosBusqueda.Enabled = true;
            if (rbAlquiler.Checked == true)
            {
                dgvFacturacion.DataSource = facturacion.listAllRent();
            }
            else if (rbDivorcioAccidente.Checked == true)
            {
                dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
            }
            else if (rbVentas.Checked == true)
            {
                dgvFacturacion.DataSource = facturacion.listAllVentas();
            }
            else
            {
                List<facturacion> list = new List<facturacion>();
                list.AddRange(facturacion.listAllRent());
                list.AddRange(facturacion.listAllDivorciosAccidentes());
                list.AddRange(facturacion.listAllVentas());
                dgvFacturacion.DataSource = list;
            }
            disableInputs();
        }
        private void disableInputs()
        {
            txtCantDevolver.Enabled = false;
            txtNumeroCaso.Enabled = false;
            txtServicio.Enabled = false;
            txtBalanceTotal.Enabled = false;
            txtUltimoPago.Enabled = false;
            gbPagoRealizar.Visible = false;
            txtTotalaPagar.Enabled = false;
            txtBalanceTotal.Enabled = false;
            txtITEBIS.Enabled = false;
            txtImpSobreRenta.Enabled = false;
        }
        // ***************** //

        public frmFacturacion()
        {
            InitializeComponent();
        }
        // when cancelar button is clicked.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                new frmMenu().Show();
            }
        }
        // when form is loaded.
        private void frmFacturacion_Load(object sender, EventArgs e)
        {
            try
            {
                cleanInputs();
                disableInputs();
                if (rbAlquiler.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllRent();
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when alquiler checked status is changed.
        private void rbDivorcioAccidente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAlquiler.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllRent();
                    gbInfomacionInquilino.Text = "Informacion Inquilino";
                    gbInformacionCliente.Text = "Informacion Cliente";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = true;
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                    gbInfomacionInquilino.Text = "Informacion Demandado";
                    gbInformacionCliente.Text = "Informacion Demandante";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = false;
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                    gbInfomacionInquilino.Text = "Informacion Comprador";
                    gbInformacionCliente.Text = "Informacion Vendedor";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = false;
                }
                else
                {
                    List<facturacion> list = new List<facturacion>();
                    list.AddRange(facturacion.listAllRent());
                    list.AddRange(facturacion.listAllDivorciosAccidentes());
                    list.AddRange(facturacion.listAllVentas());
                    dgvFacturacion.DataSource = list;
                    gbInfomacionInquilino.Text = "Informacion Inquilino o Comprador";
                    gbInformacionCliente.Text = "Informacion Cliente o Vendedor";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when alquiler checked status is changed.
        private void rbVentas_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAlquiler.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllRent();
                    gbInfomacionInquilino.Text = "Informacion Inquilino";
                    gbInformacionCliente.Text = "Informacion Cliente";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = true;
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                    gbInfomacionInquilino.Text = "Informacion Demandado";
                    gbInformacionCliente.Text = "Informacion Demandante";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = false;
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                    gbInfomacionInquilino.Text = "Informacion Comprador";
                    gbInformacionCliente.Text = "Informacion Vendedor";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = false;
                }
                else
                {
                    List<facturacion> list = new List<facturacion>();
                    list.AddRange(facturacion.listAllRent());
                    list.AddRange(facturacion.listAllDivorciosAccidentes());
                    list.AddRange(facturacion.listAllVentas());
                    dgvFacturacion.DataSource = list;
                    gbInfomacionInquilino.Text = "Informacion Inquilino o Comprador";
                    gbInformacionCliente.Text = "Informacion Cliente o Vendedor";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when alquiler checked status is changed.
        private void rbAlquiler_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAlquiler.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllRent();
                    gbInfomacionInquilino.Text = "Informacion Inquilino";
                    gbInformacionCliente.Text = "Informacion Cliente";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = true;
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                    gbInfomacionInquilino.Text = "Informacion Demandado";
                    gbInformacionCliente.Text = "Informacion Demandante";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = false;
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                    gbInfomacionInquilino.Text = "Informacion Comprador";
                    gbInformacionCliente.Text = "Informacion Vendedor";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = false;
                }
                else
                {
                    List<facturacion> list = new List<facturacion>();
                    list.AddRange(facturacion.listAllRent());
                    list.AddRange(facturacion.listAllDivorciosAccidentes());
                    list.AddRange(facturacion.listAllVentas());
                    dgvFacturacion.DataSource = list;
                    gbInfomacionInquilino.Text = "Informacion Inquilino o Comprador";
                    gbInformacionCliente.Text = "Informacion Cliente o Vendedor";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when buscar button is cliked.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAlquiler.Checked == true)
                {
                    string cedulaCli, cedulaIn, cedulaGa;
                    if (txtCedula.MaskCompleted)
                    {
                        cedulaCli = txtCedula.Text;
                    }
                    else
                    {
                        cedulaCli = "";
                    }
                    if (txtCedulaDe.MaskCompleted)
                    {
                        cedulaIn = txtCedulaDe.Text;
                    }
                    else
                    {
                        cedulaIn = "";
                    }
                    if (txtCedulaGa.MaskCompleted)
                    {
                        cedulaGa = txtCedulaGa.Text;
                    }
                    else
                    {
                        cedulaGa = "";
                    }
                    dgvFacturacion.DataSource = facturacion.searchRent(cedulaCli, cedulaIn, cedulaGa);
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    string cedulaE, cedulaO;
                    if (txtCedula.MaskCompleted)
                    {
                        cedulaE = txtCedula.Text;
                    }
                    else
                    {
                        cedulaE = "";
                    }
                    if (txtCedulaDe.MaskCompleted)
                    {
                        cedulaO = txtCedulaDe.Text;
                    }
                    else
                    {
                        cedulaO = "";
                    }
                    dgvFacturacion.DataSource = facturacion.searchDivorciosAccidentes(cedulaE, cedulaO);
                }
                else if (rbVentas.Checked == true)
                {
                    string cedulaVE, cedulaCO;
                    if (txtCedula.MaskCompleted)
                    {
                        cedulaVE = txtCedula.Text;
                    }
                    else
                    {
                        cedulaVE = "";
                    }
                    if (txtCedulaDe.MaskCompleted)
                    {
                        cedulaCO = txtCedulaDe.Text;
                    }
                    else
                    {
                        cedulaCO = "";
                    }
                    dgvFacturacion.DataSource = facturacion.searchVentas(cedulaVE, cedulaCO);
                }
                else
                {
                    string cedulaCliVE, cedulaOCO, cedulaGa;
                    if (txtCedula.MaskCompleted)
                    {
                        cedulaCliVE = txtCedula.Text;
                    }
                    else
                    {
                        cedulaCliVE = "";
                    }
                    if (txtCedulaDe.MaskCompleted)
                    {
                        cedulaOCO = txtCedulaDe.Text;
                    }
                    else
                    {
                        cedulaOCO = "";
                    }
                    if (txtCedulaGa.MaskCompleted)
                    {
                        cedulaGa = txtCedulaGa.Text;
                    }
                    else
                    {
                        cedulaGa = "";
                    }

                    // make some list objects based on facturacion objects properties.

                    List<facturacion> list = new List<facturacion>();
                    List<facturacion> list0 = (facturacion.searchVentas(cedulaCliVE, cedulaOCO));
                    List<facturacion> list1 = (facturacion.searchDivorciosAccidentes(cedulaCliVE, cedulaOCO));
                    List<facturacion> list2 = (facturacion.searchRent(cedulaCliVE, cedulaOCO, cedulaGa));
                    // join then if their values is different from null.
                    if (list0 != null) list.AddRange(list0);
                    if (list1 != null) list.AddRange(list1);
                    if (list2 != null) list.AddRange(list2);
                    // load the list into the data grid.
                    dgvFacturacion.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when seleccionar button is clicked.
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            string ID = "", Servicio = "";
            if (dgvFacturacion.SelectedRows.Count == 1)
            {
                ID = dgvFacturacion.CurrentRow.Cells[0].Value.ToString();
                Servicio = dgvFacturacion.CurrentRow.Cells[1].Value.ToString();
                try {
                    if (rbAlquiler.Checked == true)
                    {
                        cleanInputs();
                        pBaseObjfactura = facturacion.getRentStatus(ID);
                        pCliente = clientes.getCustomerObject(pBaseObjfactura.Cliente_ID, "");
                        pService = servicios.getServiceInfo(pBaseObjfactura.Service_ID);
                        dbMensualidad.Checked = true;
                        gbPagoRealizar.Visible = true;
                        txtCedula.Text = pCliente.Cedula;
                        txtNumeroCaso.Text = pBaseObjfactura.Case_ID;
                        txtServicio.Text = pService.Servicio;
                        pbCedula.Image = Image.FromFile(pCliente.Image);
                        if (pBaseObjfactura.fechaUltimoPago == string.Empty || pBaseObjfactura.fechaUltimoPago == null)
                        {
                            txtUltimoPago.Text = "No se ha hecho un pago aun";
                        }
                        else
                        {
                            txtUltimoPago.Text = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).ToLongDateString();
                        }
                        gbParametrosBusqueda.Enabled = false;
                    }
                    else if (rbVentas.Checked == true)
                    {
                        // ventas
                        cleanInputs();
                        pBaseObjfactura = facturacion.getVentasStatus(ID);
                        pCliente = clientes.getCustomerObject(pBaseObjfactura.Cliente_ID, "");
                        pService = servicios.getServiceInfo(pBaseObjfactura.Service_ID);
                        txtBalanceTotal.Text = pBaseObjfactura.TotalPago_Mensualidad;
                        txtCedula.Text = pCliente.Cedula;
                        txtImpSobreRenta.Text = "Incluido";
                        txtITEBIS.Text = "Incluido";
                        txtNumeroCaso.Text = pBaseObjfactura.Case_ID;
                        txtServicio.Text = pService.Servicio;
                        txtTotalaPagar.Text = pBaseObjfactura.TotalPago_Mensualidad;
                        if (pBaseObjfactura.fechaUltimoPago == string.Empty || pBaseObjfactura.fechaUltimoPago == null)
                        {
                            txtUltimoPago.Text = "No se ha hecho un pago aun";
                        }
                        else
                        {
                            txtUltimoPago.Text = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).ToLongDateString();
                        }
                        gbParametrosBusqueda.Enabled = false;
                    }
                    else if (rbDivorcioAccidente.Checked == true)
                    {
                        // divorcios accidente
                        cleanInputs();
                        pBaseObjfactura = facturacion.getDivorciosAccidentesStatus(ID);
                        pCliente = clientes.getCustomerObject(pBaseObjfactura.Cliente_ID, "");
                        pService = servicios.getServiceInfo(pBaseObjfactura.Service_ID);
                        txtBalanceTotal.Text = pBaseObjfactura.TotalPago_Mensualidad;
                        txtCedula.Text = pCliente.Cedula;
                        txtImpSobreRenta.Text = "Incluido";
                        txtITEBIS.Text = "Incluido";
                        txtNumeroCaso.Text = pBaseObjfactura.Case_ID;
                        txtServicio.Text = pService.Servicio;
                        txtTotalaPagar.Text = pBaseObjfactura.TotalPago_Mensualidad;
                        if (pBaseObjfactura.fechaUltimoPago == string.Empty || pBaseObjfactura.fechaUltimoPago == null)
                        {
                            txtUltimoPago.Text = "No se ha hecho un pago aun";
                        }
                        else
                        {
                            txtUltimoPago.Text = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).ToLongDateString();
                        }
                        gbParametrosBusqueda.Enabled = false;
                    }
                    else
                    {
                        // general is selected.
                        if(Servicio == "Alquiler")
                        {
                            // alquiler
                            cleanInputs();
                            pBaseObjfactura = facturacion.getRentStatus(ID);
                            pCliente = clientes.getCustomerObject(pBaseObjfactura.Cliente_ID, "");
                            pService = servicios.getServiceInfo(pBaseObjfactura.Service_ID);
                            dbMensualidad.Checked = true;
                            gbPagoRealizar.Visible = true;
                            txtCedula.Text = pCliente.Cedula;
                            txtNumeroCaso.Text = pBaseObjfactura.Case_ID;
                            txtServicio.Text = pService.Servicio;
                            pbCedula.Image = Image.FromFile(pCliente.Image);
                            if (pBaseObjfactura.fechaUltimoPago == string.Empty || pBaseObjfactura.fechaUltimoPago == null)
                            {
                                txtUltimoPago.Text = "No se ha hecho un pago aun";
                            }
                            else
                            {
                                txtUltimoPago.Text = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).ToLongDateString();
                            }
                            rbAlquiler.Checked = true;
                            gbParametrosBusqueda.Enabled = false;
                        }
                        else if(Servicio == "Divorcio o Accidente")
                        {
                            // Divorcio accidente.
                            cleanInputs();
                            pBaseObjfactura = facturacion.getDivorciosAccidentesStatus(ID);
                            pCliente = clientes.getCustomerObject(pBaseObjfactura.Cliente_ID, "");
                            pService = servicios.getServiceInfo(pBaseObjfactura.Service_ID);
                            txtBalanceTotal.Text = pBaseObjfactura.TotalPago_Mensualidad;
                            txtCedula.Text = pCliente.Cedula;
                            txtImpSobreRenta.Text = "Incluido";
                            txtITEBIS.Text = "Incluido";
                            txtNumeroCaso.Text = pBaseObjfactura.Case_ID;
                            txtServicio.Text = pService.Servicio;
                            txtTotalaPagar.Text = pBaseObjfactura.TotalPago_Mensualidad;
                            if (pBaseObjfactura.fechaUltimoPago == string.Empty || pBaseObjfactura.fechaUltimoPago == null)
                            {
                                txtUltimoPago.Text = "No se ha hecho un pago aun";
                            }
                            else
                            {
                                txtUltimoPago.Text = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).ToLongDateString();
                            }
                            rbDivorcioAccidente.Checked = true;
                            gbParametrosBusqueda.Enabled = false;
                        }
                        else if (Servicio == "Ventas de Inmuebles")
                        {
                            // venta
                            cleanInputs();
                            pBaseObjfactura = facturacion.getVentasStatus(ID);
                            pCliente = clientes.getCustomerObject(pBaseObjfactura.Cliente_ID, "");
                            pService = servicios.getServiceInfo(pBaseObjfactura.Service_ID);
                            txtBalanceTotal.Text = pBaseObjfactura.TotalPago_Mensualidad;
                            txtCedula.Text = pCliente.Cedula;
                            txtImpSobreRenta.Text = "Incluido";
                            txtITEBIS.Text = "Incluido";
                            txtNumeroCaso.Text = pBaseObjfactura.Case_ID;
                            txtServicio.Text = pService.Servicio;
                            txtTotalaPagar.Text = pBaseObjfactura.TotalPago_Mensualidad;
                            if (pBaseObjfactura.fechaUltimoPago == string.Empty || pBaseObjfactura.fechaUltimoPago == null)
                            {
                                txtUltimoPago.Text = "No se ha hecho un pago aun";
                            }
                            else
                            {
                                txtUltimoPago.Text = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).ToLongDateString();
                            }
                            rbVentas.Checked = true;
                            gbParametrosBusqueda.Enabled = false;
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un caso de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // when calcular button is clicked.
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtCantPagar.Text == string.Empty)
            {
                MessageBox.Show("Digite la cantidad que se pagara", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantPagar.Focus();
            }
            else if (txtMoneda.Text == string.Empty)
            {
                MessageBox.Show("Digite la moneda con la que se pagara", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMoneda.Focus();
            }
            else
            {
                if (Convert.ToDouble(txtMoneda.Text) <= 0)
                {
                    MessageBox.Show("La moneda con la que se pagara no debe ser igual o menor de 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMoneda.Focus();
                }
                else if (Convert.ToDouble(txtCantPagar.Text) <= 0)
                {
                    MessageBox.Show("La cantidad a pagar no debe ser igual o menor a 0", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantPagar.Focus();
                }
                else
                {
                    if ((Convert.ToDouble(txtMoneda.Text) - Convert.ToDouble(txtCantPagar.Text)) < 0)
                    {
                        MessageBox.Show("La moneda con que se pagara es menor a la cantidad que se pagara", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMoneda.Clear();
                        txtMoneda.Focus();
                    }
                    else
                    {
                        txtCantDevolver.Text = (Convert.ToDouble(txtMoneda.Text) - Convert.ToDouble(txtCantPagar.Text)).ToString("f2");
                    }
                }
            }
        }
        // when cobrar button is clicked.
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            try {
                if (pBaseObjfactura == null)
                {
                    MessageBox.Show("no se ha tomado una factura de la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnSeleccionar.Focus();
                }
                else if (txtCantDevolver.Text == string.Empty)
                {
                    MessageBox.Show("Tienen que calcular la cantidad a devolver", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnCalcular.Focus();
                }
                else {
                    double pagorealizado, totalpagar, pagomensual, pagocontrato, parestante;
                    if (rbAlquiler.Checked == true)
                    {
                        // alquiler
                        if (txtCantPagar.Text == string.Empty)
                        {
                            MessageBox.Show("No se ha digitado una cantidad a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtCantPagar.Focus();
                        }
                        else if (txtMoneda.Text == string.Empty)
                        {
                            MessageBox.Show("No se ha digitado la moneda con la que se pagara", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtMoneda.Focus();
                        }
                        else
                        {
                            totalpagar = Convert.ToDouble(txtTotalaPagar.Text);
                            pagorealizado = Convert.ToDouble(txtCantPagar.Text);
                            pagocontrato = Convert.ToDouble(pBaseObjfactura.ContratoTotal);
                            DateTime today = DateTime.Now.Date;
                            DateTime nextPayment;
                            if (pBaseObjfactura.fechaUltimoPago == string.Empty || pBaseObjfactura.fechaUltimoPago == null)
                            {
                                nextPayment = today.AddMonths(1);
                            }
                            else
                            {
                                nextPayment = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).AddMonths(1);
                            }
                            if (totalpagar >= pagorealizado)
                            {
                                try
                                {
                                    // verify wich payments the user is going to make.
                                    if (dbContrato.Checked == true && dbMensualidad.Checked == true)
                                    {
                                        // calculate mensualidad total in order to verify payment and calulate if monthly payment was completed.
                                        pagomensual = Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) + Convert.ToDouble(txtITEBIS.Text) + Convert.ToDouble(txtImpSobreRenta.Text);
                                        parestante = pagorealizado - pagomensual;
                                        // make the math to remove the remaing payment amount from the contract.
                                        parestante = pagocontrato - parestante;
                                        // validate if monthly payment was achieved.
                                        if (parestante > 0)
                                        {
                                            if (factura.registerFacturaRent(pBaseObjfactura.Cliente_ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, txtCantPagar.Text, parestante.ToString("f2"), txtTotalaPagar.Text, nextPayment.ToString("yyyy-MM-dd"), parestante.ToString("f2"), "Pago mensualidad y Abono al contrato de alquiler") > 0)
                                            {
                                                // update the payment status
                                                facturacion.updateRentStatus(pBaseObjfactura.ID, "0", DateTime.Today.Date.ToString("yyyy-MM-dd"), parestante.ToString("f2"), nextPayment.ToString("yyyy-MM-dd"));
                                                MessageBox.Show("Factura registrada Exitosamente Proximo Pago: " + nextPayment.ToLongDateString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                        }
                                        else if (parestante == 0)
                                        {
                                            if (factura.registerFacturaRent(pBaseObjfactura.Cliente_ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, txtCantPagar.Text, parestante.ToString("f2"), txtTotalaPagar.Text, nextPayment.ToString("yyyy-MM-dd"), parestante.ToString("f2"), "Pago mensualidad y Pago contrato de alquiler") > 0)
                                            {
                                                facturacion.updateRentStatus(pBaseObjfactura.ID, "0", DateTime.Today.Date.ToString("yyyy-MM-dd"), parestante.ToString("f2"), nextPayment.ToString("yyyy-MM-dd"));
                                                MessageBox.Show("Factura registrada Exitosamente Proximo Pago: " + nextPayment.ToLongDateString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                pBaseObjfactura = null;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El pago realizado excede la cantidad Total a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                    else if (dbContrato.Checked == true)
                                    {
                                        parestante = totalpagar - pagorealizado;
                                        if (parestante > 0)
                                        {
                                            if (factura.registerFacturaRent(pBaseObjfactura.Cliente_ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, txtCantPagar.Text, parestante.ToString("f2"), txtTotalaPagar.Text, pBaseObjfactura.fechaProximoPago, parestante.ToString("f2"), "Abono al contrato de alquiler") > 0)
                                            {
                                                facturacion.updateRentStatus(pBaseObjfactura.ID, "0", DateTime.Today.Date.ToString("yyyy-MM-dd"), parestante.ToString("f2"), pBaseObjfactura.fechaProximoPago);
                                                MessageBox.Show("Factura registrada Exitosamente /n Proximo Pago: " + nextPayment.ToLongDateString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                pBaseObjfactura = null;
                                            }
                                        }
                                        else if (parestante == 0)
                                        {
                                            if (factura.registerFacturaRent(pBaseObjfactura.Cliente_ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, txtCantPagar.Text, parestante.ToString("f2"), txtTotalaPagar.Text, pBaseObjfactura.fechaProximoPago, parestante.ToString("f2"), "Pago total del contrato de alquiler") > 0)
                                            {
                                                facturacion.updateRentStatus(pBaseObjfactura.ID, "0", DateTime.Today.Date.ToString("yyyy-MM-dd"), parestante.ToString("f2"), pBaseObjfactura.fechaProximoPago);
                                                MessageBox.Show("Factura registrada Exitosamente Proximo Pago: " + nextPayment.ToLongDateString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                pBaseObjfactura = null;
                                            }
                                        }
                                    }
                                    else if (dbMensualidad.Checked == true)
                                    {
                                        parestante = totalpagar - pagorealizado;
                                        if (parestante > 0)
                                        {
                                            MessageBox.Show("Debe completar el pago mensual para poder general la factura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                        else if (parestante == 0)
                                        {
                                            if (factura.registerFacturaRent(pBaseObjfactura.Cliente_ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, txtCantPagar.Text, parestante.ToString("f2"), txtTotalaPagar.Text, nextPayment.ToString("yyyy-MM-dd"), parestante.ToString("f2"), "Pago total de la mensualidad") > 0)
                                            {
                                                facturacion.updateRentStatus(pBaseObjfactura.ID, "0", DateTime.Today.Date.ToString("yyyy-MM-dd"), pBaseObjfactura.ContratoTotal, nextPayment.ToString("yyyy-MM-dd"));
                                                MessageBox.Show("Factura registrada Exitosamente Proximo Pago: " + nextPayment.ToLongDateString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                pBaseObjfactura = null;
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("El pago realizado excede la cantidad Total a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("La cantidad a pagar excede el Total a Pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txtCantPagar.Clear();
                                txtCantPagar.Focus();
                            }
                        }
                    }
                    else if (rbVentas.Checked == true)
                    {
                        // ventas
                        totalpagar = Convert.ToDouble(txtTotalaPagar.Text);
                        pagorealizado = Convert.ToDouble(txtCantPagar.Text);
                        parestante = totalpagar - pagorealizado;
                        if (parestante > 0)
                        {
                            if (factura.registerFacturaVenta(pBaseObjfactura.Cliente_ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, totalpagar.ToString("f2"), pagorealizado.ToString("f2"), parestante.ToString("f2"), DateTime.Today.Date.ToString("yyyy-MM-dd"), "Abono contrato de venta") > 0)
                            {
                                MessageBox.Show("Factura registrada exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                facturacion.updateVentaStatus(pBaseObjfactura.ID, parestante.ToString("f2"), pagorealizado.ToString("f2"), DateTime.Today.ToString("yyyy-MM-dd"));
                            }
                        }
                        else if (parestante == 0)
                        {
                            if (factura.registerFacturaVenta(pBaseObjfactura.Cliente_ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, totalpagar.ToString("f2"), pagorealizado.ToString("f2"), parestante.ToString("f2"), DateTime.Today.Date.ToString("yyyy-MM-dd"), "Pago total del contrato de venta") > 0)
                            {
                                MessageBox.Show("Factura registrada exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                facturacion.updateVentaStatus(pBaseObjfactura.ID, parestante.ToString("f2"), pagorealizado.ToString("f2"), DateTime.Today.ToString("yyyy-MM-dd"));
                            }
                        }
                        else
                        {
                            MessageBox.Show("El pago realizado excede la cantidad que se tienen que pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (rbDivorcioAccidente.Checked == true)
                    {
                        // divorcio accidente
                        totalpagar = Convert.ToDouble(txtTotalaPagar.Text);
                        pagorealizado = Convert.ToDouble(txtCantPagar.Text);
                        parestante = totalpagar - pagorealizado;
                        if (parestante > 0)
                        {
                            if (factura.registerFacturaDivorciosAccidente(pBaseObjfactura.Cliente_ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, totalpagar.ToString("f2"), pagorealizado.ToString("f2"), parestante.ToString("f2"), DateTime.Today.Date.ToString("yyyy-MM-dd"), "Abono a cuenta") > 0)
                            {
                                MessageBox.Show("Factura registrada exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                facturacion.updateDivorciosAccidenteStatus(pBaseObjfactura.ID, parestante.ToString("f2"), pagorealizado.ToString("f2"), DateTime.Today.Date.ToString("yyyy-MM-dd"));
                            }
                        }
                        else if (parestante == 0)
                        {
                            if (factura.registerFacturaDivorciosAccidente(pBaseObjfactura.Cliente_ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, totalpagar.ToString("f2"), pagorealizado.ToString("f2"), parestante.ToString("f2"), DateTime.Today.Date.ToString("yyyy-MM-dd"), "Pago total") > 0)
                            {
                                MessageBox.Show("Factura registrada exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                facturacion.updateDivorciosAccidenteStatus(pBaseObjfactura.ID, parestante.ToString("f2"), pagorealizado.ToString("f2"), DateTime.Today.ToString("yyyy-MM-dd"));
                            }
                        }
                        else
                        {
                            MessageBox.Show("El pago realizado excede el total a pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when  limpiar button is clicked on informacion cliente.
        private void btnCleanCustoInfo_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            gbParametrosBusqueda.Enabled = true;
            try {
                pbCedula.Image = Image.FromFile(@"C:\FactoriadeProyectos\Sistema-oficina-abogados\Images\n.png");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo encontrar la imagen error: " + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // when limpiar is clicked on case group.
        private void btnCleanCaseInfo_Click(object sender, EventArgs e)
        {
            txtCantDevolver.Clear();
            txtCantPagar.Clear();
            txtMoneda.Clear();
            txtNumeroCaso.Clear();
            txtServicio.Clear();
            txtBalanceTotal.Clear();
            txtUltimoPago.Clear();
        }
        // when limpiar button is clicked.
        private void btnCleanAll_Click(object sender, EventArgs e)
        {
            try
            {
                cleanInputs();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // when buscar factura is clicked.
        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            new frmSearchFacturas().Show();
        }
        // when cb mensualidad changes.
        private void dbMensualidad_CheckedChanged(object sender, EventArgs e)
        {
            if (servicios.getServiceInfo(pBaseObjfactura.Service_ID).Servicio == "Alquiler")
            {
                if (dbContrato.Checked == true && dbMensualidad.Checked == true)
                {
                    txtBalanceTotal.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) + Convert.ToDouble(pBaseObjfactura.ContratoTotal)).ToString("f2");
                    txtITEBIS.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) * 0.18).ToString("f2");
                    txtImpSobreRenta.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) * 0.10).ToString("f2");
                    txtTotalaPagar.Text = (Convert.ToDouble(txtBalanceTotal.Text) + Convert.ToDouble(txtImpSobreRenta.Text) + Convert.ToDouble(txtITEBIS.Text)).ToString("f2");
                }
                else if (dbContrato.Checked == true)
                {
                    txtBalanceTotal.Text = Convert.ToDouble(pBaseObjfactura.ContratoTotal).ToString("f2");
                    txtITEBIS.Text = "Incluido";
                    txtImpSobreRenta.Text = "Incluido";
                    txtTotalaPagar.Text = Convert.ToDouble(pBaseObjfactura.ContratoTotal).ToString("f2");
                }
                else if (dbMensualidad.Checked == true)
                {
                    txtBalanceTotal.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad)).ToString("f2");
                    txtITEBIS.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) * 0.18).ToString("f2");
                    txtImpSobreRenta.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) * 0.10).ToString("f2");
                    txtTotalaPagar.Text = (Convert.ToDouble(txtBalanceTotal.Text) + Convert.ToDouble(txtImpSobreRenta.Text) + Convert.ToDouble(txtITEBIS.Text)).ToString("f2");
                }
                else
                {
                    txtBalanceTotal.Text = "0.00";
                    gbPagoRealizar.Focus();
                }
            }
        }
        // when cb contrato changes.
        private void dbContrato_CheckedChanged(object sender, EventArgs e)
        {
            if (servicios.getServiceInfo(pBaseObjfactura.Service_ID).Servicio == "Alquiler")
            {
                if (servicios.getServiceInfo(pBaseObjfactura.Service_ID).Servicio == "Alquiler")
                {
                    if (dbContrato.Checked == true && dbMensualidad.Checked == true)
                    {
                        txtBalanceTotal.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) + Convert.ToDouble(pBaseObjfactura.ContratoTotal)).ToString("f2");
                        txtITEBIS.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) * 0.18).ToString("f2");
                        txtImpSobreRenta.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) * 0.10).ToString("f2");
                        txtTotalaPagar.Text = (Convert.ToDouble(txtBalanceTotal.Text) + Convert.ToDouble(txtImpSobreRenta.Text) + Convert.ToDouble(txtITEBIS.Text)).ToString("f2");
                    }
                    else if (dbContrato.Checked == true)
                    {
                        txtBalanceTotal.Text = Convert.ToDouble(pBaseObjfactura.ContratoTotal).ToString("f2");
                        txtITEBIS.Text = "Incluido";
                        txtImpSobreRenta.Text = "Incluido";
                        txtTotalaPagar.Text = Convert.ToDouble(pBaseObjfactura.ContratoTotal).ToString("f2");
                    }
                    else if (dbMensualidad.Checked == true)
                    {
                        txtBalanceTotal.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad)).ToString("f2");
                        txtITEBIS.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) * 0.18).ToString("f2");
                        txtImpSobreRenta.Text = (Convert.ToDouble(pBaseObjfactura.TotalPago_Mensualidad) * 0.10).ToString("f2");
                        txtTotalaPagar.Text = (Convert.ToDouble(txtBalanceTotal.Text) + Convert.ToDouble(txtImpSobreRenta.Text) + Convert.ToDouble(txtITEBIS.Text)).ToString("f2");
                    }
                    else
                    {
                        txtBalanceTotal.Text = "0.00";
                        MessageBox.Show("Debe seleccionar el pago que se realizara", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        gbPagoRealizar.Focus();
                    }
                }
            }
        }
        // none
        private void lblTotalaPagar_Click(object sender, EventArgs e)
        {

        }
        // none
        private void txtTotalaPagar_TextChanged(object sender, EventArgs e)
        {

        }
        // when radio button general is clicked.
        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAlquiler.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllRent();
                    gbInfomacionInquilino.Text = "Informacion Inquilino";
                    gbInformacionCliente.Text = "Informacion Cliente";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = true;
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                    gbInfomacionInquilino.Text = "Informacion Demandado";
                    gbInformacionCliente.Text = "Informacion Demandante";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = false;
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                    gbInfomacionInquilino.Text = "Informacion Comprador";
                    gbInformacionCliente.Text = "Informacion Vendedor";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = false;
                }
                else
                {
                    List<facturacion> list = new List<facturacion>();
                    list.AddRange(facturacion.listAllRent());
                    list.AddRange(facturacion.listAllDivorciosAccidentes());
                    list.AddRange(facturacion.listAllVentas());
                    dgvFacturacion.DataSource = list;
                    gbInfomacionInquilino.Text = "Informacion Inquilino o Comprador";
                    gbInformacionCliente.Text = "Informacion Cliente o Vendedor";
                    gbInformacionGarante.Text = "Informacion Garante";
                    gbInformacionGarante.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when radio button cedula is clicked.
        private void rbCedula_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedula.Checked)
            {
                txtCedula.Clear();
                txtCedula.Mask = "000-0000000-0";
            }
            else
            {
                txtCedula.Clear();
                txtCedula.Mask = "SE-000-0000";
            }
        }
        // when radio button pasaporte is clicked.
        private void rbPasaporte_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedula.Checked)
            {
                txtCedula.Clear();
                txtCedula.Mask = "000-0000000-0";
            }
            else
            {
                txtCedula.Clear();
                txtCedula.Mask = "SE-000-0000";
            }
        }
        // when radio button cedula is clicked.
        private void rbCedulaDE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaDE.Checked)
            {
                txtCedulaDe.Clear();
                txtCedulaDe.Mask = "000-0000000-0";
            }
            else
            {
                txtCedulaDe.Clear();
                txtCedulaDe.Mask = "SE-000-0000";
            }
        }
        // when redio button pasaporte is clicked.
        private void rbPasaporteDE_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaDE.Checked)
            {
                txtCedulaDe.Clear();
                txtCedulaDe.Mask = "000-0000000-0";
            }
            else
            {
                txtCedulaDe.Clear();
                txtCedulaDe.Mask = "SE-000-0000";
            }
        }
        // when redio button cedula is clicked.
        private void rbCedulaGa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaGa.Checked)
            {
                txtCedulaGa.Clear();
                txtCedulaGa.Mask = "000-0000000-0";
            }
            else
            {
                txtCedulaGa.Clear();
                txtCedulaGa.Mask = "SE-000-0000";
            }
        }
        // when redio button pasaporte is clicked.
        private void rbPasaporteGa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCedulaGa.Checked)
            {
                txtCedulaGa.Clear();
                txtCedulaGa.Mask = "000-0000000-0";
            }
            else
            {
                txtCedulaGa.Clear();
                txtCedulaGa.Mask = "SE-000-0000";
            }
        }
    }
}
