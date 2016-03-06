namespace Sistema_Abogados
{
    partial class frmVentasSearch
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombreVen = new System.Windows.Forms.TextBox();
            this.lblNombreVen = new System.Windows.Forms.Label();
            this.txtApellidoVe = new System.Windows.Forms.TextBox();
            this.lblApellidoVe = new System.Windows.Forms.Label();
            this.txtApellidoCo = new System.Windows.Forms.TextBox();
            this.lblApellidoCo = new System.Windows.Forms.Label();
            this.txtNombreCo = new System.Windows.Forms.TextBox();
            this.lblNombreCo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(12, 152);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.Size = new System.Drawing.Size(804, 320);
            this.dgvVentas.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(627, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(654, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // txtNombreVen
            // 
            this.txtNombreVen.Location = new System.Drawing.Point(151, 44);
            this.txtNombreVen.Name = "txtNombreVen";
            this.txtNombreVen.Size = new System.Drawing.Size(100, 20);
            this.txtNombreVen.TabIndex = 4;
            // 
            // lblNombreVen
            // 
            this.lblNombreVen.AutoSize = true;
            this.lblNombreVen.Location = new System.Drawing.Point(49, 47);
            this.lblNombreVen.Name = "lblNombreVen";
            this.lblNombreVen.Size = new System.Drawing.Size(96, 13);
            this.lblNombreVen.TabIndex = 3;
            this.lblNombreVen.Text = "Nombre Vendedor:";
            // 
            // txtApellidoVe
            // 
            this.txtApellidoVe.Location = new System.Drawing.Point(151, 94);
            this.txtApellidoVe.Name = "txtApellidoVe";
            this.txtApellidoVe.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoVe.TabIndex = 6;
            // 
            // lblApellidoVe
            // 
            this.lblApellidoVe.AutoSize = true;
            this.lblApellidoVe.Location = new System.Drawing.Point(49, 97);
            this.lblApellidoVe.Name = "lblApellidoVe";
            this.lblApellidoVe.Size = new System.Drawing.Size(96, 13);
            this.lblApellidoVe.TabIndex = 5;
            this.lblApellidoVe.Text = "Apellido Vendedor:";
            // 
            // txtApellidoCo
            // 
            this.txtApellidoCo.Location = new System.Drawing.Point(426, 94);
            this.txtApellidoCo.Name = "txtApellidoCo";
            this.txtApellidoCo.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoCo.TabIndex = 10;
            // 
            // lblApellidoCo
            // 
            this.lblApellidoCo.AutoSize = true;
            this.lblApellidoCo.Location = new System.Drawing.Point(319, 97);
            this.lblApellidoCo.Name = "lblApellidoCo";
            this.lblApellidoCo.Size = new System.Drawing.Size(101, 13);
            this.lblApellidoCo.TabIndex = 9;
            this.lblApellidoCo.Text = "Apellido Comprador:";
            // 
            // txtNombreCo
            // 
            this.txtNombreCo.Location = new System.Drawing.Point(426, 44);
            this.txtNombreCo.Name = "txtNombreCo";
            this.txtNombreCo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCo.TabIndex = 8;
            // 
            // lblNombreCo
            // 
            this.lblNombreCo.AutoSize = true;
            this.lblNombreCo.Location = new System.Drawing.Point(319, 47);
            this.lblNombreCo.Name = "lblNombreCo";
            this.lblNombreCo.Size = new System.Drawing.Size(101, 13);
            this.lblNombreCo.TabIndex = 7;
            this.lblNombreCo.Text = "Nombre Comprador:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(604, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(709, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmVentasSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(835, 484);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtApellidoCo);
            this.Controls.Add(this.lblApellidoCo);
            this.Controls.Add(this.txtNombreCo);
            this.Controls.Add(this.lblNombreCo);
            this.Controls.Add(this.txtApellidoVe);
            this.Controls.Add(this.lblApellidoVe);
            this.Controls.Add(this.txtNombreVen);
            this.Controls.Add(this.lblNombreVen);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmVentasSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Ventas";
            this.Load += new System.EventHandler(this.frmVentasSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombreVen;
        private System.Windows.Forms.Label lblNombreVen;
        private System.Windows.Forms.TextBox txtApellidoVe;
        private System.Windows.Forms.Label lblApellidoVe;
        private System.Windows.Forms.TextBox txtApellidoCo;
        private System.Windows.Forms.Label lblApellidoCo;
        private System.Windows.Forms.TextBox txtNombreCo;
        private System.Windows.Forms.Label lblNombreCo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}