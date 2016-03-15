namespace Sistema_Abogados
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
            this.rbAlquiler = new System.Windows.Forms.RadioButton();
            this.rbVentas = new System.Windows.Forms.RadioButton();
            this.rbDivorcioAccidente = new System.Windows.Forms.RadioButton();
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.lblNombreCli = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtTotalaPagar = new System.Windows.Forms.TextBox();
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
            this.btnCleanCustoInfo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbInformacionCaso = new System.Windows.Forms.GroupBox();
            this.btnCleanCaseInfo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.pbCedula = new System.Windows.Forms.PictureBox();
            this.btnCleanAll = new System.Windows.Forms.Button();
            this.btnBuscarFactura = new System.Windows.Forms.Button();
            this.gbParametrosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.gbInformacionCliente.SuspendLayout();
            this.gbInformacionCaso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCedula)).BeginInit();
            this.SuspendLayout();
            // 
            // gbParametrosBusqueda
            // 
            this.gbParametrosBusqueda.Controls.Add(this.rbAlquiler);
            this.gbParametrosBusqueda.Controls.Add(this.rbVentas);
            this.gbParametrosBusqueda.Controls.Add(this.rbDivorcioAccidente);
            this.gbParametrosBusqueda.Location = new System.Drawing.Point(12, 272);
            this.gbParametrosBusqueda.Name = "gbParametrosBusqueda";
            this.gbParametrosBusqueda.Size = new System.Drawing.Size(479, 51);
            this.gbParametrosBusqueda.TabIndex = 0;
            this.gbParametrosBusqueda.TabStop = false;
            this.gbParametrosBusqueda.Text = "Servicios";
            // 
            // rbAlquiler
            // 
            this.rbAlquiler.AutoSize = true;
            this.rbAlquiler.Location = new System.Drawing.Point(330, 19);
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
            this.rbVentas.Location = new System.Drawing.Point(220, 19);
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
            this.rbDivorcioAccidente.Location = new System.Drawing.Point(57, 19);
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
            this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturacion.Location = new System.Drawing.Point(9, 329);
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.Size = new System.Drawing.Size(673, 195);
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
            // lblNombreCli
            // 
            this.lblNombreCli.AutoSize = true;
            this.lblNombreCli.Location = new System.Drawing.Point(203, 30);
            this.lblNombreCli.Name = "lblNombreCli";
            this.lblNombreCli.Size = new System.Drawing.Size(47, 13);
            this.lblNombreCli.TabIndex = 6;
            this.lblNombreCli.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(256, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(425, 27);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(372, 30);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 8;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtTotalaPagar
            // 
            this.txtTotalaPagar.Location = new System.Drawing.Point(115, 74);
            this.txtTotalaPagar.Name = "txtTotalaPagar";
            this.txtTotalaPagar.Size = new System.Drawing.Size(82, 20);
            this.txtTotalaPagar.TabIndex = 11;
            // 
            // lblTotalaPagar
            // 
            this.lblTotalaPagar.AutoSize = true;
            this.lblTotalaPagar.Location = new System.Drawing.Point(21, 77);
            this.lblTotalaPagar.Name = "lblTotalaPagar";
            this.lblTotalaPagar.Size = new System.Drawing.Size(74, 13);
            this.lblTotalaPagar.TabIndex = 10;
            this.lblTotalaPagar.Text = "Total a Pagar:";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(256, 74);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(69, 20);
            this.txtMoneda.TabIndex = 13;
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(203, 77);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(49, 13);
            this.lblMoneda.TabIndex = 12;
            this.lblMoneda.Text = "Moneda:";
            // 
            // txtNumeroCaso
            // 
            this.txtNumeroCaso.Location = new System.Drawing.Point(86, 29);
            this.txtNumeroCaso.Name = "txtNumeroCaso";
            this.txtNumeroCaso.Size = new System.Drawing.Size(100, 20);
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
            this.txtServicio.Location = new System.Drawing.Point(266, 29);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(100, 20);
            this.txtServicio.TabIndex = 17;
            // 
            // lblServicio
            // 
            this.lblServicio.AutoSize = true;
            this.lblServicio.Location = new System.Drawing.Point(213, 32);
            this.lblServicio.Name = "lblServicio";
            this.lblServicio.Size = new System.Drawing.Size(48, 13);
            this.lblServicio.TabIndex = 16;
            this.lblServicio.Text = "Servicio:";
            // 
            // txtCantPagar
            // 
            this.txtCantPagar.Location = new System.Drawing.Point(428, 74);
            this.txtCantPagar.Name = "txtCantPagar";
            this.txtCantPagar.Size = new System.Drawing.Size(68, 20);
            this.txtCantPagar.TabIndex = 19;
            // 
            // lblCantidadaPagar
            // 
            this.lblCantidadaPagar.AutoSize = true;
            this.lblCantidadaPagar.Location = new System.Drawing.Point(333, 77);
            this.lblCantidadaPagar.Name = "lblCantidadaPagar";
            this.lblCantidadaPagar.Size = new System.Drawing.Size(92, 13);
            this.lblCantidadaPagar.TabIndex = 18;
            this.lblCantidadaPagar.Text = "Cantidad a Pagar:";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(554, 300);
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
            this.lblDevuelta.Location = new System.Drawing.Point(31, 116);
            this.lblDevuelta.Name = "lblDevuelta";
            this.lblDevuelta.Size = new System.Drawing.Size(107, 13);
            this.lblDevuelta.TabIndex = 22;
            this.lblDevuelta.Text = "Cantidad a Devolver:";
            // 
            // txtCantDevolver
            // 
            this.txtCantDevolver.Location = new System.Drawing.Point(138, 113);
            this.txtCantDevolver.Name = "txtCantDevolver";
            this.txtCantDevolver.Size = new System.Drawing.Size(85, 20);
            this.txtCantDevolver.TabIndex = 23;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(530, 115);
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
            this.lblFechaUltimoPago.Location = new System.Drawing.Point(229, 120);
            this.lblFechaUltimoPago.Name = "lblFechaUltimoPago";
            this.lblFechaUltimoPago.Size = new System.Drawing.Size(67, 13);
            this.lblFechaUltimoPago.TabIndex = 28;
            this.lblFechaUltimoPago.Text = "Ultimo Pago:";
            // 
            // txtUltimoPago
            // 
            this.txtUltimoPago.Location = new System.Drawing.Point(302, 117);
            this.txtUltimoPago.Name = "txtUltimoPago";
            this.txtUltimoPago.Size = new System.Drawing.Size(152, 20);
            this.txtUltimoPago.TabIndex = 29;
            // 
            // gbInformacionCliente
            // 
            this.gbInformacionCliente.Controls.Add(this.btnCleanCustoInfo);
            this.gbInformacionCliente.Controls.Add(this.lblCedula);
            this.gbInformacionCliente.Controls.Add(this.txtCedula);
            this.gbInformacionCliente.Controls.Add(this.lblNombreCli);
            this.gbInformacionCliente.Controls.Add(this.txtNombre);
            this.gbInformacionCliente.Controls.Add(this.lblApellido);
            this.gbInformacionCliente.Controls.Add(this.txtApellido);
            this.gbInformacionCliente.Controls.Add(this.btnBuscar);
            this.gbInformacionCliente.Location = new System.Drawing.Point(12, 12);
            this.gbInformacionCliente.Name = "gbInformacionCliente";
            this.gbInformacionCliente.Size = new System.Drawing.Size(659, 79);
            this.gbInformacionCliente.TabIndex = 30;
            this.gbInformacionCliente.TabStop = false;
            this.gbInformacionCliente.Text = "Informacion Cliente";
            // 
            // btnCleanCustoInfo
            // 
            this.btnCleanCustoInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanCustoInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCleanCustoInfo.Location = new System.Drawing.Point(542, 52);
            this.btnCleanCustoInfo.Name = "btnCleanCustoInfo";
            this.btnCleanCustoInfo.Size = new System.Drawing.Size(112, 27);
            this.btnCleanCustoInfo.TabIndex = 22;
            this.btnCleanCustoInfo.Text = "Limpiar";
            this.btnCleanCustoInfo.UseVisualStyleBackColor = true;
            this.btnCleanCustoInfo.Click += new System.EventHandler(this.btnCleanCustoInfo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Sistema_Abogados.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(542, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 33);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbInformacionCaso
            // 
            this.gbInformacionCaso.Controls.Add(this.btnCleanCaseInfo);
            this.gbInformacionCaso.Controls.Add(this.txtNumeroCaso);
            this.gbInformacionCaso.Controls.Add(this.lblTotalaPagar);
            this.gbInformacionCaso.Controls.Add(this.txtUltimoPago);
            this.gbInformacionCaso.Controls.Add(this.txtTotalaPagar);
            this.gbInformacionCaso.Controls.Add(this.lblFechaUltimoPago);
            this.gbInformacionCaso.Controls.Add(this.lblMoneda);
            this.gbInformacionCaso.Controls.Add(this.txtMoneda);
            this.gbInformacionCaso.Controls.Add(this.lblNumeroCaso);
            this.gbInformacionCaso.Controls.Add(this.lblServicio);
            this.gbInformacionCaso.Controls.Add(this.btnCalcular);
            this.gbInformacionCaso.Controls.Add(this.txtServicio);
            this.gbInformacionCaso.Controls.Add(this.txtCantDevolver);
            this.gbInformacionCaso.Controls.Add(this.lblCantidadaPagar);
            this.gbInformacionCaso.Controls.Add(this.lblDevuelta);
            this.gbInformacionCaso.Controls.Add(this.txtCantPagar);
            this.gbInformacionCaso.Location = new System.Drawing.Point(12, 97);
            this.gbInformacionCaso.Name = "gbInformacionCaso";
            this.gbInformacionCaso.Size = new System.Drawing.Size(656, 169);
            this.gbInformacionCaso.TabIndex = 31;
            this.gbInformacionCaso.TabStop = false;
            this.gbInformacionCaso.Text = "Informacion del Caso";
            // 
            // btnCleanCaseInfo
            // 
            this.btnCleanCaseInfo.Location = new System.Drawing.Point(530, 32);
            this.btnCleanCaseInfo.Name = "btnCleanCaseInfo";
            this.btnCleanCaseInfo.Size = new System.Drawing.Size(95, 23);
            this.btnCleanCaseInfo.TabIndex = 30;
            this.btnCleanCaseInfo.Text = "Limpiar";
            this.btnCleanCaseInfo.UseVisualStyleBackColor = true;
            this.btnCleanCaseInfo.Click += new System.EventHandler(this.btnCleanCaseInfo_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Sistema_Abogados.Properties.Resources.exit;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(851, 458);
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
            this.btnCobrar.Location = new System.Drawing.Point(687, 458);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(158, 66);
            this.btnCobrar.TabIndex = 26;
            this.btnCobrar.Text = "Aceptar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // pbCedula
            // 
            this.pbCedula.Location = new System.Drawing.Point(677, 18);
            this.pbCedula.Name = "pbCedula";
            this.pbCedula.Size = new System.Drawing.Size(302, 248);
            this.pbCedula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCedula.TabIndex = 25;
            this.pbCedula.TabStop = false;
            // 
            // btnCleanAll
            // 
            this.btnCleanAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanAll.Image = global::Sistema_Abogados.Properties.Resources._1361350698_edit_clear;
            this.btnCleanAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCleanAll.Location = new System.Drawing.Point(716, 395);
            this.btnCleanAll.Name = "btnCleanAll";
            this.btnCleanAll.Size = new System.Drawing.Size(235, 57);
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
            this.btnBuscarFactura.Location = new System.Drawing.Point(716, 309);
            this.btnBuscarFactura.Name = "btnBuscarFactura";
            this.btnBuscarFactura.Size = new System.Drawing.Size(235, 57);
            this.btnBuscarFactura.TabIndex = 32;
            this.btnBuscarFactura.Text = "Buscar Factura";
            this.btnBuscarFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarFactura.UseVisualStyleBackColor = true;
            this.btnBuscarFactura.Click += new System.EventHandler(this.btnBuscarFactura_Click);
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(991, 533);
            this.Controls.Add(this.btnBuscarFactura);
            this.Controls.Add(this.btnCleanAll);
            this.Controls.Add(this.gbInformacionCaso);
            this.Controls.Add(this.gbInformacionCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.pbCedula);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvFacturacion);
            this.Controls.Add(this.gbParametrosBusqueda);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCedula)).EndInit();
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
        private System.Windows.Forms.Label lblNombreCli;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtTotalaPagar;
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
        private System.Windows.Forms.Button btnCleanCustoInfo;
        private System.Windows.Forms.Button btnCleanCaseInfo;
        private System.Windows.Forms.Button btnCleanAll;
        private System.Windows.Forms.Button btnBuscarFactura;
    }
}