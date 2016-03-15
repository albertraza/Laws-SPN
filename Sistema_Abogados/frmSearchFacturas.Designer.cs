namespace Sistema_Abogados
{
    partial class frmSearchFacturas
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
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.gbServicios = new System.Windows.Forms.GroupBox();
            this.rbAlquiler = new System.Windows.Forms.RadioButton();
            this.rbVentas = new System.Windows.Forms.RadioButton();
            this.rbDivorcioAccidente = new System.Windows.Forms.RadioButton();
            this.gbInfoClienteCaso = new System.Windows.Forms.GroupBox();
            this.rbPasaporte = new System.Windows.Forms.RadioButton();
            this.rbCedula = new System.Windows.Forms.RadioButton();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPasaporte = new System.Windows.Forms.MaskedTextBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroCaso = new System.Windows.Forms.Label();
            this.txtNumeroCaso = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.gbServicios.SuspendLayout();
            this.gbInfoClienteCaso.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(12, 228);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(767, 286);
            this.dgvFacturas.TabIndex = 0;
            // 
            // gbServicios
            // 
            this.gbServicios.Controls.Add(this.rbAlquiler);
            this.gbServicios.Controls.Add(this.rbVentas);
            this.gbServicios.Controls.Add(this.rbDivorcioAccidente);
            this.gbServicios.Location = new System.Drawing.Point(12, 12);
            this.gbServicios.Name = "gbServicios";
            this.gbServicios.Size = new System.Drawing.Size(513, 61);
            this.gbServicios.TabIndex = 1;
            this.gbServicios.TabStop = false;
            this.gbServicios.Text = "Busqueda por servicios";
            // 
            // rbAlquiler
            // 
            this.rbAlquiler.AutoSize = true;
            this.rbAlquiler.Location = new System.Drawing.Point(347, 28);
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
            this.rbVentas.Location = new System.Drawing.Point(235, 28);
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
            this.rbDivorcioAccidente.Location = new System.Drawing.Point(73, 28);
            this.rbDivorcioAccidente.Name = "rbDivorcioAccidente";
            this.rbDivorcioAccidente.Size = new System.Drawing.Size(129, 17);
            this.rbDivorcioAccidente.TabIndex = 0;
            this.rbDivorcioAccidente.TabStop = true;
            this.rbDivorcioAccidente.Text = "Divorcios o Accidente";
            this.rbDivorcioAccidente.UseVisualStyleBackColor = true;
            this.rbDivorcioAccidente.CheckedChanged += new System.EventHandler(this.rbDivorcioAccidente_CheckedChanged);
            // 
            // gbInfoClienteCaso
            // 
            this.gbInfoClienteCaso.Controls.Add(this.rbPasaporte);
            this.gbInfoClienteCaso.Controls.Add(this.rbCedula);
            this.gbInfoClienteCaso.Controls.Add(this.lblApellido);
            this.gbInfoClienteCaso.Controls.Add(this.txtApellido);
            this.gbInfoClienteCaso.Controls.Add(this.lblNombre);
            this.gbInfoClienteCaso.Controls.Add(this.txtNombre);
            this.gbInfoClienteCaso.Controls.Add(this.txtPasaporte);
            this.gbInfoClienteCaso.Controls.Add(this.txtCedula);
            this.gbInfoClienteCaso.Controls.Add(this.lblNumeroCaso);
            this.gbInfoClienteCaso.Controls.Add(this.txtNumeroCaso);
            this.gbInfoClienteCaso.Location = new System.Drawing.Point(12, 89);
            this.gbInfoClienteCaso.Name = "gbInfoClienteCaso";
            this.gbInfoClienteCaso.Size = new System.Drawing.Size(513, 133);
            this.gbInfoClienteCaso.TabIndex = 2;
            this.gbInfoClienteCaso.TabStop = false;
            this.gbInfoClienteCaso.Text = "Informacion Cliente y Caso";
            // 
            // rbPasaporte
            // 
            this.rbPasaporte.AutoSize = true;
            this.rbPasaporte.Location = new System.Drawing.Point(334, 33);
            this.rbPasaporte.Name = "rbPasaporte";
            this.rbPasaporte.Size = new System.Drawing.Size(76, 17);
            this.rbPasaporte.TabIndex = 12;
            this.rbPasaporte.TabStop = true;
            this.rbPasaporte.Text = "Pasaporte:";
            this.rbPasaporte.UseVisualStyleBackColor = true;
            this.rbPasaporte.CheckedChanged += new System.EventHandler(this.rbPasaporte_CheckedChanged);
            // 
            // rbCedula
            // 
            this.rbCedula.AutoSize = true;
            this.rbCedula.Location = new System.Drawing.Point(168, 32);
            this.rbCedula.Name = "rbCedula";
            this.rbCedula.Size = new System.Drawing.Size(61, 17);
            this.rbCedula.TabIndex = 11;
            this.rbCedula.TabStop = true;
            this.rbCedula.Text = "Cedula:";
            this.rbCedula.UseVisualStyleBackColor = true;
            this.rbCedula.CheckedChanged += new System.EventHandler(this.rbCedula_CheckedChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(232, 96);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(81, 13);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido cliente:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(319, 93);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(110, 20);
            this.txtApellido.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre cliente:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(101, 93);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(110, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtPasaporte
            // 
            this.txtPasaporte.Location = new System.Drawing.Point(414, 32);
            this.txtPasaporte.Mask = "SE-000-0000";
            this.txtPasaporte.Name = "txtPasaporte";
            this.txtPasaporte.Size = new System.Drawing.Size(93, 20);
            this.txtPasaporte.TabIndex = 5;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(235, 31);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(93, 20);
            this.txtCedula.TabIndex = 3;
            // 
            // lblNumeroCaso
            // 
            this.lblNumeroCaso.AutoSize = true;
            this.lblNumeroCaso.Location = new System.Drawing.Point(14, 34);
            this.lblNumeroCaso.Name = "lblNumeroCaso";
            this.lblNumeroCaso.Size = new System.Drawing.Size(53, 13);
            this.lblNumeroCaso.TabIndex = 1;
            this.lblNumeroCaso.Text = "Caso NO:";
            // 
            // txtNumeroCaso
            // 
            this.txtNumeroCaso.Location = new System.Drawing.Point(73, 31);
            this.txtNumeroCaso.Name = "txtNumeroCaso";
            this.txtNumeroCaso.Size = new System.Drawing.Size(73, 20);
            this.txtNumeroCaso.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(658, 116);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 50);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Sistema_Abogados.Properties.Resources.search;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(531, 172);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 50);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnImprimir.Location = new System.Drawing.Point(531, 116);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(121, 50);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelar.Location = new System.Drawing.Point(658, 172);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(121, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmSearchFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gbInfoClienteCaso);
            this.Controls.Add(this.gbServicios);
            this.Controls.Add(this.dgvFacturas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSearchFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Factura";
            this.Load += new System.EventHandler(this.frmSearchFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.gbServicios.ResumeLayout(false);
            this.gbServicios.PerformLayout();
            this.gbInfoClienteCaso.ResumeLayout(false);
            this.gbInfoClienteCaso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.GroupBox gbServicios;
        private System.Windows.Forms.RadioButton rbAlquiler;
        private System.Windows.Forms.RadioButton rbVentas;
        private System.Windows.Forms.RadioButton rbDivorcioAccidente;
        private System.Windows.Forms.GroupBox gbInfoClienteCaso;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.Label lblNumeroCaso;
        private System.Windows.Forms.TextBox txtNumeroCaso;
        private System.Windows.Forms.MaskedTextBox txtPasaporte;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rbPasaporte;
        private System.Windows.Forms.RadioButton rbCedula;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
    }
}