using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mantenimientoStandares.LogicadeNegocio;
using mantenimientoStandares.Entidades;

namespace mantenimientoStandares.Presentacion
{
    public partial class Form1 : Form
    {
        
        public Boolean oEditar;

        public Form1()
        {
            InitializeComponent();
            llenarCombox();

            List<Jornal> a = GestordeMantenimiento.ListarJornalTop();
            DataTable xxx = Extensiones.ToDataTable(a);
            txtJornal.Text = Convert.ToString(xxx.Rows[0][0].ToString());


            decimal nPrecioUnitario = 0;
            this.txtpreciounitario.Text = Convert.ToString(nPrecioUnitario);


            decimal nEstandar1erDia = 0;
            this.txtestandar1erdia.Text = Convert.ToString(nEstandar1erDia);


            decimal nEstandar2doDia = 0;
            this.txtestandar2dodia.Text = Convert.ToString(nEstandar2doDia);


            decimal npreciounitario1erdia = 0;
            this.txtpreciounitario1erdia.Text = Convert.ToString(npreciounitario1erdia);

            decimal npreciounitario2dodia = 0;
            this.txtpreciounitario2dodia.Text = Convert.ToString(npreciounitario2dodia);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Inicio();
            //llenarGrid();       
            this.btnGrabar.Enabled = false;
            this.btnInicio.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnNuevo.Enabled = true;
        }

        

        #region Funciones publicas 
        public void limpiar()
        {
            #region Cajas de texto
            this.txtStandarExtra.Clear();
            this.txtporcentaje1erdia.Text = "1";
            this.txtporcentaje2dodia.Text = "1";
            this.txtStandar.Text = "1";
            this.txtStandarExtra.Text = "1";
            this.txtprecioUnitarioExtra.Text = "1";
            this.txtpreciounitario.Text = "1";
            this.txtestandar1erdia.Text = "1";
            this.txtestandar2dodia.Text = "1";
            this.txtpreciounitario1erdia.Text = "1";
            this.txtpreciounitario2dodia.Text = "1";
            this.txthorastrabajadas.Text = "1";            

            this.txtporcentaje1erdia.Enabled = false;
            this.txtporcentaje2dodia.Enabled = false;

            this.txtStandar.Enabled = false;
            this.txtStandar.Enabled = false;
            this.txtStandarExtra.Enabled = false;
            this.txtestandar1erdia.Enabled = false;
            this.txtestandar2dodia.Enabled = false;

            this.txtpreciounitario.Enabled = false;
            this.txtpreciounitario1erdia.Enabled = false;
            this.txtpreciounitario2dodia.Enabled = false;
            this.txtprecioUnitarioExtra.Enabled = false;

            this.txthorastrabajadas.Enabled = true;
            #endregion

            #region Combox
            this.cbarea.SelectedIndex = 0;
            this.cbFormato.SelectedIndex = 0;
            this.cbarea.Enabled = true;
            this.cbFormato.Enabled = true;
            #endregion

            #region Grilla
            List<Estandares> oLimpiar = GestordeMantenimiento.LimpiarEstandares();
            this.dglistarStandares.DataSource = oLimpiar;        
            #endregion

            #region DatetimePicker
            this.dtkFechaInicio.Value = DateTime.Now;
            this.dtkFechaFin.Value = DateTime.Now;
            this.dtpdesde.Value = DateTime.Now;
            this.dtpHasta.Value = DateTime.Now;
            this.dtkFechaInicio.Enabled = true;
            this.dtkFechaFin.Enabled = true;
            #endregion
        }

