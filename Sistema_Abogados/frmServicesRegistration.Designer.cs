namespace Sistema_Abogados
{
    partial class frmServicesRegistration
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
            this.txtServices = new System.Windows.Forms.TextBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPreBonus = new System.Windows.Forms.Label();
            this.txtPreBonus = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtServices
            // 
            this.txtServices.Location = new System.Drawing.Point(97, 53);
            this.txtServices.Name = "txtServices";
            this.txtServices.Size = new System.Drawing.Size(244, 20);
            this.txtServices.TabIndex = 0;
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.Location = new System.Drawing.Point(43, 56);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(48, 13);
            this.lblServices.TabIndex = 1;
            this.lblServices.Text = "Servicio:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(110, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(43, 126);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Descripcion:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(46, 142);
            this.txtDescription.MaxLength = 300;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(523, 198);
            this.txtDescription.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(423, 56);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Precio:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(469, 53);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // lblPreBonus
            // 
            this.lblPreBonus.AutoSize = true;
            this.lblPreBonus.Location = new System.Drawing.Point(422, 92);
            this.lblPreBonus.Name = "lblPreBonus";
            this.lblPreBonus.Size = new System.Drawing.Size(41, 13);
            this.lblPreBonus.TabIndex = 8;
            this.lblPreBonus.Text = "Abono:";
            // 
            // txtPreBonus
            // 
            this.txtPreBonus.Location = new System.Drawing.Point(469, 89);
            this.txtPreBonus.Name = "txtPreBonus";
            this.txtPreBonus.Size = new System.Drawing.Size(100, 20);
            this.txtPreBonus.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(381, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmServicesRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(624, 408);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblPreBonus);
            this.Controls.Add(this.txtPreBonus);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblServices);
            this.Controls.Add(this.txtServices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmServicesRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Servicios";
            this.Load += new System.EventHandler(this.frmServicesRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServices;
        private System.Windows.Forms.Label lblServices;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPreBonus;
        private System.Windows.Forms.TextBox txtPreBonus;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
    }
}