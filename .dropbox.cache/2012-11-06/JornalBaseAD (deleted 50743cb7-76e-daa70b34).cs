using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mantenimientoStandares.Entidades;
using System.Data.SqlClient;
using System.Data;

namespace mantenimientoStandares.AccesoaDatos
{
    public class JornalBaseAD
    {


        public List<Jornal> ListarJornalTop()
        {
            SqlConnection conexion = new SqlConnection("Data Source=(local) ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            //SqlConnection conexion = new SqlConnection(@"Data Source=HRUIZS\SQLEXPRESS ;Initial Catalog=BdSanJuanEficienciaPlanta; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "pa_selecionarJornalBase";
            comando.CommandTimeout = 0;

            List<Jornal> jornales = new List<Jornal>();

            try
            {
                conexion.Open();

                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);

                while (datos.Read())
                {
                    Jornal jornal = new Jornal();
                    jornal.jornalbase = !datos.IsDBNull(datos.GetOrdinal("JornalBasico")) ? datos.GetDecimal(datos.GetOrdinal("JornalBasico")) : (decimal?)null;

                   
                    jornales.Add(jornal);
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

            return jornales;
        }


    }
}
