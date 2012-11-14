namespace rSunat.ReportesSunat.Presentacion
{
    partial class frmBuscarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarCuenta));
            this.gbParametros = new System.Windows.Forms.GroupBox();
            this.lblnombretxtbuscar = new System.Windows.Forms.Label();
            this.txtBuscarCampo = new System.Windows.Forms.TextBox();
            this.cbbuscarCampo = new System.Windows.Forms.ComboBox();
            this.lblnombreCampo = new System.Windows.Forms.Label();
            this.gbPlandeCuentas = new System.Windows.Forms.GroupBox();
            this.dgPlandeCuentas = new System.Windows.Forms.DataGridView();
            this.idcuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOkey = new System.Windows.Forms.Button();
            this.gbParametros.SuspendLayout();
            this.gbPlandeCuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlandeCuentas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbParametros
            // 
            this.gbParametros.Controls.Add(this.lblnombretxtbuscar);
            this.gbParametros.Controls.Add(this.txtBuscarCampo);
            this.gbParametros.Controls.Add(this.cbbuscarCampo);
            this.gbParametros.Controls.Add(this.lblnombreCampo);
            this.gbParametros.Location = new System.Drawing.Point(26, 12);
            this.gbParametros.Name = "gbParametros";
            this.gbParametros.Size = new System.Drawing.Size(476, 79);
            this.gbParametros.TabIndex = 0;
            this.gbParametros.TabStop = false;
            this.gbParametros.Text = "Parámetros";
            // 
            // lblnombretxtbuscar
            // 
            this.lblnombretxtbuscar.AutoSize = true;
            this.lblnombretxtbuscar.Location = new System.Drawing.Point(206, 24);
            this.lblnombretxtbuscar.Name = "lblnombretxtbuscar";
            this.lblnombretxtbuscar.Size = new System.Drawing.Size(108, 13);
            this.lblnombretxtbuscar.TabIndex = 3;
            this.lblnombretxtbuscar.Text = "Descripción / Cuenta";
            // 
            // txtBuscarCampo
            // 
            this.txtBuscarCampo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCampo.Location = new System.Drawing.Point(163, 42);
            this.txtBuscarCampo.Name = "txtBuscarCampo";
            this.txtBuscarCampo.Size = new System.Drawing.Size(307, 20);
            this.txtBuscarCampo.TabIndex = 2;
            // 
            // cbbuscarCampo
            // 
            this.cbbuscarCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbuscarCampo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbuscarCampo.FormattingEnabled = true;
            this.cbbuscarCampo.Location = new System.Drawing.Point(14, 41);
            this.cbbuscarCampo.Name = "cbbuscarCampo";
            this.cbbuscarCampo.Size = new System.Drawing.Size(126, 21);
            this.cbbuscarCampo.TabIndex = 1;
            // 
            // lblnombreCampo
            // 
            this.lblnombreCampo.AutoSize = true;
            this.lblnombreCampo.Location = new System.Drawing.Point(54, 24);
            this.lblnombreCampo.Name = "lblnombreCampo";
            this.lblnombreCampo.Size = new System.Drawing.Size(40, 13);
            this.lblnombreCampo.TabIndex = 0;
            this.lblnombreCampo.Text = "Campo";
            // 
            // gbPlandeCuentas
            // 
            this.gbPlandeCuentas.Controls.Add(this.dgPlandeCuentas);
            this.gbPlandeCuentas.Location = new System.Drawing.Point(26, 97);
            this.gbPlandeCuentas.Name = "gbPlandeCuentas";
            this.gbPlandeCuentas.Size = new System.Drawing.Size(661, 248);
            this.gbPlandeCuentas.TabIndex = 1;
            this.gbPlandeCuentas.TabStop = false;
            this.gbPlandeCuentas.Text = "Plan de cuentas";
            // 
            // dgPlandeCuentas
            // 
            this.dgPlandeCuentas.AllowUserToAddRows = false;
            this.dgPlandeCuentas.AllowUserToDeleteRows = false;
            this.dgPlandeCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlandeCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcuenta,
            this.descripcion});
            this.dgPlandeCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPlandeCuentas.Location = new System.Drawing.Point(3, 16);
            this.dgPlandeCuentas.Name = "dgPlandeCuentas";
            this.dgPlandeCuentas.ReadOnly = true;
            this.dgPlandeCuentas.Size = new System.Drawing.Size(655, 229);
            this.dgPlandeCuentas.TabIndex = 0;
            // 
            // idcuenta
            // 
            this.idcuenta.DataPropertyName = "cuenta";
            this.idcuenta.HeaderText = "Cuenta";
            this.idcuenta.Name = "idcuenta";
            this.idcuenta.ReadOnly = true;
            this.idcuenta.Width = 80;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 500;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Location = new System.Drawing.Point(509, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 79);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNuevo.Location = new System.Drawing.Point(97, 19);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 56);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(29, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 56);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Consultar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSalir);
            this.groupBox2.Controls.Add(this.btnOkey);
            this.groupBox2.Location = new System.Drawing.Point(123, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 78);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opción";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(318, 13);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(70, 59);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOkey
            // 
            this.btnOkey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOkey.Image = ((System.Drawing.Image)(resources.GetObject("btnOkey.Image")));
            this.btnOkey.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOkey.Location = new System.Drawing.Point(93, 13);
            this.btnOkey.Name = "btnOkey";
            this.btnOkey.Size = new System.Drawing.Size(70, 59);
            this.btnOkey.TabIndex = 5;
            this.btnOkey.Text = "Consultar";
            this.btnOkey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOkey.UseVisualStyleBackColor = true;
            this.btnOkey.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmBuscarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 435);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPlandeCuentas);
            this.Controls.Add(this.gbParametros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarCuenta";
            this.Text = "... Buscar Cuenta";
            this.Load += new System.EventHandler(this.frmBuscarCuenta_Load);
            this.gbParametros.ResumeLayout(false);
            this.gbParametros.PerformLayout();
            this.gbPlandeCuentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlandeCuentas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbParametros;
        private System.Windows.Forms.GroupBox gbPlandeCuentas;
        private System.Windows.Forms.TextBox txtBuscarCampo;
        private System.Windows.Forms.ComboBox cbbuscarCampo;
        private System.Windows.Forms.Label lblnombreCampo;
        private System.Windows.Forms.Label lblnombretxtbuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgPlandeCuentas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnOkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}