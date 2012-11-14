using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mantenimientoStandares.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace mantenimientoStandares.AccesoaDatos
{
    public class StandarAD
    {
        public int Insertar(Standar standar)
        {
            SqlConnection conexion = new SqlConnection("Data Source=(local) ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            //SqlConnection conexion = new SqlConnection(@"Data Source=HRUIZS\SQLEXPRESS ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "pa_insertarStandar";
            comando.CommandTimeout = 0;
            Util.AgregarParametro(ref comando, "@IdEstandar", ParameterDirection.Output, SqlDbType.Int, null);
            Util.AgregarParametro(ref comando, "@idarea", ParameterDirection.Input, SqlDbType.NVarChar, 2, standar.IdArea);
            Util.AgregarParametro(ref comando, "@HorasTrabajadas", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.HorasTrabajadas);
            Util.AgregarParametro(ref comando, "@Estandar", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.Estandar);
            Util.AgregarParametro(ref comando, "@EstandarExtra", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarExtra);
            Util.AgregarParametro(ref comando, "@Jornal", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.Jornal);
            Util.AgregarParametro(ref comando, "@PrecioUnitario", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.PrecioUnitario);
            Util.AgregarParametro(ref comando, "@PrecioUnitarioExtra", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.PrecioUnitarioExtra);
            Util.AgregarParametro(ref comando, "@UserDecimal01", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.UserDecimal01);
            Util.AgregarParametro(ref comando, "@UserVarchar01", ParameterDirection.Input, SqlDbType.VarChar,50, standar.UserVarchar01);
            Util.AgregarParametro(ref comando, "@FechaInicio", ParameterDirection.Input, SqlDbType.DateTime, standar.FechaInicio);
            Util.AgregarParametro(ref comando, "@FechaFinal", ParameterDirection.Input, SqlDbType.DateTime, standar.FechaInicio);
            Util.AgregarParametro(ref comando, "@IdFormato", ParameterDirection.Input, SqlDbType.Char, 2, standar.IdFormato);
            Util.AgregarParametro(ref comando, "@EstandarPorcentajePrimerDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarPorcentajePrimerDia);
            Util.AgregarParametro(ref comando, "@EstandarPorcentajeSegundoDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarPorcentajeSegundoDia);
            Util.AgregarParametro(ref comando, "@EstandarPrimerDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarPrimerDia);
            Util.AgregarParametro(ref comando, "@EstandarSegundoDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarSegundoDia);
            Util.AgregarParametro(ref comando, "@PrecioPrimerDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.PrecioPrimerDia);
            Util.AgregarParametro(ref comando, "@PrecioSegundoDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.PrecioSegundoDia);
            int IdStandar = -1;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                IdStandar = Convert.ToInt32(comando.Parameters["@IdEstandar"].Value);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Dispose();
            }
            return IdStandar;
        }

        public int Actualizar(Standar standar)
        {
            SqlConnection conexion = new SqlConnection("Data Source=(local) ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            //SqlConnection conexion = new SqlConnection(@"Data Source=HRUIZS\SQLEXPRESS ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "pa_actualizarStandar";
            comando.CommandTimeout = 0;
            Util.AgregarParametro(ref comando, "@IdEStandar", ParameterDirection.Input, SqlDbType.Int, standar.IdStandar);
            Util.AgregarParametro(ref comando, "@idarea", ParameterDirection.Input, SqlDbType.NVarChar, 2, standar.IdArea);
            Util.AgregarParametro(ref comando, "@HorasTrabajadas", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.HorasTrabajadas);
            Util.AgregarParametro(ref comando, "@Estandar", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.Estandar);
            Util.AgregarParametro(ref comando, "@EstandarExtra", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarExtra);
            Util.AgregarParametro(ref comando, "@Jornal", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.Jornal);
            Util.AgregarParametro(ref comando, "@PrecioUnitario", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.PrecioUnitario);
            Util.AgregarParametro(ref comando, "@PrecioUnitarioExtra", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.PrecioUnitarioExtra);
            Util.AgregarParametro(ref comando, "@UserDecimal01", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.UserDecimal01);
            Util.AgregarParametro(ref comando, "@UserVarchar01", ParameterDirection.Input, SqlDbType.VarChar, 50, standar.UserVarchar01);
            Util.AgregarParametro(ref comando, "@FechaInicio", ParameterDirection.Input, SqlDbType.DateTime, standar.FechaInicio);
            Util.AgregarParametro(ref comando, "@FechaFinal", ParameterDirection.Input, SqlDbType.DateTime, standar.FechaInicio);
            Util.AgregarParametro(ref comando, "@IdFormato", ParameterDirection.Input, SqlDbType.Char, 2, standar.IdFormato);
            Util.AgregarParametro(ref comando, "@EstandarPorcentajePrimerDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarPorcentajePrimerDia);
            Util.AgregarParametro(ref comando, "@EstandarPorcentajeSegundoDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarPorcentajeSegundoDia);
            Util.AgregarParametro(ref comando, "@EstandarPrimerDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarPrimerDia);
            Util.AgregarParametro(ref comando, "@EstandarSegundoDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 2, standar.EstandarSegundoDia);
            Util.AgregarParametro(ref comando, "@PrecioPrimerDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.PrecioPrimerDia);
            Util.AgregarParametro(ref comando, "@PrecioSegundoDia", ParameterDirection.Input, SqlDbType.Decimal, 17, 6, standar.PrecioSegundoDia);
            int IdStandar = -1;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                IdStandar = Convert.ToInt32(comando.Parameters["@IdEStandar"].Value);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
                conexion.Dispose();
            }
            return IdStandar;
        }

        public List<Standar> Verificar_duplicidad_Estandar(string IdArea, DateTime FechaInicio)
        {
            SqlConnection conexion = new SqlConnection("Data Source=(local) ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            //SqlConnection conexion = new SqlConnection(@"Data Source=HRUIZS\SQLEXPRESS ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "pa_verificarStandar";
            comando.CommandTimeout = 0;
            Util.AgregarParametro(ref comando, "@idarea", ParameterDirection.Input, SqlDbType.NVarChar, 2, IdArea);
            Util.AgregarParametro(ref comando, "@fechainico", ParameterDirection.Input, SqlDbType.DateTime, FechaInicio);
            List<Standar> standars = new List<Standar>();
             try
                {
                    conexion.Open();
                    SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);

                    while (datos.Read())
                        {
                        Standar standar = new Standar();
                        standar.IdArea = datos.GetString(datos.GetOrdinal("IdArea"));
                        standars.Add(standar);
                        }

                datos.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();

                conexion.Dispose();
            }

            return standars;
        }
    }
}
