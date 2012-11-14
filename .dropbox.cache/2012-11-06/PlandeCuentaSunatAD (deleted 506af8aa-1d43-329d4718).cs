using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rSunat.ReportesSunat.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace rSunat.ReportesSunat.AccesoDatos
{
   public class PlandeCuentaSunatAD
    {
       public List<PlandeCuentaSunat> ListarPlanxCuenta(string oCuenta)
       {
           SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
           SqlCommand comando = conexion.CreateCommand();
           comando.CommandType = CommandType.StoredProcedure;
           comando.CommandText = "pa_listarPlandeCuentasxCuenta";
           comando.CommandTimeout = 0;
           Util.AgregarParametro(ref comando, "@cuenta", ParameterDirection.Input, SqlDbType.NVarChar, 20, oCuenta);
           List<PlandeCuentaSunat> plandecuentasSunat = new List<PlandeCuentaSunat>();
           try
           {
               conexion.Open();
               SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);
               while (datos.Read())
               {
                   PlandeCuentaSunat oPlandeCuenaSunat = new PlandeCuentaSunat();
                   oPlandeCuenaSunat.cuenta = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")) : null; ;
                   oPlandeCuenaSunat.descripcion = !datos.IsDBNull(datos.GetOrdinal("descripcion")) ? datos.GetString(datos.GetOrdinal("descripcion")) : null; ;
                   plandecuentasSunat.Add(oPlandeCuenaSunat);
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

           return plandecuentasSunat;
       }

       public List<PlandeCuentaSunat> ListarPlanxDescripcion(string oDescripcion)
       {
           SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
           SqlCommand comando = conexion.CreateCommand();
           comando.CommandType = CommandType.StoredProcedure;
           comando.CommandText = "pa_listarPlandeCuentasxDescripcion";
           comando.CommandTimeout = 0;
           Util.AgregarParametro(ref comando, "@descripcion", ParameterDirection.Input, SqlDbType.NVarChar, 20, oDescripcion);


           List<PlandeCuentaSunat> plandecuentasSunat = new List<PlandeCuentaSunat>();
           try
           {
               conexion.Open();
               SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);
               while (datos.Read())
               {
                   PlandeCuentaSunat oPlandeCuenaSunat = new PlandeCuentaSunat();
                   //Operador ? :
                   //variable = condicion ? valor_verdadero : valor_falso;
                   //de 02 caracteres
                   oPlandeCuenaSunat.cuenta = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")) : null; ;
                   oPlandeCuenaSunat.descripcion = !datos.IsDBNull(datos.GetOrdinal("descripcion")) ? datos.GetString(datos.GetOrdinal("descripcion")) : null; ;
                   plandecuentasSunat.Add(oPlandeCuenaSunat);
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

           return plandecuentasSunat;
       }


       public List<PlandeCuentaSunat> ListarCuentaMaximaMinima()
       {
           SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
           SqlCommand comando = conexion.CreateCommand();
           comando.CommandType = CommandType.StoredProcedure;
           comando.CommandText = "pa_listarCuentaMinimaMaxima";
           comando.CommandTimeout = 0;
          
           List<PlandeCuentaSunat> plandecuentasSunat = new List<PlandeCuentaSunat>();
           try
           {
               conexion.Open();
               SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);
               while (datos.Read())
               {
                   PlandeCuentaSunat oPlandeCuenaSunat = new PlandeCuentaSunat();
                   //Operador ? :
                   //variable = condicion ? valor_verdadero : valor_falso;
                   //de 02 caracteres
                   oPlandeCuenaSunat.cuenta = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")) : null; ;
                   oPlandeCuenaSunat.descripcion = !datos.IsDBNull(datos.GetOrdinal("descripcion")) ? datos.GetString(datos.GetOrdinal("descripcion")) : null; ;
                   plandecuentasSunat.Add(oPlandeCuenaSunat);
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

           return plandecuentasSunat;
       }

       public List<PlandeCuentaSunat> ListarPlanxCuentaExacta(string oCuenta)
       {
           SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
           SqlCommand comando = conexion.CreateCommand();
           comando.CommandType = CommandType.StoredProcedure;
           comando.CommandText = "pa_listarPlandeCuentasxCuentaExacta";
           comando.CommandTimeout = 0;
           Util.AgregarParametro(ref comando, "@cuenta", ParameterDirection.Input, SqlDbType.NVarChar, 20, oCuenta);
           List<PlandeCuentaSunat> plandecuentasSunat = new List<PlandeCuentaSunat>();
           try
           {
               conexion.Open();
               SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);
               while (datos.Read())
               {
                   PlandeCuentaSunat oPlandeCuenaSunat = new PlandeCuentaSunat();
                   oPlandeCuenaSunat.cuenta = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")) : null; ;
                   oPlandeCuenaSunat.descripcion = !datos.IsDBNull(datos.GetOrdinal("descripcion")) ? datos.GetString(datos.GetOrdinal("descripcion")) : null; ;
                   plandecuentasSunat.Add(oPlandeCuenaSunat);
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

           return plandecuentasSunat;
       }
    }
}
