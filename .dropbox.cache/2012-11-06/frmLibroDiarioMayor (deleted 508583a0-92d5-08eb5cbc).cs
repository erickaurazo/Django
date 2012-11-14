using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using rSunat.ReportesSunat.LogicadeNegocio;
using rSunat.ReportesSunat.Entidades;
using rSunat.ReportesSunat.AccesoDatos;
using System.Configuration;
using System.Xml.Linq;
using System.Diagnostics;
using System.Collections;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Exportando_DataGridView;



namespace rSunat.ReportesSunat.Presentacion
{
    public partial class frmConsultarReporte : Form
    {
        #region variables 
        public string dm_Empresa = "001";
        public string dm_dinicioAño;
        public string dm_diniciomes;
        public string dm_dFinmes;
        public string dm_diniciodia;
        public string dm_dFindia;
        public string dm_dFinAño;
        public int d_grupo;
        public int _oCodigo;
        public bool xActivo;
        public string tipoMoneda;
        //public string normalsimplicado;
        public string getoCuentaInicio;
        public string getoCuentaFin;
        public string getoDescripcionInico;
        public string getoDescripcionFin;
        public string numCuentaInicio;
        public string numCuentaFinal;
        frmBuscarCuenta ooo = new frmBuscarCuenta();
        string _getCuenta;
        string _GetDescripcion;
        #endregion

        public frmConsultarReporte()
        {
            InitializeComponent();
            llenarCombo();
        }

        private void frmConsultarReporte_Load(object sender, EventArgs e)
        {

            Inico();

        }

        #region Botones 

