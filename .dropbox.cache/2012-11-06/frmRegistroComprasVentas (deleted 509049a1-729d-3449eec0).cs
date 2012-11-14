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
    public partial class frmRegistroComprasVentas : Form
    {
        public string cMoneda;
        public string vAmbito;
        public string cv_Moneda;
        public string cv_dinicioAño;
        public string cv_diniciomes;
        public string cv_dFinAño;
        public string cv_dfinmes;
        public string cRegistro;
        public frmRegistroComprasVentas()       
        {
            InitializeComponent();
        }     
       
         private void frmRegistroComprasVentas_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        #region Botones 

         private void btnNuevo_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("¿Desea realizar una nueva consulta?", "Gestión de Reportes", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                Limpiar();
            }
            //this.btnConsultar.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("¡Desea salir del fórmulario?", "Gestión de Reportes", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Validar();
            switch (this.cbeleccionReporte.Text)
            {
                case "Registro de Ventas":
                    //@IDEMPRESA    CHAR(3),-- CÓDIGO DE LA EMPRESA
                    //@PERIODODESDE CHAR(6),-- DESDE (YYYYMMDD)
                    //@PERIODOHASTA CHAR(6),-- HASTA (YYYYMMDD)
                    //@TIPOMONEDA   CHAR(1),-- [N]ACIONAL O [E]XTRANJERA
                    //@AMBITO       CHAR(3),-- AMBITO DE DOCUMENTOS
                    //@PORCUENTA    NUMERIC(1) -- REGISTRO DE VENTAS POR CUENTA (1):SI, (0):NO
                    //RegistroVentas(IDEMPRESA,PERIODODESDE,PERIODOHASTA,TIPOMONED,AMBITO,PORCUENTA)
                    //ahora solo lleno mi datatable a mi grilla para listar los registros de la consulta
                    List<RegistroVentas> tabla = GestordeReportes.ListarRegistroVentas("001", (cv_dinicioAño + cv_diniciomes), (cv_dFinAño + cv_dfinmes), cv_Moneda, vAmbito, "0");
                    dgRegistrosRegistroVentas.DataSource = tabla;

                    if (dgRegistrosRegistroVentas.RowCount > 0)
                    {
                        this.btnExportarPDF.Enabled = true;
                        this.btnSalir.Enabled = true;
                        this.btnExportarExcel.Enabled = true;
                        this.btnExportarTxt.Enabled = true;
                        this.btnNuevo.Enabled = true;
                        limpiarTotalesVentas();
                        CalcularTotales();
                    }
                    else
                    {
                        MessageBox.Show("No se han coincidencia en la generacion de la consulta", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnExportarPDF.Enabled = false;
                        this.btnSalir.Enabled = true;
                        this.btnExportarExcel.Enabled = false;
                        this.btnExportarTxt.Enabled = false;
                        this.btnNuevo.Enabled = false;
                        limpiarTotalesVentas();
                        return;
                    }

                    this.lblResultados.Text = "Se han encontrado " + dgRegistrosRegistroVentas.RowCount + " Registros";
                    break;

                case "Registro de Compras":
                    // instrucciones;
                    List<RegistroCompras> oRegistrodeCompras = GestordeReportes.ListarRegistroCompras("001", (cv_dinicioAño + cv_diniciomes), (cv_dFinAño + cv_dfinmes), "C", cv_Moneda);
                    this.dgRegistrodeCompras.DataSource = oRegistrodeCompras;



                    if (this.dgRegistrodeCompras.RowCount > 0)
                    {
                        this.btnExportarPDF.Enabled = true;
                        this.btnSalir.Enabled = true;
                        this.btnExportarExcel.Enabled = true;
                        this.btnExportarTxt.Enabled = true;
                        this.btnNuevo.Enabled = true;
                        //limpiarTotalesVentas();
                        //CalcularTotales();
                    }
                    else
                    {
                        MessageBox.Show("No se han coincidencia en la generacion de la consulta", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnExportarPDF.Enabled = false;
                        this.btnSalir.Enabled = true;
                        this.btnExportarExcel.Enabled = false;
                        this.btnExportarTxt.Enabled = false;
                        this.btnNuevo.Enabled = false;
                        //limpiarTotalesVentas();
                        return;
                    }
                    this.lblResultados.Text = "Se han encontrado " + dgRegistrodeCompras.RowCount + " registros";
                    break;

            }

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (gbGridRegistrodeVentas.Visible == true)
            {
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();
                    //Especificar rutal del archivo con extencion de excel.
                    OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Reg_ventas.xls");
                    //obtenemos los titulos del grid y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgRegistrosRegistroVentas.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }
                    //se crean los renglones de la tabla
                    foreach (DataGridViewRow item in dgRegistrosRegistroVentas.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }
                    //se pasan los datos del dataGridView a la tabla
                    foreach (DataGridViewColumn item in dgRegistrosRegistroVentas.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgRegistrosRegistroVentas.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgRegistrosRegistroVentas[item.Index, itemx.Index].Value;
                        }
                    }
                    MessageBox.Show("El procceso de exportacion del Registro de Ventas fue Completado", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            
            }
            
        if (dgRegistrodeCompras.Visible == true)
            {
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();
                    //Especificar rutal del archivo con extencion de excel.
                    OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Reg_compras.xls");
                    //obtenemos los titulos del grid y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgRegistrodeCompras.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }
                    //se crean los renglones de la tabla
                    foreach (DataGridViewRow item in dgRegistrodeCompras.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }
                    //se pasan los datos del dataGridView a la tabla
                    foreach (DataGridViewColumn item in dgRegistrodeCompras.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgRegistrodeCompras.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgRegistrodeCompras[item.Index, itemx.Index].Value;
                        }
                    }
                    MessageBox.Show("El procceso de exportacion del Registro de Comprás fue completado", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("¡Desea salir del fórmulario?", "Gestión de Reportes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            if (gbGridRegistrodeVentas.Visible == true)
            {
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();
                    //Especificar rutal del archivo con extencion de CSV.
                    OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Reg_ventas.txt");

                    //obtenemos los titulos del grid y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgRegistrosRegistroVentas.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }
                    //se crean los renglones de la tabla
                    foreach (DataGridViewRow item in dgRegistrosRegistroVentas.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }
                    //se pasan los datos del dataGridView a la tabla
                    foreach (DataGridViewColumn item in dgRegistrosRegistroVentas.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgRegistrosRegistroVentas.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgRegistrosRegistroVentas[item.Index, itemx.Index].Value;
                        }
                    }
                    MessageBox.Show("El procceso de exportacion del Registro de Ventas fue Completado", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (dgRegistrodeCompras.Visible == true)
            {
                try
                {
                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();
                    //Especificar rutal del archivo con extencion de CSV.
                    OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Reg_ventas.txt");

                    //obtenemos los titulos del grid y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgRegistrodeCompras.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }
                    //se crean los renglones de la tabla
                    foreach (DataGridViewRow item in dgRegistrodeCompras.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }
                    //se pasan los datos del dataGridView a la tabla
                    foreach (DataGridViewColumn item in dgRegistrodeCompras.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgRegistrodeCompras.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgRegistrodeCompras[item.Index, itemx.Index].Value;
                        }
                    }
                    MessageBox.Show("El procceso de exportacion del Registro de Ventas fue Completado", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

#endregion

        #region Generar_funciones_de_exportacion 
        //Genero el documento pdf
        public void GenerarDocumento(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView
            PdfPTable datatable = new PdfPTable(dgRegistrosRegistroVentas.ColumnCount);
            //asignanos algunas propiedades para el diseño del pdf
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas(dgRegistrosRegistroVentas);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 60;
            datatable.DefaultCell.BorderWidth = 1;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_JUSTIFIED;

            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF
            for (int i = 0; i < dgRegistrosRegistroVentas.ColumnCount; i++)
            {
                datatable.AddCell(dgRegistrosRegistroVentas.Columns[i].HeaderText);
            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;


            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dgRegistrosRegistroVentas.RowCount - 1; i++)
            {
                for (int j = 0; j < dgRegistrosRegistroVentas.ColumnCount; j++)
                {
                    datatable.AddCell(dgRegistrosRegistroVentas[j, i].Value.ToString());
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
        #endregion

        #region Eventos 

        private void cbeleccionReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cbeleccionReporte.Text)
            {
                case "Registro de Ventas":
                    // instrucciones;
                    this.gbRegistrodeVentas.Enabled = true;
                    this.gbRegistrodeVentas.Visible = true;
                    this.gbGridRegistrodeVentas.Enabled = true;
                    this.gbGridRegistrodeVentas.Visible = true;
                    this.gbRegistrodeCompras.Visible = false;
                    this.gbRegistrodeCompras.Enabled = false;
                    this.gbGridRegistrodeCompras.Enabled = false;
                    this.gbGridRegistrodeCompras.Visible = false;
                    gbPeriodos.Enabled = true;
                    gbRegistrodeVentas.Enabled = true;
                    this.btnConsultar.Enabled = true;
                    gbTotalesRegistroVentas.Enabled = true;
                    gbTotalesRegistroVentas.Visible = true;

                    break;
                case "Registro de Compras":
                    // instrucciones;
                    this.gbRegistrodeVentas.Enabled = false;
                    this.gbRegistrodeVentas.Visible = false;
                    this.gbGridRegistrodeVentas.Enabled = false;
                    this.gbGridRegistrodeVentas.Visible = false;
                    this.gbRegistrodeCompras.Enabled = true;
                    this.gbRegistrodeCompras.Visible = true;
                    this.gbGridRegistrodeCompras.Enabled = true;
                    this.gbGridRegistrodeCompras.Visible = true;
                    gbPeriodos.Enabled = true;
                    gbRegistrodeCompras.Enabled = true;
                    this.btnConsultar.Enabled = true;
                    gbTotalesRegistroVentas.Enabled = false;
                    gbTotalesRegistroVentas.Visible = false;

                    break;
                default:
                    //
                    this.gbRegistrodeVentas.Enabled = false;
                    this.gbRegistrodeCompras.Enabled = false;
                    gbPeriodos.Enabled = false;
                    gbRegistrodeCompras.Enabled = false;
                    gbRegistrodeVentas.Enabled = false;
                    this.btnConsultar.Enabled = false;
                    gbTotalesRegistroVentas.Enabled = false;
                    gbTotalesRegistroVentas.Visible = false;
                    this.btnExportarPDF.Enabled = false;
                    this.btnSalir.Enabled = true;
                    this.btnExportarExcel.Enabled = false;
                    this.btnExportarTxt.Enabled = false;
                    this.btnNuevo.Enabled = false;
                    break;
            }
        }

        #endregion

        #region funciones
        
        public void limpiarTotalesVentas()
        {
            lblVVALFACEXP.Text = "0.00";
            lblVBASIMPGRA.Text = "0.00";
            lblVIMPTOTEXO.Text = "0.00";
            lblVIMPTOTINA.Text = "0.00";         
            lblVISC.Text = "0.00";
            lblVIGVIPM.Text = "0.00";
            lblVBASIMIVAP.Text = "0.00"; 
            lblBIVAP.Text = "0.00";   
            lblVOTRTRICGO.Text = "0.00";
            lblVIMPTOTCOM.Text = "0.00";
            this.lblResultados.Text = "Se han encontrado # Registros";
        }

        public void Limpiar()
        {
            cbeleccionReporte.SelectedIndex = 0;
            cbTipodemoneda.SelectedIndex = 0;
            cbComprasxRegistro.SelectedIndex = 0;
            cbAmbito.SelectedIndex = 0;
            this.dtpperiodoFinal.Value = DateTime.Now;
            this.dtpperiodoinicial.Value = DateTime.Now;

            switch (this.gbGridRegistrodeVentas.Visible)
            {
                case true:
                    // instrucciones;
                    List<RegistroVentas> tabla = GestordeReportes.ListarRegistroVentas("984", "200001", "200001", "N", "", "0");
                    dgRegistrosRegistroVentas.DataSource = tabla;
                    limpiarTotalesVentas();
                    break;
                default:
                    //                  
                    break;
            }

            switch (this.gbGridRegistrodeCompras.Visible)
            {
                case true:
                    // instrucciones;
                    List<RegistroCompras> oRegistrodeCompras = GestordeReportes.ListarRegistroCompras("991", "201001", "201001", "C", "N");
                    this.dgRegistrodeCompras.DataSource = oRegistrodeCompras;
                    break;
                default:
                    //                  
                    break;
            }
        }

        public void Validar()
        {            
            #region Datetimepicker
            cv_dinicioAño = this.dtpperiodoinicial.Value.Year.ToString();
            //VALIDAR (MES) DE LA FECHA INICIO DEL MAYOR

            cv_diniciomes = this.dtpperiodoinicial.Value.Month.ToString();
            if (cv_diniciomes.Length == 1)
            {
                cv_diniciomes = "0" + this.dtpperiodoinicial.Value.Month.ToString();
            }
            else
            {
                cv_diniciomes = this.dtpperiodoinicial.Value.Month.ToString();
            }

            cv_dFinAño = this.dtpperiodoFinal.Value.Year.ToString();

            //VALIDAR (MES) DE LA FECHA INICIO DEL MAYOR
            cv_dfinmes = this.dtpperiodoFinal.Value.Month.ToString();
            if (cv_dfinmes.Length == 1)
            {
                cv_dfinmes = "0" + this.dtpperiodoFinal.Value.Month.ToString();
            }
            else
            {
                cv_dfinmes = this.dtpperiodoFinal.Value.Month.ToString();
            }
            #endregion

            if (this.cbeleccionReporte.SelectedIndex == 0)
            {
                MessageBox.Show("Falta seleccionar el Reporte a consultar", "Gestión de Reportes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
            }

            //(VENTAS) - validar el combobox del ambito
            if (this.cbAmbito.Text == "(Todos)")
            {
                vAmbito = "";
            }
            //(COMPRAS) - Asignar variable si es por operacion o por Subdiario
            if (this.cbComprasxRegistro.Text == "Por Operación")
            {
                cRegistro = "O";
            }
            if (this.cbComprasxRegistro.Text == "Por Subdiario")
            {
                cRegistro = "S";
            }
            //(VENTAS - COMPRAS) - 
            if (this.cbTipodemoneda.Text == "Nuevos Soles")
            {
                cv_Moneda = "N";
            }

            if (this.cbTipodemoneda.Text == "Dólares Americanos")
            {
                cv_Moneda = "E";
            }

            //(VENTAS - COMPRAS) - Validar que la fecha de inicio no sea mayor a la fecha de término
            if (this.dtpperiodoinicial.Value.Year != this.dtpperiodoFinal.Value.Year)
            {
                DialogResult x = MessageBox.Show("Advertencia el rango de fechas difiere entre años\n Desea Continuar", "Gestión de Reportes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes)
                {
                }
                else
                {
                    return;
                }
            }
        }

        public void Inicio()
        {



            this.cbeleccionReporte.Items.Add("Seleccione Reporte");
            this.cbeleccionReporte.Items.Add("Registro de Ventas");
            this.cbeleccionReporte.Items.Add("Registro de Compras");

            this.cbComprasxRegistro.Items.Add("Por Operación");
            this.cbComprasxRegistro.Items.Add("Por Subdiario");

            this.cbAmbito.Items.Add("(Todos)");


            this.cbTipodemoneda.Items.Add("Nuevos Soles");
            this.cbTipodemoneda.Items.Add("Dólares Americanos");

            cbeleccionReporte.SelectedIndex = 0;
            cbTipodemoneda.SelectedIndex = 0;
            cbComprasxRegistro.SelectedIndex = 0;
            cbAmbito.SelectedIndex = 0;

            gbPeriodos.Enabled = false;
            gbRegistrodeCompras.Enabled = false;
            gbRegistrodeVentas.Enabled = false;
            gbTotalesRegistroVentas.Enabled = false;
            gbTotalesRegistroVentas.Visible = false;
            this.btnExportarPDF.Enabled = false;
            this.btnSalir.Enabled = true;
            this.btnExportarExcel.Enabled = false;
            this.btnExportarTxt.Enabled = false;
            this.btnNuevo.Enabled = false;

        }


        public void CalcularTotales()
        {
            //Valor Facturado Exportación
            decimal sumVVALFACEXP = 0;
            foreach(DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
                {
                    sumVVALFACEXP += Convert.ToDecimal(row.Cells["VVALFACEXP"].Value);
                }
            lblVVALFACEXP.Text = string.Format("{0:N2}", sumVVALFACEXP);
            //string.Format("{0:N2}",mdebe);


            //Base Imponible Operacion Grabada
            decimal sumVBASIMPGRA = 0;
            foreach (DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
            {
                sumVBASIMPGRA += Convert.ToDecimal(row.Cells["VBASIMPGRA"].Value);
            }
            lblVBASIMPGRA.Text = string.Format("{0:N2}", sumVBASIMPGRA);
            //


            //Importe Total Operación Exonerada
            decimal sumVIMPTOTEXO = 0;
            foreach (DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
            {
                sumVIMPTOTEXO += Convert.ToDecimal(row.Cells["VIMPTOTEXO"].Value);
            }
            lblVIMPTOTEXO.Text = string.Format("{0:N2}", sumVIMPTOTEXO);
            //


            //Importe total Operación inafecta
            decimal sumVIMPTOTINA = 0;
            foreach (DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
            {
                sumVIMPTOTINA += Convert.ToDecimal(row.Cells["VIMPTOTINA"].Value);
            }
            lblVIMPTOTINA.Text = string.Format("{0:N2}", sumVIMPTOTINA);
            //

 
            //VISC
            decimal sumVISC = 0;
            foreach (DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
            {
                sumVISC += Convert.ToDecimal(row.Cells["VISC"].Value);
            }
            lblVISC.Text = string.Format("{0:N2}", sumVISC);
            //


            //IGV y/o IPM
            decimal sumVIGVIPM = 0;
            foreach (DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
            {
                sumVIGVIPM += Convert.ToDecimal(row.Cells["VIGVIPM"].Value);
            }
            lblVIGVIPM.Text = string.Format("{0:N2}", sumVIGVIPM);
            //

            //Base imponible operacion/IVAP
            decimal sumVBASIMIVAP = 0;
            foreach (DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
            {
                sumVBASIMIVAP += Convert.ToDecimal(row.Cells["VBASIMIVAP"].Value);
            }
            lblVBASIMIVAP.Text = string.Format("{0:N2}", sumVBASIMIVAP);
            //

            //Base imponible operacion/IVAP
            decimal sumBIVAP = 0;
            foreach (DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
            {
                sumBIVAP += Convert.ToDecimal(row.Cells["BIVAP"].Value);
            }
            lblBIVAP.Text = string.Format("{0:N2}", sumBIVAP);
            //

            //Otros Tributos
            decimal sumVOTRTRICGO = 0;
            foreach (DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
            {
                sumVOTRTRICGO += Convert.ToDecimal(row.Cells["VOTRTRICGO"].Value);
            }
            lblVOTRTRICGO.Text = string.Format("{0:N2}", sumVOTRTRICGO);
            //

            //Importe total Comprobante de Pago
            decimal sumVIMPTOTCOM = 0;
            foreach (DataGridViewRow row in this.dgRegistrosRegistroVentas.Rows)
            {
                sumVIMPTOTCOM += Convert.ToDecimal(row.Cells["VIMPTOTCOM"].Value);
            }
            lblVIMPTOTCOM.Text = string.Format("{0:N2}", sumVIMPTOTCOM);
            //

            // String.Format("{0:0.000}",
        }

        #endregion

       
    }
}
