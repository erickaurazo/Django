using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rSunat.ReportesSunat.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace rSunat.ReportesSunat.AccesoDatos
{
    public class LibroDiarioAD
    {
        public List<LibroDiario> ListarLibroDiario(string c_emp, string c_desde, string c_hasta, string c_mon, string c_tipo,  int c_grupo)
        {
            //SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=bdsjprueba; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            //bdsjprueba
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "RPTLIBRO_DIARIO";
            comando.CommandTimeout = 0;
            Util.AgregarParametro(ref comando, "@c_emp", ParameterDirection.Input, SqlDbType.NVarChar, 3, c_emp);
            Util.AgregarParametro(ref comando, "@c_desde", ParameterDirection.Input, SqlDbType.NVarChar, 10, c_desde);
            Util.AgregarParametro(ref comando, "@c_hasta", ParameterDirection.Input, SqlDbType.NVarChar, 10, c_hasta);
            Util.AgregarParametro(ref comando, "@c_mon", ParameterDirection.Input, SqlDbType.NVarChar, 1, c_mon);
            Util.AgregarParametro(ref comando, "@c_tipo", ParameterDirection.Input, SqlDbType.NVarChar, 12, c_tipo);
            //Util.AgregarParametro(ref comando, "@c_grupo", ParameterDirection.Input, SqlDbType.NVarChar, 12, c_grupo);
            Util.AgregarParametro(ref comando, "@c_grupo", ParameterDirection.Input, SqlDbType.Int, 1, c_grupo);
            List<LibroDiario> librosDiario = new List<LibroDiario>();
            try
            {
                conexion.Open();
                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);
                while (datos.Read())
                {
                    LibroDiario libroDiario = new LibroDiario();
                    //Operador ? :
                    //variable = condicion ? valor_verdadero : valor_falso;

                    ////libroDiario.DMES = "01/01/2010";
                    ////02 CARACTERES
                    libroDiario.DMES = !datos.IsDBNull(datos.GetOrdinal("fecha")) ? String.Format("{0:MM}", datos.GetDateTime(datos.GetOrdinal("fecha"))) : null; ;

                    //libroDiario.DMES = !datos.IsDBNull(datos.GetOrdinal("fecha")) ? datos.GetString(datos.GetOrdinal("fecha")).Trim() : null;
                    //if (libroDiario.DMES != null )
                    //{
                    //    libroDiario.DMES = (!datos.IsDBNull(datos.GetOrdinal("fecha")) ? datos.GetString(datos.GetOrdinal("fecha")).Trim() : null);
                    //}
                    //else
                    //{
                    //     libroDiario.DMES = !datos.IsDBNull(datos.GetOrdinal("fecha")) ? String.Format("{0:MM}", datos.GetDateTime(datos.GetOrdinal("fecha"))) : null; ;

                    //}

                    //libroDiario.DNUMASIOPE = "";
                    //HASTA 15 CARACTERES
                    libroDiario.DNUMASIOPE = !datos.IsDBNull(datos.GetOrdinal("operacion")) ? datos.GetString(datos.GetOrdinal("operacion")).Trim() : null;
                    if (libroDiario.DNUMASIOPE != null && libroDiario.DNUMASIOPE.Length > 15)
                    {
                        libroDiario.DNUMASIOPE = !datos.IsDBNull(datos.GetOrdinal("operacion")) ? datos.GetString(datos.GetOrdinal("operacion")).Substring(0, 15).Trim() : null;
                    }
                    else
                    {
                        libroDiario.DNUMASIOPE = !datos.IsDBNull(datos.GetOrdinal("operacion")) ? datos.GetString(datos.GetOrdinal("operacion")).Trim() : null;
                    }

                    //libroDiario.DNUMCTACON = "";
                    //HASTA 24 CARACTERES
                    libroDiario.DNUMCTACON = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")).Trim() : null;
                    if (libroDiario.DNUMCTACON != null && libroDiario.DNUMCTACON.Length > 24)
                    {
                        libroDiario.DNUMCTACON = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")).Substring(0, 24).Trim() : null;
                    }
                    else
                    {
                        libroDiario.DNUMCTACON = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")).Trim() : null;
                    }


                    //10 CARACTERES EN FORMATO DD/MM/AAAA
                    libroDiario.DFECOPE = !datos.IsDBNull(datos.GetOrdinal("fecha")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("fecha"))) : null; ;


                    //HASTA 100 CARACTERES
                    //libroDiario.DGLOSA = "";
                    libroDiario.DGLOSA = !datos.IsDBNull(datos.GetOrdinal("denominacion")) ? datos.GetString(datos.GetOrdinal("denominacion")).Trim() : null;
                    if (libroDiario.DGLOSA != null && libroDiario.DGLOSA.Length > 100)
                    {
                        libroDiario.DGLOSA = !datos.IsDBNull(datos.GetOrdinal("denominacion")) ? datos.GetString(datos.GetOrdinal("denominacion")).Substring(0, 100).Trim() : null;
                    }
                    else
                    {
                        libroDiario.DGLOSA = !datos.IsDBNull(datos.GetOrdinal("denominacion")) ? datos.GetString(datos.GetOrdinal("denominacion")).Trim() : null;
                    }

                    ////HASTA 10 CARACTERES
                    libroDiario.DCENCOS = "";
                    //libroDiario.DCENCOS = !datos.IsDBNull(datos.GetOrdinal("dcencos")) ? datos.GetString(datos.GetOrdinal("dcencos")).Trim() : null;
                    //if (libroDiario.DCENCOS != null && libroDiario.DCENCOS.Length > 10)
                    //{
                    //    libroDiario.DCENCOS = !datos.IsDBNull(datos.GetOrdinal("dcencos")) ? datos.GetString(datos.GetOrdinal("dcencos")).Substring(0, 10).Trim() : null;
                    //}
                    //else
                    //{
                    //    libroDiario.DCENCOS = !datos.IsDBNull(datos.GetOrdinal("dcencos")) ? datos.GetString(datos.GetOrdinal("dcencos")).Trim() : null;
                    //}


                    //NUMERICO CON 02 DECIMALES
                    // kardex.KCOSING = !datos.IsDBNull(datos.GetOrdinal("TCAMBIO")) ? String.Format("{0:0.########}", datos.GetDecimal(datos.GetOrdinal("TCAMBIO"))) : null; ;

                    libroDiario.DDEBE = !datos.IsDBNull(datos.GetOrdinal("debe")) ? String.Format("{0:0.##}", datos.GetDecimal(datos.GetOrdinal("debe"))) : null;
                    if (libroDiario.DDEBE == "0.00")
                    {
                        libroDiario.DDEBE = "0";
                    }
                    else
                    {
                        libroDiario.DDEBE = !datos.IsDBNull(datos.GetOrdinal("debe")) ? String.Format("{0:0.00}", datos.GetDecimal(datos.GetOrdinal("debe"))) : null;
                    }

                    //NUMERICO CON 02 DECIMALES
                    libroDiario.DHABER = !datos.IsDBNull(datos.GetOrdinal("haber")) ? String.Format("{0:0.00}", datos.GetDecimal(datos.GetOrdinal("haber"))) : null;
                    if (libroDiario.DHABER == "0.00")
                    {
                        libroDiario.DHABER = "0";
                    }
                    else
                    {
                        libroDiario.DHABER = !datos.IsDBNull(datos.GetOrdinal("haber")) ? String.Format("{0:0.00}", datos.GetDecimal(datos.GetOrdinal("haber"))) : null;
                    }

                    //HASTA 20 CARACTERES
                    libroDiario.DINTREG = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroDiario.DINTREG != null && libroDiario.DINTREG.Length > 20)
                    {
                        libroDiario.DINTREG = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroDiario.DINTREG = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }

                    
                    //HASTA 20 CARACTERES
                    libroDiario.DINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroDiario.DINTKARDEX != null && libroDiario.DINTKARDEX.Length > 20)
                    {
                        libroDiario.DINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroDiario.DINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }

 
                    //HASTA 20 CARACTERES
                    libroDiario.DINTVTACOM = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroDiario.DINTVTACOM != null && libroDiario.DINTVTACOM.Length > 20)
                    {
                        libroDiario.DINTVTACOM = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroDiario.DINTVTACOM = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }


                    //HASTA 20 CARACTERES
                    libroDiario.DINTREG2 = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroDiario.DINTREG2 != null && libroDiario.DINTREG2.Length > 20)
                    {
                        libroDiario.DINTREG2 = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroDiario.DINTREG2 = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }
                    
                    librosDiario.Add(libroDiario);                   
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

            return librosDiario;
        }
    
    }
}