        private void btnConsultarReporte_Click(object sender, EventArgs e)      
        {
            //this.btnConsultarReporte.Enabled = false;
            VerificarDatos();
            xActivo = true;
            Controles(xActivo);
            switch (this.cbSelecionadorReporte.Text)
            {
                case "Libro Mayor":
                    // instrucciones;
                    List<LibroMayor> tabla = GestordeReportes.ListarLibroMayor(dm_Empresa, numCuentaInicio, numCuentaFinal, (dm_dinicioAño + dm_diniciomes + dm_diniciodia), (dm_dFinAño + dm_dFinmes + dm_dFindia), tipoMoneda);
                    dgReportesSunatMayor.DataSource = tabla;
                    if (dgReportesSunatMayor.RowCount > 0)
                    {
                        this.btnSalir.Enabled = true;
                        this.btnReporteExcel.Enabled = true;
                        this.btnTxt.Enabled = true;
                        this.btnNuevo.Enabled = true;
                        this.lbltotalregistros.Text = "Se han encontrado " + dgReportesSunatMayor.RowCount + " Registros";
                        CalcularTotales();
                    }
                    else
                    {
                        MessageBox.Show("No se han coincidencia en la generacion de la consulta", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        this.btnSalir.Enabled = true;
                        this.btnReporteExcel.Enabled = false;
                        this.btnTxt.Enabled = false;
                        this.btnNuevo.Enabled = false;
                        return;
                    }       

                    break;
                case "Libro Diario":
                    // instrucciones;
                    List<LibroDiario> tabla2 = GestordeReportes.ListarLibroDiario(dm_Empresa, (dm_dinicioAño + dm_diniciomes + dm_diniciodia), (dm_dFinAño + dm_dFinmes + dm_dFindia), tipoMoneda, "N", d_grupo);
                    dgReportesSunatDiario.DataSource = tabla2;

                    if (dgReportesSunatDiario.RowCount > 0)
                    {                       
                        this.btnSalir.Enabled = true;
                        this.btnReporteExcel.Enabled = true;
                        this.btnTxt.Enabled = true;
                        this.btnNuevo.Enabled = true;
                        this.lbltotalregistros.Text = "Se han encontrado " + dgReportesSunatDiario.RowCount + " Registros";
                        CalcularTotales();
                    }
                    else
                    {
                        MessageBox.Show("No se han coincidencia en la generacion de la consulta", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       
                        this.btnSalir.Enabled = true;
                        this.btnReporteExcel.Enabled = false;
                        this.btnTxt.Enabled = false;
                        this.btnNuevo.Enabled = false;
                        return;
                    }                    
                    break;
                default:
                    // instrucciones;                    
                    break;                   
            }
            this.btnNuevo.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.btnConsultarReporte.Enabled = true;
            DialogResult x = MessageBox.Show("¿Desea realizar una nueva consulta?", "Gestión de Reportes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                limpiar();
            }
            this.btnNuevo.Enabled = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            //Form1 formulariosz = new Form1();
            //formulariosz.ShowDialog();
            //frmReporteMatricula rep = new frmReporteMatricula(_oCodigo);
            //rep.ShowDialog();


        }

        private void btnReporteCvs_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList titulos = new ArrayList();
                DataTable datosTabla = new DataTable();
                //Especificar rutal del archivo con extencion de CSV.
                OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Reporte.csv");

                //obtenemos los titulos del grid y creamos las columnas de la tabla
                foreach (DataGridViewColumn item in dgReportesSunatMayor.Columns)
                {
                    titulos.Add(item.HeaderText);
                    datosTabla.Columns.Add();
                }
                //se crean los renglones de la tabla
                foreach (DataGridViewRow item in dgReportesSunatMayor.Rows)
                {
                    DataRow rowx = datosTabla.NewRow();
                    datosTabla.Rows.Add(rowx);
                }
                //se pasan los datos del dataGridView a la tabla
                foreach (DataGridViewColumn item in dgReportesSunatMayor.Columns)
                {
                    foreach (DataGridViewRow itemx in dgReportesSunatMayor.Rows)
                    {
                        datosTabla.Rows[itemx.Index][item.Index] = dgReportesSunatMayor[item.Index, itemx.Index].Value;
                    }
                }
                OF.ExportCSV(titulos, datosTabla);
                Process.Start(OF.xpath);
                MessageBox.Show("Procceso Completo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion         

        public void GenerarDocumento(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView
            PdfPTable datatable = new PdfPTable(dgReportesSunatMayor.ColumnCount);
            //asignanos algunas propiedades para el diseño del pdf
            datatable.DefaultCell.Padding = 2;
            float[] headerwidths = GetTamañoColumnas(dgReportesSunatMayor);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 90;
            datatable.DefaultCell.BorderWidth = 1;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF
            for (int i = 0; i < dgReportesSunatMayor.ColumnCount; i++)
            {
                datatable.AddCell(dgReportesSunatMayor.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dgReportesSunatMayor.RowCount - 1; i++)
            {
                for (int j = 0; j < dgReportesSunatMayor.ColumnCount; j++)
                {
                    datatable.AddCell(dgReportesSunatMayor[j, i].Value.ToString());
                }
                datatable.CompleteRow();
            }
            //SE AGREGAR LA PDFPTABLE AL DOCUMENTO
            document.Add(datatable);
        }
        //Obtiene los tamaños de las columnas del grid
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }     

        public void limpiar()
        {
            //this.dgReportesSunatMayor.DataSource = " ";
            
            cbTipoMoneda.SelectedIndex = 0;                      
            this.dtoFin.Value = DateTime.Now;
            this.dtpInico.Value = DateTime.Now;

            if (this.gbConsultaMayor.Visible || this.cbSelecionadorReporte.SelectedIndex == 1)
            {                
                List<LibroMayor> oLibroMayor = GestordeReportes.ListarLibroMayor("987","10","10","20000101","20000131","N");
                dgReportesSunatMayor.DataSource = oLibroMayor;
                lbldebe.Text = "0.00";
                lblhaber.Text = "0.00";
            }
            else
            {}

            if (this.gbConsultaDiario.Visible || this.cbSelecionadorReporte.SelectedIndex == 2)
           {
               List<LibroDiario> tabla2 = GestordeReportes.ListarLibroDiario("987", "20000101", "20000101", "N", "N", 0);
               dgReportesSunatDiario.DataSource = tabla2;
               lblDebeDiario.Text = "0.00";
               lblHaberDiario.Text = "0.00";
           }
           else
           {}
            this.cbSelecionadorReporte.SelectedIndex = 0;
            this.lbltotalregistros.Text = "";
            this.chkOpcionesAvanzadas.Checked = false;
            
            Controles(xActivo);
            xActivo = false;
         
        }

        public void llenarCombo()
        {
            this.cbSelecionadorReporte.Items.Add("Seleccione Reporte");
            this.cbSelecionadorReporte.Items.Add("Libro Mayor");
            this.cbSelecionadorReporte.Items.Add("Libro Diario");
            this.cbTipoMoneda.Items.Add("Nuevos Soles");
            this.cbTipoMoneda.Items.Add("Dólares Americanos");
        }

        public void Controles(bool oActivo)
        {


            if (oActivo == false)
            {
                //this.btnPdf.Enabled = false;
                this.btnReporteExcel.Enabled = false;
                this.btnTxt.Enabled = false;

            }
            else
            {
                //this.btnPdf.Enabled = true;
                this.btnReporteExcel.Enabled = true;
                this.btnTxt.Enabled = true;

            }
        }

        public void VerificarDatos()
        {                     
            if (this.cbSelecionadorReporte.SelectedIndex == 0)
            {
                MessageBox.Show("Falta seleccionar el Reporte");
                return;
            }

            if (this.cbTipoMoneda.Text == "Nuevos Soles")
            {
                tipoMoneda = "N";
            }

            if (this.cbTipoMoneda.Text == "Dólares Americanos")
            {
                tipoMoneda = "E";
            }                     
           
            dm_dinicioAño = this.dtpInico.Value.Year.ToString();
            //
            //VALIDAR (MES) DE LA FECHA INICIO DEL MAYOR
            dm_diniciomes = this.dtpInico.Value.Month.ToString();
            if (dm_diniciomes.Length == 1)
            {
                dm_diniciomes = "0" + this.dtpInico.Value.Month.ToString();
            }
            else
            {
                dm_diniciomes = this.dtpInico.Value.Month.ToString();
            }
            //
            //VALIDAR (DIA) DE LA FECHA INICIO DEL MAYOR
            dm_diniciodia = this.dtpInico.Value.Day.ToString();
            if (dm_diniciodia.Length == 1)
            {
                dm_diniciodia = "0" + this.dtpInico.Value.Day.ToString();
            }
            else
            {
                dm_diniciodia = this.dtpInico.Value.Day.ToString();
            }

            //VALIDAR (AÑO) DE LA FECHA FIN DEL MAYOR
            dm_dFinAño = this.dtoFin.Value.Year.ToString();

            //VALIDAR (DIA) DE LA FECHA FIN DEL MAYOR
            dm_dFinmes = this.dtoFin.Value.Month.ToString();
            if (dm_dFinmes.Length == 1)
            {
                //AGREGARLE UN 0 A LOS MESES
                dm_dFinmes = "0" + this.dtoFin.Value.Month.ToString();
            }
            else
            {
                dm_dFinmes = this.dtoFin.Value.Month.ToString();
            }

            // VALIDAR (DIA) DE LA FECHA FIN DEL MAYOR
            dm_dFindia = this.dtoFin.Value.Day.ToString();
            if (dm_dFindia.Length == 1)
            {
                dm_dFindia = "0" + this.dtoFin.Value.Day.ToString();
            }
            else
            {
                dm_dFindia = this.dtoFin.Value.Day.ToString();
            }
            
            //
            //
            //Advertir sobre la diferencia entre años tanto de inicio como de fin
            if (this.dtpInico.Value.Year != this.dtoFin.Value.Year)
            {

                DialogResult x = MessageBox.Show("Advertencia el rango de fechas difiere entre años\n Desea Continuar", "Gestión de Reportes", MessageBoxButtons.YesNo);
                if (x == DialogResult.Yes)
                {

                }
                else
                {
                    return;
                }
            }
           
       
           
            // validar que ingrese un numero de cuenta inicial
            if (this.txtnumerocuentaInicial.Text == "")
            {
                //numCuentaInicio = String.Format(this.txtnumerocuentaInicial.Text);
                MessageBox.Show("Falta ingresar el numero de la cuenta inicial");
                return;
            }
            else
            {
                //MessageBox.Show("Falta ingresar el numero de la cuenta inicial");
                //return;
                numCuentaInicio = String.Format(this.txtnumerocuentaInicial.Text);
            }


            if (this.txtnumerocuentaFinal.Text == "")
            {
                //numCuentaFinal = String.Format(this.txtnumerocuentaFinal.Text);
                MessageBox.Show("Falta ingresar el numero de la cuenta Final");
                return;
            }
            else
            {
                //MessageBox.Show("Falta ingresar el numero de la cuenta Final");
                //return;
                numCuentaFinal = String.Format(this.txtnumerocuentaFinal.Text);
            }


            if (int.Parse(txtnumerocuentaInicial.Text) > int.Parse(txtnumerocuentaFinal.Text))
            {
                MessageBox.Show("La cuenta inicial es mayor a la cuenta final");
                txtnumerocuentaFinal.Focus();
                return;
            }


            if (chkDiarioIncluyeInicial.Checked == true)
            {
                d_grupo = 1;
            }
            else
            {
                d_grupo = 0;
            }

           

        }

        public void CalcularTotales()
        {

            decimal mdebe = 0;
            foreach (DataGridViewRow row in this.dgReportesSunatMayor.Rows)
            {
                mdebe += Convert.ToDecimal(row.Cells["MDEBE"].Value);
            }
            lbldebe.Text =  string.Format("{0:N2}",mdebe);

            //string.Format("{0:N2}", n);
            
            decimal mhaber = 0;
            foreach (DataGridViewRow row in this.dgReportesSunatMayor.Rows)
            {
                mhaber += Convert.ToDecimal(row.Cells["MHABER"].Value);
            }
            lblhaber.Text = string.Format("{0:N2}",mhaber);


            ///haber
            decimal hdebe = 0;
            foreach (DataGridViewRow row in this.dgReportesSunatDiario.Rows)
            {
                hdebe += Convert.ToDecimal(row.Cells["DDEBE"].Value);
            }
            lblDebeDiario.Text = string.Format("{0:N2}", hdebe);

            //string.Format("{0:N2}", n);

            decimal hhaber = 0;
            foreach (DataGridViewRow row in this.dgReportesSunatDiario.Rows)
            {
                hhaber += Convert.ToDecimal(row.Cells["DHABER"].Value);
            }
            lblHaberDiario.Text = string.Format("{0:N2}", hhaber);


        }

        public void CuentasMinimasMaximas()
        {

            DataTable objplanCuentas;
            objplanCuentas = Extensiones.ToDataTable(GestordeReportes.listarPrimerUltimaCuenta());
            
            if (objplanCuentas.Rows[0][0].ToString() == null)
            {
                this.txtnumerocuentaInicial.Text = "10";
                this.txtnumerocuentaFinal.Text = "9779914";
                this.txtCuentaInicial.Text = "CAJA Y BANCOS";
                this.txtCuentaFinal.Text = "CARGAS FINANCIERAS GENERALES";
            }
            else
            {
                this.txtnumerocuentaInicial.Text = objplanCuentas.Rows[0][0].ToString();
                this.txtnumerocuentaFinal.Text = objplanCuentas.Rows[1][0].ToString();
                this.txtCuentaInicial.Text = objplanCuentas.Rows[0][1].ToString();
                this.txtCuentaFinal.Text = objplanCuentas.Rows[1][1].ToString();
            }


        }

        public void Inico()
        {
            //oculto los parámetros para la consulta del diario y el groupbox que contiene la grilla de la consulta del diario
            this.gbLibroDiario.Visible = false;
            this.gbConsultaDiario.Visible = false;

            this.gbLibroMayor.Visible = true;
            this.gbLibroMayor.Enabled = false;
            this.gbLibroDiario.Visible = false;
            gbParametros.Enabled = false;

            gbResultadoDiario.Visible = false;
            gbResultadoMayor.Visible = false;

            //this.btnConsultarReporte.Enabled = false;

            cbSelecionadorReporte.SelectedIndex = 0;
            cbTipoMoneda.SelectedIndex = 0;
            CuentasMinimasMaximas();
            xActivo = false;
            Controles(xActivo);

        }                     
       
        private void btnBuscarCuentaInicio_Click_1(object sender, EventArgs e)
        {
            DialogResult resp = ooo.ShowDialog();
            if (resp != DialogResult.OK)
            {
                _getCuenta = ooo.getCuenta;
                _GetDescripcion = ooo.getDescripcion;
                this.txtnumerocuentaInicial.Text = _getCuenta;
                this.txtCuentaInicial.Text = _GetDescripcion;
            }
            else
            {
            }
        }

        private void txtnumerocuentaInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txtnumerocuentaFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void cbSelecionadorReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cbSelecionadorReporte.Text)
            {
                case "Libro Mayor":
                    this.gbLibroMayor.Enabled = true;
                    this.gbLibroMayor.Visible = true;
                    this.dgReportesSunatMayor.Enabled = true;
                    this.dgReportesSunatMayor.Visible = true;
                    this.gbConsultaMayor.Enabled = true;
                    this.gbConsultaMayor.Visible = true;

                    this.gbLibroDiario.Enabled = false;
                    this.gbLibroDiario.Visible = false;
                    this.dgReportesSunatDiario.Enabled = false;
                    this.dgReportesSunatDiario.Visible = false;
                    this.gbConsultaDiario.Enabled = false;
                    this.gbConsultaDiario.Visible = false;
                    this.btnConsultarReporte.Enabled = true;
                    this.btnNuevo.Enabled = true;

                    gbResultadoDiario.Visible = false;
                    gbResultadoMayor.Visible = true;

                    gbParametros.Enabled = true;
                    // instrucciones;                   
                    break;
                case "Libro Diario":
                    this.gbLibroMayor.Enabled = false;
                    this.gbLibroMayor.Visible = false;
                    this.dgReportesSunatMayor.Enabled = false;
                    this.dgReportesSunatMayor.Visible = false;
                    this.gbConsultaMayor.Enabled = false;
                    this.gbConsultaMayor.Visible = false;

                    this.gbLibroDiario.Enabled = true;
                    this.gbLibroDiario.Visible = true;
                    this.dgReportesSunatDiario.Enabled = true;
                    this.dgReportesSunatDiario.Visible = true;
                    this.gbConsultaDiario.Enabled = true;
                    this.gbConsultaDiario.Visible = true;
                    this.btnConsultarReporte.Enabled = true;
                    this.btnNuevo.Enabled = true;

                    gbResultadoDiario.Visible = true;
                    gbResultadoMayor.Visible = false;

                    gbParametros.Enabled = true;


                    // instrucciones;                    
                    break;
                default:
                    // instrucciones;     
                    gbParametros.Enabled = false;
                    this.btnNuevo.Enabled = false;
                    this.btnConsultarReporte.Enabled = false;
                    this.btnSalir.Enabled = true;
                    gbResultadoDiario.Visible = false;
                    gbResultadoMayor.Visible = false;
                    break;
            }
        }

        private void chkOpcionesAvanzadas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOpcionesAvanzadas.Checked == true)
            {
                //this.txtnumerocuentaInicial.Clear();
                //this.txtnumerocuentaFinal.Clear();
                this.txtnumerocuentaInicial.Enabled = true;
                this.txtnumerocuentaFinal.Enabled = true;
                this.btnBuscarCuentaFin.Enabled = false;
                this.btnBuscarCuentaInicio.Enabled = false;
                //this.txtCuentaInicial.Clear();
                //this.txtCuentaFinal.Clear();
                this.btnBuscarCuentaFin.Enabled = true;
                this.btnBuscarCuentaInicio.Enabled = true;
                txtnumerocuentaInicial.Focus();
            }
            else
            {
                CuentasMinimasMaximas();
                this.txtnumerocuentaInicial.Enabled = false;
                this.txtnumerocuentaFinal.Enabled = false;
                this.btnBuscarCuentaFin.Enabled = false;
                this.btnBuscarCuentaInicio.Enabled = false;
            }

