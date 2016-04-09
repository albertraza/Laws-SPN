namespace Sistema_Abogados
{
    partial class frmReporteAlquilerGenerator
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
            this.gbDates = new System.Windows.Forms.GroupBox();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.gbVistaReporte = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.gbFiltro = new System.Windows.Forms.GroupBox();
            this.rbCaso = new System.Windows.Forms.RadioButton();
            this.rbAbono = new System.Windows.Forms.RadioButton();
            this.gbCaso = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbInquilino = new System.Windows.Forms.GroupBox();
            this.rbPasaporteIn = new System.Windows.Forms.RadioButton();
            this.rbCedulaIn = new System.Windows.Forms.RadioButton();
            this.txtCedulaIn = new System.Windows.Forms.MaskedTextBox();
            this.lblCedulaIn = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.rbPasaporte = new System.Windows.Forms.RadioButton();
            this.rbCedulaCli = new System.Windows.Forms.RadioButton();
            this.txtCedulaCl = new System.Windows.Forms.MaskedTextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.dgvCasos = new System.Windows.Forms.DataGridView();
            this.gbDates.SuspendLayout();
            this.gbVistaReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.gbFiltro.SuspendLayout();
            this.gbCaso.SuspendLayout();
            this.gbInquilino.SuspendLayout();
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDates
            // 
            this.gbDates.Controls.Add(this.btnGeneral);
            this.gbDates.Controls.Add(this.dtpHasta);
            this.gbDates.Controls.Add(this.lblHasta);
            this.gbDates.Controls.Add(this.dtpDesde);
            this.gbDates.Controls.Add(this.lblDesde);
            this.gbDates.Location = new System.Drawing.Point(12, 82);
            this.gbDates.Name = "gbDates";
            this.gbDates.Size = new System.Drawing.Size(300, 170);
            this.gbDates.TabIndex = 0;
            this.gbDates.TabStop = false;
            this.gbDates.Text = "Filtro por Fechas";
            // 
            // btnGeneral
            // 
            this.btnGeneral.Location = new System.Drawing.Point(105, 130);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(106, 23);
            this.btnGeneral.TabIndex = 4;
            this.btnGeneral.Text = "General Reporte";
            this.btnGeneral.UseVisualStyleBackColor = true;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(73, 87);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(26, 93);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(73, 39);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(26, 45);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // gbVistaReporte
            // 
            this.gbVistaReporte.Controls.Add(this.btnImprimir);
            this.gbVistaReporte.Controls.Add(this.dgvReporte);
            this.gbVistaReporte.Location = new System.Drawing.Point(12, 258);
            this.gbVistaReporte.Name = "gbVistaReporte";
            this.gbVistaReporte.Size = new System.Drawing.Size(878, 214);
            this.gbVistaReporte.TabIndex = 1;
            this.gbVistaReporte.TabStop = false;
            this.gbVistaReporte.Text = "Reporte";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(766, 14);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(106, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(6, 43);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(866, 160);
            this.dgvReporte.TabIndex = 0;
            // 
            // gbFiltro
            // 
            this.gbFiltro.Controls.Add(this.rbCaso);
            this.gbFiltro.Controls.Add(this.rbAbono);
            this.gbFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbFiltro.Name = "gbFiltro";
            this.gbFiltro.Size = new System.Drawing.Size(300, 64);
            this.gbFiltro.TabIndex = 5;
            this.gbFiltro.TabStop = false;
            this.gbFiltro.Text = "Filtro";
            // 
            // rbCaso
            // 
            this.rbCaso.AutoSize = true;
            this.rbCaso.Location = new System.Drawing.Point(198, 28);
            this.rbCaso.Name = "rbCaso";
            this.rbCaso.Size = new System.Drawing.Size(68, 17);
            this.rbCaso.TabIndex = 1;
            this.rbCaso.TabStop = true;
            this.rbCaso.Text = "Por Caso";
            this.rbCaso.UseVisualStyleBackColor = true;
            this.rbCaso.CheckedChanged += new System.EventHandler(this.rbCaso_CheckedChanged);
            // 
            // rbAbono
            // 
            this.rbAbono.AutoSize = true;
            this.rbAbono.Location = new System.Drawing.Point(20, 28);
            this.rbAbono.Name = "rbAbono";
            this.rbAbono.Size = new System.Drawing.Size(75, 17);
            this.rbAbono.TabIndex = 0;
            this.rbAbono.TabStop = true;
            this.rbAbono.Text = "Por Abono";
            this.rbAbono.UseVisualStyleBackColor = true;
            this.rbAbono.CheckedChanged += new System.EventHandler(this.rbAbono_CheckedChanged);
            // 
            // gbCaso
            // 
            this.gbCaso.Controls.Add(this.btnGenerar);
            this.gbCaso.Controls.Add(this.btnLimpiar);
            this.gbCaso.Controls.Add(this.btnBuscar);
            this.gbCaso.Controls.Add(this.gbInquilino);
            this.gbCaso.Controls.Add(this.gbCliente);
            this.gbCaso.Controls.Add(this.dgvCasos);
            this.gbCaso.Location = new System.Drawing.Point(318, 12);
            this.gbCaso.Name = "gbCaso";
            this.gbCaso.Size = new System.Drawing.Size(572, 240);
            this.gbCaso.TabIndex = 6;
            this.gbCaso.TabStop = false;
            this.gbCaso.Text = "Casos";
            this.gbCaso.Enter += new System.EventHandler(this.gbCaso_Enter);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(447, 74);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(106, 23);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(460, 45);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(460, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // gbInquilino
            // 
            this.gbInquilino.Controls.Add(this.rbPasaporteIn);
            this.gbInquilino.Controls.Add(this.rbCedulaIn);
            this.gbInquilino.Controls.Add(this.txtCedulaIn);
            this.gbInquilino.Controls.Add(this.lblCedulaIn);
            this.gbInquilino.Location = new System.Drawing.Point(223, 16);
            this.gbInquilino.Name = "gbInquilino";
            this.gbInquilino.Size = new System.Drawing.Size(200, 87);
            this.gbInquilino.TabIndex = 2;
            this.gbInquilino.TabStop = false;
            this.gbInquilino.Text = "Inquilino";
            // 
            // rbPasaporteIn
            // 
            this.rbPasaporteIn.AutoSize = true;
            this.rbPasaporteIn.Location = new System.Drawing.Point(103, 48);
            this.rbPasaporteIn.Name = "rbPasaporteIn";
            this.rbPasaporteIn.Size = new System.Drawing.Size(73, 17);
            this.rbPasaporteIn.TabIndex = 3;
            this.rbPasaporteIn.TabStop = true;
            this.rbPasaporteIn.Text = "Pasaporte";
            this.rbPasaporteIn.UseVisualStyleBackColor = true;
            this.rbPasaporteIn.CheckedChanged += new System.EventHandler(this.rbPasaporteIn_CheckedChanged);
            // 
            // rbCedulaIn
            // 
            this.rbCedulaIn.AutoSize = true;
            this.rbCedulaIn.Location = new System.Drawing.Point(34, 48);
            this.rbCedulaIn.Name = "rbCedulaIn";
            this.rbCedulaIn.Size = new System.Drawing.Size(58, 17);
            this.rbCedulaIn.TabIndex = 2;
            this.rbCedulaIn.TabStop = true;
            this.rbCedulaIn.Text = "Cedula";
            this.rbCedulaIn.UseVisualStyleBackColor = true;
            this.rbCedulaIn.CheckedChanged += new System.EventHandler(this.rbCedulaIn_CheckedChanged);
            // 
            // txtCedulaIn
            // 
            this.txtCedulaIn.Location = new System.Drawing.Point(76, 22);
            this.txtCedulaIn.Mask = "000-0000000-0";
            this.txtCedulaIn.Name = "txtCedulaIn";
            this.txtCedulaIn.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaIn.TabIndex = 1;
            // 
            // lblCedulaIn
            // 
            this.lblCedulaIn.AutoSize = true;
            this.lblCedulaIn.Location = new System.Drawing.Point(18, 25);
            this.lblCedulaIn.Name = "lblCedulaIn";
            this.lblCedulaIn.Size = new System.Drawing.Size(43, 13);
            this.lblCedulaIn.TabIndex = 0;
            this.lblCedulaIn.Text = "Cedula:";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.rbPasaporte);
            this.gbCliente.Controls.Add(this.rbCedulaCli);
            this.gbCliente.Controls.Add(this.txtCedulaCl);
            this.gbCliente.Controls.Add(this.lblCedula);
            this.gbCliente.Location = new System.Drawing.Point(6, 16);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(200, 87);
            this.gbCliente.TabIndex = 1;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // rbPasaporte
            // 
            this.rbPasaporte.AutoSize = true;
            this.rbPasaporte.Location = new System.Drawing.Point(103, 48);
            this.rbPasaporte.Name = "rbPasaporte";
            this.rbPasaporte.Size = new System.Drawing.Size(73, 17);
            this.rbPasaporte.TabIndex = 3;
            this.rbPasaporte.TabStop = true;
            this.rbPasaporte.Text = "Pasaporte";
            this.rbPasaporte.UseVisualStyleBackColor = true;
            this.rbPasaporte.CheckedChanged += new System.EventHandler(this.rbPasaporte_CheckedChanged);
            // 
            // rbCedulaCli
            // 
            this.rbCedulaCli.AutoSize = true;
            this.rbCedulaCli.Location = new System.Drawing.Point(34, 48);
            this.rbCedulaCli.Name = "rbCedulaCli";
            this.rbCedulaCli.Size = new System.Drawing.Size(58, 17);
            this.rbCedulaCli.TabIndex = 2;
            this.rbCedulaCli.TabStop = true;
            this.rbCedulaCli.Text = "Cedula";
            this.rbCedulaCli.UseVisualStyleBackColor = true;
            this.rbCedulaCli.CheckedChanged += new System.EventHandler(this.rbCedulaCli_CheckedChanged);
            // 
            // txtCedulaCl
            // 
            this.txtCedulaCl.Location = new System.Drawing.Point(76, 22);
            this.txtCedulaCl.Mask = "000-0000000-0";
            this.txtCedulaCl.Name = "txtCedulaCl";
            this.txtCedulaCl.Size = new System.Drawing.Size(100, 20);
            this.txtCedulaCl.TabIndex = 1;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(18, 25);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(43, 13);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cedula:";
            // 
            // dgvCasos
            // 
            this.dgvCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasos.Location = new System.Drawing.Point(6, 109);
            this.dgvCasos.Name = "dgvCasos";
            this.dgvCasos.Size = new System.Drawing.Size(560, 125);
            this.dgvCasos.TabIndex = 0;
            // 
            // frmReporteAlquilerGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(902, 484);
            this.Controls.Add(this.gbCaso);
            this.Controls.Add(this.gbFiltro);
            this.Controls.Add(this.gbVistaReporte);
            this.Controls.Add(this.gbDates);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteAlquilerGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Alquiler";
            this.Load += new System.EventHandler(this.frmReporteAlquilerGenerator_Load);
            this.gbDates.ResumeLayout(false);
            this.gbDates.PerformLayout();
            this.gbVistaReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.gbFiltro.ResumeLayout(false);
            this.gbFiltro.PerformLayout();
            this.gbCaso.ResumeLayout(false);
            this.gbInquilino.ResumeLayout(false);
            this.gbInquilino.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDates;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.GroupBox gbVistaReporte;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.GroupBox gbFiltro;
        private System.Windows.Forms.RadioButton rbCaso;
        private System.Windows.Forms.RadioButton rbAbono;
        private System.Windows.Forms.GroupBox gbCaso;
        private System.Windows.Forms.GroupBox gbInquilino;
        private System.Windows.Forms.RadioButton rbPasaporteIn;
        private System.Windows.Forms.RadioButton rbCedulaIn;
        private System.Windows.Forms.MaskedTextBox txtCedulaIn;
        private System.Windows.Forms.Label lblCedulaIn;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.RadioButton rbPasaporte;
        private System.Windows.Forms.RadioButton rbCedulaCli;
        private System.Windows.Forms.MaskedTextBox txtCedulaCl;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.DataGridView dgvCasos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
    }
}