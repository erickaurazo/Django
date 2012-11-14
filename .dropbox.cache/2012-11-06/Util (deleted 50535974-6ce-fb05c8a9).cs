using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace rSunat.ReportesSunat.AccesoDatos
{
    public class Util
    {
        public static void AgregarParametro(ref SqlCommand comando, string nombre, ParameterDirection direccion ,  SqlDbType tipo, int longitud, object valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Direction = direccion;
            parametro.SqlDbType = tipo;
            parametro.Size = longitud;
            parametro.Value = valor;

            comando.Parameters.Add(parametro);
        }
        

        public static void AgregarParametro(ref SqlCommand comando, string nombre, ParameterDirection direccion, SqlDbType tipo, byte precision, byte escala, object valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Direction = direccion;
            parametro.SqlDbType = tipo;
            parametro.Precision = precision;
            parametro.Scale = escala;
            parametro.Value = valor;

            comando.Parameters.Add(parametro); 
        }
        
        public static void AgregarParametro(ref SqlCommand comando, string nombre, ParameterDirection direccion, SqlDbType tipo,object valor)
        {
            SqlParameter parametro = new SqlParameter();
            parametro.ParameterName = nombre;
            parametro.Direction = direccion;
            parametro.SqlDbType = tipo;
            parametro.Value = valor;

            comando.Parameters.Add(parametro);
        }
    }
}
