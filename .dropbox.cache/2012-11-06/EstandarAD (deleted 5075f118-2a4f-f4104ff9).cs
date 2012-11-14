using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mantenimientoStandares.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace mantenimientoStandares.AccesoaDatos
{
    public class EstandarAD
    {

        public List<Estandares> Listar()
        {
            SqlConnection conexion = new SqlConnection("Data Source=(local) ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            //SqlConnection conexion = new SqlConnection(@"Data Source=HRUIZS\SQLEXPRESS ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "pa_listarEstandares";
            comando.CommandTimeout = 0;

            List<Estandares> standars = new List<Estandares>();

            try
            {
                conexion.Open();

                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);

                while (datos.Read())
                {
                    Estandares standar = new Estandares();

                    standar.IdEstandar = !datos.IsDBNull(datos.GetOrdinal("IdEstandar")) ? datos.GetInt32(datos.GetOrdinal("IdEstandar")) : (Int32?) null;
                    standar.HorasTrabajadas = !datos.IsDBNull(datos.GetOrdinal("HorasTrabajadas")) ? datos.GetDecimal(datos.GetOrdinal("HorasTrabajadas")) : (decimal?)null;

                    standar.oArea = datos.GetString(datos.GetOrdinal("oArea"));

                    standar.Estandar = !datos.IsDBNull(datos.GetOrdinal("Estandar")) ? datos.GetDecimal(datos.GetOrdinal("Estandar")) : (decimal?)null;

                    standar.EstandarExtra = !datos.IsDBNull(datos.GetOrdinal("EstandarExtra")) ? datos.GetDecimal(datos.GetOrdinal("EstandarExtra")) : (decimal?)null;
                    standar.Jornal = !datos.IsDBNull(datos.GetOrdinal("Jornal")) ? datos.GetDecimal(datos.GetOrdinal("Jornal")) : (decimal?)null;

                    standar.PrecioUnitario = !datos.IsDBNull(datos.GetOrdinal("PrecioUnitario")) ? datos.GetDecimal(datos.GetOrdinal("PrecioUnitario")) : (decimal?)null;
                    standar.PrecioUnitarioExtra = !datos.IsDBNull(datos.GetOrdinal("PrecioUnitarioExtra")) ? datos.GetDecimal(datos.GetOrdinal("PrecioUnitarioExtra")) : (decimal?)null;

                    standar.UserDecimal01 = !datos.IsDBNull(datos.GetOrdinal("UserDecimal01")) ? datos.GetDecimal(datos.GetOrdinal("UserDecimal01")) : (decimal?)null;

                    standar.UserVarchar01 = datos.GetString(datos.GetOrdinal("UserVarchar01"));
                    if (standar.UserVarchar01 != null && standar.UserVarchar01.Length > 100)
                    {
                        standar.UserVarchar01 = !datos.IsDBNull(datos.GetOrdinal("UserVarchar01")) ? datos.GetString(datos.GetOrdinal("UserVarchar01")).Substring(0, 100).Trim() : null;
                    }
                    else
                    {
                        standar.UserVarchar01 = !datos.IsDBNull(datos.GetOrdinal("UserVarchar01")) ? datos.GetString(datos.GetOrdinal("UserVarchar01")).Trim() : null;
                    }

                    standar.FechaInicio = datos.GetDateTime(datos.GetOrdinal("FechaInicio"));
                    standar.FechaFinal = datos.GetDateTime(datos.GetOrdinal("FechaFinal"));


                    standar.oFormato = datos.GetString(datos.GetOrdinal("oFormato"));


                    //standar.IdFormato = !datos.IsDBNull(datos.GetOrdinal("IdFormato")) ? datos.GetString(datos.GetOrdinal("IdFormato")) : null;
                    standar.EstandarPorcentajePrimerDia = !datos.IsDBNull(datos.GetOrdinal("EstandarPorcentajePrimerDia")) ? datos.GetDecimal(datos.GetOrdinal("EstandarPorcentajePrimerDia")) : (decimal?)null;

                    standar.EstandarPorcentajeSegundoDia = !datos.IsDBNull(datos.GetOrdinal("EstandarPorcentajeSegundoDia")) ? datos.GetDecimal(datos.GetOrdinal("EstandarPorcentajeSegundoDia")) : (decimal?)null;
                    standar.EstandarPrimerDia = !datos.IsDBNull(datos.GetOrdinal("EstandarPrimerDia")) ? datos.GetDecimal(datos.GetOrdinal("EstandarPrimerDia")) : (decimal?)null;

                    standar.EstandarSegundoDia = !datos.IsDBNull(datos.GetOrdinal("EstandarSegundoDia")) ? datos.GetDecimal(datos.GetOrdinal("EstandarSegundoDia")) : (decimal?)null;
                    standar.PrecioPrimerDia = !datos.IsDBNull(datos.GetOrdinal("PrecioPrimerDia")) ? datos.GetDecimal(datos.GetOrdinal("PrecioPrimerDia")) : (decimal?)null;
                    standar.PrecioSegundoDia = !datos.IsDBNull(datos.GetOrdinal("PrecioSegundoDia")) ? datos.GetDecimal(datos.GetOrdinal("PrecioSegundoDia")) : (decimal?)null;

                    standar.idArea = datos.GetString(datos.GetOrdinal("IdArea"));
                    standar.idFormato = datos.GetString(datos.GetOrdinal("IdFormato"));


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


        public List<Estandares> LimpiarEstandares()
        {
            SqlConnection conexion = new SqlConnection("Data Source=(local) ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            //SqlConnection conexion = new SqlConnection(@"Data Source=HRUIZS\SQLEXPRESS ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "pa_limpiarEstandares";
            comando.CommandTimeout = 0;

            List<Estandares> standars = new List<Estandares>();

            try
            {
                conexion.Open();

                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);

                while (datos.Read())
                {
                    Estandares standar = new Estandares();

                    standar.IdEstandar = !datos.IsDBNull(datos.GetOrdinal("IdEstandar")) ? datos.GetInt32(datos.GetOrdinal("IdEstandar")) : (Int32?)null;
                    standar.HorasTrabajadas = !datos.IsDBNull(datos.GetOrdinal("HorasTrabajadas")) ? datos.GetDecimal(datos.GetOrdinal("HorasTrabajadas")) : (decimal?)null;

                    standar.oArea = datos.GetString(datos.GetOrdinal("oArea"));

                    standar.Estandar = !datos.IsDBNull(datos.GetOrdinal("Estandar")) ? datos.GetDecimal(datos.GetOrdinal("Estandar")) : (decimal?)null;

                    standar.EstandarExtra = !datos.IsDBNull(datos.GetOrdinal("EstandarExtra")) ? datos.GetDecimal(datos.GetOrdinal("EstandarExtra")) : (decimal?)null;
                    standar.Jornal = !datos.IsDBNull(datos.GetOrdinal("Jornal")) ? datos.GetDecimal(datos.GetOrdinal("Jornal")) : (decimal?)null;

                    standar.PrecioUnitario = !datos.IsDBNull(datos.GetOrdinal("PrecioUnitario")) ? datos.GetDecimal(datos.GetOrdinal("PrecioUnitario")) : (decimal?)null;
                    standar.PrecioUnitarioExtra = !datos.IsDBNull(datos.GetOrdinal("PrecioUnitarioExtra")) ? datos.GetDecimal(datos.GetOrdinal("PrecioUnitarioExtra")) : (decimal?)null;

                    standar.UserDecimal01 = !datos.IsDBNull(datos.GetOrdinal("UserDecimal01")) ? datos.GetDecimal(datos.GetOrdinal("UserDecimal01")) : (decimal?)null;

                    standar.UserVarchar01 = datos.GetString(datos.GetOrdinal("UserVarchar01"));
                    if (standar.UserVarchar01 != null && standar.UserVarchar01.Length > 100)
                    {
                        standar.UserVarchar01 = !datos.IsDBNull(datos.GetOrdinal("UserVarchar01")) ? datos.GetString(datos.GetOrdinal("UserVarchar01")).Substring(0, 100).Trim() : null;
                    }
                    else
                    {
                        standar.UserVarchar01 = !datos.IsDBNull(datos.GetOrdinal("UserVarchar01")) ? datos.GetString(datos.GetOrdinal("UserVarchar01")).Trim() : null;
                    }

                    standar.FechaInicio = datos.GetDateTime(datos.GetOrdinal("FechaInicio"));
                    standar.FechaFinal = datos.GetDateTime(datos.GetOrdinal("FechaFinal"));


                    standar.oFormato = datos.GetString(datos.GetOrdinal("oFormato"));


                    //standar.IdFormato = !datos.IsDBNull(datos.GetOrdinal("IdFormato")) ? datos.GetString(datos.GetOrdinal("IdFormato")) : null;
                    standar.EstandarPorcentajePrimerDia = !datos.IsDBNull(datos.GetOrdinal("EstandarPorcentajePrimerDia")) ? datos.GetDecimal(datos.GetOrdinal("EstandarPorcentajePrimerDia")) : (decimal?)null;

                    standar.EstandarPorcentajeSegundoDia = !datos.IsDBNull(datos.GetOrdinal("EstandarPorcentajeSegundoDia")) ? datos.GetDecimal(datos.GetOrdinal("EstandarPorcentajeSegundoDia")) : (decimal?)null;
                    standar.EstandarPrimerDia = !datos.IsDBNull(datos.GetOrdinal("EstandarPrimerDia")) ? datos.GetDecimal(datos.GetOrdinal("EstandarPrimerDia")) : (decimal?)null;

                    standar.EstandarSegundoDia = !datos.IsDBNull(datos.GetOrdinal("EstandarSegundoDia")) ? datos.GetDecimal(datos.GetOrdinal("EstandarSegundoDia")) : (decimal?)null;
                    standar.PrecioPrimerDia = !datos.IsDBNull(datos.GetOrdinal("PrecioPrimerDia")) ? datos.GetDecimal(datos.GetOrdinal("PrecioPrimerDia")) : (decimal?)null;
                    standar.PrecioSegundoDia = !datos.IsDBNull(datos.GetOrdinal("PrecioSegundoDia")) ? datos.GetDecimal(datos.GetOrdinal("PrecioSegundoDia")) : (decimal?)null;

                    standar.idArea = datos.GetString(datos.GetOrdinal("IdArea"));
                    standar.idFormato = datos.GetString(datos.GetOrdinal("IdFormato"));


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
