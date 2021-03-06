﻿namespace Sistema_Abogados
{
    partial class frmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbParametrosBusqueda = new System.Windows.Forms.GroupBox();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbAlquiler = new System.Windows.Forms.RadioButton();
            this.rbVentas = new System.Windows.Forms.RadioButton();
            this.rbDivorcioAccidente = new System.Windows.Forms.RadioButton();
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.txtBalanceTotal = new System.Windows.Forms.TextBox();
            this.lblTotalaPagar = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtNumeroCaso = new System.Windows.Forms.TextBox();
            this.lblNumeroCaso = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.lblServicio = new System.Windows.Forms.Label();
            this.txtCantPagar = new System.Windows.Forms.TextBox();
            this.lblCantidadaPagar = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.lblDevuelta = new System.Windows.Forms.Label();
            this.txtCantDevolver = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblFechaUltimoPago = new System.Windows.Forms.Label();
            this.txtUltimoPago = new System.Windows.Forms.TextBox();
            this.gbInformacionCliente = new System.Windows.Forms.GroupBox();
            this.rbPasaporte = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbInformacionCaso = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalaPagar = new System.Windows.Forms.TextBox();
            this.lblImpRenta = new System.Windows.Forms.Label();
            this.btnCleanCaseInfo = new System.Windows.Forms.Button();
            this.txtImpSobreRenta = new System.Windows.Forms.TextBox();
            this.lblITEBIS = new System.Windows.Forms.Label();
            this.txtITEBIS = new System.Windows.Forms.TextBox();
            this.gbPagoRealizar = new System.Windows.Forms.GroupBox();
            this.dbMensualidad = new System.Windows.Forms.CheckBox();
            this.dbContrato = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.pbCedula = new System.Windows.Forms.PictureBox();
            this.btnCleanAll = new System.Windows.Forms.Button();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.gbInfomacionInquilino = new System.Windows.Forms.GroupBox();
            this.rbPasaporteDE = new System.Windows.Forms.RadioButton();
            this.rbCedulaDE = new System.Windows.Forms.RadioButton();
            this.lblCedulaDe = new System.Windows.Forms.Label();
            this.txtCedulaDe = new System.Windows.Forms.MaskedTextBox();
            this.gbInformacionGarante = new System.Windows.Forms.GroupBox();
            this.rbPasaporteGa = new System.Windows.Forms.RadioButton();
            this.rbCedulaGa = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCedulaGa = new System.Windows.Forms.MaskedTextBox();
            this.gbParametrosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.gbInformacionCliente.SuspendLayout();
            this.gbInformacionCaso.SuspendLayout();
            this.gbPagoRealizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCedula)).BeginInit();
            this.gbInfomacionInquilino.SuspendLayout();
            this.gbInformacionGarante.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbParametrosBusqueda
            // 
            this.gbParametrosBusqueda.Controls.Add(this.rbGeneral);
            this.gbParametrosBusqueda.Controls.Add(this.rbAlquiler);
            this.gbParametrosBusqueda.Controls.Add(this.rbVentas);
            this.gbParametrosBusqueda.Controls.Add(this.rbDivorcioAccidente);
            this.gbParametrosBusqueda.Location = new System.Drawing.Point(8, 12);
            this.gbParametrosBusqueda.Name = "gbParametrosBusqueda";
            this.gbParametrosBusqueda.Size = new System.Drawing.Size(488, 51);
            this.gbParametrosBusqueda.TabIndex = 0;
            this.gbParametrosBusqueda.TabStop = false;
            this.gbParametrosBusqueda.Text = "Servicios";
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Location = new System.Drawing.Point(393, 20);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(62, 17);
            this.rbGeneral.TabIndex = 3;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "General";
            this.rbGeneral.UseVisualStyleBackColor = true;
            this.rbGeneral.CheckedChanged += new System.EventHandler(this.rbGeneral_CheckedChanged);
            // 
            // rbAlquiler
            // 
            this.rbAlquiler.AutoSize = true;
            this.rbAlquiler.Location = new System.Drawing.Point(280, 19);
            this.rbAlquiler.Name = "rbAlquiler";
            this.rbAlquiler.Size = new System.Drawing.Size(59, 17);
            this.rbAlquiler.TabIndex = 2;
            this.rbAlquiler.TabStop = true;
            this.rbAlquiler.Text = "Alquiler";
            this.rbAlquiler.UseVisualStyleBackColor = true;
            this.rbAlquiler.CheckedChanged += new System.EventHandler(this.rbAlquiler_CheckedChanged);
            // 
            // rbVentas
            // 
            this.rbVentas.AutoSize = true;
            this.rbVentas.Location = new System.Drawing.Point(180, 19);
            this.rbVentas.Name = "rbVentas";
            this.rbVentas.Size = new System.Drawing.Size(58, 17);
            this.rbVentas.TabIndex = 1;
            this.rbVentas.TabStop = true;
            this.rbVentas.Text = "Ventas";
            this.rbVentas.UseVisualStyleBackColor = true;
            this.rbVentas.CheckedChanged += new System.EventHandler(this.rbVentas_CheckedChanged);
            // 
            // rbDivorcioAccidente
            // 
            this.rbDivorcioAccidente.AutoSize = true;
            this.rbDivorcioAccidente.Location = new System.Drawing.Point(16, 19);
            this.rbDivorcioAccidente.Name = "rbDivorcioAccidente";
            this.rbDivorcioAccidente.Size = new System.Drawing.Size(129, 17);
            this.rbDivorcioAccidente.TabIndex = 0;
            this.rbDivorcioAccidente.TabStop = true;
            this.rbDivorcioAccidente.Text = "Divorcios o Accidente";
            this.rbDivorcioAccidente.UseVisualStyleBackColor = true;
            this.rbDivorcioAccidente.CheckedChanged += new System.EventHandler(this.rbDivorcioAccidente_CheckedChanged);
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturacion.Location = new System.Drawing.Point(8, 351);
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.Size = new System.Drawing.Size(717, 195);
            this.dgvFacturacion.TabIndex = 3;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(21, 30);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 4;
            this.lblCedula.Text = "Cedula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(70, 27);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 5;
            // 
            // txtBalanceTotal
            // 
            this.txtBalanceTotal.Location = new System.Drawing.Point(115, 71);
            this.txtBalanceTotal.Name = "txtBalanceTotal";
            this.txtBalanceTotal.Size = new System.Drawing.Size(82, 20);
            this.txtBalanceTotal.TabIndex = 11;
            this.txtBalanceTotal.TextChanged += new System.EventHandler(this.txtTotalaPagar_TextChanged);
            // 
            // lblTotalaPagar
            // 
            this.lblTotalaPagar.AutoSize = true;
            this.lblTotalaPagar.Location = new System.Drawing.Point(21, 74);
            this.lblTotalaPagar.Name = "lblTotalaPagar";
            this.lblTotalaPagar.Size = new System.Drawing.Size(76, 13);
            this.lblTotalaPagar.TabIndex = 10;
            this.lblTotalaPagar.Text = "Balance Total:";
            this.lblTotalaPagar.Click += new System.EventHandler(this.lblTotalaPagar_Click);
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(443, 71);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(69, 20);
            this.txtMoneda.TabIndex = 13;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(390, 74);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(49, 13);
            this.lblMoneda.TabIndex = 12;
            this.lblMoneda.Text = "Moneda:";
            // 
            // txtNumeroCaso
            // 
            this.txtNumeroCaso.Location = new System.Drawing.Point(86, 29);
            this.txtNumeroCaso.Name = "txtNumeroCaso";
            this.txtNumeroCaso.Size = new System.Drawing.Size(59, 20);
            this.txtNumeroCaso.TabIndex = 15;
            // 
            // lblNumeroCaso
            // 
            this.lblNumeroCaso.AutoSize = true;
            this.lblNumeroCaso.Location = new System.Drawing.Point(27, 32);
            this.lblNumeroCaso.Name = "lblNumeroCaso";
            this.lblNumeroCaso.Size = new System.Drawing.Size(53, 13);
            this.lblNumeroCaso.TabIndex = 14;
            this.lblNumeroCaso.Text = "Caso NO:";
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(202, 29);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(100, 20);
            this.txtServicio.TabIndex = 17;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(149, 32);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(48, 13);
            this.lblServicio.TabIndex = 16;
            this.lblServicio.Text = "Servicio:";
            // 
            // txtCantPagar
            // 
            this.txtCantPagar.Location = new System.Drawing.Point(298, 71);
            this.txtCantPagar.Name = "txtCantPagar";
            this.txtCantPagar.Size = new System.Drawing.Size(68, 20);
            this.txtCantPagar.TabIndex = 19;
            // 
            // lblCantidadaPagar
            // 
            this.lblCantidadaPagar.AutoSize = true;
            this.lblCantidadaPagar.Location = new System.Drawing.Point(203, 74);
            this.lblCantidadaPagar.Name = "lblCantidadaPagar";
            this.lblCantidadaPagar.Size = new System.Drawing.Size(92, 13);
            this.lblCantidadaPagar.TabIndex = 18;
            this.lblCantidadaPagar.Text = "Cantidad a Pagar:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(536, 322);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(128, 23);
            this.btnSeleccionar.TabIndex = 20;
            this.btnSeleccionar.Text = "Seleccionar Caso";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // lblDevuelta
            // 
            this.lblDevuelta.AutoSize = true;
            this.lblDevuelta.Location = new System.Drawing.Point(518, 74);
            this.lblDevuelta.Name = "lblDevuelta";
            this.lblDevuelta.Size = new System.Drawing.Size(53, 13);
            this.lblDevuelta.TabIndex = 22;
            this.lblDevuelta.Text = "Devuelta:";
            // 
            // txtCantDevolver
            // 
            this.txtCantDevolver.Location = new System.Drawing.Point(577, 71);
            this.txtCantDevolver.Name = "txtCantDevolver";
            this.txtCantDevolver.Size = new System.Drawing.Size(73, 20);
            this.txtCantDevolver.TabIndex = 23;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(425, 322);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 23);
            this.btnCalcular.TabIndex = 24;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblFechaUltimoPago
            // 
            this.lblFechaUltimoPago.AutoSize = true;
            this.lblFechaUltimoPago.Location = new System.Drawing.Point(308, 32);
            this.lblFechaUltimoPago.Name = "lblFechaUltimoPago";
            this.lblFechaUltimoPago.Size = new System.Drawing.Size(67, 13);
            this.lblFechaUltimoPago.TabIndex = 28;
            this.lblFechaUltimoPago.Text = "Ultimo Pago:";
            // 
            // txtUltimoPago
            // 
            this.txtUltimoPago.Location = new System.Drawing.Point(381, 29);
            this.txtUltimoPago.Name = "txtUltimoPago";
            this.txtUltimoPago.Size = new System.Drawing.Size(152, 20);
            this.txtUltimoPago.TabIndex = 29;
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.Controls.Add(this.rbPasaporte);
            this.gbInformacionCliente.Controls.Add(this.rbCedula);
            this.gbInformacionCliente.Controls.Add(this.lblCedula);
            this.gbInformacionCliente.Controls.Add(this.txtCedula);
            this.gbInformacionCliente.Location = new System.Drawing.Point(8, 69);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(213, 82);
            this.gbInformacionCliente.TabIndex = 30;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Informacion Cliente";
            // 
            // rbPasaporte
            // 
            this.rbPasaporte.AutoSize = true;
            this.rbPasaporte.Location = new System.Drawing.Point(105, 53);
            this.rbPasaporte.Name = "rbPasaporte";
            this.rbPasaporte.Size = new System.Drawing.Size(73, 17);
            this.rbPasaporte.TabIndex = 7;
            this.rbPasaporte.TabStop = true;
            this.rbPasaporte.Text = "Pasaporte";
            this.rbPasaporte.UseVisualStyleBackColor = true;
            this.rbPasaporte.CheckedChanged += new System.EventHandler(this.rbPasaporte_CheckedChanged);
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Location = new System.Drawing.Point(24, 53);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(58, 17);
            this.rbCedula.TabIndex = 6;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula";
            this.rbCedula.UseVisualStyleBackColor = true;
            this.rbCedula.CheckedChanged += new System.EventHandler(this.rbCedula_CheckedChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Sistema_Abogados.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(530, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(141, 51);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbInformacionCaso
            // 
            this.gbInformacionCaso.Controls.Add(this.lblTotal);
            this.gbInformacionCaso.Controls.Add(this.txtTotalaPagar);
            this.gbInformacionCaso.Controls.Add(this.lblImpRenta);
            this.gbInformacionCaso.Controls.Add(this.btnCleanCaseInfo);
            this.gbInformacionCaso.Controls.Add(this.txtImpSobreRenta);
            this.gbInformacionCaso.Controls.Add(this.lblITEBIS);
            this.gbInformacionCaso.Controls.Add(this.txtITEBIS);
            this.gbInformacionCaso.Controls.Add(this.gbPagoRealizar);
            this.gbInformacionCaso.Controls.Add(this.txtNumeroCaso);
            this.gbInformacionCaso.Controls.Add(this.lblTotalaPagar);
            this.gbInformacionCaso.Controls.Add(this.txtUltimoPago);
            this.gbInformacionCaso.Controls.Add(this.txtBalanceTotal);
            this.gbInformacionCaso.Controls.Add(this.lblFechaUltimoPago);
            this.gbInformacionCaso.Controls.Add(this.lblMoneda);
            this.gbInformacionCaso.Controls.Add(this.txtMoneda);
            this.gbInformacionCaso.Controls.Add(this.lblNumeroCaso);
            this.gbInformacionCaso.Controls.Add(this.lblServicio);
            this.gbInformacionCaso.Controls.Add(this.lblCantidadaPagar);
            this.gbInformacionCaso.Controls.Add(this.txtCantPagar);
            this.gbInformacionCaso.Controls.Add(this.txtServicio);
            this.gbInformacionCaso.Controls.Add(this.txtCantDevolver);
            this.gbInformacionCaso.Controls.Add(this.lblDevuelta);
            this.gbInformacionCaso.Location = new System.Drawing.Point(8, 157);
            this.gbInformacionCaso.Name = "gbInformacionCaso";
            this.gbInformacionCaso.Size = new System.Drawing.Size(670, 159);
            this.gbInformacionCaso.TabIndex = 31;
            this.gbInformacionCaso.TabStop = false;
            this.gbInformacionCaso.Text = "Informacion del Caso";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(454, 119);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 36;
            this.lblTotal.Text = "Total:";
            // 
            // txtTotalaPagar
            // 
            this.txtTotalaPagar.Location = new System.Drawing.Point(494, 116);
            this.txtTotalaPagar.Name = "txtTotalaPagar";
            this.txtTotalaPagar.Size = new System.Drawing.Size(86, 20);
            this.txtTotalaPagar.TabIndex = 37;
            // 
            // lblImpRenta
            // 
            this.lblImpRenta.AutoSize = true;
            this.lblImpRenta.Location = new System.Drawing.Point(335, 119);
            this.lblImpRenta.Name = "lblImpRenta";
            this.lblImpRenta.Size = new System.Drawing.Size(28, 13);
            this.lblImpRenta.TabIndex = 34;
            this.lblImpRenta.Text = "ISR:";
            // 
            // btnCleanCaseInfo
            // 
            this.btnCleanCaseInfo.Location = new System.Drawing.Point(555, 27);
            this.btnCleanCaseInfo.Name = "btnCleanCaseInfo";
            this.btnCleanCaseInfo.Size = new System.Drawing.Size(95, 23);
            this.btnCleanCaseInfo.TabIndex = 30;
            this.btnCleanCaseInfo.Text = "Limpiar";
            this.btnCleanCaseInfo.UseVisualStyleBackColor = true;
            this.btnCleanCaseInfo.Click += new System.EventHandler(this.btnCleanCaseInfo_Click);
            // 
            // txtImpSobreRenta
            // 
            this.txtImpSobreRenta.Location = new System.Drawing.Point(369, 116);
            this.txtImpSobreRenta.Name = "txtImpSobreRenta";
            this.txtImpSobreRenta.Size = new System.Drawing.Size(69, 20);
            this.txtImpSobreRenta.TabIndex = 35;
            // 
            // lblITEBIS
            // 
            this.lblITEBIS.AutoSize = true;
            this.lblITEBIS.Location = new System.Drawing.Point(206, 119);
            this.lblITEBIS.Name = "lblITEBIS";
            this.lblITEBIS.Size = new System.Drawing.Size(44, 13);
            this.lblITEBIS.TabIndex = 32;
            this.lblITEBIS.Text = "ITEBIS:";
            // 
            // txtITEBIS
            // 
            this.txtITEBIS.Location = new System.Drawing.Point(256, 116);
            this.txtITEBIS.Name = "txtITEBIS";
            this.txtITEBIS.Size = new System.Drawing.Size(69, 20);
            this.txtITEBIS.TabIndex = 33;
            // 
            // gbPagoRealizar
            // 
            this.gbPagoRealizar.Controls.Add(this.dbMensualidad);
            this.gbPagoRealizar.Controls.Add(this.dbContrato);
            this.gbPagoRealizar.Location = new System.Drawing.Point(16, 106);
            this.gbPagoRealizar.Name = "gbPagoRealizar";
            this.gbPagoRealizar.Size = new System.Drawing.Size(183, 47);
            this.gbPagoRealizar.TabIndex = 31;
            this.gbPagoRealizar.TabStop = false;
            this.gbPagoRealizar.Text = "Pago a realizar";
            // 
            // dbMensualidad
            // 
            this.dbMensualidad.AutoSize = true;
            this.dbMensualidad.Location = new System.Drawing.Point(14, 18);
            this.dbMensualidad.Name = "dbMensualidad";
            this.dbMensualidad.Size = new System.Drawing.Size(86, 17);
            this.dbMensualidad.TabIndex = 1;
            this.dbMensualidad.Text = "Mensualidad";
            this.dbMensualidad.UseVisualStyleBackColor = true;
            this.dbMensualidad.CheckedChanged += new System.EventHandler(this.dbMensualidad_CheckedChanged);
            // 
            // dbContrato
            // 
            this.dbContrato.AutoSize = true;
            this.dbContrato.Location = new System.Drawing.Point(106, 18);
            this.dbContrato.Name = "dbContrato";
            this.dbContrato.Size = new System.Drawing.Size(66, 17);
            this.dbContrato.TabIndex = 0;
            this.dbContrato.Text = "Contrato";
            this.dbContrato.UseVisualStyleBackColor = true;
            this.dbContrato.CheckedChanged += new System.EventHandler(this.dbContrato_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Sistema_Abogados.Properties.Resources.exit;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(883, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 66);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.Image = global::Sistema_Abogados.Properties.Resources.checkout;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(731, 471);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(146, 66);
            this.btnCobrar.TabIndex = 26;
            this.btnCobrar.Text = "Aceptar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // pbCedula
            // 
            this.pbCedula.Location = new System.Drawing.Point(731, 45);
            this.pbCedula.Name = "pbCedula";
            this.pbCedula.Size = new System.Drawing.Size(272, 248);
            this.pbCedula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCedula.TabIndex = 25;
            this.pbCedula.TabStop = false;
            // 
            // btnCleanAll
            // 
            this.btnCleanAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanAll.Image = global::Sistema_Abogados.Properties.Resources._1361350698_edit_clear;
            this.btnCleanAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCleanAll.Location = new System.Drawing.Point(764, 397);
            this.btnCleanAll.Name = "btnCleanAll";
            this.btnCleanAll.Size = new System.Drawing.Size(217, 57);
            this.btnCleanAll.TabIndex = 31;
            this.btnCleanAll.Text = "Limpiar Todo";
            this.btnCleanAll.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCleanAll.UseVisualStyleBackColor = true;
            this.btnCleanAll.Click += new System.EventHandler(this.btnCleanAll_Click);
            // 
            // btnBuscarFactura
            // 
            this.btnBuscarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarFactura.Image = global::Sistema_Abogados.Properties.Resources.search;
            this.btnBuscarFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarFactura.Location = new System.Drawing.Point(779, 322);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(202, 57);
            this.btnBuscarFactura.TabIndex = 32;
            this.btnBuscarFactura.Text = "Buscar Factura";
            this.btnBuscarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // gbInfomacionInquilino
            // 
            this.gbInfomacionInquilino.Controls.Add(this.rbPasaporteDE);
            this.gbInfomacionInquilino.Controls.Add(this.rbCedulaDE);
            this.gbInfomacionInquilino.Controls.Add(this.lblCedulaDe);
            this.gbInfomacionInquilino.Controls.Add(this.txtCedulaDe);
            this.gbInfomacionInquilino.Location = new System.Drawing.Point(234, 69);
            this.gbInfomacionInquilino.Name = "gbInfomacionInquilino";
            this.gbInfomacionInquilino.Size = new System.Drawing.Size(252, 82);
            this.gbInfomacionInquilino.TabIndex = 33;
            this.gbInfomacionInquilino.TabStop = false;
            this.gbInfomacionInquilino.Text = "Informacion Inquilino";
            // 
            // rbPasaporteDE
            // 
            this.rbPasaporteDE.AutoSize = true;
            this.rbPasaporteDE.Location = new System.Drawing.Point(117, 53);
            this.rbPasaporteDE.Name = "rbPasaporteDE";
            this.rbPasaporteDE.Size = new System.Drawing.Size(73, 17);
            this.rbPasaporteDE.TabIndex = 9;
            this.rbPasaporteDE.TabStop = true;
            this.rbPasaporteDE.Text = "Pasaporte";
            this.rbPasaporteDE.UseVisualStyleBackColor = true;
            this.rbPasaporteDE.CheckedChanged += new System.EventHandler(this.rbPasaporteDE_CheckedChanged);
            // 
            // rbCedulaDE
            // 
            this.rbCedulaDE.AutoSize = true;
            this.rbCedulaDE.Location = new System.Drawing.Point(36, 53);
            this.rbCedulaDE.Name = "rbCedulaDE";
            this.rbCedulaDE.Size = new System.Drawing.Size(58, 17);
            this.rbCedulaDE.TabIndex = 8;
            this.rbCedulaDE.TabStop = true;
            this.rbCedulaDE.Text = "Cedula";
            this.rbCedulaDE.UseVisualStyleBackColor = true;
            this.rbCedulaDE.CheckedChanged += new System.EventHandler(this.rbCedulaDE_CheckedChanged);
            // 
            // lblCedulaDe
            // 
            this.lblCedulaDe.AutoSize = true;
            this.lblCedulaDe.Location = new System.Drawing.Point(33, 30);
            this.lblCedulaDe.Name = "lblCedulaDe";
            this.lblCedulaDe.Size = new System.Drawing.Size(43, 13);
            this.lblCedulaDe.TabIndex = 4;
            this.lblCedulaDe.Text = "Cedula:";
            // 
            // txtCedulaDe
            // 
            this.txtCedulaDe.Location = new System.Drawing.Point(82, 27);
            this.txtCedulaDe.Mask = "000-0000000-0";
            this.txtCedulaDe.Name = "txtCedulaDe";
            this.txtCedulaDe.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaDe.TabIndex = 5;
            // 
            // gbInformacionGarante
            // 
            this.gbInformacionGarante.Controls.Add(this.rbPasaporteGa);
            this.gbInformacionGarante.Controls.Add(this.rbCedulaGa);
            this.gbInformacionGarante.Controls.Add(this.label2);
            this.gbInformacionGarante.Controls.Add(this.txtCedulaGa);
            this.gbInformacionGarante.Location = new System.Drawing.Point(502, 69);
            this.gbInformacionGarante.Name = "gbInformacionGarante";
            this.gbInformacionGarante.Size = new System.Drawing.Size(213, 82);
            this.gbInformacionGarante.TabIndex = 34;
            this.gbInformacionGarante.TabStop = false;
            this.gbInformacionGarante.Text = "Informacion Garante";
            // 
            // rbPasaporteGa
            // 
            this.rbPasaporteGa.AutoSize = true;
            this.rbPasaporteGa.Location = new System.Drawing.Point(105, 53);
            this.rbPasaporteGa.Name = "rbPasaporteGa";
            this.rbPasaporteGa.Size = new System.Drawing.Size(73, 17);
            this.rbPasaporteGa.TabIndex = 9;
            this.rbPasaporteGa.TabStop = true;
            this.rbPasaporteGa.Text = "Pasaporte";
            this.rbPasaporteGa.UseVisualStyleBackColor = true;
            this.rbPasaporteGa.CheckedChanged += new System.EventHandler(this.rbPasaporteGa_CheckedChanged);
            // 
            // rbCedulaGa
            // 
            this.rbCedulaGa.AutoSize = true;
            this.rbCedulaGa.Location = new System.Drawing.Point(24, 53);
            this.rbCedulaGa.Name = "rbCedulaGa";
            this.rbCedulaGa.Size = new System.Drawing.Size(58, 17);
            this.rbCedulaGa.TabIndex = 8;
            this.rbCedulaGa.TabStop = true;
            this.rbCedulaGa.Text = "Cedula";
            this.rbCedulaGa.UseVisualStyleBackColor = true;
            this.rbCedulaGa.CheckedChanged += new System.EventHandler(this.rbCedulaGa_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cedula:";
            // 
            // txtCedulaGa
            // 
            this.txtCedulaGa.Location = new System.Drawing.Point(70, 27);
            this.txtCedulaGa.Mask = "000-0000000-0";
            this.txtCedulaGa.Name = "txtCedulaGa";
            this.txtCedulaGa.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaGa.TabIndex = 5;
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(1023, 558);
            this.Controls.Add(this.gbInformacionGarante);
            this.Controls.Add(this.gbInfomacionInquilino);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.btnCleanAll);
            this.Controls.Add(this.gbInformacionCaso);
            this.Controls.Add(this.gbInformacionCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.pbCedula);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvFacturacion);
            this.Controls.Add(this.gbParametrosBusqueda);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFacturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.gbParametrosBusqueda.ResumeLayout(false);
            this.gbParametrosBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.gbInformacionCliente.ResumeLayout(false);
            this.gbInformacionCliente.PerformLayout();
            this.gbInformacionCaso.ResumeLayout(false);
            this.gbInformacionCaso.PerformLayout();
            this.gbPagoRealizar.ResumeLayout(false);
            this.gbPagoRealizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCedula)).EndInit();
            this.gbInfomacionInquilino.ResumeLayout(false);
            this.gbInfomacionInquilino.PerformLayout();
            this.gbInformacionGarante.ResumeLayout(false);
            this.gbInformacionGarante.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametrosBusqueda;
        private System.Windows.Forms.RadioButton rbAlquiler;
        private System.Windows.Forms.RadioButton rbVentas;
        private System.Windows.Forms.RadioButton rbDivorcioAccidente;
        private System.Windows.Forms.DataGridView dgvFacturacion;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.TextBox txtBalanceTotal;
        private System.Windows.Forms.Label lblTotalaPagar;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtNumeroCaso;
        private System.Windows.Forms.Label lblNumeroCaso;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Label lblServicio;
        private System.Windows.Forms.TextBox txtCantPagar;
        private System.Windows.Forms.Label lblCantidadaPagar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDevuelta;
        private System.Windows.Forms.TextBox txtCantDevolver;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.PictureBox pbCedula;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblFechaUltimoPago;
        private System.Windows.Forms.TextBox txtUltimoPago;
        private System.Windows.Forms.GroupBox gbInformacionCliente;
        private System.Windows.Forms.GroupBox gbInformacionCaso;
        private System.Windows.Forms.Button btnCleanCaseInfo;
        private System.Windows.Forms.Button btnCleanAll;
        private System.Windows.Forms.Button btnBuscarFactura;
        private System.Windows.Forms.GroupBox gbPagoRealizar;
        private System.Windows.Forms.CheckBox dbMensualidad;
        private System.Windows.Forms.CheckBox dbContrato;
        private System.Windows.Forms.Label lblImpRenta;
        private System.Windows.Forms.TextBox txtImpSobreRenta;
        private System.Windows.Forms.Label lblITEBIS;
        private System.Windows.Forms.TextBox txtITEBIS;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalaPagar;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbPasaporte;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.GroupBox gbInfomacionInquilino;
        private System.Windows.Forms.RadioButton rbPasaporteDE;
        private System.Windows.Forms.RadioButton rbCedulaDE;
        private System.Windows.Forms.Label lblCedulaDe;
        private System.Windows.Forms.MaskedTextBox txtCedulaDe;
        private System.Windows.Forms.GroupBox gbInformacionGarante;
        private System.Windows.Forms.RadioButton rbPasaporteGa;
        private System.Windows.Forms.RadioButton rbCedulaGa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCedulaGa;
    }
}