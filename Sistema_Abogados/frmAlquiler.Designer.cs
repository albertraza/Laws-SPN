﻿namespace Sistema_Abogados
{
    partial class frmAlquiler
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
            this.gbInfoCustomer = new System.Windows.Forms.GroupBox();
            this.lblSearchCust = new System.Windows.Forms.LinkLabel();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtCustCell = new System.Windows.Forms.TextBox();
            this.lblCustCell = new System.Windows.Forms.Label();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.txtCustLastName = new System.Windows.Forms.TextBox();
            this.lblCustLastName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.gbInfoInqui = new System.Windows.Forms.GroupBox();
            this.lblSearchInqui = new System.Windows.Forms.LinkLabel();
            this.btnSearchInqui = new System.Windows.Forms.Button();
            this.txtCellphoneInqui = new System.Windows.Forms.TextBox();
            this.lblCellphoneInqui = new System.Windows.Forms.Label();
            this.txtPhoneInqui = new System.Windows.Forms.TextBox();
            this.lblPhoneInqui = new System.Windows.Forms.Label();
            this.txtLastNameInqui = new System.Windows.Forms.TextBox();
            this.lblLastNameInqui = new System.Windows.Forms.Label();
            this.txtNameInqui = new System.Windows.Forms.TextBox();
            this.lblNameInqui = new System.Windows.Forms.Label();
            this.txtIDInqui = new System.Windows.Forms.TextBox();
            this.lblIDInqui = new System.Windows.Forms.Label();
            this.gbInfoGaran = new System.Windows.Forms.GroupBox();
            this.lblSearchGara = new System.Windows.Forms.LinkLabel();
            this.btnSearchGaran = new System.Windows.Forms.Button();
            this.txtCellphoneGaran = new System.Windows.Forms.TextBox();
            this.lblCellphoneGaran = new System.Windows.Forms.Label();
            this.txtPhoneGaran = new System.Windows.Forms.TextBox();
            this.lblPhonegaran = new System.Windows.Forms.Label();
            this.txtLastNameGaran = new System.Windows.Forms.TextBox();
            this.lblLastNameGaran = new System.Windows.Forms.Label();
            this.txtNameGaran = new System.Windows.Forms.TextBox();
            this.lblNameGaran = new System.Windows.Forms.Label();
            this.txtIDGaran = new System.Windows.Forms.TextBox();
            this.lblIDGaran = new System.Windows.Forms.Label();
            this.gbInfoAlqui = new System.Windows.Forms.GroupBox();
            this.txtHonorarios = new System.Windows.Forms.TextBox();
            this.lblHonorarios = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.lblAbono = new System.Windows.Forms.Label();
            this.txtPriceRent = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.gbInfoInmueble = new System.Windows.Forms.GroupBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.cbCities = new System.Windows.Forms.ComboBox();
            this.lblSector = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtDeposito = new System.Windows.Forms.TextBox();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.btnClearCustomer = new System.Windows.Forms.Button();
            this.btnClearInqui = new System.Windows.Forms.Button();
            this.btnClearGaran = new System.Windows.Forms.Button();
            this.gbInfoCustomer.SuspendLayout();
            this.gbInfoInqui.SuspendLayout();
            this.gbInfoGaran.SuspendLayout();
            this.gbInfoAlqui.SuspendLayout();
            this.gbInfoInmueble.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfoCustomer
            // 
            this.gbInfoCustomer.Controls.Add(this.btnClearCustomer);
            this.gbInfoCustomer.Controls.Add(this.lblSearchCust);
            this.gbInfoCustomer.Controls.Add(this.btnSearchCustomer);
            this.gbInfoCustomer.Controls.Add(this.txtCustCell);
            this.gbInfoCustomer.Controls.Add(this.lblCustCell);
            this.gbInfoCustomer.Controls.Add(this.txtCustPhone);
            this.gbInfoCustomer.Controls.Add(this.lblCustPhone);
            this.gbInfoCustomer.Controls.Add(this.txtCustLastName);
            this.gbInfoCustomer.Controls.Add(this.lblCustLastName);
            this.gbInfoCustomer.Controls.Add(this.txtCustName);
            this.gbInfoCustomer.Controls.Add(this.lblCustName);
            this.gbInfoCustomer.Controls.Add(this.txtCustID);
            this.gbInfoCustomer.Controls.Add(this.lblCustID);
            this.gbInfoCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbInfoCustomer.Name = "gbInfoCustomer";
            this.gbInfoCustomer.Size = new System.Drawing.Size(299, 172);
            this.gbInfoCustomer.TabIndex = 0;
            this.gbInfoCustomer.TabStop = false;
            this.gbInfoCustomer.Text = "Informacion Cliente";
            // 
            // lblSearchCust
            // 
            this.lblSearchCust.AutoSize = true;
            this.lblSearchCust.Location = new System.Drawing.Point(73, 58);
            this.lblSearchCust.Name = "lblSearchCust";
            this.lblSearchCust.Size = new System.Drawing.Size(40, 13);
            this.lblSearchCust.TabIndex = 21;
            this.lblSearchCust.TabStop = true;
            this.lblSearchCust.Text = "Buscar";
            this.lblSearchCust.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSearchCust_LinkClicked);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(165, 134);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(109, 23);
            this.btnSearchCustomer.TabIndex = 10;
            this.btnSearchCustomer.Text = "Buscar Cliente";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtCustCell
            // 
            this.txtCustCell.Location = new System.Drawing.Point(70, 108);
            this.txtCustCell.Name = "txtCustCell";
            this.txtCustCell.Size = new System.Drawing.Size(94, 20);
            this.txtCustCell.TabIndex = 9;
            // 
            // lblCustCell
            // 
            this.lblCustCell.AutoSize = true;
            this.lblCustCell.Location = new System.Drawing.Point(27, 111);
            this.lblCustCell.Name = "lblCustCell";
            this.lblCustCell.Size = new System.Drawing.Size(42, 13);
            this.lblCustCell.TabIndex = 8;
            this.lblCustCell.Text = "Celular:";
            this.lblCustCell.Click += new System.EventHandler(this.lblCustCell_Click);
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(204, 74);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(89, 20);
            this.txtCustPhone.TabIndex = 7;
            this.txtCustPhone.TextChanged += new System.EventHandler(this.txtCustNombre_TextChanged);
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(151, 77);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(52, 13);
            this.lblCustPhone.TabIndex = 6;
            this.lblCustPhone.Text = "Telefono:";
            // 
            // txtCustLastName
            // 
            this.txtCustLastName.Location = new System.Drawing.Point(70, 74);
            this.txtCustLastName.Name = "txtCustLastName";
            this.txtCustLastName.Size = new System.Drawing.Size(75, 20);
            this.txtCustLastName.TabIndex = 5;
            // 
            // lblCustLastName
            // 
            this.lblCustLastName.AutoSize = true;
            this.lblCustLastName.Location = new System.Drawing.Point(17, 77);
            this.lblCustLastName.Name = "lblCustLastName";
            this.lblCustLastName.Size = new System.Drawing.Size(47, 13);
            this.lblCustLastName.TabIndex = 4;
            this.lblCustLastName.Text = "Apellido:";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(204, 35);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(70, 20);
            this.txtCustName.TabIndex = 3;
            this.txtCustName.TextChanged += new System.EventHandler(this.txtCustName_TextChanged);
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(151, 38);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(47, 13);
            this.lblCustName.TabIndex = 2;
            this.lblCustName.Text = "Nombre:";
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(70, 35);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(51, 20);
            this.txtCustID.TabIndex = 1;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(43, 38);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(21, 13);
            this.lblCustID.TabIndex = 0;
            this.lblCustID.Text = "ID:";
            // 
            // gbInfoInqui
            // 
            this.gbInfoInqui.Controls.Add(this.btnClearInqui);
            this.gbInfoInqui.Controls.Add(this.lblSearchInqui);
            this.gbInfoInqui.Controls.Add(this.btnSearchInqui);
            this.gbInfoInqui.Controls.Add(this.txtCellphoneInqui);
            this.gbInfoInqui.Controls.Add(this.lblCellphoneInqui);
            this.gbInfoInqui.Controls.Add(this.txtPhoneInqui);
            this.gbInfoInqui.Controls.Add(this.lblPhoneInqui);
            this.gbInfoInqui.Controls.Add(this.txtLastNameInqui);
            this.gbInfoInqui.Controls.Add(this.lblLastNameInqui);
            this.gbInfoInqui.Controls.Add(this.txtNameInqui);
            this.gbInfoInqui.Controls.Add(this.lblNameInqui);
            this.gbInfoInqui.Controls.Add(this.txtIDInqui);
            this.gbInfoInqui.Controls.Add(this.lblIDInqui);
            this.gbInfoInqui.Location = new System.Drawing.Point(326, 12);
            this.gbInfoInqui.Name = "gbInfoInqui";
            this.gbInfoInqui.Size = new System.Drawing.Size(301, 172);
            this.gbInfoInqui.TabIndex = 1;
            this.gbInfoInqui.TabStop = false;
            this.gbInfoInqui.Text = "Informacion  Inquilino";
            // 
            // lblSearchInqui
            // 
            this.lblSearchInqui.AutoSize = true;
            this.lblSearchInqui.Location = new System.Drawing.Point(82, 58);
            this.lblSearchInqui.Name = "lblSearchInqui";
            this.lblSearchInqui.Size = new System.Drawing.Size(40, 13);
            this.lblSearchInqui.TabIndex = 22;
            this.lblSearchInqui.TabStop = true;
            this.lblSearchInqui.Text = "Buscar";
            this.lblSearchInqui.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btnSearchInqui
            // 
            this.btnSearchInqui.Location = new System.Drawing.Point(168, 134);
            this.btnSearchInqui.Name = "btnSearchInqui";
            this.btnSearchInqui.Size = new System.Drawing.Size(109, 23);
            this.btnSearchInqui.TabIndex = 21;
            this.btnSearchInqui.Text = "Buscar Inquilino";
            this.btnSearchInqui.UseVisualStyleBackColor = true;
            this.btnSearchInqui.Click += new System.EventHandler(this.btnSearchInqui_Click);
            // 
            // txtCellphoneInqui
            // 
            this.txtCellphoneInqui.Location = new System.Drawing.Point(71, 110);
            this.txtCellphoneInqui.Name = "txtCellphoneInqui";
            this.txtCellphoneInqui.Size = new System.Drawing.Size(91, 20);
            this.txtCellphoneInqui.TabIndex = 20;
            // 
            // lblCellphoneInqui
            // 
            this.lblCellphoneInqui.AutoSize = true;
            this.lblCellphoneInqui.Location = new System.Drawing.Point(23, 113);
            this.lblCellphoneInqui.Name = "lblCellphoneInqui";
            this.lblCellphoneInqui.Size = new System.Drawing.Size(42, 13);
            this.lblCellphoneInqui.TabIndex = 19;
            this.lblCellphoneInqui.Text = "Celular:";
            // 
            // txtPhoneInqui
            // 
            this.txtPhoneInqui.Location = new System.Drawing.Point(202, 74);
            this.txtPhoneInqui.Name = "txtPhoneInqui";
            this.txtPhoneInqui.Size = new System.Drawing.Size(93, 20);
            this.txtPhoneInqui.TabIndex = 18;
            // 
            // lblPhoneInqui
            // 
            this.lblPhoneInqui.AutoSize = true;
            this.lblPhoneInqui.Location = new System.Drawing.Point(149, 77);
            this.lblPhoneInqui.Name = "lblPhoneInqui";
            this.lblPhoneInqui.Size = new System.Drawing.Size(52, 13);
            this.lblPhoneInqui.TabIndex = 17;
            this.lblPhoneInqui.Text = "Telefono:";
            // 
            // txtLastNameInqui
            // 
            this.txtLastNameInqui.Location = new System.Drawing.Point(71, 74);
            this.txtLastNameInqui.Name = "txtLastNameInqui";
            this.txtLastNameInqui.Size = new System.Drawing.Size(75, 20);
            this.txtLastNameInqui.TabIndex = 16;
            // 
            // lblLastNameInqui
            // 
            this.lblLastNameInqui.AutoSize = true;
            this.lblLastNameInqui.Location = new System.Drawing.Point(18, 77);
            this.lblLastNameInqui.Name = "lblLastNameInqui";
            this.lblLastNameInqui.Size = new System.Drawing.Size(47, 13);
            this.lblLastNameInqui.TabIndex = 15;
            this.lblLastNameInqui.Text = "Apellido:";
            // 
            // txtNameInqui
            // 
            this.txtNameInqui.Location = new System.Drawing.Point(202, 38);
            this.txtNameInqui.Name = "txtNameInqui";
            this.txtNameInqui.Size = new System.Drawing.Size(75, 20);
            this.txtNameInqui.TabIndex = 14;
            // 
            // lblNameInqui
            // 
            this.lblNameInqui.AutoSize = true;
            this.lblNameInqui.Location = new System.Drawing.Point(154, 42);
            this.lblNameInqui.Name = "lblNameInqui";
            this.lblNameInqui.Size = new System.Drawing.Size(47, 13);
            this.lblNameInqui.TabIndex = 13;
            this.lblNameInqui.Text = "Nombre:";
            // 
            // txtIDInqui
            // 
            this.txtIDInqui.Location = new System.Drawing.Point(71, 38);
            this.txtIDInqui.Name = "txtIDInqui";
            this.txtIDInqui.Size = new System.Drawing.Size(51, 20);
            this.txtIDInqui.TabIndex = 12;
            // 
            // lblIDInqui
            // 
            this.lblIDInqui.AutoSize = true;
            this.lblIDInqui.Location = new System.Drawing.Point(44, 41);
            this.lblIDInqui.Name = "lblIDInqui";
            this.lblIDInqui.Size = new System.Drawing.Size(21, 13);
            this.lblIDInqui.TabIndex = 11;
            this.lblIDInqui.Text = "ID:";
            // 
            // gbInfoGaran
            // 
            this.gbInfoGaran.Controls.Add(this.btnClearGaran);
            this.gbInfoGaran.Controls.Add(this.lblSearchGara);
            this.gbInfoGaran.Controls.Add(this.btnSearchGaran);
            this.gbInfoGaran.Controls.Add(this.txtCellphoneGaran);
            this.gbInfoGaran.Controls.Add(this.lblCellphoneGaran);
            this.gbInfoGaran.Controls.Add(this.txtPhoneGaran);
            this.gbInfoGaran.Controls.Add(this.lblPhonegaran);
            this.gbInfoGaran.Controls.Add(this.txtLastNameGaran);
            this.gbInfoGaran.Controls.Add(this.lblLastNameGaran);
            this.gbInfoGaran.Controls.Add(this.txtNameGaran);
            this.gbInfoGaran.Controls.Add(this.lblNameGaran);
            this.gbInfoGaran.Controls.Add(this.txtIDGaran);
            this.gbInfoGaran.Controls.Add(this.lblIDGaran);
            this.gbInfoGaran.Location = new System.Drawing.Point(653, 12);
            this.gbInfoGaran.Name = "gbInfoGaran";
            this.gbInfoGaran.Size = new System.Drawing.Size(299, 172);
            this.gbInfoGaran.TabIndex = 2;
            this.gbInfoGaran.TabStop = false;
            this.gbInfoGaran.Text = "Informacion Garante";
            // 
            // lblSearchGara
            // 
            this.lblSearchGara.AutoSize = true;
            this.lblSearchGara.Location = new System.Drawing.Point(87, 54);
            this.lblSearchGara.Name = "lblSearchGara";
            this.lblSearchGara.Size = new System.Drawing.Size(40, 13);
            this.lblSearchGara.TabIndex = 22;
            this.lblSearchGara.TabStop = true;
            this.lblSearchGara.Text = "Buscar";
            this.lblSearchGara.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSearchGara_LinkClicked);
            // 
            // btnSearchGaran
            // 
            this.btnSearchGaran.Location = new System.Drawing.Point(157, 134);
            this.btnSearchGaran.Name = "btnSearchGaran";
            this.btnSearchGaran.Size = new System.Drawing.Size(109, 23);
            this.btnSearchGaran.TabIndex = 21;
            this.btnSearchGaran.Text = "Buscar Garante";
            this.btnSearchGaran.UseVisualStyleBackColor = true;
            this.btnSearchGaran.Click += new System.EventHandler(this.btnSearchGaran_Click);
            // 
            // txtCellphoneGaran
            // 
            this.txtCellphoneGaran.Location = new System.Drawing.Point(67, 106);
            this.txtCellphoneGaran.Name = "txtCellphoneGaran";
            this.txtCellphoneGaran.Size = new System.Drawing.Size(84, 20);
            this.txtCellphoneGaran.TabIndex = 20;
            // 
            // lblCellphoneGaran
            // 
            this.lblCellphoneGaran.AutoSize = true;
            this.lblCellphoneGaran.Location = new System.Drawing.Point(19, 109);
            this.lblCellphoneGaran.Name = "lblCellphoneGaran";
            this.lblCellphoneGaran.Size = new System.Drawing.Size(42, 13);
            this.lblCellphoneGaran.TabIndex = 19;
            this.lblCellphoneGaran.Text = "Celular:";
            // 
            // txtPhoneGaran
            // 
            this.txtPhoneGaran.Location = new System.Drawing.Point(198, 74);
            this.txtPhoneGaran.Name = "txtPhoneGaran";
            this.txtPhoneGaran.Size = new System.Drawing.Size(84, 20);
            this.txtPhoneGaran.TabIndex = 18;
            // 
            // lblPhonegaran
            // 
            this.lblPhonegaran.AutoSize = true;
            this.lblPhonegaran.Location = new System.Drawing.Point(145, 77);
            this.lblPhonegaran.Name = "lblPhonegaran";
            this.lblPhonegaran.Size = new System.Drawing.Size(52, 13);
            this.lblPhonegaran.TabIndex = 17;
            this.lblPhonegaran.Text = "Telefono:";
            // 
            // txtLastNameGaran
            // 
            this.txtLastNameGaran.Location = new System.Drawing.Point(67, 74);
            this.txtLastNameGaran.Name = "txtLastNameGaran";
            this.txtLastNameGaran.Size = new System.Drawing.Size(75, 20);
            this.txtLastNameGaran.TabIndex = 16;
            // 
            // lblLastNameGaran
            // 
            this.lblLastNameGaran.AutoSize = true;
            this.lblLastNameGaran.Location = new System.Drawing.Point(14, 77);
            this.lblLastNameGaran.Name = "lblLastNameGaran";
            this.lblLastNameGaran.Size = new System.Drawing.Size(47, 13);
            this.lblLastNameGaran.TabIndex = 15;
            this.lblLastNameGaran.Text = "Apellido:";
            // 
            // txtNameGaran
            // 
            this.txtNameGaran.Location = new System.Drawing.Point(198, 38);
            this.txtNameGaran.Name = "txtNameGaran";
            this.txtNameGaran.Size = new System.Drawing.Size(68, 20);
            this.txtNameGaran.TabIndex = 14;
            // 
            // lblNameGaran
            // 
            this.lblNameGaran.AutoSize = true;
            this.lblNameGaran.Location = new System.Drawing.Point(145, 41);
            this.lblNameGaran.Name = "lblNameGaran";
            this.lblNameGaran.Size = new System.Drawing.Size(47, 13);
            this.lblNameGaran.TabIndex = 13;
            this.lblNameGaran.Text = "Nombre:";
            // 
            // txtIDGaran
            // 
            this.txtIDGaran.Location = new System.Drawing.Point(76, 31);
            this.txtIDGaran.Name = "txtIDGaran";
            this.txtIDGaran.Size = new System.Drawing.Size(51, 20);
            this.txtIDGaran.TabIndex = 12;
            // 
            // lblIDGaran
            // 
            this.lblIDGaran.AutoSize = true;
            this.lblIDGaran.Location = new System.Drawing.Point(49, 34);
            this.lblIDGaran.Name = "lblIDGaran";
            this.lblIDGaran.Size = new System.Drawing.Size(21, 13);
            this.lblIDGaran.TabIndex = 11;
            this.lblIDGaran.Text = "ID:";
            // 
            // gbInfoAlqui
            // 
            this.gbInfoAlqui.Controls.Add(this.txtDeposito);
            this.gbInfoAlqui.Controls.Add(this.lblDeposito);
            this.gbInfoAlqui.Controls.Add(this.txtHonorarios);
            this.gbInfoAlqui.Controls.Add(this.lblHonorarios);
            this.gbInfoAlqui.Controls.Add(this.txtAbono);
            this.gbInfoAlqui.Controls.Add(this.lblAbono);
            this.gbInfoAlqui.Controls.Add(this.txtPriceRent);
            this.gbInfoAlqui.Controls.Add(this.lblPrice);
            this.gbInfoAlqui.Location = new System.Drawing.Point(12, 202);
            this.gbInfoAlqui.Name = "gbInfoAlqui";
            this.gbInfoAlqui.Size = new System.Drawing.Size(299, 140);
            this.gbInfoAlqui.TabIndex = 3;
            this.gbInfoAlqui.TabStop = false;
            this.gbInfoAlqui.Text = "Alquiler";
            this.gbInfoAlqui.Enter += new System.EventHandler(this.gbInfoAlqui_Enter);
            // 
            // txtHonorarios
            // 
            this.txtHonorarios.Location = new System.Drawing.Point(76, 78);
            this.txtHonorarios.Name = "txtHonorarios";
            this.txtHonorarios.Size = new System.Drawing.Size(75, 20);
            this.txtHonorarios.TabIndex = 20;
            this.txtHonorarios.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblHonorarios
            // 
            this.lblHonorarios.AutoSize = true;
            this.lblHonorarios.Location = new System.Drawing.Point(14, 81);
            this.lblHonorarios.Name = "lblHonorarios";
            this.lblHonorarios.Size = new System.Drawing.Size(61, 13);
            this.lblHonorarios.TabIndex = 19;
            this.lblHonorarios.Text = "Honorarios:";
            // 
            // txtAbono
            // 
            this.txtAbono.Location = new System.Drawing.Point(177, 31);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(64, 20);
            this.txtAbono.TabIndex = 18;
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Location = new System.Drawing.Point(130, 34);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(41, 13);
            this.lblAbono.TabIndex = 17;
            this.lblAbono.Text = "Abono:";
            // 
            // txtPriceRent
            // 
            this.txtPriceRent.Location = new System.Drawing.Point(60, 31);
            this.txtPriceRent.Name = "txtPriceRent";
            this.txtPriceRent.Size = new System.Drawing.Size(64, 20);
            this.txtPriceRent.TabIndex = 16;
            this.txtPriceRent.TextChanged += new System.EventHandler(this.txtPriceRent_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(14, 34);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Alquiler:";
            // 
            // gbInfoInmueble
            // 
            this.gbInfoInmueble.Controls.Add(this.txtDetails);
            this.gbInfoInmueble.Controls.Add(this.lblDetails);
            this.gbInfoInmueble.Controls.Add(this.cbCities);
            this.gbInfoInmueble.Controls.Add(this.lblSector);
            this.gbInfoInmueble.Controls.Add(this.txtAddress);
            this.gbInfoInmueble.Controls.Add(this.lblAddress);
            this.gbInfoInmueble.Location = new System.Drawing.Point(333, 202);
            this.gbInfoInmueble.Name = "gbInfoInmueble";
            this.gbInfoInmueble.Size = new System.Drawing.Size(602, 140);
            this.gbInfoInmueble.TabIndex = 4;
            this.gbInfoInmueble.TabStop = false;
            this.gbInfoInmueble.Text = "Informacion Inmueble";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(87, 75);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(303, 46);
            this.txtDetails.TabIndex = 24;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(33, 78);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(48, 13);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "Detalles:";
            // 
            // cbCities
            // 
            this.cbCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Location = new System.Drawing.Point(381, 31);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(121, 21);
            this.cbCities.TabIndex = 23;
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(334, 34);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(41, 13);
            this.lblSector.TabIndex = 22;
            this.lblSector.Text = "Sector:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(87, 31);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(230, 20);
            this.txtAddress.TabIndex = 21;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(26, 34);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 13);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Direccion:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(189, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Limpiar todo";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(362, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDeposito
            // 
            this.txtDeposito.Location = new System.Drawing.Point(214, 78);
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Size = new System.Drawing.Size(75, 20);
            this.txtDeposito.TabIndex = 22;
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(156, 81);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(52, 13);
            this.lblDeposito.TabIndex = 21;
            this.lblDeposito.Text = "Deposito:";
            // 
            // btnClearCustomer
            // 
            this.btnClearCustomer.Location = new System.Drawing.Point(46, 134);
            this.btnClearCustomer.Name = "btnClearCustomer";
            this.btnClearCustomer.Size = new System.Drawing.Size(85, 23);
            this.btnClearCustomer.TabIndex = 22;
            this.btnClearCustomer.Text = "Limpiar";
            this.btnClearCustomer.UseVisualStyleBackColor = true;
            this.btnClearCustomer.Click += new System.EventHandler(this.btnClearCustomer_Click);
            // 
            // btnClearInqui
            // 
            this.btnClearInqui.Location = new System.Drawing.Point(47, 134);
            this.btnClearInqui.Name = "btnClearInqui";
            this.btnClearInqui.Size = new System.Drawing.Size(85, 23);
            this.btnClearInqui.TabIndex = 23;
            this.btnClearInqui.Text = "Limpiar";
            this.btnClearInqui.UseVisualStyleBackColor = true;
            this.btnClearInqui.Click += new System.EventHandler(this.btnClearInqui_Click);
            // 
            // btnClearGaran
            // 
            this.btnClearGaran.Location = new System.Drawing.Point(52, 134);
            this.btnClearGaran.Name = "btnClearGaran";
            this.btnClearGaran.Size = new System.Drawing.Size(85, 23);
            this.btnClearGaran.TabIndex = 23;
            this.btnClearGaran.Text = "Limpiar";
            this.btnClearGaran.UseVisualStyleBackColor = true;
            this.btnClearGaran.Click += new System.EventHandler(this.btnClearGaran_Click);
            // 
            // frmAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(964, 406);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInfoInmueble);
            this.Controls.Add(this.gbInfoAlqui);
            this.Controls.Add(this.gbInfoGaran);
            this.Controls.Add(this.gbInfoInqui);
            this.Controls.Add(this.gbInfoCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAlquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.frmAlquiler_Load);
            this.gbInfoCustomer.ResumeLayout(false);
            this.gbInfoCustomer.PerformLayout();
            this.gbInfoInqui.ResumeLayout(false);
            this.gbInfoInqui.PerformLayout();
            this.gbInfoGaran.ResumeLayout(false);
            this.gbInfoGaran.PerformLayout();
            this.gbInfoAlqui.ResumeLayout(false);
            this.gbInfoAlqui.PerformLayout();
            this.gbInfoInmueble.ResumeLayout(false);
            this.gbInfoInmueble.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoCustomer;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.TextBox txtCustLastName;
        private System.Windows.Forms.Label lblCustLastName;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.GroupBox gbInfoInqui;
        private System.Windows.Forms.GroupBox gbInfoGaran;
        private System.Windows.Forms.GroupBox gbInfoAlqui;
        private System.Windows.Forms.TextBox txtCustCell;
        private System.Windows.Forms.Label lblCustCell;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnSearchInqui;
        private System.Windows.Forms.TextBox txtCellphoneInqui;
        private System.Windows.Forms.Label lblCellphoneInqui;
        private System.Windows.Forms.TextBox txtPhoneInqui;
        private System.Windows.Forms.Label lblPhoneInqui;
        private System.Windows.Forms.TextBox txtLastNameInqui;
        private System.Windows.Forms.Label lblLastNameInqui;
        private System.Windows.Forms.TextBox txtNameInqui;
        private System.Windows.Forms.Label lblNameInqui;
        private System.Windows.Forms.TextBox txtIDInqui;
        private System.Windows.Forms.Label lblIDInqui;
        private System.Windows.Forms.Button btnSearchGaran;
        private System.Windows.Forms.TextBox txtCellphoneGaran;
        private System.Windows.Forms.Label lblCellphoneGaran;
        private System.Windows.Forms.TextBox txtPhoneGaran;
        private System.Windows.Forms.Label lblPhonegaran;
        private System.Windows.Forms.TextBox txtLastNameGaran;
        private System.Windows.Forms.Label lblLastNameGaran;
        private System.Windows.Forms.TextBox txtNameGaran;
        private System.Windows.Forms.Label lblNameGaran;
        private System.Windows.Forms.TextBox txtIDGaran;
        private System.Windows.Forms.Label lblIDGaran;
        private System.Windows.Forms.TextBox txtHonorarios;
        private System.Windows.Forms.Label lblHonorarios;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.TextBox txtPriceRent;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox gbInfoInmueble;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox cbCities;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lblSearchCust;
        private System.Windows.Forms.LinkLabel lblSearchInqui;
        private System.Windows.Forms.LinkLabel lblSearchGara;
        private System.Windows.Forms.TextBox txtDeposito;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Button btnClearCustomer;
        private System.Windows.Forms.Button btnClearInqui;
        private System.Windows.Forms.Button btnClearGaran;
    }
}