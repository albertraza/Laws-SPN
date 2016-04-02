namespace Sistema_Abogados
{
    partial class frmDivorciosAccidenteReportGenerator
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
            this.rbReporteaGeneral = new System.Windows.Forms.GroupBox();
            this.rbAbono = new System.Windows.Forms.RadioButton();
            this.rbCaso = new System.Windows.Forms.RadioButton();
            this.gbFechas = new System.Windows.Forms.GroupBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dgvPreviewReporte = new System.Windows.Forms.DataGridView();
            this.gbInformacion = new System.Windows.Forms.GroupBox();
            this.gbVista = new System.Windows.Forms.GroupBox();
            this.dgvCasos = new System.Windows.Forms.DataGridView();
            this.lblCedulaDemandante = new System.Windows.Forms.Label();
            this.txtCedulaE = new System.Windows.Forms.MaskedTextBox();
            this.gbDemandante = new System.Windows.Forms.GroupBox();
            this.rbCedulaE = new System.Windows.Forms.RadioButton();
            this.rbPasaporteE = new System.Windows.Forms.RadioButton();
            this.gbDemandado = new System.Windows.Forms.GroupBox();
            this.rbPasaporteO = new System.Windows.Forms.RadioButton();
            this.rbCedulaO = new System.Windows.Forms.RadioButton();
            this.txtCedulaO = new System.Windows.Forms.MaskedTextBox();
            this.lblCedulaO = new System.Windows.Forms.Label();
            this.btnBuscarCaso = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGenerarReporteCaso = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnGenerarReporteAbono = new System.Windows.Forms.Button();
            this.rbReporteaGeneral.SuspendLayout();
            this.gbFechas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewReporte)).BeginInit();
            this.gbInformacion.SuspendLayout();
            this.gbVista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).BeginInit();
            this.gbDemandante.SuspendLayout();
            this.gbDemandado.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbReporteaGeneral
            // 
            this.rbReporteaGeneral.Controls.Add(this.rbCaso);
            this.rbReporteaGeneral.Controls.Add(this.rbAbono);
            this.rbReporteaGeneral.Location = new System.Drawing.Point(12, 12);
            this.rbReporteaGeneral.Name = "rbReporteaGeneral";
            this.rbReporteaGeneral.Size = new System.Drawing.Size(302, 81);
            this.rbReporteaGeneral.TabIndex = 0;
            this.rbReporteaGeneral.TabStop = false;
            this.rbReporteaGeneral.Text = "Reportes a general";
            // 
            // rbAbono
            // 
            this.rbAbono.AutoSize = true;
            this.rbAbono.Location = new System.Drawing.Point(30, 38);
            this.rbAbono.Name = "rbAbono";
            this.rbAbono.Size = new System.Drawing.Size(102, 17);
            this.rbAbono.TabIndex = 0;
            this.rbAbono.TabStop = true;
            this.rbAbono.Text = "Abono a Cuenta";
            this.rbAbono.UseVisualStyleBackColor = true;
            this.rbAbono.CheckedChanged += new System.EventHandler(this.rbAbono_CheckedChanged);
            // 
            // rbCaso
            // 
            this.rbCaso.AutoSize = true;
            this.rbCaso.Location = new System.Drawing.Point(175, 38);
            this.rbCaso.Name = "rbCaso";
            this.rbCaso.Size = new System.Drawing.Size(68, 17);
            this.rbCaso.TabIndex = 1;
            this.rbCaso.TabStop = true;
            this.rbCaso.Text = "Por Caso";
            this.rbCaso.UseVisualStyleBackColor = true;
            // 
            // gbFechas
            // 
            this.gbFechas.Controls.Add(this.btnGenerarReporteAbono);
            this.gbFechas.Controls.Add(this.dtpHasta);
            this.gbFechas.Controls.Add(this.lblHasta);
            this.gbFechas.Controls.Add(this.dtpDesde);
            this.gbFechas.Controls.Add(this.lblDesde);
            this.gbFechas.Location = new System.Drawing.Point(12, 117);
            this.gbFechas.Name = "gbFechas";
            this.gbFechas.Size = new System.Drawing.Size(302, 128);
            this.gbFechas.TabIndex = 1;
            this.gbFechas.TabStop = false;
            this.gbFechas.Text = "Filtro por fechas";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(22, 33);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(74, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Fecha Desde:";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(102, 27);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(184, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(102, 64);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(184, 20);
            this.dtpHasta.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(22, 70);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(71, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Fecha Hasta:";
            // 
            // dgvPreviewReporte
            // 
            this.dgvPreviewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreviewReporte.Location = new System.Drawing.Point(18, 19);
            this.dgvPreviewReporte.Name = "dgvPreviewReporte";
            this.dgvPreviewReporte.Size = new System.Drawing.Size(933, 237);
            this.dgvPreviewReporte.TabIndex = 2;
            // 
            // gbInformacion
            // 
            this.gbInformacion.Controls.Add(this.btnGenerarReporteCaso);
            this.gbInformacion.Controls.Add(this.btnLimpiar);
            this.gbInformacion.Controls.Add(this.btnBuscarCaso);
            this.gbInformacion.Controls.Add(this.gbDemandado);
            this.gbInformacion.Controls.Add(this.gbDemandante);
            this.gbInformacion.Controls.Add(this.dgvCasos);
            this.gbInformacion.Location = new System.Drawing.Point(341, 12);
            this.gbInformacion.Name = "gbInformacion";
            this.gbInformacion.Size = new System.Drawing.Size(628, 277);
            this.gbInformacion.TabIndex = 3;
            this.gbInformacion.TabStop = false;
            this.gbInformacion.Text = "Busqueda de Casos";
            // 
            // gbVista
            // 
            this.gbVista.Controls.Add(this.dgvPreviewReporte);
            this.gbVista.Location = new System.Drawing.Point(12, 310);
            this.gbVista.Name = "gbVista";
            this.gbVista.Size = new System.Drawing.Size(957, 263);
            this.gbVista.TabIndex = 4;
            this.gbVista.TabStop = false;
            this.gbVista.Text = "Vista del Reporte";
            // 
            // dgvCasos
            // 
            this.dgvCasos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCasos.Location = new System.Drawing.Point(6, 121);
            this.dgvCasos.Name = "dgvCasos";
            this.dgvCasos.Size = new System.Drawing.Size(616, 150);
            this.dgvCasos.TabIndex = 5;
            // 
            // lblCedulaDemandante
            // 
            this.lblCedulaDemandante.AutoSize = true;
            this.lblCedulaDemandante.Location = new System.Drawing.Point(12, 22);
            this.lblCedulaDemandante.Name = "lblCedulaDemandante";
            this.lblCedulaDemandante.Size = new System.Drawing.Size(43, 13);
            this.lblCedulaDemandante.TabIndex = 6;
            this.lblCedulaDemandante.Text = "Cedula:";
            // 
            // txtCedulaE
            // 
            this.txtCedulaE.Location = new System.Drawing.Point(71, 19);
            this.txtCedulaE.Name = "txtCedulaE";
            this.txtCedulaE.Size = new System.Drawing.Size(113, 20);
            this.txtCedulaE.TabIndex = 7;
            // 
            // gbDemandante
            // 
            this.gbDemandante.Controls.Add(this.rbPasaporteE);
            this.gbDemandante.Controls.Add(this.rbCedulaE);
            this.gbDemandante.Controls.Add(this.txtCedulaE);
            this.gbDemandante.Controls.Add(this.lblCedulaDemandante);
            this.gbDemandante.Location = new System.Drawing.Point(15, 19);
            this.gbDemandante.Name = "gbDemandante";
            this.gbDemandante.Size = new System.Drawing.Size(200, 81);
            this.gbDemandante.TabIndex = 8;
            this.gbDemandante.TabStop = false;
            this.gbDemandante.Text = "Demandante";
            // 
            // rbCedulaE
            // 
            this.rbCedulaE.AutoSize = true;
            this.rbCedulaE.Location = new System.Drawing.Point(15, 49);
            this.rbCedulaE.Name = "rbCedulaE";
            this.rbCedulaE.Size = new System.Drawing.Size(58, 17);
            this.rbCedulaE.TabIndex = 8;
            this.rbCedulaE.TabStop = true;
            this.rbCedulaE.Text = "Cedula";
            this.rbCedulaE.UseVisualStyleBackColor = true;
            this.rbCedulaE.CheckedChanged += new System.EventHandler(this.rbCedulaE_CheckedChanged);
            // 
            // rbPasaporteE
            // 
            this.rbPasaporteE.AutoSize = true;
            this.rbPasaporteE.Location = new System.Drawing.Point(105, 49);
            this.rbPasaporteE.Name = "rbPasaporteE";
            this.rbPasaporteE.Size = new System.Drawing.Size(73, 17);
            this.rbPasaporteE.TabIndex = 9;
            this.rbPasaporteE.TabStop = true;
            this.rbPasaporteE.Text = "Pasaporte";
            this.rbPasaporteE.UseVisualStyleBackColor = true;
            this.rbPasaporteE.CheckedChanged += new System.EventHandler(this.rbPasaporteE_CheckedChanged);
            // 
            // gbDemandado
            // 
            this.gbDemandado.Controls.Add(this.rbPasaporteO);
            this.gbDemandado.Controls.Add(this.rbCedulaO);
            this.gbDemandado.Controls.Add(this.txtCedulaO);
            this.gbDemandado.Controls.Add(this.lblCedulaO);
            this.gbDemandado.Location = new System.Drawing.Point(230, 19);
            this.gbDemandado.Name = "gbDemandado";
            this.gbDemandado.Size = new System.Drawing.Size(200, 81);
            this.gbDemandado.TabIndex = 9;
            this.gbDemandado.TabStop = false;
            this.gbDemandado.Text = "Demandante";
            // 
            // rbPasaporteO
            // 
            this.rbPasaporteO.AutoSize = true;
            this.rbPasaporteO.Location = new System.Drawing.Point(105, 49);
            this.rbPasaporteO.Name = "rbPasaporteO";
            this.rbPasaporteO.Size = new System.Drawing.Size(73, 17);
            this.rbPasaporteO.TabIndex = 9;
            this.rbPasaporteO.TabStop = true;
            this.rbPasaporteO.Text = "Pasaporte";
            this.rbPasaporteO.UseVisualStyleBackColor = true;
            this.rbPasaporteO.CheckedChanged += new System.EventHandler(this.rbPasaporteO_CheckedChanged);
            // 
            // rbCedulaO
            // 
            this.rbCedulaO.AutoSize = true;
            this.rbCedulaO.Location = new System.Drawing.Point(15, 49);
            this.rbCedulaO.Name = "rbCedulaO";
            this.rbCedulaO.Size = new System.Drawing.Size(58, 17);
            this.rbCedulaO.TabIndex = 8;
            this.rbCedulaO.TabStop = true;
            this.rbCedulaO.Text = "Cedula";
            this.rbCedulaO.UseVisualStyleBackColor = true;
            this.rbCedulaO.CheckedChanged += new System.EventHandler(this.rbCedulaO_CheckedChanged);
            // 
            // txtCedulaO
            // 
            this.txtCedulaO.Location = new System.Drawing.Point(71, 19);
            this.txtCedulaO.Name = "txtCedulaO";
            this.txtCedulaO.Size = new System.Drawing.Size(113, 20);
            this.txtCedulaO.TabIndex = 7;
            // 
            // lblCedulaO
            // 
            this.lblCedulaO.AutoSize = true;
            this.lblCedulaO.Location = new System.Drawing.Point(12, 22);
            this.lblCedulaO.Name = "lblCedulaO";
            this.lblCedulaO.Size = new System.Drawing.Size(43, 13);
            this.lblCedulaO.TabIndex = 6;
            this.lblCedulaO.Text = "Cedula:";
            // 
            // btnBuscarCaso
            // 
            this.btnBuscarCaso.Location = new System.Drawing.Point(464, 19);
            this.btnBuscarCaso.Name = "btnBuscarCaso";
            this.btnBuscarCaso.Size = new System.Drawing.Size(119, 27);
            this.btnBuscarCaso.TabIndex = 10;
            this.btnBuscarCaso.Text = "Buscar";
            this.btnBuscarCaso.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(464, 52);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(119, 27);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporteCaso
            // 
            this.btnGenerarReporteCaso.Location = new System.Drawing.Point(464, 85);
            this.btnGenerarReporteCaso.Name = "btnGenerarReporteCaso";
            this.btnGenerarReporteCaso.Size = new System.Drawing.Size(119, 27);
            this.btnGenerarReporteCaso.TabIndex = 12;
            this.btnGenerarReporteCaso.Text = "Generar Reporte";
            this.btnGenerarReporteCaso.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(102, 277);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(119, 27);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.Text = "Imprimir Reporte";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReporteAbono
            // 
            this.btnGenerarReporteAbono.Location = new System.Drawing.Point(90, 95);
            this.btnGenerarReporteAbono.Name = "btnGenerarReporteAbono";
            this.btnGenerarReporteAbono.Size = new System.Drawing.Size(119, 27);
            this.btnGenerarReporteAbono.TabIndex = 11;
            this.btnGenerarReporteAbono.Text = "Generar Reporte";
            this.btnGenerarReporteAbono.UseVisualStyleBackColor = true;
            // 
            // frmDivorciosAccidenteReportGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(981, 585);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gbVista);
            this.Controls.Add(this.gbInformacion);
            this.Controls.Add(this.gbFechas);
            this.Controls.Add(this.rbReporteaGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDivorciosAccidenteReportGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Divorcio Accidente";
            this.Load += new System.EventHandler(this.frmDivorciosAccidenteReportGenerator_Load);
            this.rbReporteaGeneral.ResumeLayout(false);
            this.rbReporteaGeneral.PerformLayout();
            this.gbFechas.ResumeLayout(false);
            this.gbFechas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreviewReporte)).EndInit();
            this.gbInformacion.ResumeLayout(false);
            this.gbVista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCasos)).EndInit();
            this.gbDemandante.ResumeLayout(false);
            this.gbDemandante.PerformLayout();
            this.gbDemandado.ResumeLayout(false);
            this.gbDemandado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rbReporteaGeneral;
        private System.Windows.Forms.RadioButton rbCaso;
        private System.Windows.Forms.RadioButton rbAbono;
        private System.Windows.Forms.GroupBox gbFechas;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DataGridView dgvPreviewReporte;
        private System.Windows.Forms.GroupBox gbInformacion;
        private System.Windows.Forms.GroupBox gbVista;
        private System.Windows.Forms.DataGridView dgvCasos;
        private System.Windows.Forms.GroupBox gbDemandado;
        private System.Windows.Forms.RadioButton rbPasaporteO;
        private System.Windows.Forms.RadioButton rbCedulaO;
        private System.Windows.Forms.MaskedTextBox txtCedulaO;
        private System.Windows.Forms.Label lblCedulaO;
        private System.Windows.Forms.GroupBox gbDemandante;
        private System.Windows.Forms.RadioButton rbPasaporteE;
        private System.Windows.Forms.RadioButton rbCedulaE;
        private System.Windows.Forms.MaskedTextBox txtCedulaE;
        private System.Windows.Forms.Label lblCedulaDemandante;
        private System.Windows.Forms.Button btnGenerarReporteCaso;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscarCaso;
        private System.Windows.Forms.Button btnGenerarReporteAbono;
        private System.Windows.Forms.Button btnImprimir;
    }
}