        public void Inicio()
        {
       
            #region Cajas de texto 
                this.txtStandarExtra.Clear();
                this.txtporcentaje1erdia.Text = "1";
                this.txtporcentaje2dodia.Text = "1";
                this.txtStandar.Text = "1";
                this.txtStandarExtra.Text = "1";
                this.txtprecioUnitarioExtra.Text = "1";
                this.txtpreciounitario.Text = "1";
                this.txtestandar1erdia.Text = "1";
                this.txtestandar2dodia.Text = "1";
                this.txtpreciounitario1erdia.Text = "1";
                this.txtpreciounitario2dodia.Text = "1";
                this.txthorastrabajadas.Text = "1";

                this.txtporcentaje1erdia.Enabled = false;
                this.txtporcentaje2dodia.Enabled = false;

                this.txtStandar.Enabled = false;
                this.txtStandar.Enabled = false;
                this.txtStandarExtra.Enabled = false;
                this.txtestandar1erdia.Enabled = false;
                this.txtestandar2dodia.Enabled = false;

                this.txtpreciounitario.Enabled = false;
                this.txtpreciounitario1erdia.Enabled = false;
                this.txtpreciounitario2dodia.Enabled = false;
                this.txtprecioUnitarioExtra.Enabled = false;

                this.txthorastrabajadas.Enabled = false;
            #endregion

            #region Combox 
                this.cbarea.SelectedIndex = 0;
                this.cbFormato.SelectedIndex = 0;
                this.cbarea.Enabled = false;
                this.cbFormato.Enabled = false;
            #endregion

            #region Grilla 
                this.dglistarStandares.DataSource = "";
            #endregion

            #region DatetimePicker 
                this.dtkFechaInicio.Value = DateTime.Now;
                this.dtkFechaFin.Value = DateTime.Now;
                this.dtpdesde.Value = DateTime.Now;
                this.dtpHasta.Value = DateTime.Now;
                this.dtkFechaInicio.Enabled = false;
                this.dtkFechaFin.Enabled = false;
            #endregion
        }

        public void llenarCombox() 
        {
            List<Area> oAreas = GestordeMantenimiento.ListarAreas();

            this.cbarea.DataSource = oAreas;
            this.cbarea.DisplayMember = "descripcion";
            this.cbarea.ValueMember = "idarea";


            List<Formato> oFormato = GestordeMantenimiento.ListarFormatos();
            this.cbFormato.DataSource = oFormato;
            this.cbFormato.DisplayMember = "descripcion";
            this.cbFormato.ValueMember = "idFormato";
        }

        public void llenarGrid() 
        {
            List<Estandares> tabla = GestordeMantenimiento.ListarStandares();
            this.dglistarStandares.DataSource = tabla;               
        }

        public void Validar()
        {
            if (this.dtkFechaInicio.Value > this.dtkFechaFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha Final","Validación");
                return;
            }


        }

        #endregion

