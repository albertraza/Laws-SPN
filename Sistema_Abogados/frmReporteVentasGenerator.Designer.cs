namespace Sistema_Abogados
{
    partial class frmReporteVentasGenerator
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
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.btnCrearReporte = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.gbPreviewReporte = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.gbReporte = new System.Windows.Forms.GroupBox();
            this.rbAbono = new System.Windows.Forms.RadioButton();
            this.rbCaso = new System.Windows.Forms.RadioButton();
            this.gbCasos = new System.Windows.Forms.GroupBox();
            this.dgvCasos = new System.Windows.Forms.DataGridView();
            this.lblCedulaVe = new System.Windows.Forms.Label();
            this.txtCedulaVe = new System.Windows.Forms.MaskedTextBox();
            this.txtCedulaCo = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCedulaVe = new System.Windows.Forms.RadioButton();
            this.rbPasaporteVe = new System.Windows.Forms.RadioButton();
            this.rbPasaporteCo = new System.Windows.Forms.RadioButton();
            this.rbCedulaCo = new System.Windows.Forms.RadioButton();
            this.rbVendedor = new System.Windows.Forms.GroupBox();
            this.gbComprador = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.gbFechas.SuspendLayout();
            this.gbPreviewReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.gbReporte.SuspendLayout();
            this.gbCasos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).BeginInit();
            this.rbVendedor.SuspendLayout();
            this.gbComprador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFechas
            // 
            this.gbFechas.Controls.Add(this.btnCrearReporte);
            this.gbFechas.Controls.Add(this.dtpHasta);
            this.gbFechas.Controls.Add(this.lblHasta);
            this.gbFechas.Controls.Add(this.dtpDesde);
            this.gbFechas.Controls.Add(this.lblDesde);
            this.gbFechas.Location = new System.Drawing.Point(30, 89);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(324, 165);
            this.gbFechas.TabIndex = 0;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Filtro por fecha";
            // 
            // btnCrearReporte
            // 
            this.btnCrearReporte.Location = new System.Drawing.Point(95, 113);
            this.btnCrearReporte.Name = "btnCrearReporte";
            this.btnCrearReporte.Size = new System.Drawing.Size(131, 23);
            this.btnCrearReporte.TabIndex = 4;
            this.btnCrearReporte.Text = "Crear Reporte";
            this.btnCrearReporte.UseVisualStyleBackColor = true;
            this.btnCrearReporte.Click += new System.EventHandler(this.btnCrearReporte_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(71, 71);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(27, 71);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(71, 34);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(24, 34);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // gbPreviewReporte
            // 
            this.gbPreviewReporte.Controls.Add(this.btnImprimir);
            this.gbPreviewReporte.Controls.Add(this.dgvReporte);
            this.gbPreviewReporte.Location = new System.Drawing.Point(30, 260);
            this.gbPreviewReporte.Name = "gbPreviewReporte";
            this.gbPreviewReporte.Size = new System.Drawing.Size(951, 246);
            this.gbPreviewReporte.TabIndex = 1;
            this.gbPreviewReporte.TabStop = false;
            this.gbPreviewReporte.Text = "Vista Reporte";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(831, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(114, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir Reporte";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dgvReporte
            // 
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.Location = new System.Drawing.Point(6, 39);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.Size = new System.Drawing.Size(939, 201);
            this.dgvReporte.TabIndex = 2;
            // 
            // gbReporte
            // 
            this.gbReporte.Controls.Add(this.rbCaso);
            this.gbReporte.Controls.Add(this.rbAbono);
            this.gbReporte.Location = new System.Drawing.Point(30, 12);
            this.gbReporte.Name = "gbReporte";
            this.gbReporte.Size = new System.Drawing.Size(324, 71);
            this.gbReporte.TabIndex = 2;
            this.gbReporte.TabStop = false;
            this.gbReporte.Text = "Reporte por";
            // 
            // rbAbono
            // 
            this.rbAbono.AutoSize = true;
            this.rbAbono.Location = new System.Drawing.Point(30, 30);
            this.rbAbono.Name = "rbAbono";
            this.rbAbono.Size = new System.Drawing.Size(75, 17);
            this.rbAbono.TabIndex = 0;
            this.rbAbono.TabStop = true;
            this.rbAbono.Text = "Por Abono";
            this.rbAbono.UseVisualStyleBackColor = true;
            this.rbAbono.CheckedChanged += new System.EventHandler(this.rbAbono_CheckedChanged);
            // 
            // rbCaso
            // 
            this.rbCaso.AutoSize = true;
            this.rbCaso.Location = new System.Drawing.Point(209, 30);
            this.rbCaso.Name = "rbCaso";
            this.rbCaso.Size = new System.Drawing.Size(68, 17);
            this.rbCaso.TabIndex = 1;
            this.rbCaso.TabStop = true;
            this.rbCaso.Text = "Por Caso";
            this.rbCaso.UseVisualStyleBackColor = true;
            this.rbCaso.CheckedChanged += new System.EventHandler(this.rbCaso_CheckedChanged);
            // 
            // gbCasos
            // 
            this.gbCasos.Controls.Add(this.btnGenerar);
            this.gbCasos.Controls.Add(this.btnLimpiar);
            this.gbCasos.Controls.Add(this.btnBuscar);
            this.gbCasos.Controls.Add(this.gbComprador);
            this.gbCasos.Controls.Add(this.rbVendedor);
            this.gbCasos.Controls.Add(this.dgvCasos);
            this.gbCasos.Location = new System.Drawing.Point(360, 12);
            this.gbCasos.Name = "gbCasos";
            this.gbCasos.Size = new System.Drawing.Size(621, 242);
            this.gbCasos.TabIndex = 3;
            this.gbCasos.TabStop = false;
            this.gbCasos.Text = "Casos";
            // 
            // dgvCasos
            // 
            this.dgvCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasos.Location = new System.Drawing.Point(6, 106);
            this.dgvCasos.Name = "dgvCasos";
            this.dgvCasos.Size = new System.Drawing.Size(609, 130);
            this.dgvCasos.TabIndex = 0;
            // 
            // lblCedulaVe
            // 
            this.lblCedulaVe.AutoSize = true;
            this.lblCedulaVe.Location = new System.Drawing.Point(24, 22);
            this.lblCedulaVe.Name = "lblCedulaVe";
            this.lblCedulaVe.Size = new System.Drawing.Size(43, 13);
            this.lblCedulaVe.TabIndex = 1;
            this.lblCedulaVe.Text = "Cedula:";
            // 
            // txtCedulaVe
            // 
            this.txtCedulaVe.Location = new System.Drawing.Point(76, 19);
            this.txtCedulaVe.Mask = "000-0000000-0";
            this.txtCedulaVe.Name = "txtCedulaVe";
            this.txtCedulaVe.Size = new System.Drawing.Size(97, 20);
            this.txtCedulaVe.TabIndex = 2;
            // 
            // txtCedulaCo
            // 
            this.txtCedulaCo.Location = new System.Drawing.Point(86, 20);
            this.txtCedulaCo.Mask = "000-0000000-0";
            this.txtCedulaCo.Name = "txtCedulaCo";
            this.txtCedulaCo.Size = new System.Drawing.Size(97, 20);
            this.txtCedulaCo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula:";
            // 
            // rbCedulaVe
            // 
            this.rbCedulaVe.AutoSize = true;
            this.rbCedulaVe.Location = new System.Drawing.Point(27, 45);
            this.rbCedulaVe.Name = "rbCedulaVe";
            this.rbCedulaVe.Size = new System.Drawing.Size(58, 17);
            this.rbCedulaVe.TabIndex = 5;
            this.rbCedulaVe.TabStop = true;
            this.rbCedulaVe.Text = "Cedula";
            this.rbCedulaVe.UseVisualStyleBackColor = true;
            // 
            // rbPasaporteVe
            // 
            this.rbPasaporteVe.AutoSize = true;
            this.rbPasaporteVe.Location = new System.Drawing.Point(100, 45);
            this.rbPasaporteVe.Name = "rbPasaporteVe";
            this.rbPasaporteVe.Size = new System.Drawing.Size(73, 17);
            this.rbPasaporteVe.TabIndex = 6;
            this.rbPasaporteVe.TabStop = true;
            this.rbPasaporteVe.Text = "Pasaporte";
            this.rbPasaporteVe.UseVisualStyleBackColor = true;
            // 
            // rbPasaporteCo
            // 
            this.rbPasaporteCo.AutoSize = true;
            this.rbPasaporteCo.Location = new System.Drawing.Point(110, 46);
            this.rbPasaporteCo.Name = "rbPasaporteCo";
            this.rbPasaporteCo.Size = new System.Drawing.Size(73, 17);
            this.rbPasaporteCo.TabIndex = 8;
            this.rbPasaporteCo.TabStop = true;
            this.rbPasaporteCo.Text = "Pasaporte";
            this.rbPasaporteCo.UseVisualStyleBackColor = true;
            // 
            // rbCedulaCo
            // 
            this.rbCedulaCo.AutoSize = true;
            this.rbCedulaCo.Location = new System.Drawing.Point(37, 46);
            this.rbCedulaCo.Name = "rbCedulaCo";
            this.rbCedulaCo.Size = new System.Drawing.Size(58, 17);
            this.rbCedulaCo.TabIndex = 7;
            this.rbCedulaCo.TabStop = true;
            this.rbCedulaCo.Text = "Cedula";
            this.rbCedulaCo.UseVisualStyleBackColor = true;
            // 
            // rbVendedor
            // 
            this.rbVendedor.Controls.Add(this.lblCedulaVe);
            this.rbVendedor.Controls.Add(this.txtCedulaVe);
            this.rbVendedor.Controls.Add(this.rbCedulaVe);
            this.rbVendedor.Controls.Add(this.rbPasaporteVe);
            this.rbVendedor.Location = new System.Drawing.Point(22, 19);
            this.rbVendedor.Name = "rbVendedor";
            this.rbVendedor.Size = new System.Drawing.Size(200, 72);
            this.rbVendedor.TabIndex = 9;
            this.rbVendedor.TabStop = false;
            this.rbVendedor.Text = "Vendedor";
            // 
            // gbComprador
            // 
            this.gbComprador.Controls.Add(this.label1);
            this.gbComprador.Controls.Add(this.txtCedulaCo);
            this.gbComprador.Controls.Add(this.rbPasaporteCo);
            this.gbComprador.Controls.Add(this.rbCedulaCo);
            this.gbComprador.Location = new System.Drawing.Point(252, 19);
            this.gbComprador.Name = "gbComprador";
            this.gbComprador.Size = new System.Drawing.Size(200, 72);
            this.gbComprador.TabIndex = 10;
            this.gbComprador.TabStop = false;
            this.gbComprador.Text = "Comprador";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(501, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(501, 48);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(481, 77);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(114, 23);
            this.btnGenerar.TabIndex = 13;
            this.btnGenerar.Text = "Generar Reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmReporteVentasGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(993, 518);
            this.Controls.Add(this.gbCasos);
            this.Controls.Add(this.gbReporte);
            this.Controls.Add(this.gbPreviewReporte);
            this.Controls.Add(this.gbFechas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReporteVentasGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.frmReporteVentasGenerator_Load);
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            this.gbPreviewReporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.gbReporte.ResumeLayout(false);
            this.gbReporte.PerformLayout();
            this.gbCasos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).EndInit();
            this.rbVendedor.ResumeLayout(false);
            this.rbVendedor.PerformLayout();
            this.gbComprador.ResumeLayout(false);
            this.gbComprador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.Button btnCrearReporte;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.GroupBox gbPreviewReporte;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox gbReporte;
        private System.Windows.Forms.RadioButton rbCaso;
        private System.Windows.Forms.RadioButton rbAbono;
        private System.Windows.Forms.GroupBox gbCasos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbComprador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCedulaCo;
        private System.Windows.Forms.RadioButton rbPasaporteCo;
        private System.Windows.Forms.RadioButton rbCedulaCo;
        private System.Windows.Forms.GroupBox rbVendedor;
        private System.Windows.Forms.Label lblCedulaVe;
        private System.Windows.Forms.MaskedTextBox txtCedulaVe;
        private System.Windows.Forms.RadioButton rbCedulaVe;
        private System.Windows.Forms.RadioButton rbPasaporteVe;
        private System.Windows.Forms.DataGridView dgvCasos;
    }
}