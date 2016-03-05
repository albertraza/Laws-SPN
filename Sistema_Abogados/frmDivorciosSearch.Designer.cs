namespace Sistema_Abogados
{
    partial class frmDivorciosSearch
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
            this.dgvDivorcios = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombreDemandante = new System.Windows.Forms.TextBox();
            this.lblNombreDemandante = new System.Windows.Forms.Label();
            this.txtApellidoDemandante = new System.Windows.Forms.TextBox();
            this.lblApellidoDemandante = new System.Windows.Forms.Label();
            this.txtApellidoDemandado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreDemandado = new System.Windows.Forms.TextBox();
            this.lblNombreDemandado = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivorcios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDivorcios
            // 
            this.dgvDivorcios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDivorcios.Location = new System.Drawing.Point(12, 136);
            this.dgvDivorcios.Name = "dgvDivorcios";
            this.dgvDivorcios.Size = new System.Drawing.Size(833, 332);
            this.dgvDivorcios.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(608, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(635, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtNombreDemandante
            // 
            this.txtNombreDemandante.Location = new System.Drawing.Point(173, 33);
            this.txtNombreDemandante.Name = "txtNombreDemandante";
            this.txtNombreDemandante.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDemandante.TabIndex = 4;
            // 
            // lblNombreDemandante
            // 
            this.lblNombreDemandante.AutoSize = true;
            this.lblNombreDemandante.Location = new System.Drawing.Point(58, 36);
            this.lblNombreDemandante.Name = "lblNombreDemandante";
            this.lblNombreDemandante.Size = new System.Drawing.Size(109, 13);
            this.lblNombreDemandante.TabIndex = 3;
            this.lblNombreDemandante.Text = "Nombre demandante:";
            // 
            // txtApellidoDemandante
            // 
            this.txtApellidoDemandante.Location = new System.Drawing.Point(173, 85);
            this.txtApellidoDemandante.Name = "txtApellidoDemandante";
            this.txtApellidoDemandante.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoDemandante.TabIndex = 6;
            // 
            // lblApellidoDemandante
            // 
            this.lblApellidoDemandante.AutoSize = true;
            this.lblApellidoDemandante.Location = new System.Drawing.Point(58, 88);
            this.lblApellidoDemandante.Name = "lblApellidoDemandante";
            this.lblApellidoDemandante.Size = new System.Drawing.Size(109, 13);
            this.lblApellidoDemandante.TabIndex = 5;
            this.lblApellidoDemandante.Text = "Apellido demandante:";
            // 
            // txtApellidoDemandado
            // 
            this.txtApellidoDemandado.Location = new System.Drawing.Point(423, 85);
            this.txtApellidoDemandado.Name = "txtApellidoDemandado";
            this.txtApellidoDemandado.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoDemandado.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Apellido demandado:";
            // 
            // txtNombreDemandado
            // 
            this.txtNombreDemandado.Location = new System.Drawing.Point(423, 33);
            this.txtNombreDemandado.Name = "txtNombreDemandado";
            this.txtNombreDemandado.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDemandado.TabIndex = 8;
            // 
            // lblNombreDemandado
            // 
            this.lblNombreDemandado.AutoSize = true;
            this.lblNombreDemandado.Location = new System.Drawing.Point(311, 36);
            this.lblNombreDemandado.Name = "lblNombreDemandado";
            this.lblNombreDemandado.Size = new System.Drawing.Size(106, 13);
            this.lblNombreDemandado.TabIndex = 7;
            this.lblNombreDemandado.Text = "Nombre demandado:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(611, 83);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(728, 83);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmDivorciosSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(864, 480);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtApellidoDemandado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreDemandado);
            this.Controls.Add(this.lblNombreDemandado);
            this.Controls.Add(this.txtApellidoDemandante);
            this.Controls.Add(this.lblApellidoDemandante);
            this.Controls.Add(this.txtNombreDemandante);
            this.Controls.Add(this.lblNombreDemandante);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dgvDivorcios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDivorciosSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Divorcios Search";
            this.Load += new System.EventHandler(this.frmDivorciosSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivorcios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDivorcios;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombreDemandante;
        private System.Windows.Forms.Label lblNombreDemandante;
        private System.Windows.Forms.TextBox txtApellidoDemandante;
        private System.Windows.Forms.Label lblApellidoDemandante;
        private System.Windows.Forms.TextBox txtApellidoDemandado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreDemandado;
        private System.Windows.Forms.Label lblNombreDemandado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}