        #region Mantenimientos 
        private void btnGrabar_Click(object sender, EventArgs e)
        {
        if (oEditar == true)
                {
                    List<Standar> tabla = GestordeMantenimiento.Verificar_duplicidad_Estandar(Convert.ToString(this.cbarea.SelectedValue), Convert.ToDateTime(this.dtkFechaInicio.Value));
                        if (tabla.Count > 1)
                            {
                                MessageBox.Show("No puede ingresar doblemente un estandar por día en la misma área", "Mantenimiento de Estandares", MessageBoxButtons.OK);
                                return;
                            }
                    else
                        {
                        try
                            {
                                Standar oStandar = new Standar();     
                                oStandar.IdStandar = Convert.ToString(this.dglistarStandares.CurrentRow.Cells[0].Value);
                                oStandar.IdArea = Convert.ToString(this.cbarea.SelectedValue);
                                oStandar.HorasTrabajadas = Convert.ToDecimal(this.txthorastrabajadas.Text);
                                oStandar.Estandar = Convert.ToDecimal(this.txtStandar.Text);
                                oStandar.EstandarExtra = Convert.ToDecimal(this.txtStandarExtra.Text);
                                oStandar.IdFormato = Convert.ToString(cbFormato.SelectedValue);
                                oStandar.Jornal = Convert.ToDecimal(this.txtJornal.Text);
                                oStandar.PrecioUnitarioExtra = Convert.ToDecimal(this.txtprecioUnitarioExtra.Text);
                                oStandar.EstandarPorcentajePrimerDia = Convert.ToDecimal(this.txtporcentaje1erdia.Text);
                                oStandar.EstandarPorcentajeSegundoDia = Convert.ToDecimal(this.txtporcentaje2dodia.Text);
                                oStandar.FechaInicio = this.dtkFechaInicio.Value;
                                oStandar.FechaFinal = this.dtkFechaFin.Value;
                                oStandar.UserDecimal01 = Convert.ToDecimal(0);
                                oStandar.UserVarchar01 = "";
                                oStandar.PrecioUnitario = Convert.ToDecimal(txtpreciounitario.Text);
                                oStandar.EstandarPrimerDia = Convert.ToDecimal(txtestandar1erdia.Text);
                                oStandar.EstandarSegundoDia = Convert.ToDecimal(txtestandar2dodia.Text);
                                oStandar.PrecioPrimerDia = Convert.ToDecimal(txtpreciounitario1erdia.Text);
                                oStandar.PrecioSegundoDia = Convert.ToDecimal(txtpreciounitario2dodia.Text);
                                
                                GestordeMantenimiento a = new GestordeMantenimiento();
                                a.Actualizar(oStandar);
                                MessageBox.Show("Se ha actualizado correctamente", "Mantenimiento de Estandares", MessageBoxButtons.OK);
                                llenarGrid();
                                dglistarStandares.Enabled = false;
                                oEditar = false;
                            }
                        catch (Exception ex)
                            {
                                throw ex;
                            }
                       
                    }
                        
                }

        else
            {
                List<Standar> tabla = GestordeMantenimiento.Verificar_duplicidad_Estandar(Convert.ToString(this.cbarea.SelectedValue), Convert.ToDateTime(this.dtkFechaInicio.Value));
                    if (tabla.Count > 0)
                        {
                            MessageBox.Show("No puede registrar el grabado porque el estandar para las fechas selecionadas ya se encuentra registrada para una misma área", "Mantenimiento de Estandares", MessageBoxButtons.OK);
                            return;
                        }
                    else
                        {
                        try
                            {
                                Standar oStandar = new Standar();   
                                oStandar.IdArea = Convert.ToString(this.cbarea.SelectedValue);
                                oStandar.HorasTrabajadas = Convert.ToDecimal(this.txthorastrabajadas.Text);
                                oStandar.Estandar = Convert.ToDecimal(this.txtStandar.Text);
                                oStandar.EstandarExtra = Convert.ToDecimal(this.txtStandarExtra.Text);
                                oStandar.IdFormato = Convert.ToString(cbFormato.SelectedValue);
                                oStandar.Jornal = Convert.ToDecimal(this.txtJornal.Text);
                                oStandar.PrecioUnitarioExtra = Convert.ToDecimal(this.txtprecioUnitarioExtra.Text);
                                oStandar.EstandarPorcentajePrimerDia = Convert.ToDecimal(this.txtporcentaje1erdia.Text);
                                oStandar.EstandarPorcentajeSegundoDia = Convert.ToDecimal(this.txtporcentaje2dodia.Text);
                                oStandar.FechaInicio = Convert.ToDateTime(this.dtkFechaInicio.Value);
                                oStandar.FechaFinal = Convert.ToDateTime(this.dtkFechaFin.Value);
                                oStandar.UserDecimal01 = Convert.ToDecimal(0);
                                oStandar.UserVarchar01 = "";
                                oStandar.PrecioUnitario = Convert.ToDecimal(txtpreciounitario.Text);
                                oStandar.EstandarPrimerDia = Convert.ToDecimal(txtestandar1erdia.Text);
                                oStandar.EstandarSegundoDia = Convert.ToDecimal(txtestandar2dodia.Text);
                                oStandar.PrecioPrimerDia = Convert.ToDecimal(txtpreciounitario1erdia.Text);
                                oStandar.PrecioSegundoDia = Convert.ToDecimal(txtpreciounitario2dodia.Text);
                                GestordeMantenimiento a = new GestordeMantenimiento();
                                a.Insertar(oStandar);
                                MessageBox.Show("Se han grabado correctamente los datos!", "Mantenimiento de Estandares", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                                llenarGrid();
                                dglistarStandares.Enabled = false;

                    }
                    catch (Exception ex)
                    {
                        throw ex;

                    }
                }               
            }
        this.btnGrabar.Enabled = false;
        this.btnInicio.Enabled = true;
        this.btnEditar.Enabled = true;
        this.btnNuevo.Enabled = true;
        } 

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            oEditar = false;
            DialogResult x = MessageBox.Show("¿Desea registrar una nuevo registro ", "Mantenimiento de Estandares ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x == DialogResult.Yes)
            {
                limpiar();
            }

            this.btnGrabar.Enabled = true;
            this.btnInicio.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnNuevo.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            oEditar = true;
            this.btnGrabar.Enabled = true;
            this.btnInicio.Enabled = true;
            this.btnEditar.Enabled = false;
            this.btnNuevo.Enabled = true;
            this.dglistarStandares.Enabled = true;
            this.txthorastrabajadas.Enabled = true;
            this.txtStandar.Enabled = true;
            this.txtStandarExtra.Enabled = true;
            this.txtprecioUnitarioExtra.Enabled = true;
            this.txtporcentaje1erdia.Enabled = true;
            this.txtporcentaje2dodia.Enabled = true;
            this.cbarea.Enabled = true;
            this.cbFormato.Enabled = true;
            
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("¡Desea salir del fórmulario actual?", "Mantenimiento de Estándares", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                                                                                                  
            if (x == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConsultarBusqueda_Click(object sender, EventArgs e)
        {
            llenarGrid();

            this.btnGrabar.Enabled = false;
            this.btnInicio.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnNuevo.Enabled = true;


            this.cbarea.Enabled = false;
            this.cbFormato.Enabled = false;
            this.dtkFechaInicio.Enabled = false;
            this.dtkFechaFin.Enabled = false;
            this.txthorastrabajadas.Enabled = false;
            this.dglistarStandares.Enabled = false;

        }
        #endregion

        #region Eventos GridView 
        private void dglistarStandares_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            this.txtStandar.Text =  Convert.ToString(dglistarStandares.CurrentRow.Cells[3].Value);
            this.txthorastrabajadas.Text = Convert.ToString(dglistarStandares.CurrentRow.Cells[2].Value);
            this.txtStandarExtra.Text = Convert.ToString(dglistarStandares.CurrentRow.Cells[4].Value);
            this.txtpreciounitario.Text = Convert.ToString(dglistarStandares.CurrentRow.Cells[6].Value);
            this.txtprecioUnitarioExtra.Text = Convert.ToString(dglistarStandares.CurrentRow.Cells[7].Value);
            this.txtporcentaje1erdia.Text = Convert.ToString(dglistarStandares.CurrentRow.Cells[13].Value);
            this.txtporcentaje2dodia.Text = Convert.ToString(dglistarStandares.CurrentRow.Cells[14].Value);
            this.dtkFechaFin.Value = Convert.ToDateTime(dglistarStandares.CurrentRow.Cells[11].Value);
            this.dtkFechaInicio.Value = Convert.ToDateTime(dglistarStandares.CurrentRow.Cells[10].Value);
            this.txtpreciounitario1erdia.Text =Convert.ToString(dglistarStandares.CurrentRow.Cells[17].Value);
            this.txtpreciounitario2dodia.Text =  Convert.ToString(dglistarStandares.CurrentRow.Cells[18].Value);
            this.txtestandar1erdia.Text = Convert.ToString(dglistarStandares.CurrentRow.Cells[15].Value);
            this.txtestandar2dodia.Text = Convert.ToString(dglistarStandares.CurrentRow.Cells[16].Value);
            this.cbarea.SelectedValue = Convert.ToString(dglistarStandares.CurrentRow.Cells[19].Value);
            this.cbFormato.SelectedValue = Convert.ToString(dglistarStandares.CurrentRow.Cells[20].Value);
        }
        #endregion

        #region Eventos KeyPress 
        private void txtStandar_KeyPress(object sender, KeyPressEventArgs e)
        {
            //// para que solo acepte valores numericos
            //if (((e.KeyChar) < 48 && e.KeyChar != 8) || e.KeyChar > 57)
            //{
            //    MessageBox.Show("Sólo se permiten Números");
            //    e.Handled = true;
            //}

            //// para que acepten valores numericos con decimales
            // el punto es e.KeyChar != 46 y la coma es e.KeyChar != 44
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números");
                e.Handled = true;
            }
        }

        private void txthorastrabajadas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números", "Advertencia", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void txtStandarExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números", "Advertencia", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void txtprecioUnitarioExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números", "Advertencia");
                e.Handled = true;
            }
        }

