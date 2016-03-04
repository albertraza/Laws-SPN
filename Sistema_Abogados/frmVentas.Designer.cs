namespace Sistema_Abogados
{
    partial class frmVentas
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
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.lblSearchSeller = new System.Windows.Forms.LinkLabel();
            this.btnSearchSeller = new System.Windows.Forms.Button();
            this.btnClearSeller = new System.Windows.Forms.Button();
            this.txtCelularSeller = new System.Windows.Forms.TextBox();
            this.lblCelularSeller = new System.Windows.Forms.Label();
            this.txtPhoneSeller = new System.Windows.Forms.TextBox();
            this.lblPhoneSeller = new System.Windows.Forms.Label();
            this.txtLastNameSeller = new System.Windows.Forms.TextBox();
            this.lblLastNameSeller = new System.Windows.Forms.Label();
            this.txtNameSeller = new System.Windows.Forms.TextBox();
            this.lblNameSeller = new System.Windows.Forms.Label();
            this.txtCedulaSeller = new System.Windows.Forms.TextBox();
            this.lblCedulaSeller = new System.Windows.Forms.Label();
            this.txtIDSeller = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.gbComprador = new System.Windows.Forms.GroupBox();
            this.lblSearchBuy = new System.Windows.Forms.LinkLabel();
            this.btnSearchBuy = new System.Windows.Forms.Button();
            this.btnClearBuy = new System.Windows.Forms.Button();
            this.txtCelularBuy = new System.Windows.Forms.TextBox();
            this.lblCelularBuy = new System.Windows.Forms.Label();
            this.txtPhoneBuy = new System.Windows.Forms.TextBox();
            this.lblPhoneBuy = new System.Windows.Forms.Label();
            this.txtLastNameBuy = new System.Windows.Forms.TextBox();
            this.lblLastNameBuy = new System.Windows.Forms.Label();
            this.txtNameBuy = new System.Windows.Forms.TextBox();
            this.lblNameBuy = new System.Windows.Forms.Label();
            this.txtCedulaBuy = new System.Windows.Forms.TextBox();
            this.lblCedulaBuy = new System.Windows.Forms.Label();
            this.txtIDBuy = new System.Windows.Forms.TextBox();
            this.lblIDBuy = new System.Windows.Forms.Label();
            this.gbInfoPagos = new System.Windows.Forms.GroupBox();
            this.txtMatricula = new System.Windows.Forms.MaskedTextBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblInmueble = new System.Windows.Forms.Label();
            this.cbInmueble = new System.Windows.Forms.ComboBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.lblPreciodeVenta = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.lblAbono = new System.Windows.Forms.Label();
            this.txtHonorarios = new System.Windows.Forms.TextBox();
            this.lblHonorarios = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbVendedor.SuspendLayout();
            this.gbComprador.SuspendLayout();
            this.gbInfoPagos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbVendedor
            // 
            this.gbVendedor.Controls.Add(this.lblSearchSeller);
            this.gbVendedor.Controls.Add(this.btnSearchSeller);
            this.gbVendedor.Controls.Add(this.btnClearSeller);
            this.gbVendedor.Controls.Add(this.txtCelularSeller);
            this.gbVendedor.Controls.Add(this.lblCelularSeller);
            this.gbVendedor.Controls.Add(this.txtPhoneSeller);
            this.gbVendedor.Controls.Add(this.lblPhoneSeller);
            this.gbVendedor.Controls.Add(this.txtLastNameSeller);
            this.gbVendedor.Controls.Add(this.lblLastNameSeller);
            this.gbVendedor.Controls.Add(this.txtNameSeller);
            this.gbVendedor.Controls.Add(this.lblNameSeller);
            this.gbVendedor.Controls.Add(this.txtCedulaSeller);
            this.gbVendedor.Controls.Add(this.lblCedulaSeller);
            this.gbVendedor.Controls.Add(this.txtIDSeller);
            this.gbVendedor.Controls.Add(this.lblID);
            this.gbVendedor.Location = new System.Drawing.Point(12, 12);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.Size = new System.Drawing.Size(382, 218);
            this.gbVendedor.TabIndex = 0;
            this.gbVendedor.TabStop = false;
            this.gbVendedor.Text = "Vendedor";
            // 
            // lblSearchSeller
            // 
            this.lblSearchSeller.AutoSize = true;
            this.lblSearchSeller.Location = new System.Drawing.Point(129, 57);
            this.lblSearchSeller.Name = "lblSearchSeller";
            this.lblSearchSeller.Size = new System.Drawing.Size(40, 13);
            this.lblSearchSeller.TabIndex = 3;
            this.lblSearchSeller.TabStop = true;
            this.lblSearchSeller.Text = "Buscar";
            this.lblSearchSeller.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSearchSeller_LinkClicked);
            // 
            // btnSearchSeller
            // 
            this.btnSearchSeller.Location = new System.Drawing.Point(227, 179);
            this.btnSearchSeller.Name = "btnSearchSeller";
            this.btnSearchSeller.Size = new System.Drawing.Size(123, 23);
            this.btnSearchSeller.TabIndex = 13;
            this.btnSearchSeller.Text = "Buscar Vendedor";
            this.btnSearchSeller.UseVisualStyleBackColor = true;
            this.btnSearchSeller.Click += new System.EventHandler(this.btnSearchSeller_Click);
            // 
            // btnClearSeller
            // 
            this.btnClearSeller.Location = new System.Drawing.Point(45, 179);
            this.btnClearSeller.Name = "btnClearSeller";
            this.btnClearSeller.Size = new System.Drawing.Size(75, 23);
            this.btnClearSeller.TabIndex = 12;
            this.btnClearSeller.Text = "Limpiar";
            this.btnClearSeller.UseVisualStyleBackColor = true;
            // 
            // txtCelularSeller
            // 
            this.txtCelularSeller.Location = new System.Drawing.Point(250, 135);
            this.txtCelularSeller.Name = "txtCelularSeller";
            this.txtCelularSeller.Size = new System.Drawing.Size(100, 20);
            this.txtCelularSeller.TabIndex = 11;
            // 
            // lblCelularSeller
            // 
            this.lblCelularSeller.AutoSize = true;
            this.lblCelularSeller.Location = new System.Drawing.Point(207, 138);
            this.lblCelularSeller.Name = "lblCelularSeller";
            this.lblCelularSeller.Size = new System.Drawing.Size(42, 13);
            this.lblCelularSeller.TabIndex = 10;
            this.lblCelularSeller.Text = "Celular:";
            // 
            // txtPhoneSeller
            // 
            this.txtPhoneSeller.Location = new System.Drawing.Point(69, 135);
            this.txtPhoneSeller.Name = "txtPhoneSeller";
            this.txtPhoneSeller.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneSeller.TabIndex = 9;
            // 
            // lblPhoneSeller
            // 
            this.lblPhoneSeller.AutoSize = true;
            this.lblPhoneSeller.Location = new System.Drawing.Point(11, 138);
            this.lblPhoneSeller.Name = "lblPhoneSeller";
            this.lblPhoneSeller.Size = new System.Drawing.Size(52, 13);
            this.lblPhoneSeller.TabIndex = 8;
            this.lblPhoneSeller.Text = "Telefono:";
            // 
            // txtLastNameSeller
            // 
            this.txtLastNameSeller.Location = new System.Drawing.Point(250, 82);
            this.txtLastNameSeller.Name = "txtLastNameSeller";
            this.txtLastNameSeller.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameSeller.TabIndex = 7;
            // 
            // lblLastNameSeller
            // 
            this.lblLastNameSeller.AutoSize = true;
            this.lblLastNameSeller.Location = new System.Drawing.Point(202, 85);
            this.lblLastNameSeller.Name = "lblLastNameSeller";
            this.lblLastNameSeller.Size = new System.Drawing.Size(47, 13);
            this.lblLastNameSeller.TabIndex = 6;
            this.lblLastNameSeller.Text = "Apellido:";
            // 
            // txtNameSeller
            // 
            this.txtNameSeller.Location = new System.Drawing.Point(69, 82);
            this.txtNameSeller.Name = "txtNameSeller";
            this.txtNameSeller.Size = new System.Drawing.Size(100, 20);
            this.txtNameSeller.TabIndex = 5;
            // 
            // lblNameSeller
            // 
            this.lblNameSeller.AutoSize = true;
            this.lblNameSeller.Location = new System.Drawing.Point(21, 85);
            this.lblNameSeller.Name = "lblNameSeller";
            this.lblNameSeller.Size = new System.Drawing.Size(47, 13);
            this.lblNameSeller.TabIndex = 4;
            this.lblNameSeller.Text = "Nombre:";
            // 
            // txtCedulaSeller
            // 
            this.txtCedulaSeller.Location = new System.Drawing.Point(250, 34);
            this.txtCedulaSeller.Name = "txtCedulaSeller";
            this.txtCedulaSeller.Size = new System.Drawing.Size(118, 20);
            this.txtCedulaSeller.TabIndex = 3;
            // 
            // lblCedulaSeller
            // 
            this.lblCedulaSeller.AutoSize = true;
            this.lblCedulaSeller.Location = new System.Drawing.Point(201, 37);
            this.lblCedulaSeller.Name = "lblCedulaSeller";
            this.lblCedulaSeller.Size = new System.Drawing.Size(43, 13);
            this.lblCedulaSeller.TabIndex = 2;
            this.lblCedulaSeller.Text = "Cedula:";
            // 
            // txtIDSeller
            // 
            this.txtIDSeller.Location = new System.Drawing.Point(69, 34);
            this.txtIDSeller.Name = "txtIDSeller";
            this.txtIDSeller.Size = new System.Drawing.Size(100, 20);
            this.txtIDSeller.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(42, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // gbComprador
            // 
            this.gbComprador.Controls.Add(this.lblSearchBuy);
            this.gbComprador.Controls.Add(this.btnSearchBuy);
            this.gbComprador.Controls.Add(this.btnClearBuy);
            this.gbComprador.Controls.Add(this.txtCelularBuy);
            this.gbComprador.Controls.Add(this.lblCelularBuy);
            this.gbComprador.Controls.Add(this.txtPhoneBuy);
            this.gbComprador.Controls.Add(this.lblPhoneBuy);
            this.gbComprador.Controls.Add(this.txtLastNameBuy);
            this.gbComprador.Controls.Add(this.lblLastNameBuy);
            this.gbComprador.Controls.Add(this.txtNameBuy);
            this.gbComprador.Controls.Add(this.lblNameBuy);
            this.gbComprador.Controls.Add(this.txtCedulaBuy);
            this.gbComprador.Controls.Add(this.lblCedulaBuy);
            this.gbComprador.Controls.Add(this.txtIDBuy);
            this.gbComprador.Controls.Add(this.lblIDBuy);
            this.gbComprador.Location = new System.Drawing.Point(412, 12);
            this.gbComprador.Name = "gbComprador";
            this.gbComprador.Size = new System.Drawing.Size(382, 218);
            this.gbComprador.TabIndex = 1;
            this.gbComprador.TabStop = false;
            this.gbComprador.Text = "Comprador";
            // 
            // lblSearchBuy
            // 
            this.lblSearchBuy.AutoSize = true;
            this.lblSearchBuy.Location = new System.Drawing.Point(129, 57);
            this.lblSearchBuy.Name = "lblSearchBuy";
            this.lblSearchBuy.Size = new System.Drawing.Size(40, 13);
            this.lblSearchBuy.TabIndex = 14;
            this.lblSearchBuy.TabStop = true;
            this.lblSearchBuy.Text = "Buscar";
            this.lblSearchBuy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSearchBuy_LinkClicked);
            // 
            // btnSearchBuy
            // 
            this.btnSearchBuy.Location = new System.Drawing.Point(227, 179);
            this.btnSearchBuy.Name = "btnSearchBuy";
            this.btnSearchBuy.Size = new System.Drawing.Size(123, 23);
            this.btnSearchBuy.TabIndex = 13;
            this.btnSearchBuy.Text = "Buscar comprador";
            this.btnSearchBuy.UseVisualStyleBackColor = true;
            this.btnSearchBuy.Click += new System.EventHandler(this.btnSearchBuy_Click);
            // 
            // btnClearBuy
            // 
            this.btnClearBuy.Location = new System.Drawing.Point(45, 179);
            this.btnClearBuy.Name = "btnClearBuy";
            this.btnClearBuy.Size = new System.Drawing.Size(75, 23);
            this.btnClearBuy.TabIndex = 12;
            this.btnClearBuy.Text = "Limpiar";
            this.btnClearBuy.UseVisualStyleBackColor = true;
            // 
            // txtCelularBuy
            // 
            this.txtCelularBuy.Location = new System.Drawing.Point(250, 135);
            this.txtCelularBuy.Name = "txtCelularBuy";
            this.txtCelularBuy.Size = new System.Drawing.Size(100, 20);
            this.txtCelularBuy.TabIndex = 11;
            // 
            // lblCelularBuy
            // 
            this.lblCelularBuy.AutoSize = true;
            this.lblCelularBuy.Location = new System.Drawing.Point(207, 138);
            this.lblCelularBuy.Name = "lblCelularBuy";
            this.lblCelularBuy.Size = new System.Drawing.Size(42, 13);
            this.lblCelularBuy.TabIndex = 10;
            this.lblCelularBuy.Text = "Celular:";
            // 
            // txtPhoneBuy
            // 
            this.txtPhoneBuy.Location = new System.Drawing.Point(69, 135);
            this.txtPhoneBuy.Name = "txtPhoneBuy";
            this.txtPhoneBuy.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneBuy.TabIndex = 9;
            // 
            // lblPhoneBuy
            // 
            this.lblPhoneBuy.AutoSize = true;
            this.lblPhoneBuy.Location = new System.Drawing.Point(11, 138);
            this.lblPhoneBuy.Name = "lblPhoneBuy";
            this.lblPhoneBuy.Size = new System.Drawing.Size(52, 13);
            this.lblPhoneBuy.TabIndex = 8;
            this.lblPhoneBuy.Text = "Telefono:";
            // 
            // txtLastNameBuy
            // 
            this.txtLastNameBuy.Location = new System.Drawing.Point(250, 82);
            this.txtLastNameBuy.Name = "txtLastNameBuy";
            this.txtLastNameBuy.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameBuy.TabIndex = 7;
            // 
            // lblLastNameBuy
            // 
            this.lblLastNameBuy.AutoSize = true;
            this.lblLastNameBuy.Location = new System.Drawing.Point(202, 85);
            this.lblLastNameBuy.Name = "lblLastNameBuy";
            this.lblLastNameBuy.Size = new System.Drawing.Size(47, 13);
            this.lblLastNameBuy.TabIndex = 6;
            this.lblLastNameBuy.Text = "Apellido:";
            // 
            // txtNameBuy
            // 
            this.txtNameBuy.Location = new System.Drawing.Point(69, 82);
            this.txtNameBuy.Name = "txtNameBuy";
            this.txtNameBuy.Size = new System.Drawing.Size(100, 20);
            this.txtNameBuy.TabIndex = 5;
            // 
            // lblNameBuy
            // 
            this.lblNameBuy.AutoSize = true;
            this.lblNameBuy.Location = new System.Drawing.Point(21, 85);
            this.lblNameBuy.Name = "lblNameBuy";
            this.lblNameBuy.Size = new System.Drawing.Size(47, 13);
            this.lblNameBuy.TabIndex = 4;
            this.lblNameBuy.Text = "Nombre:";
            // 
            // txtCedulaBuy
            // 
            this.txtCedulaBuy.Location = new System.Drawing.Point(250, 34);
            this.txtCedulaBuy.Name = "txtCedulaBuy";
            this.txtCedulaBuy.Size = new System.Drawing.Size(118, 20);
            this.txtCedulaBuy.TabIndex = 3;
            // 
            // lblCedulaBuy
            // 
            this.lblCedulaBuy.AutoSize = true;
            this.lblCedulaBuy.Location = new System.Drawing.Point(201, 37);
            this.lblCedulaBuy.Name = "lblCedulaBuy";
            this.lblCedulaBuy.Size = new System.Drawing.Size(43, 13);
            this.lblCedulaBuy.TabIndex = 2;
            this.lblCedulaBuy.Text = "Cedula:";
            // 
            // txtIDBuy
            // 
            this.txtIDBuy.Location = new System.Drawing.Point(69, 34);
            this.txtIDBuy.Name = "txtIDBuy";
            this.txtIDBuy.Size = new System.Drawing.Size(100, 20);
            this.txtIDBuy.TabIndex = 1;
            // 
            // lblIDBuy
            // 
            this.lblIDBuy.AutoSize = true;
            this.lblIDBuy.Location = new System.Drawing.Point(42, 37);
            this.lblIDBuy.Name = "lblIDBuy";
            this.lblIDBuy.Size = new System.Drawing.Size(21, 13);
            this.lblIDBuy.TabIndex = 0;
            this.lblIDBuy.Text = "ID:";
            // 
            // gbInfoPagos
            // 
            this.gbInfoPagos.Controls.Add(this.txtMatricula);
            this.gbInfoPagos.Controls.Add(this.lblMatricula);
            this.gbInfoPagos.Controls.Add(this.txtDescripcion);
            this.gbInfoPagos.Controls.Add(this.lblDescripcion);
            this.gbInfoPagos.Controls.Add(this.lblInmueble);
            this.gbInfoPagos.Controls.Add(this.cbInmueble);
            this.gbInfoPagos.Controls.Add(this.txtPrecioVenta);
            this.gbInfoPagos.Controls.Add(this.lblPreciodeVenta);
            this.gbInfoPagos.Controls.Add(this.txtAbono);
            this.gbInfoPagos.Controls.Add(this.lblAbono);
            this.gbInfoPagos.Controls.Add(this.txtHonorarios);
            this.gbInfoPagos.Controls.Add(this.lblHonorarios);
            this.gbInfoPagos.Location = new System.Drawing.Point(12, 236);
            this.gbInfoPagos.Name = "gbInfoPagos";
            this.gbInfoPagos.Size = new System.Drawing.Size(782, 150);
            this.gbInfoPagos.TabIndex = 2;
            this.gbInfoPagos.TabStop = false;
            this.gbInfoPagos.Text = "Informacion Venta";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(650, 35);
            this.txtMatricula.Mask = "000000";
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(65, 20);
            this.txtMatricula.TabIndex = 11;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(591, 38);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(53, 13);
            this.lblMatricula.TabIndex = 10;
            this.lblMatricula.Text = "Matricula:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(299, 35);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(283, 49);
            this.txtDescripcion.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(232, 38);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 8;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblInmueble
            // 
            this.lblInmueble.AutoSize = true;
            this.lblInmueble.Location = new System.Drawing.Point(42, 38);
            this.lblInmueble.Name = "lblInmueble";
            this.lblInmueble.Size = new System.Drawing.Size(53, 13);
            this.lblInmueble.TabIndex = 7;
            this.lblInmueble.Text = "Inmueble:";
            // 
            // cbInmueble
            // 
            this.cbInmueble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInmueble.FormattingEnabled = true;
            this.cbInmueble.Location = new System.Drawing.Point(98, 35);
            this.cbInmueble.Name = "cbInmueble";
            this.cbInmueble.Size = new System.Drawing.Size(100, 21);
            this.cbInmueble.TabIndex = 6;
            this.cbInmueble.SelectedIndexChanged += new System.EventHandler(this.cbInmueble_SelectedIndexChanged);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(482, 108);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 5;
            // 
            // lblPreciodeVenta
            // 
            this.lblPreciodeVenta.AutoSize = true;
            this.lblPreciodeVenta.Location = new System.Drawing.Point(405, 111);
            this.lblPreciodeVenta.Name = "lblPreciodeVenta";
            this.lblPreciodeVenta.Size = new System.Drawing.Size(71, 13);
            this.lblPreciodeVenta.TabIndex = 4;
            this.lblPreciodeVenta.Text = "Precio Venta:";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(279, 108);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(100, 20);
            this.txtAbono.TabIndex = 3;
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Location = new System.Drawing.Point(232, 111);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(41, 13);
            this.lblAbono.TabIndex = 2;
            this.lblAbono.Text = "Abono:";
            // 
            // txtHonorarios
            // 
            this.txtHonorarios.Location = new System.Drawing.Point(98, 108);
            this.txtHonorarios.Name = "txtHonorarios";
            this.txtHonorarios.Size = new System.Drawing.Size(100, 20);
            this.txtHonorarios.TabIndex = 1;
            // 
            // lblHonorarios
            // 
            this.lblHonorarios.AutoSize = true;
            this.lblHonorarios.Location = new System.Drawing.Point(31, 111);
            this.lblHonorarios.Name = "lblHonorarios";
            this.lblHonorarios.Size = new System.Drawing.Size(61, 13);
            this.lblHonorarios.TabIndex = 0;
            this.lblHonorarios.Text = "Honorarios:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(345, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(202, 392);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(92, 23);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Limpiar todo";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 392);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar Datos";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(808, 421);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbInfoPagos);
            this.Controls.Add(this.gbComprador);
            this.Controls.Add(this.gbVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbVendedor.ResumeLayout(false);
            this.gbVendedor.PerformLayout();
            this.gbComprador.ResumeLayout(false);
            this.gbComprador.PerformLayout();
            this.gbInfoPagos.ResumeLayout(false);
            this.gbInfoPagos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.TextBox txtIDSeller;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnSearchSeller;
        private System.Windows.Forms.Button btnClearSeller;
        private System.Windows.Forms.TextBox txtCelularSeller;
        private System.Windows.Forms.Label lblCelularSeller;
        private System.Windows.Forms.TextBox txtPhoneSeller;
        private System.Windows.Forms.Label lblPhoneSeller;
        private System.Windows.Forms.TextBox txtLastNameSeller;
        private System.Windows.Forms.Label lblLastNameSeller;
        private System.Windows.Forms.TextBox txtNameSeller;
        private System.Windows.Forms.Label lblNameSeller;
        private System.Windows.Forms.TextBox txtCedulaSeller;
        private System.Windows.Forms.Label lblCedulaSeller;
        private System.Windows.Forms.GroupBox gbComprador;
        private System.Windows.Forms.Button btnSearchBuy;
        private System.Windows.Forms.Button btnClearBuy;
        private System.Windows.Forms.TextBox txtCelularBuy;
        private System.Windows.Forms.Label lblCelularBuy;
        private System.Windows.Forms.TextBox txtPhoneBuy;
        private System.Windows.Forms.Label lblPhoneBuy;
        private System.Windows.Forms.TextBox txtLastNameBuy;
        private System.Windows.Forms.Label lblLastNameBuy;
        private System.Windows.Forms.TextBox txtNameBuy;
        private System.Windows.Forms.Label lblNameBuy;
        private System.Windows.Forms.TextBox txtCedulaBuy;
        private System.Windows.Forms.Label lblCedulaBuy;
        private System.Windows.Forms.TextBox txtIDBuy;
        private System.Windows.Forms.Label lblIDBuy;
        private System.Windows.Forms.GroupBox gbInfoPagos;
        private System.Windows.Forms.MaskedTextBox txtMatricula;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblInmueble;
        private System.Windows.Forms.ComboBox cbInmueble;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label lblPreciodeVenta;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.TextBox txtHonorarios;
        private System.Windows.Forms.Label lblHonorarios;
        private System.Windows.Forms.LinkLabel lblSearchSeller;
        private System.Windows.Forms.LinkLabel lblSearchBuy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSave;
    }
}