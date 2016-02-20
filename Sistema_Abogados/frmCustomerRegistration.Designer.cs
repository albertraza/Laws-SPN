namespace Sistema_Abogados
{
    partial class frmCustomerRegistration
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.rbDemandado = new System.Windows.Forms.RadioButton();
            this.rbDemandante = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.txtPassport = new System.Windows.Forms.MaskedTextBox();
            this.gbDocument = new System.Windows.Forms.GroupBox();
            this.rbPassport = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtCellphone = new System.Windows.Forms.MaskedTextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.txtOcupation = new System.Windows.Forms.TextBox();
            this.lblOcupation = new System.Windows.Forms.Label();
            this.gbInformacionGeneral = new System.Windows.Forms.GroupBox();
            this.lblNew = new System.Windows.Forms.LinkLabel();
            this.lblSave = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.gbStatus.SuspendLayout();
            this.gbDocument.SuspendLayout();
            this.gbInformacionGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(532, 32);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(257, 268);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(604, 306);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(117, 23);
            this.btnSelectImage.TabIndex = 4;
            this.btnSelectImage.Text = "Seleccionar Imagen";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rbDemandado);
            this.gbStatus.Controls.Add(this.rbDemandante);
            this.gbStatus.Location = new System.Drawing.Point(532, 348);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(257, 62);
            this.gbStatus.TabIndex = 5;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // rbDemandado
            // 
            this.rbDemandado.AutoSize = true;
            this.rbDemandado.Location = new System.Drawing.Point(158, 30);
            this.rbDemandado.Name = "rbDemandado";
            this.rbDemandado.Size = new System.Drawing.Size(83, 17);
            this.rbDemandado.TabIndex = 1;
            this.rbDemandado.TabStop = true;
            this.rbDemandado.Text = "Demandado";
            this.rbDemandado.UseVisualStyleBackColor = true;
            // 
            // rbDemandante
            // 
            this.rbDemandante.AutoSize = true;
            this.rbDemandante.Location = new System.Drawing.Point(19, 30);
            this.rbDemandante.Name = "rbDemandante";
            this.rbDemandante.Size = new System.Drawing.Size(86, 17);
            this.rbDemandante.TabIndex = 0;
            this.rbDemandante.TabStop = true;
            this.rbDemandante.Text = "Demandante";
            this.rbDemandante.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 131);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nombre:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(274, 128);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(221, 131);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(47, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Apellido:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Registrar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(163, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(296, 387);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(85, 28);
            this.txtID.Mask = "000-0000000-0";
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(117, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtPassport
            // 
            this.txtPassport.Location = new System.Drawing.Point(297, 28);
            this.txtPassport.Mask = "SE-000-0000";
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(102, 20);
            this.txtPassport.TabIndex = 1;
            // 
            // gbDocument
            // 
            this.gbDocument.Controls.Add(this.rbPassport);
            this.gbDocument.Controls.Add(this.rbCedula);
            this.gbDocument.Controls.Add(this.txtPassport);
            this.gbDocument.Controls.Add(this.txtID);
            this.gbDocument.Location = new System.Drawing.Point(19, 46);
            this.gbDocument.Name = "gbDocument";
            this.gbDocument.Size = new System.Drawing.Size(428, 67);
            this.gbDocument.TabIndex = 0;
            this.gbDocument.TabStop = false;
            this.gbDocument.Text = "Documento";
            // 
            // rbPassport
            // 
            this.rbPassport.AutoSize = true;
            this.rbPassport.Location = new System.Drawing.Point(215, 29);
            this.rbPassport.Name = "rbPassport";
            this.rbPassport.Size = new System.Drawing.Size(76, 17);
            this.rbPassport.TabIndex = 5;
            this.rbPassport.TabStop = true;
            this.rbPassport.Text = "Pasaporte:";
            this.rbPassport.UseVisualStyleBackColor = true;
            this.rbPassport.CheckedChanged += new System.EventHandler(this.rbPassport_CheckedChanged);
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Location = new System.Drawing.Point(21, 29);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(61, 17);
            this.rbCedula.TabIndex = 4;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula:";
            this.rbCedula.UseVisualStyleBackColor = true;
            this.rbCedula.CheckedChanged += new System.EventHandler(this.rbCedula_CheckedChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(33, 174);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(55, 13);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Direccion:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(89, 171);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(179, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(32, 222);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 13);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "Telefono:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(89, 219);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 5;
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(293, 219);
            this.txtCellphone.Mask = "(999) 000-0000";
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(100, 20);
            this.txtCellphone.TabIndex = 6;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Location = new System.Drawing.Point(245, 222);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(42, 13);
            this.lblCellphone.TabIndex = 19;
            this.lblCellphone.Text = "Celular:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(89, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(44, 269);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "E-Mail:";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(275, 174);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(41, 13);
            this.lblSector.TabIndex = 23;
            this.lblSector.Text = "Sector:";
            // 
            // cbSector
            // 
            this.cbSector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Location = new System.Drawing.Point(316, 171);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(121, 21);
            this.cbSector.TabIndex = 4;
            // 
            // txtOcupation
            // 
            this.txtOcupation.Location = new System.Drawing.Point(339, 269);
            this.txtOcupation.Name = "txtOcupation";
            this.txtOcupation.Size = new System.Drawing.Size(108, 20);
            this.txtOcupation.TabIndex = 8;
            // 
            // lblOcupation
            // 
            this.lblOcupation.AutoSize = true;
            this.lblOcupation.Location = new System.Drawing.Point(271, 272);
            this.lblOcupation.Name = "lblOcupation";
            this.lblOcupation.Size = new System.Drawing.Size(62, 13);
            this.lblOcupation.TabIndex = 26;
            this.lblOcupation.Text = "Ocupacion:";
            // 
            // gbInformacionGeneral
            // 
            this.gbInformacionGeneral.Controls.Add(this.lblSave);
            this.gbInformacionGeneral.Controls.Add(this.lblNew);
            this.gbInformacionGeneral.Controls.Add(this.gbDocument);
            this.gbInformacionGeneral.Controls.Add(this.txtOcupation);
            this.gbInformacionGeneral.Controls.Add(this.lblName);
            this.gbInformacionGeneral.Controls.Add(this.lblOcupation);
            this.gbInformacionGeneral.Controls.Add(this.txtName);
            this.gbInformacionGeneral.Controls.Add(this.cbSector);
            this.gbInformacionGeneral.Controls.Add(this.lblLastName);
            this.gbInformacionGeneral.Controls.Add(this.lblSector);
            this.gbInformacionGeneral.Controls.Add(this.txtLastName);
            this.gbInformacionGeneral.Controls.Add(this.txtEmail);
            this.gbInformacionGeneral.Controls.Add(this.lblAddress);
            this.gbInformacionGeneral.Controls.Add(this.lblEmail);
            this.gbInformacionGeneral.Controls.Add(this.txtAddress);
            this.gbInformacionGeneral.Controls.Add(this.txtCellphone);
            this.gbInformacionGeneral.Controls.Add(this.lblPhone);
            this.gbInformacionGeneral.Controls.Add(this.lblCellphone);
            this.gbInformacionGeneral.Controls.Add(this.txtPhone);
            this.gbInformacionGeneral.Location = new System.Drawing.Point(26, 23);
            this.gbInformacionGeneral.Name = "gbInformacionGeneral";
            this.gbInformacionGeneral.Size = new System.Drawing.Size(487, 333);
            this.gbInformacionGeneral.TabIndex = 0;
            this.gbInformacionGeneral.TabStop = false;
            this.gbInformacionGeneral.Text = "Informacion General";
            // 
            // lblNew
            // 
            this.lblNew.AutoSize = true;
            this.lblNew.Location = new System.Drawing.Point(398, 195);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(39, 13);
            this.lblNew.TabIndex = 6;
            this.lblNew.TabStop = true;
            this.lblNew.Text = "Nuevo";
            this.lblNew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNew_LinkClicked);
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Location = new System.Drawing.Point(335, 195);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(45, 13);
            this.lblSave.TabIndex = 27;
            this.lblSave.TabStop = true;
            this.lblSave.Text = "Guardar";
            this.lblSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSave_LinkClicked);
            // 
            // frmCustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(816, 428);
            this.Controls.Add(this.gbInformacionGeneral);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbStatus);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCustomerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuarios";
            this.Load += new System.EventHandler(this.frmCustomerRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.gbDocument.ResumeLayout(false);
            this.gbDocument.PerformLayout();
            this.gbInformacionGeneral.ResumeLayout(false);
            this.gbInformacionGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.RadioButton rbDemandado;
        private System.Windows.Forms.RadioButton rbDemandante;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.MaskedTextBox txtPassport;
        private System.Windows.Forms.GroupBox gbDocument;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rbPassport;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.TextBox txtOcupation;
        private System.Windows.Forms.Label lblOcupation;
        private System.Windows.Forms.GroupBox gbInformacionGeneral;
        private System.Windows.Forms.LinkLabel lblNew;
        private System.Windows.Forms.LinkLabel lblSave;
    }
}