            this.txtnumerocuentaInicial.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("¡Desea salir del fórmulario?", "Gestión de Reportes", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnBuscarCuentaFin_Leave(object sender, EventArgs e)
        {
            DialogResult resp = ooo.ShowDialog();
            if (resp != DialogResult.OK)
            {
                _getCuenta = ooo.getCuenta;
                _GetDescripcion = ooo.getDescripcion;
                this.txtnumerocuentaInicial.Text = _getCuenta;
                this.txtCuentaInicial.Text = _GetDescripcion;
            }
            else
            {
                ////_getCuenta = ooo.getCuenta;
                ////_GetDescripcion = ooo.getDescripcion;
                ////this.txtnumerocuentaInicial.Text = _getCuenta;
                ////this.txtCuentaInicial.Text = _GetDescripcion;
                //List<PlandeCuentaSunat> oCuentas = GestordeReportes.listarPrimerUltimaCuenta();
                //this.dgvcuentasmaximasyminimas.DataSource = oCuentas;
                //this.txtnumerocuentaInicial.Text = Convert.ToString(this.dgvcuentasmaximasyminimas.Rows[0].Cells[0].Value);
                //this.txtCuentaInicial.Text = Convert.ToString(this.dgvcuentasmaximasyminimas.Rows[0].Cells[1].Value)
            }
        }

        private void btnBuscarCuentaInicio_Click_2(object sender, EventArgs e)
        {
            DialogResult resp = ooo.ShowDialog();
            if (resp != DialogResult.OK)
            {
                _getCuenta = ooo.getCuenta;
                _GetDescripcion = ooo.getDescripcion;
                this.txtnumerocuentaFinal.Text = _getCuenta;
                this.txtCuentaFinal.Text = _GetDescripcion;
            }
            else
            {
                ////_getCuenta = ooo.getCuenta;
                ////_GetDescripcion = ooo.getDescripcion;
                ////this.txtnumerocuentaInicial.Text = _getCuenta;
                ////this.txtCuentaInicial.Text = _GetDescripcion;
                //List<PlandeCuentaSunat> oCuentas = GestordeReportes.listarPrimerUltimaCuenta();
                //this.dgvcuentasmaximasyminimas.DataSource = oCuentas;
                //this.txtnumerocuentaInicial.Text = Convert.ToString(this.dgvcuentasmaximasyminimas.Rows[0].Cells[0].Value);
                //this.txtCuentaInicial.Text = Convert.ToString(this.dgvcuentasmaximasyminimas.Rows[0].Cells[1].Value)
            }
        }

        private void txtnumerocuentaInicial_Leave_1(object sender, EventArgs e)
        {
            DataTable objCuentaExacta;
            objCuentaExacta = Extensiones.ToDataTable(GestordeReportes.ListarPlanxCuentaExacta(this.txtnumerocuentaInicial.Text));

            if (objCuentaExacta.Rows.Count != 0)
            {
                txtCuentaInicial.Text = objCuentaExacta.Rows[0][1].ToString();
            }
            else
            {
                this.txtnumerocuentaInicial.Clear();
                this.txtCuentaInicial.Clear();
                MessageBox.Show("No existe la cuenta, pruebe con el boton de búsquedad de Plan de Cuentas", "Advertencia");
                this.txtnumerocuentaInicial.Text = "10";
                txtnumerocuentaInicial.Focus();
                return;
            }
        }

        private void txtnumerocuentaFinal_Leave_1(object sender, EventArgs e)
        {

            DataTable objCuentaExacta;
            objCuentaExacta = Extensiones.ToDataTable(GestordeReportes.ListarPlanxCuentaExacta(this.txtnumerocuentaFinal.Text));

            if (objCuentaExacta.Rows.Count != 0)
            {
                txtCuentaFinal.Text = objCuentaExacta.Rows[0][1].ToString();
            }
            else
            {
                this.txtnumerocuentaFinal.Clear();
                this.txtCuentaFinal.Clear();
                MessageBox.Show("No existe la cuenta, pruebe con el boton de búsquedad de Plan de Cuentas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnumerocuentaFinal.Text = "10";
                this.txtnumerocuentaFinal.Focus();
                return;
            }
        }

        private void btnBuscarCuentaFin_Click(object sender, EventArgs e)
        {
            DialogResult resp = ooo.ShowDialog();


            if (resp != DialogResult.OK)
            {
                _getCuenta = ooo.getCuenta;
                _GetDescripcion = ooo.getDescripcion;
                this.txtnumerocuentaFinal.Text = _getCuenta;
                this.txtCuentaFinal.Text = _GetDescripcion;
            }
            else
            {
            }
        }

        private void btnTxt_Click_1(object sender, EventArgs e)
        {
            if (gbConsultaDiario.Enabled == true)
            {
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();
                    //Especificar rutal del archivo con extencion de CSV.
                    OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Diario.txt");

                    //obtenemos los titulos del grid y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgReportesSunatDiario.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }
                    //se crean los renglones de la tabla
                    foreach (DataGridViewRow item in dgReportesSunatDiario.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }
                    //se pasan los datos del dataGridView a la tabla
                    foreach (DataGridViewColumn item in dgReportesSunatDiario.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgReportesSunatDiario.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgReportesSunatDiario[item.Index, itemx.Index].Value;
                        }
                    }
                    MessageBox.Show("El procceso de exportacion del Libro Diario fue Completado", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OF.ExportTXT(titulos, datosTabla);
                    Process.Start(OF.xpath);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
            }
            if (gbConsultaMayor.Enabled == true)
            {
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();
                    //Especificar rutal del archivo con extencion de CSV.
                    OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Maryor.txt");

                    //obtenemos los titulos del grid y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgReportesSunatMayor.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }
                    //se crean los renglones de la tabla
                    foreach (DataGridViewRow item in dgReportesSunatMayor.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }
                    //se pasan los datos del dataGridView a la tabla
                    foreach (DataGridViewColumn item in dgReportesSunatMayor.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgReportesSunatMayor.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgReportesSunatMayor[item.Index, itemx.Index].Value;
                        }
                    }
                    MessageBox.Show("El procceso de exportacion del Libro Mayor fue Completado", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OF.ExportTXT(titulos, datosTabla);
                    Process.Start(OF.xpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
            }    
        }

        private void btnReporteExcel_Click_1(object sender, EventArgs e)
        {

           
            if (gbConsultaDiario.Enabled == true)
            {
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();
                    //Especificar rutal del archivo con extencion de excel.
                    OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Diario.xls");

                    //obtenemos los titulos del grid y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgReportesSunatDiario.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }
                    //se crean los renglones de la tabla
                    foreach (DataGridViewRow item in dgReportesSunatDiario.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }
                    //se pasan los datos del dataGridView a la tabla
                    foreach (DataGridViewColumn item in dgReportesSunatDiario.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgReportesSunatDiario.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgReportesSunatDiario[item.Index, itemx.Index].Value;
                        }
                    }
                    MessageBox.Show("El procceso de exportacion del Libro Diario fue Completado", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OF.Export(titulos, datosTabla);
                    Process.Start(OF.xpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();
                    //Especificar rutal del archivo con extencion de excel.
                    OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Mayor.xls");

                    //obtenemos los titulos del grid y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgReportesSunatMayor.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }
                    //se crean los renglones de la tabla
                    foreach (DataGridViewRow item in dgReportesSunatMayor.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }
                    //se pasan los datos del dataGridView a la tabla
                    foreach (DataGridViewColumn item in dgReportesSunatMayor.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgReportesSunatMayor.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgReportesSunatMayor[item.Index, itemx.Index].Value;
                        }
                    }
                    MessageBox.Show("El procceso de exportacion del Libro Mayor fue Completado", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OF.Export(titulos, datosTabla);
                    Process.Start(OF.xpath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

    }
}
