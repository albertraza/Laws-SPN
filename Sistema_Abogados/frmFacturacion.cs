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
            txtApellido.Clear();
            txtCantDevolver.Clear();
            txtCantPagar.Clear();
            txtCedula.Clear();
            txtMoneda.Clear();
            txtNombre.Clear();
            txtNumeroCaso.Clear();
            txtServicio.Clear();
            txtTotalaPagar.Clear();
            txtUltimoPago.Clear();
            rbDivorcioAccidente.Checked = true;
            if (rbAlquiler.Checked == true)
            {
                dgvFacturacion.DataSource = facturacion.listAllRent();
                lblTotalaPagar.Text = "Mensualidad:";
                txtUltimoPago.Visible = true;
                lblFechaUltimoPago.Visible = true;
            }
            else if (rbDivorcioAccidente.Checked == true)
            {
                dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                lblTotalaPagar.Text = "Total a Pagar:";
                txtUltimoPago.Visible = false;
                lblFechaUltimoPago.Visible = false;
            }
            else if (rbVentas.Checked == true)
            {
                dgvFacturacion.DataSource = facturacion.listAllVentas();
                lblTotalaPagar.Text = "Total a Pagar:";
                txtUltimoPago.Visible = false;
                lblFechaUltimoPago.Visible = false;
            }
            else
            {
                List<facturacion> list = new List<facturacion>();
                list.AddRange(facturacion.listAllRent());
                list.AddRange(facturacion.listAllDivorciosAccidentes());
                list.AddRange(facturacion.listAllVentas());
                dgvFacturacion.DataSource = list;
            }
        }
        private void disableInputs()
        {
            txtCantDevolver.Enabled = false;
            txtNumeroCaso.Enabled = false;
            txtServicio.Enabled = false;
            txtTotalaPagar.Enabled = false;
            txtUltimoPago.Enabled = false;
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
                    lblTotalaPagar.Text = "Mensualidad:";
                    txtUltimoPago.Visible = true;
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
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
                    lblTotalaPagar.Text = "Mensualidad:";
                    txtUltimoPago.Visible = true;
                    lblFechaUltimoPago.Visible = true;
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
                }
                else
                {
                    List<facturacion> list = new List<facturacion>();
                    list.AddRange(facturacion.listAllRent());
                    list.AddRange(facturacion.listAllDivorciosAccidentes());
                    list.AddRange(facturacion.listAllVentas());
                    dgvFacturacion.DataSource = list;
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
                    lblTotalaPagar.Text = "Mensualidad:";
                    txtUltimoPago.Visible = true;
                    lblFechaUltimoPago.Visible = true;
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
                }
                else
                {
                    List<facturacion> list = new List<facturacion>();
                    list.AddRange(facturacion.listAllRent());
                    list.AddRange(facturacion.listAllDivorciosAccidentes());
                    list.AddRange(facturacion.listAllVentas());
                    dgvFacturacion.DataSource = list;
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
                    lblTotalaPagar.Text = "Mensualidad:";
                    txtUltimoPago.Visible = true;
                    lblFechaUltimoPago.Visible = true;
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
                }
                else
                {
                    List<facturacion> list = new List<facturacion>();
                    list.AddRange(facturacion.listAllRent());
                    list.AddRange(facturacion.listAllDivorciosAccidentes());
                    list.AddRange(facturacion.listAllVentas());
                    dgvFacturacion.DataSource = list;
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
                    string cedula, nombre, apellido;
                    if (txtCedula.MaskCompleted)
                    {
                        cedula = txtCedula.Text;
                    }
                    else
                    {
                        cedula = "";
                    }
                    if (txtNombre.Text == string.Empty)
                    {
                        nombre = "";
                    }
                    else
                    {
                        nombre = txtNombre.Text;
                    }
                    if (txtApellido.Text == string.Empty)
                    {
                        apellido = "";
                    }
                    else
                    {
                        apellido = txtApellido.Text;
                    }
                    dgvFacturacion.DataSource = facturacion.searchRent(cedula, nombre, apellido);
                    lblTotalaPagar.Text = "Mensualidad:";
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    string cedula, nombre, apellido;
                    if (txtCedula.MaskCompleted)
                    {
                        cedula = txtCedula.Text;
                    }
                    else
                    {
                        cedula = "";
                    }
                    if (txtNombre.Text == string.Empty)
                    {
                        nombre = "";
                    }
                    else
                    {
                        nombre = txtNombre.Text;
                    }
                    if (txtApellido.Text == string.Empty)
                    {
                        apellido = "";
                    }
                    else
                    {
                        apellido = txtApellido.Text;
                    }
                    dgvFacturacion.DataSource = facturacion.searchDivorciosAccidentes(cedula, nombre, apellido);
                    lblTotalaPagar.Text = "Total a Pagar:";
                }
                else if (rbVentas.Checked == true)
                {
                    string cedula, nombre, apellido;
                    if (txtCedula.MaskCompleted)
                    {
                        cedula = txtCedula.Text;
                    }
                    else
                    {
                        cedula = "";
                    }
                    if (txtNombre.Text == string.Empty)
                    {
                        nombre = "";
                    }
                    else
                    {
                        nombre = txtNombre.Text;
                    }
                    if (txtApellido.Text == string.Empty)
                    {
                        apellido = "";
                    }
                    else
                    {
                        apellido = txtApellido.Text;
                    }
                    dgvFacturacion.DataSource = facturacion.searchVentas(cedula, nombre, apellido);
                    lblTotalaPagar.Text = "Total a Pagar:";
                }
                else
                {
                    string cedula, nombre, apellido;
                    if (txtCedula.MaskCompleted)
                    {
                        cedula = txtCedula.Text;
                    }
                    else
                    {
                        cedula = "";
                    }
                    if (txtNombre.Text == string.Empty)
                    {
                        nombre = "";
                    }
                    else
                    {
                        nombre = txtNombre.Text;
                    }
                    if (txtApellido.Text == string.Empty)
                    {
                        apellido = "";
                    }
                    else
                    {
                        apellido = txtApellido.Text;
                    }
                    List<facturacion> list = new List<facturacion>();
                    list.AddRange(facturacion.searchVentas(cedula, nombre, apellido));
                    list.AddRange(facturacion.searchDivorciosAccidentes(cedula, nombre, apellido));
                    list.AddRange(facturacion.searchRent(cedula, nombre, apellido));
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
            try
            {
                if (rbAlquiler.Checked == true)
                {
                    // alquiler
                    if (dgvFacturacion.SelectedRows.Count == 1)
                    {
                        // get facturacion data in deep.
                        facturacionBaseObj pFacturaBase = facturacion.getRentStatus(dgvFacturacion.CurrentRow.Cells[0].Value.ToString());
                        if (pFacturaBase != null)
                        {
                            pBaseObjfactura = pFacturaBase;
                            // get customer data.
                            pCliente = clientes.getCustomerObject(pFacturaBase.Cliente_ID);
                            // get service data.
                            pService = servicios.getServiceInfo(pFacturaBase.Service_ID);
                            txtNombre.Text = pCliente.Nombre;
                            txtApellido.Text = pCliente.Apellido;
                            txtCedula.Text = pCliente.Cedula;
                            txtServicio.Text = pService.Servicio;
                            txtNumeroCaso.Text = pFacturaBase.ID;

                            DateTime fechaActual = DateTime.Today.Date;
                            DateTime proximoPago;
                            if (pBaseObjfactura.fechaUltimoPago == null || pBaseObjfactura.fechaUltimoPago == string.Empty)
                            {
                                txtUltimoPago.Text = "No se ha hecho un pago";
                                proximoPago = fechaActual.AddMonths(1);
                            }
                            else
                            {
                                txtUltimoPago.Text = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).ToLongDateString();
                                proximoPago = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).AddMonths(1);
                            }

                            if (Convert.ToDouble(pBaseObjfactura.Abono_Deposito) <= 0)
                            {
                                txtTotalaPagar.Text = pFacturaBase.TotalPago_Mensualidad;
                                lblTotalaPagar.Text = "Mensualidad:";
                            }
                            else
                            {
                                txtTotalaPagar.Text = (Convert.ToDouble(pFacturaBase.TotalPago_Mensualidad) + Convert.ToDouble(pBaseObjfactura.Abono_Deposito)).ToString("f2");
                                lblTotalaPagar.Text = "Mensuali. y Dep :";
                            }
                            pbCedula.Image = Image.FromFile(pCliente.Image);
                        }
                        else
                        {
                            MessageBox.Show("El caso o el status no existen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado un Alquiler de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    // divorcio y accidente.
                    if (dgvFacturacion.SelectedRows.Count == 1)
                    {
                        // load status data.
                        facturacionBaseObj pFacturacionObj = facturacion.getDivorciosAccidentesStatus(dgvFacturacion.CurrentRow.Cells[0].Value.ToString());
                        if (pFacturacionObj != null)
                        {
                            pBaseObjfactura = pFacturacionObj;
                            // load customer data.
                            pCliente = clientes.getCustomerObject(pFacturacionObj.Cliente_ID);
                            // load service data.
                            pService = servicios.getServiceInfo(pFacturacionObj.Service_ID);
                            txtCedula.Text = pCliente.Cedula;
                            txtNombre.Text = pCliente.Nombre;
                            txtApellido.Text = pCliente.Apellido;
                            txtTotalaPagar.Text = pFacturacionObj.TotalPago_Mensualidad;
                            txtNumeroCaso.Text = pFacturacionObj.Case_ID;
                            txtServicio.Text = pService.Servicio;
                            pbCedula.Image = Image.FromFile(pCliente.Image);
                        }
                        else
                        {
                            MessageBox.Show("El caso o el Status del caso no existen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado un Caso de Divorcio o Alquiler de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (rbVentas.Checked == true)
                {
                    // ventas.
                    if (dgvFacturacion.SelectedRows.Count == 1)
                    {
                        // load status data.
                        facturacionBaseObj pfacturacion = facturacion.getVentasStatus(dgvFacturacion.CurrentRow.Cells[0].Value.ToString());
                        if (pfacturacion != null)
                        {
                            pBaseObjfactura = pfacturacion;
                            // load customer data.
                            pCliente = clientes.getCustomerObject(pfacturacion.Cliente_ID);
                            // load service info.
                            pService = servicios.getServiceInfo(pfacturacion.Service_ID);
                            txtCedula.Text = pCliente.Cedula;
                            txtNombre.Text = pCliente.Nombre;
                            txtApellido.Text = pCliente.Apellido;
                            txtTotalaPagar.Text = pfacturacion.TotalPago_Mensualidad;
                            txtServicio.Text = pService.Servicio;
                            txtNumeroCaso.Text = pfacturacion.Case_ID;
                            pbCedula.Image = Image.FromFile(pCliente.Image);
                        }
                        else
                        {
                            MessageBox.Show("El Caso o el Status no encontrados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado una venta de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtCantDevolver.Text = (Convert.ToDouble(txtMoneda.Text) - Convert.ToDouble(txtCantPagar.Text)).ToString("f2");
            }
        }
        // when General radio button is clicked.
        private void rbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbAlquiler.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllRent();
                    lblTotalaPagar.Text = "Mensualidad:";
                    txtUltimoPago.Visible = true;
                    lblFechaUltimoPago.Visible = true;
                }
                else if (rbDivorcioAccidente.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllDivorciosAccidentes();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
                }
                else if (rbVentas.Checked == true)
                {
                    dgvFacturacion.DataSource = facturacion.listAllVentas();
                    lblTotalaPagar.Text = "Total a Pagar:";
                    txtUltimoPago.Visible = false;
                    lblFechaUltimoPago.Visible = false;
                }
                else
                {
                    List<facturacion> list = new List<facturacion>();
                    list.AddRange(facturacion.listAllRent());
                    list.AddRange(facturacion.listAllDivorciosAccidentes());
                    list.AddRange(facturacion.listAllVentas());
                    dgvFacturacion.DataSource = list;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // when cobrar button is clicked.
        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == string.Empty && txtNombre.Text == string.Empty && txtApellido.Text == string.Empty && txtNumeroCaso.Text == string.Empty && txtCantPagar.Text == string.Empty)
            {
                MessageBox.Show("No se ha cargado el caso, tome uno de la tabla", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnSeleccionar.Focus();
            }
            else if (txtCantDevolver.Text == string.Empty && txtMoneda.Text == string.Empty && txtCantPagar.Text == string.Empty)
            {
                MessageBox.Show("No se ha calculado la cantidad que se devolvera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnCalcular.Focus();
            }
            else
            {
                if (Convert.ToDouble(txtTotalaPagar.Text) < Convert.ToDouble(txtCantPagar.Text))
                {
                    MessageBox.Show("El pago a realizar no debe ser mayor a la cantidad que se debe pagar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantPagar.Focus();
                }
                else if (Convert.ToDouble(txtCantPagar.Text) == 0)
                {
                    MessageBox.Show("La cantidad a pagar no puede ser cero, digite una valida", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantPagar.Focus();
                }
                else if (Convert.ToDouble(txtCantPagar.Text) < 0)
                {
                    MessageBox.Show("La cantidad a pagar no debe ser menor de cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantPagar.Focus();
                }
                else
                {
                    double tp, pr, cp, abono;
                    cp = Convert.ToDouble(txtCantPagar.Text);
                    tp = Convert.ToDouble(txtTotalaPagar.Text);
                    abono = Convert.ToDouble(pBaseObjfactura.Abono_Deposito);
                    abono = abono - cp;
                    if(abono <= 0)
                    {
                        abono = 0;
                    }
                    pr = tp - cp;
                    DateTime proximoPago;
                    DateTime fechaActual = DateTime.Today.Date;
                    if(pBaseObjfactura.fechaUltimoPago == null || pBaseObjfactura.fechaUltimoPago == string.Empty)
                    {
                        proximoPago = fechaActual.AddMonths(1);
                    }
                    else
                    {
                        proximoPago = Convert.ToDateTime(pBaseObjfactura.fechaUltimoPago).AddMonths(1);
                    }
                    try
                    {
                        if(pBaseObjfactura.Service_ID == "3")
                        {
                            // Alquiler
                            if(Convert.ToDouble(pBaseObjfactura.Abono_Deposito) == 0)
                            {
                                if(facturacion.registerFacturaRent(pCliente.ID, pService.ID, pBaseObjfactura.Case_ID, cp.ToString("f2"), pr.ToString("f2"), tp.ToString("f2"), proximoPago.ToString("yyyy-MM-dd"), pr.ToString("f2"), "Pago mensualidad") > 0)
                                {
                                    MessageBox.Show("Factura registrada exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    facturacion.updateRentStatus(pBaseObjfactura.ID, "0", DateTime.Today.Date.ToString("yyyy-MM-dd"));
                                    cleanInputs();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo registrar la factura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                double deposito = Convert.ToDouble(pBaseObjfactura.Abono_Deposito);
                                deposito = deposito - cp;
                                if(deposito <= 0)
                                {
                                    deposito = 0;
                                }
                                if(facturacion.registerFacturaRent(pCliente.ID, pService.ID, pBaseObjfactura.Case_ID, cp.ToString("f2"), pr.ToString("f2"), tp.ToString("f2"), proximoPago.ToString("yyyy-MM-dd"), pr.ToString("f2"), "Pago mensualidad y deposito") > 0)
                                {
                                    MessageBox.Show("Factura registrada Exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    facturacion.updateRentStatus(pBaseObjfactura.ID, deposito.ToString("f2"), DateTime.Today.Date.ToString("yyyy-MM-dd"));
                                    cleanInputs();
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo registrar la factura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                        }
                        else if(pBaseObjfactura.Service_ID == "4")
                        {
                            // Divorcios o Accidente
                            if(facturacion.registerFacturaDivorciosAccidente(pBaseObjfactura.ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, tp.ToString("f2"), cp.ToString("f2"), pr.ToString("f2")) > 0)
                            {
                                MessageBox.Show("Factura registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                facturacion.updateDivorciosAccidenteStatus(pBaseObjfactura.ID, pr.ToString("f2"), abono.ToString("f2"));
                                cleanInputs();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo registrar la factura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            // Ventas
                            if(facturacion.registerFacturaVenta(pBaseObjfactura.ID, pBaseObjfactura.Service_ID, pBaseObjfactura.Case_ID, tp.ToString("f2"), cp.ToString("f2"), pr.ToString("f2")) > 0)
                            {
                                MessageBox.Show("Factura registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                facturacion.updateVentaStatus(pBaseObjfactura.ID, pr.ToString("f2"), abono.ToString("f2"));
                                cleanInputs();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo registrar la factura", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // when  limpiar button is clicked on informacion cliente.
        private void btnCleanCustoInfo_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
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
            txtTotalaPagar.Clear();
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
    }
}
