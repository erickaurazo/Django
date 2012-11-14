using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mantenimientoStandares.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace mantenimientoStandares.AccesoaDatos
{
    public class AreaAD
    {

        public List<Area> Listar()
        {
            SqlConnection conexion = new SqlConnection("Data Source=(local) ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            //SqlConnection conexion = new SqlConnection(@"Data Source=HRUIZS\SQLEXPRESS ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "pa_listarAreadeProceso";
            comando.CommandTimeout = 0;

            List<Area> areas = new List<Area>();

            try
            {
                conexion.Open();

                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);

                while (datos.Read())
                {
                    Area area = new Area();

                    area.idarea = datos.GetString(datos.GetOrdinal("idarea"));
                    if (area.idarea != null && area.idarea.Length > 2)
                        {
                            area.idarea = !datos.IsDBNull(datos.GetOrdinal("idarea")) ? datos.GetString(datos.GetOrdinal("idarea")).Substring(0, 2).Trim() : null;
                        }
                    else
                        {
                            area.idarea = !datos.IsDBNull(datos.GetOrdinal("idarea")) ? datos.GetString(datos.GetOrdinal("idarea")).Trim() : null;
                        }

                    area.descripcion = datos.GetString(datos.GetOrdinal("descripcion"));
                    if (area.descripcion != null && area.descripcion.Length > 70)
                        {
                            area.descripcion = !datos.IsDBNull(datos.GetOrdinal("descripcion")) ? datos.GetString(datos.GetOrdinal("descripcion")).Substring(0, 70).Trim() : null;
                        }
                    else
                        {
                            area.descripcion = !datos.IsDBNull(datos.GetOrdinal("descripcion")) ? datos.GetString(datos.GetOrdinal("descripcion")).Trim() : null;
                        }

                    areas.Add(area);
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

            return areas;
        }

    }
}
