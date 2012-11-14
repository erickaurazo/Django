namespace rSunat.ReportesSunat.Presentacion
{
    partial class frmLibroKARDEX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibroKARDEX));
            this.dgRegistroKARDEX = new System.Windows.Forms.DataGridView();
            this.gbOpcionesGestiondeReporte = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportarTxt = new System.Windows.Forms.Button();
            this.btnExportarPDF = new System.Windows.Forms.Button();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.gbRegistroKardex = new System.Windows.Forms.GroupBox();
            this.KMES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KANEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KCATALOGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTIPEXIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KCODEXIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KFECDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTIPDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KSERDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KNUMDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTIPOPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDESEXIST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KUNIMED = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KMETVAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KUNIING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KCOSING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTOTING = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KUNIRET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KCOSRET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTOTRET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KSALFIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KCOSFIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KTOTFIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KINTDIAMAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KINTVTACOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KINTREG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistroKARDEX)).BeginInit();
            this.gbOpcionesGestiondeReporte.SuspendLayout();
            this.gbRegistroKardex.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRegistroKARDEX
            // 
            this.dgRegistroKARDEX.AllowUserToAddRows = false;
            this.dgRegistroKARDEX.AllowUserToDeleteRows = false;
            this.dgRegistroKARDEX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistroKARDEX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KMES,
            this.KANEXO,
            this.KCATALOGO,
            this.KTIPEXIST,
            this.KCODEXIST,
            this.KFECDOC,
            this.KTIPDOC,
            this.KSERDOC,
            this.KNUMDOC,
            this.KTIPOPE,
            this.KDESEXIST,
            this.KUNIMED,
            this.KMETVAL,
            this.KUNIING,
            this.KCOSING,
            this.KTOTING,
            this.KUNIRET,
            this.KCOSRET,
            this.KTOTRET,
            this.KSALFIN,
            this.KCOSFIN,
            this.KTOTFIN,
            this.KINTDIAMAY,
            this.KINTVTACOM,
            this.KINTREG});
            this.dgRegistroKARDEX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRegistroKARDEX.Location = new System.Drawing.Point(3, 16);
            this.dgRegistroKARDEX.Name = "dgRegistroKARDEX";
            this.dgRegistroKARDEX.ReadOnly = true;
            this.dgRegistroKARDEX.Size = new System.Drawing.Size(1186, 471);
            this.dgRegistroKARDEX.TabIndex = 0;
            // 
            // gbOpcionesGestiondeReporte
            // 
            this.gbOpcionesGestiondeReporte.Controls.Add(this.btnSalir);
            this.gbOpcionesGestiondeReporte.Controls.Add(this.btnExportarTxt);
            this.gbOpcionesGestiondeReporte.Controls.Add(this.btnExportarPDF);
            this.gbOpcionesGestiondeReporte.Controls.Add(this.btnExportarExcel);
            this.gbOpcionesGestiondeReporte.Location = new System.Drawing.Point(919, 12);
            this.gbOpcionesGestiondeReporte.Name = "gbOpcionesGestiondeReporte";
            this.gbOpcionesGestiondeReporte.Size = new System.Drawing.Size(299, 92);
            this.gbOpcionesGestiondeReporte.TabIndex = 6;
            this.gbOpcionesGestiondeReporte.TabStop = false;
            this.gbOpcionesGestiondeReporte.Text = "Gestión de Reportes";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(218, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(61, 61);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportarTxt
            // 
            this.btnExportarTxt.Image = global::rSunat.ReportesSunat.Presentacion.Properties.Resources.txt_file;
            this.btnExportarTxt.Location = new System.Drawing.Point(84, 16);
            this.btnExportarTxt.Name = "btnExportarTxt";
            this.btnExportarTxt.Size = new System.Drawing.Size(61, 61);
            this.btnExportarTxt.TabIndex = 2;
            this.btnExportarTxt.UseVisualStyleBackColor = true;
            this.btnExportarTxt.Click += new System.EventHandler(this.btnExportarTxt_Click);
            // 
            // btnExportarPDF
            // 
            this.btnExportarPDF.Image = global::rSunat.ReportesSunat.Presentacion.Properties.Resources.pdf_file;
            this.btnExportarPDF.Location = new System.Drawing.Point(151, 16);
            this.btnExportarPDF.Name = "btnExportarPDF";
            this.btnExportarPDF.Size = new System.Drawing.Size(61, 61);
            this.btnExportarPDF.TabIndex = 1;
            this.btnExportarPDF.UseVisualStyleBackColor = true;
            this.btnExportarPDF.Click += new System.EventHandler(this.btnExportarPDF_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Image = global::rSunat.ReportesSunat.Presentacion.Properties.Resources.xls_file;
            this.btnExportarExcel.Location = new System.Drawing.Point(17, 16);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(61, 61);
            this.btnExportarExcel.TabIndex = 0;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.Location = new System.Drawing.Point(1034, 620);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(184, 13);
            this.lblResultados.TabIndex = 12;
            this.lblResultados.Text = "Se han encontrado # Registros";
            // 
            // gbRegistroKardex
            // 
            this.gbRegistroKardex.Controls.Add(this.dgRegistroKARDEX);
            this.gbRegistroKardex.Location = new System.Drawing.Point(26, 127);
            this.gbRegistroKardex.Name = "gbRegistroKardex";
            this.gbRegistroKardex.Size = new System.Drawing.Size(1192, 490);
            this.gbRegistroKardex.TabIndex = 13;
            this.gbRegistroKardex.TabStop = false;
            this.gbRegistroKardex.Text = "Registros";
            // 
            // KMES
            // 
            this.KMES.DataPropertyName = "KMES";
            this.KMES.HeaderText = "Mes de Operación";
            this.KMES.Name = "KMES";
            this.KMES.ReadOnly = true;
            // 
            // KANEXO
            // 
            this.KANEXO.DataPropertyName = "KANEXO";
            this.KANEXO.HeaderText = "KANEXO";
            this.KANEXO.Name = "KANEXO";
            this.KANEXO.ReadOnly = true;
            // 
            // KCATALOGO
            // 
            this.KCATALOGO.DataPropertyName = "KCATALOGO";
            this.KCATALOGO.HeaderText = "KCATALOGO";
            this.KCATALOGO.Name = "KCATALOGO";
            this.KCATALOGO.ReadOnly = true;
            // 
            // KTIPEXIST
            // 
            this.KTIPEXIST.DataPropertyName = "KTIPEXIST";
            this.KTIPEXIST.HeaderText = "KTIPEXIST";
            this.KTIPEXIST.Name = "KTIPEXIST";
            this.KTIPEXIST.ReadOnly = true;
            // 
            // KCODEXIST
            // 
            this.KCODEXIST.DataPropertyName = "KCODEXIST";
            this.KCODEXIST.HeaderText = "KCODEXIST";
            this.KCODEXIST.Name = "KCODEXIST";
            this.KCODEXIST.ReadOnly = true;
            // 
            // KFECDOC
            // 
            this.KFECDOC.DataPropertyName = "KFECDOC";
            this.KFECDOC.HeaderText = "KFECDOC";
            this.KFECDOC.Name = "KFECDOC";
            this.KFECDOC.ReadOnly = true;
            // 
            // KTIPDOC
            // 
            this.KTIPDOC.DataPropertyName = "KTIPDOC";
            this.KTIPDOC.HeaderText = "KTIPDOC";
            this.KTIPDOC.Name = "KTIPDOC";
            this.KTIPDOC.ReadOnly = true;
            // 
            // KSERDOC
            // 
            this.KSERDOC.DataPropertyName = "KSERDOC";
            this.KSERDOC.HeaderText = "KSERDOC";
            this.KSERDOC.Name = "KSERDOC";
            this.KSERDOC.ReadOnly = true;
            // 
            // KNUMDOC
            // 
            this.KNUMDOC.DataPropertyName = "KNUMDOC";
            this.KNUMDOC.HeaderText = "KNUMDOC";
            this.KNUMDOC.Name = "KNUMDOC";
            this.KNUMDOC.ReadOnly = true;
            // 
            // KTIPOPE
            // 
            this.KTIPOPE.DataPropertyName = "KTIPOPE";
            this.KTIPOPE.HeaderText = "KTIPOPE";
            this.KTIPOPE.Name = "KTIPOPE";
            this.KTIPOPE.ReadOnly = true;
            // 
            // KDESEXIST
            // 
            this.KDESEXIST.DataPropertyName = "KDESEXIST";
            this.KDESEXIST.HeaderText = "KDESEXIST";
            this.KDESEXIST.Name = "KDESEXIST";
            this.KDESEXIST.ReadOnly = true;
            // 
            // KUNIMED
            // 
            this.KUNIMED.DataPropertyName = "KUNIMED";
            this.KUNIMED.HeaderText = "KUNIMED";
            this.KUNIMED.Name = "KUNIMED";
            this.KUNIMED.ReadOnly = true;
            // 
            // KMETVAL
            // 
            this.KMETVAL.DataPropertyName = "KMETVAL";
            this.KMETVAL.HeaderText = "KMETVAL";
            this.KMETVAL.Name = "KMETVAL";
            this.KMETVAL.ReadOnly = true;
            // 
            // KUNIING
            // 
            this.KUNIING.DataPropertyName = "KUNIING";
            this.KUNIING.HeaderText = "KUNIING";
            this.KUNIING.Name = "KUNIING";
            this.KUNIING.ReadOnly = true;
            // 
            // KCOSING
            // 
            this.KCOSING.DataPropertyName = "KCOSING";
            this.KCOSING.HeaderText = "KCOSING";
            this.KCOSING.Name = "KCOSING";
            this.KCOSING.ReadOnly = true;
            // 
            // KTOTING
            // 
            this.KTOTING.DataPropertyName = "KTOTING";
            this.KTOTING.HeaderText = "KTOTING";
            this.KTOTING.Name = "KTOTING";
            this.KTOTING.ReadOnly = true;
            // 
            // KUNIRET
            // 
            this.KUNIRET.DataPropertyName = "KUNIRET";
            this.KUNIRET.HeaderText = "KUNIRET";
            this.KUNIRET.Name = "KUNIRET";
            this.KUNIRET.ReadOnly = true;
            // 
            // KCOSRET
            // 
            this.KCOSRET.DataPropertyName = "KCOSRET";
            this.KCOSRET.HeaderText = "KCOSRET";
            this.KCOSRET.Name = "KCOSRET";
            this.KCOSRET.ReadOnly = true;
            // 
            // KTOTRET
            // 
            this.KTOTRET.DataPropertyName = "KTOTRET";
            this.KTOTRET.HeaderText = "KTOTRET";
            this.KTOTRET.Name = "KTOTRET";
            this.KTOTRET.ReadOnly = true;
            // 
            // KSALFIN
            // 
            this.KSALFIN.DataPropertyName = "KSALFIN";
            this.KSALFIN.HeaderText = "KSALFIN";
            this.KSALFIN.Name = "KSALFIN";
            this.KSALFIN.ReadOnly = true;
            // 
            // KCOSFIN
            // 
            this.KCOSFIN.DataPropertyName = "KCOSFIN";
            this.KCOSFIN.HeaderText = "KCOSFIN";
            this.KCOSFIN.Name = "KCOSFIN";
            this.KCOSFIN.ReadOnly = true;
            // 
            // KTOTFIN
            // 
            this.KTOTFIN.DataPropertyName = "KTOTFIN";
            this.KTOTFIN.HeaderText = "KTOTFIN";
            this.KTOTFIN.Name = "KTOTFIN";
            this.KTOTFIN.ReadOnly = true;
            // 
            // KINTDIAMAY
            // 
            this.KINTDIAMAY.DataPropertyName = "KINTDIAMAY";
            this.KINTDIAMAY.HeaderText = "KINTDIAMAY";
            this.KINTDIAMAY.Name = "KINTDIAMAY";
            this.KINTDIAMAY.ReadOnly = true;
            // 
            // KINTVTACOM
            // 
            this.KINTVTACOM.DataPropertyName = "KINTVTACOM";
            this.KINTVTACOM.HeaderText = "KINTVTACOM";
            this.KINTVTACOM.Name = "KINTVTACOM";
            this.KINTVTACOM.ReadOnly = true;
            // 
            // KINTREG
            // 
            this.KINTREG.DataPropertyName = "KINTREG";
            this.KINTREG.HeaderText = "KINTREG";
            this.KINTREG.Name = "KINTREG";
            this.KINTREG.ReadOnly = true;
            // 
            // frmLibroKARDEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.gbRegistroKardex);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.gbOpcionesGestiondeReporte);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLibroKARDEX";
            this.Text = "... Libro KARDEX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistroKARDEX)).EndInit();
            this.gbOpcionesGestiondeReporte.ResumeLayout(false);
            this.gbRegistroKardex.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRegistroKARDEX;
        private System.Windows.Forms.GroupBox gbOpcionesGestiondeReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportarTxt;
        private System.Windows.Forms.Button btnExportarPDF;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.GroupBox gbRegistroKardex;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMES;
        private System.Windows.Forms.DataGridViewTextBoxColumn KANEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KCATALOGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTIPEXIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn KCODEXIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn KFECDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTIPDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn KSERDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn KNUMDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTIPOPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDESEXIST;
        private System.Windows.Forms.DataGridViewTextBoxColumn KUNIMED;
        private System.Windows.Forms.DataGridViewTextBoxColumn KMETVAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn KUNIING;
        private System.Windows.Forms.DataGridViewTextBoxColumn KCOSING;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTOTING;
        private System.Windows.Forms.DataGridViewTextBoxColumn KUNIRET;
        private System.Windows.Forms.DataGridViewTextBoxColumn KCOSRET;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTOTRET;
        private System.Windows.Forms.DataGridViewTextBoxColumn KSALFIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KCOSFIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KTOTFIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KINTDIAMAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn KINTVTACOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn KINTREG;
    }
}