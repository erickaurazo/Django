using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mantenimientoStandares.Entidades;
using System.Data;
using System.Data.SqlClient;


namespace mantenimientoStandares.AccesoaDatos
{
    public class FormatoAD
    {

        public List<Formato> Listar()
        {
            SqlConnection conexion = new SqlConnection("Data Source=(local) ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            //SqlConnection conexion = new SqlConnection(@"Data Source=HRUIZS\SQLEXPRESS ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "pa_listarFormatos";
            comando.CommandTimeout = 0;

            List<Formato> formatos = new List<Formato>();

            try
            {
                conexion.Open();

                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);

                while (datos.Read())
                {
                    Formato formato = new Formato();

                    formato.idFormato = datos.GetString(datos.GetOrdinal("idFormato"));
                    if (formato.idFormato != null && formato.idFormato.Length > 2)
                    {
                        formato.idFormato = !datos.IsDBNull(datos.GetOrdinal("idFormato")) ? datos.GetString(datos.GetOrdinal("idFormato")).Substring(0, 2).Trim() : null;
                    }
                    else
                    {
                        formato.idFormato = !datos.IsDBNull(datos.GetOrdinal("idFormato")) ? datos.GetString(datos.GetOrdinal("idFormato")).Trim() : null;
                    }

                    formato.descripcion = datos.GetString(datos.GetOrdinal("descripcion"));
                    if (formato.descripcion != null && formato.descripcion.Length > 70)
                    {
                        formato.descripcion = !datos.IsDBNull(datos.GetOrdinal("descripcion")) ? datos.GetString(datos.GetOrdinal("descripcion")).Substring(0, 70).Trim() : null;
                    }
                    else
                    {
                        formato.descripcion = !datos.IsDBNull(datos.GetOrdinal("descripcion")) ? datos.GetString(datos.GetOrdinal("descripcion")).Trim() : null;
                    }

                    formatos.Add(formato);
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

            return formatos;
        }

    }
}
