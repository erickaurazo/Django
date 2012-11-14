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
    public partial class frmLibroKARDEX : Form
    {
        public frmLibroKARDEX()
        {
            InitializeComponent();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarTxt_Click(object sender, EventArgs e)
        {
            if (gbRegistroKardex.Enabled == true)
            {
                try
                {
                    //DataTable objkardex;
                    //objkardex = Extensiones.ToDataTable(GestordeReportes.ListarKardex());

                    ArrayList titulos = new ArrayList();
                    DataTable datosTabla = new DataTable();
                    //Especificar rutal del archivo con extencion de CSV.
                    OtrosFormatos OF = new OtrosFormatos(Application.StartupPath + @"\\Kárdex.txt");

                    //obtenemos los titulos del grid y creamos las columnas de la tabla
                    foreach (DataGridViewColumn item in dgRegistroKARDEX.Columns)
                    {
                        titulos.Add(item.HeaderText);
                        datosTabla.Columns.Add();
                    }

                    //se crean los renglones de la tabla
                    foreach (DataGridViewRow item in dgRegistroKARDEX.Rows)
                    {
                        DataRow rowx = datosTabla.NewRow();
                        datosTabla.Rows.Add(rowx);
                    }
                    //se pasan los datos del dataGridView a la tabla
                    foreach (DataGridViewColumn item in dgRegistroKARDEX.Columns)
                    {
                        foreach (DataGridViewRow itemx in dgRegistroKARDEX.Rows)
                        {
                            datosTabla.Rows[itemx.Index][item.Index] = dgRegistroKARDEX[item.Index, itemx.Index].Value;
                        }
                    }
                    MessageBox.Show("El procceso de exportacion del Libro Kardex fue Completado", "Gestión de Reportes");
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

        private void btnExportarPDF_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GenerarDocumento(Document document)
        {
            //se crea un objeto PdfTable con el numero de columnas del dataGridView
            PdfPTable datatable = new PdfPTable(dgRegistroKARDEX.ColumnCount);
            //asignanos algunas propiedades para el diseño del pdf
            datatable.DefaultCell.Padding = 1;
            float[] headerwidths = GetTamañoColumnas(dgRegistroKARDEX);
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 80;
            datatable.DefaultCell.BorderWidth = 1;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
            //SE GENERA EL ENCABEZADO DE LA TABLA EN EL PDF
            for (int i = 0; i < dgRegistroKARDEX.ColumnCount; i++)
            {
                datatable.AddCell(dgRegistroKARDEX.Columns[i].HeaderText);
            }
            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;
            //SE GENERA EL CUERPO DEL PDF
            for (int i = 0; i < dgRegistroKARDEX.RowCount - 1; i++)
            {
                for (int j = 0; j < dgRegistroKARDEX.ColumnCount; j++)
                {
                    datatable.AddCell(dgRegistroKARDEX[j, i].Value.ToString());
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


    }
}