        private void txtporcentaje1erdia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números", "Advertencia");
                e.Handled = true;
            }
        }

        private void txtporcentaje2dodia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 46) || e.KeyChar > 57)
            {
                MessageBox.Show("Sólo se permiten Números", "Advertencia");
                e.Handled = true;
            }
        }
        #endregion

        #region Eventos_Leave 
        private void txthorastrabajadas_Leave(object sender, EventArgs e)
        {
            if (this.txthorastrabajadas.Text == "" || this.txthorastrabajadas.Text == "0")
            {
                MessageBox.Show("Ingrese un valor superior a Cero (0)", "Advertencia");
                //txthorastrabajadas.Text = "1";              
                txthorastrabajadas.Focus();
                return;
            }
            else
            {
                this.txtStandar.Enabled = true;
                this.txtStandar.Focus();
            }
        }

        private void txtStandar_Leave(object sender, EventArgs e)
        {
            string sStandar;
            if (this.txtStandar.Text == "" || this.txtStandar.Text == "0")
            {
                MessageBox.Show("Ingrese un valor superior a Cero (0)", "Advertencia");
                //txthorastrabajadas.Text = "1";              
                txtStandar.Focus();
                return;
            }
            else
            {
                sStandar = this.txtStandar.Text;
                txtpreciounitario.Text = String.Format("{0:0.######}" ,Convert.ToString(Math.Round(Convert.ToDecimal(this.txtJornal.Text) / Convert.ToDecimal(sStandar),6)));
                this.txtStandarExtra.Enabled = true;
                this.txtStandarExtra.Text = this.txtStandar.Text;
                this.txtStandarExtra.Focus();                
            }
        }

        private void txtStandarExtra_Leave(object sender, EventArgs e)
        {
            if (this.txtStandarExtra.Text == "" || this.txtStandarExtra.Text == "0")
            {
                MessageBox.Show("Ingrese un valor superior a Cero (0)", "Advertencia");
                //txthorastrabajadas.Text = "1";              
                txtStandarExtra.Focus();
                return;
            }
            else
            {
                txtprecioUnitarioExtra.Enabled = true;
                txtprecioUnitarioExtra.Focus();
            }
        }

        private void txtprecioUnitarioExtra_Leave(object sender, EventArgs e)
        {
            if (this.txtprecioUnitarioExtra.Text == "" || this.txtprecioUnitarioExtra.Text == "0")
            {
                MessageBox.Show("Ingrese un valor superior a Cero (0)", "Advertencia");
                //txthorastrabajadas.Text = "1";              
                txtprecioUnitarioExtra.Focus();
                return;
            }
            else
            {
                txtporcentaje1erdia.Enabled = true;
                txtporcentaje1erdia.Focus();
            }
        }

        private void txtporcentaje1erdia_Leave(object sender, EventArgs e)
        {
            string sporcentaje1erdia;
            if (this.txtporcentaje1erdia.Text == "" || this.txtporcentaje1erdia.Text == "0")
            {
                MessageBox.Show("Ingrese un valor superior a Cero (0)", "Advertencia");                         
                txtporcentaje1erdia.Focus();
                return;
            }
            else
            {
                sporcentaje1erdia = this.txtporcentaje1erdia.Text;              
                txtestandar1erdia.Text =  String.Format("{0:0.00}" , Convert.ToString (Math.Round(Convert.ToDecimal(this.txtStandar.Text) * Convert.ToDecimal(sporcentaje1erdia),2) / 100)) ;
                txtpreciounitario1erdia.Text = String.Format("{0:0.######}", Convert.ToString(Math.Round(Convert.ToDecimal(this.txtJornal.Text) / Convert.ToDecimal(txtestandar1erdia.Text), 6)));
                //txtpreciounitario1erdia.Text = Convert.ToString(Convert.ToDecimal(this.txtJornal.Text) / Convert.ToDecimal(txtestandar1erdia.Text));
                txtporcentaje2dodia.Enabled = true;
                txtporcentaje2dodia.Focus();
            }
        }

        private void txtporcentaje2dodia_Leave(object sender, EventArgs e)
        {
            string sporcentaje2dodia;
            if (this.txtporcentaje2dodia.Text == "" || this.txtporcentaje2dodia.Text == "0")
            {
                MessageBox.Show("Ingrese un valor superior a Cero (0)", "Advertencia");            
                txtporcentaje2dodia.Focus();
            }
            else
            {
                sporcentaje2dodia = this.txtporcentaje2dodia.Text;
                txtestandar2dodia.Text = String.Format("{0:0.00}", Convert.ToString(Math.Round(Convert.ToDecimal(this.txtStandar.Text) * Convert.ToDecimal(sporcentaje2dodia), 2) / 100));
                txtpreciounitario2dodia.Text = String.Format("{0:0.######}", Convert.ToString(Math.Round(Convert.ToDecimal(this.txtJornal.Text) / Convert.ToDecimal(txtestandar2dodia.Text), 6)));
           }
        }
        #endregion

        private void dtkFechaFin_Leave(object sender, EventArgs e)
        {
            if (this.dtkFechaInicio.Value > this.dtkFechaFin.Value)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha Final", "Validación");
                return;
            }
            else
            { 
            }
        }

    }
}
