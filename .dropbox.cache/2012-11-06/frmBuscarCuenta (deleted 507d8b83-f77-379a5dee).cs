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
using rSunat.ReportesSunat.Presentacion;
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
    public partial class frmBuscarCuenta : Form
    {
        //Se envian estos dos parámetros
        public string getCuenta;
        public string getDescripcion;
        //se asignan dos variables para realizar los pa
        public string numCuenta;
        public string nomCuenta;
    
        public frmBuscarCuenta()
        {
            InitializeComponent();
            llenarCombo();
        }

        public frmBuscarCuenta(string getCuenta, string getDescripcion)
        {
            
            
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("¡Desea salir del fórmulario?", "Gestión de Reportes", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //REALIZO UNA NUEVA CONSULTA, POR TANTO PRIMERO LIMPIO EL FORMULARIO
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.txtBuscarCampo.Clear();
            this.cbbuscarCampo.SelectedIndex = 0;
        }

        //LLENAR EL COMBO PARA LA BUSQUEDAD
        public void llenarCombo()
        {

            this.cbbuscarCampo.Items.Add("Cuenta");
            this.cbbuscarCampo.Items.Add("Descripción");
            cbbuscarCampo.SelectedIndex = 0;
        }


        // VALIDO LOS CAMPOS COMO EL TEXTBOX, LA ELECION DEL COMBOBOX Y QUE SE INGRESEN VALORES PERMITIDOS EN EL TEXTOX
        public void verificarCampos() 
        {

            if (this.txtBuscarCampo.Text == "")
            {
                MessageBox.Show("Ingrese un nombre o un numero de cuenta/descripción", "Gestión de Reportes");
                return;
            }
            else
            {
                this.numCuenta = this.txtBuscarCampo.Text;
                //this.nomCuenta = this.txtBuscarCampo.Text;
            }
        }

        private void frmBuscarCuenta_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            verificarCampos();
           
           List<PlandeCuentaSunat> tabla = GestordeReportes.ListarPlanxCuenta(numCuenta);
           this.dgPlandeCuentas.DataSource = tabla;

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            //try
            //{
            //    getCuenta = Convert.ToString(this.dgPlandeCuentas.CurrentRow.Cells[0].Value);
            //    getDescripcion = Convert.ToString(this.dgPlandeCuentas.CurrentRow.Cells[1].Value);

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("No se ha seleccionado cuenta"+ex.Message);
            //    return;
            //}

            DialogResult x = MessageBox.Show("Esta seguro de confirmar la cuenta?", "Gestión de Reportes", MessageBoxButtons.OKCancel);
            if (x == DialogResult.OK)
            {
                getCuenta = Convert.ToString(this.dgPlandeCuentas.CurrentRow.Cells[0].Value);
                getDescripcion = Convert.ToString(this.dgPlandeCuentas.CurrentRow.Cells[1].Value);
                this.Close();
            }

           
        }
    }
}
