using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rSunat.ReportesSunat.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace rSunat.ReportesSunat.AccesoDatos
{
    public class KARDEXAD
    {

        public List<KARDEX> ListarKardex(string c_emp, string c_desde, string c_hasta, string c_mon, string c_tipo, string c_grupo)
        {
//            SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=bdsjprueba; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "RPT_KARDEX_SUNAT_SJ";
            comando.CommandTimeout = 0;

            Util.AgregarParametro(ref comando, "@c_emp", ParameterDirection.Input, SqlDbType.NVarChar, 3, c_emp);
            Util.AgregarParametro(ref comando, "@c_desde", ParameterDirection.Input, SqlDbType.NVarChar, 8, c_desde);
            Util.AgregarParametro(ref comando, "@c_hasta", ParameterDirection.Input, SqlDbType.NVarChar, 8, c_hasta);
            Util.AgregarParametro(ref comando, "@c_mon", ParameterDirection.Input, SqlDbType.NVarChar, 1, c_mon);
            Util.AgregarParametro(ref comando, "@c_tipo", ParameterDirection.Input, SqlDbType.NVarChar, 12, c_tipo);
            Util.AgregarParametro(ref comando, "@c_grupo", ParameterDirection.Input, SqlDbType.NVarChar, 12, c_grupo);

            List<KARDEX> kardexs = new List<KARDEX>();

            try
            {
                conexion.Open();

                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);

                while (datos.Read())
                {
                    KARDEX kardex = new KARDEX();
                    //Operador ? :
                    //variable = condicion ? valor_verdadero : valor_falso;

                    // 02 CARACTER
                    kardex.KMES = !datos.IsDBNull(datos.GetOrdinal("DMES")) ? datos.GetString(datos.GetOrdinal("DMES")).Trim() : null;
                  



                    // 07 CARACTER
                    kardex.KANEXO = !datos.IsDBNull(datos.GetOrdinal("KANEXO")) ? datos.GetString(datos.GetOrdinal("KANEXO")).Trim() : null;
                    if (kardex.KANEXO != null && kardex.KANEXO.Length>7)
                    {
                        kardex.KANEXO = !datos.IsDBNull(datos.GetOrdinal("KANEXO")) ? datos.GetString(datos.GetOrdinal("KANEXO")).Substring(0, 7).Trim() : null;
                    }
                    else
                    {
                        kardex.KANEXO = !datos.IsDBNull(datos.GetOrdinal("KANEXO")) ? datos.GetString(datos.GetOrdinal("KANEXO")).Trim() : null;
                    }
                    
                    

                    // 01 CARACTER
                    kardex.KCATALOGO = !datos.IsDBNull(datos.GetOrdinal("KCATALOGO")) ? datos.GetString(datos.GetOrdinal("KCATALOGO")).Trim() : null;
                    if (kardex.KCATALOGO != null && kardex.KCATALOGO.Length > 1)
                    {
                        kardex.KCATALOGO = !datos.IsDBNull(datos.GetOrdinal("KCATALOGO")) ? datos.GetString(datos.GetOrdinal("KCATALOGO")).Substring(0, 1).Trim() : null;
                    }
                    else
                    {
                        kardex.KCATALOGO = !datos.IsDBNull(datos.GetOrdinal("KCATALOGO")) ? datos.GetString(datos.GetOrdinal("KCATALOGO")).Trim() : null;
                    }


                    

                    // 2 CARACTERES
                    kardex.KTIPEXIST = !datos.IsDBNull(datos.GetOrdinal("KTIPEXIST")) ? datos.GetString(datos.GetOrdinal("KTIPEXIST")).Trim() : null;
                    if (kardex.KTIPEXIST != null && kardex.KTIPEXIST.Length > 2)
                    {
                        kardex.KTIPEXIST = !datos.IsDBNull(datos.GetOrdinal("KTIPEXIST")) ? datos.GetString(datos.GetOrdinal("KTIPEXIST")).Substring(0, 2).Trim() : null;
                    }
                    else
                    {
                        kardex.KTIPEXIST = !datos.IsDBNull(datos.GetOrdinal("KTIPEXIST")) ? datos.GetString(datos.GetOrdinal("KTIPEXIST")).Trim() : null;
                    }


                    // 24 CARACTERES
                    kardex.KCODEXIST = !datos.IsDBNull(datos.GetOrdinal("KCODEXIST")) ? datos.GetString(datos.GetOrdinal("KCODEXIST")).Trim() : null;
                    if (kardex.KCODEXIST != null && kardex.KCODEXIST.Length > 24)
                    {
                        kardex.KCODEXIST = !datos.IsDBNull(datos.GetOrdinal("KCODEXIST")) ? datos.GetString(datos.GetOrdinal("KCODEXIST")).Substring(0, 24).Trim() : null;
                    }
                    else
                    {
                        kardex.KCODEXIST = !datos.IsDBNull(datos.GetOrdinal("KCODEXIST")) ? datos.GetString(datos.GetOrdinal("KCODEXIST")).Trim() : null;
                    }



                    // 10 CARACTERES EN FORMATO FECHA
                    kardex.KFECDOC = !datos.IsDBNull(datos.GetOrdinal("KFECDOC")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("KFECDOC"))) : null; ;
                    if (kardex.KFECDOC != null && kardex.KFECDOC.Length > 10)
                    {
                        kardex.KFECDOC = !datos.IsDBNull(datos.GetOrdinal("KFECDOC")) ? datos.GetString(datos.GetOrdinal("KFECDOC")).Substring(0, 10).Trim() : null;
                    }
                    else
                    {
                        kardex.KFECDOC = !datos.IsDBNull(datos.GetOrdinal("KFECDOC")) ? datos.GetString(datos.GetOrdinal("KFECDOC")).Trim() : null;
                    }



                    //02 CARACTERES
                    kardex.KTIPDOC = !datos.IsDBNull(datos.GetOrdinal("KTIPDOC")) ? datos.GetString(datos.GetOrdinal("KTIPDOC")).Trim() : null;
                    if (kardex.KTIPDOC != null && kardex.KTIPDOC.Length > 2)
                    {
                        kardex.KTIPDOC = !datos.IsDBNull(datos.GetOrdinal("KTIPDOC")) ? datos.GetString(datos.GetOrdinal("KTIPDOC")).Substring(0, 2).Trim() : null;
                    }
                    else
                    {
                        kardex.KTIPDOC = !datos.IsDBNull(datos.GetOrdinal("KTIPDOC")) ? datos.GetString(datos.GetOrdinal("KTIPDOC")).Trim() : null;
                    }



                    // 20 CARACTERES
                    kardex.KSERDOC = !datos.IsDBNull(datos.GetOrdinal("KSERDOC")) ? datos.GetString(datos.GetOrdinal("KSERDOC")).Trim() : null;
                    if (kardex.KSERDOC != null && kardex.KSERDOC.Length > 20)
                    {
                        kardex.KSERDOC = !datos.IsDBNull(datos.GetOrdinal("KSERDOC")) ? datos.GetString(datos.GetOrdinal("KSERDOC")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        kardex.KSERDOC = !datos.IsDBNull(datos.GetOrdinal("KSERDOC")) ? datos.GetString(datos.GetOrdinal("KSERDOC")).Trim() : null;
                    } 


                    
                    // 20 CARACTERES
                    kardex.KNUMDOC = !datos.IsDBNull(datos.GetOrdinal("KNUMDOC")) ? datos.GetString(datos.GetOrdinal("KNUMDOC")).Trim() : null;
                    if (kardex.KNUMDOC != null && kardex.KNUMDOC.Length > 20)
                    {
                        kardex.KNUMDOC = !datos.IsDBNull(datos.GetOrdinal("KNUMDOC")) ? datos.GetString(datos.GetOrdinal("KNUMDOC")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        kardex.KNUMDOC = !datos.IsDBNull(datos.GetOrdinal("KNUMDOC")) ? datos.GetString(datos.GetOrdinal("KNUMDOC")).Trim() : null;
                    } 

                    

                    // 2 CARACTERES
                    kardex.KTIPOPE = !datos.IsDBNull(datos.GetOrdinal("KTIPOPE")) ? datos.GetString(datos.GetOrdinal("KTIPOPE")).Trim() : null;
                    if (kardex.KTIPOPE != null && kardex.KTIPOPE.Length > 2)
                    {
                        kardex.KTIPOPE = !datos.IsDBNull(datos.GetOrdinal("KTIPOPE")) ? datos.GetString(datos.GetOrdinal("KTIPOPE")).Substring(0, 2).Trim() : null;
                    }
                    else
                    {
                        kardex.KTIPOPE = !datos.IsDBNull(datos.GetOrdinal("KTIPOPE")) ? datos.GetString(datos.GetOrdinal("KTIPOPE")).Trim() : null;
                    } 
                    

                    // 80 CARACTERES
                    kardex.KDESEXIST = !datos.IsDBNull(datos.GetOrdinal("KDESEXIST")) ? datos.GetString(datos.GetOrdinal("KDESEXIST")).Trim() : null;
                    if (kardex.KDESEXIST != null && kardex.KDESEXIST.Length > 80)
                    {
                        kardex.KDESEXIST = !datos.IsDBNull(datos.GetOrdinal("KDESEXIST")) ? datos.GetString(datos.GetOrdinal("KDESEXIST")).Substring(0, 80).Trim() : null;
                    }
                    else
                    {
                        kardex.KDESEXIST = !datos.IsDBNull(datos.GetOrdinal("KDESEXIST")) ? datos.GetString(datos.GetOrdinal("KDESEXIST")).Trim() : null;
                    } 


                    // 3 CARACTERES
                    kardex.KUNIMED = !datos.IsDBNull(datos.GetOrdinal("KUNIMED")) ? datos.GetString(datos.GetOrdinal("KUNIMED")).Trim() : null;
                    if (kardex.KUNIMED != null && kardex.KUNIMED.Length > 3)
                    {
                        kardex.KUNIMED = !datos.IsDBNull(datos.GetOrdinal("KUNIMED")) ? datos.GetString(datos.GetOrdinal("KUNIMED")).Substring(0, 3).Trim() : null;
                    }
                    else
                    {
                        kardex.KUNIMED = !datos.IsDBNull(datos.GetOrdinal("KUNIMED")) ? datos.GetString(datos.GetOrdinal("KUNIMED")).Trim() : null;
                    } 


                    // 1 CARACTERES
                    kardex.KMETVAL = !datos.IsDBNull(datos.GetOrdinal("KMETVAL")) ? datos.GetString(datos.GetOrdinal("KMETVAL")).Trim() : null;
                    if (kardex.KMETVAL != null && kardex.KMETVAL.Length > 1)
                    {
                        kardex.KMETVAL = !datos.IsDBNull(datos.GetOrdinal("KMETVAL")) ? datos.GetString(datos.GetOrdinal("KMETVAL")).Substring(0, 1).Trim() : null;
                    }
                    else
                    {
                        kardex.KMETVAL = !datos.IsDBNull(datos.GetOrdinal("KMETVAL")) ? datos.GetString(datos.GetOrdinal("KMETVAL")).Trim() : null;
                    } 


                    // NUMEICO 12 ENTEROS Y 8 DECIMALES
                    kardex.KUNIING = !datos.IsDBNull(datos.GetOrdinal("TCAMBIO")) ? String.Format("{0:0.00000000}", datos.GetDecimal(datos.GetOrdinal("TCAMBIO"))) : null; ;
                    //kardex.KUNIING = !datos.IsDBNull(datos.GetOrdinal("precio")) ? String.Format("{0:0.#####}", datos.GetDecimal(datos.GetOrdinal("precio"))) : null;
                    //if (kardex.KUNIING != )
                    //{
                    //    kardex.KUNIING = "0";
                    //}
                    //else
                    //{
                    //    kardex.KUNIING = !datos.IsDBNull(datos.GetOrdinal("precio")) ? String.Format("{0:0.#####}", datos.GetDecimal(datos.GetOrdinal("precio"))) : null;
                    //} 




                    // NUMERICO 12 ENTEROS Y 8 DECIMALES
                    kardex.KCOSING = !datos.IsDBNull(datos.GetOrdinal("KCOSING")) ? String.Format("{0:0.00000000}", datos.GetDecimal(datos.GetOrdinal("TCAMBIO"))) : null; ;


                    // NUMERICO 12 ENTEROS Y 8 DECIMALES
                    kardex.KTOTING = !datos.IsDBNull(datos.GetOrdinal("KTOTING")) ? String.Format("{0:0.00000000}", datos.GetDecimal(datos.GetOrdinal("KTOTING"))) : null; ;




                    // NUMERICO 12 ENTEROS Y 8 DECIMALES
                    kardex.KUNIRET = !datos.IsDBNull(datos.GetOrdinal("KUNIRET")) ? String.Format("{0:0.00000000}", datos.GetDecimal(datos.GetOrdinal("KUNIRET"))) : null; ;




                    // NUMERICO 12 ENTEROS Y 8 DECIMALES
                    kardex.KCOSRET = !datos.IsDBNull(datos.GetOrdinal("KCOSRET")) ? String.Format("{0:0.00000000}", datos.GetDecimal(datos.GetOrdinal("KCOSRET"))) : null; ;


                    // NUMERICO 12 ENTEROS Y 8 DECIMALES
                    kardex.KTOTRET = !datos.IsDBNull(datos.GetOrdinal("KTOTRET")) ? String.Format("{0:0.00000000}", datos.GetDecimal(datos.GetOrdinal("KTOTRET"))) : null; ;



                    // NUMERICO 12 ENTEROS Y 8 DECIMALES
                    kardex.KSALFIN = !datos.IsDBNull(datos.GetOrdinal("KSALFIN")) ? String.Format("{0:0.00000000}", datos.GetDecimal(datos.GetOrdinal("KSALFIN"))) : null; ;


                    // NUMERICO 12 ENTEROS Y 8 DECIMALES
                    kardex.KCOSFIN = !datos.IsDBNull(datos.GetOrdinal("KCOSFIN")) ? String.Format("{0:0.00000000}", datos.GetDecimal(datos.GetOrdinal("KCOSFIN"))) : null; ;


                    // NUMERICO 12 ENTEROS Y 8 DECIMALES
                    kardex.KTOTFIN = !datos.IsDBNull(datos.GetOrdinal("KTOTFIN")) ? String.Format("{0:0.00000000}", datos.GetDecimal(datos.GetOrdinal("KTOTFIN"))) : null; 
                 


                    // 20 CARACTERES
                    kardex.KINTDIAMAY = !datos.IsDBNull(datos.GetOrdinal("KINTDIAMAY")) ? datos.GetString(datos.GetOrdinal("KINTDIAMAY")).Trim() : null;
                    if (kardex.KINTDIAMAY != null && kardex.KINTDIAMAY.Length > 20)
                    {
                        kardex.KINTDIAMAY = !datos.IsDBNull(datos.GetOrdinal("KINTDIAMAY")) ? datos.GetString(datos.GetOrdinal("KINTDIAMAY")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        kardex.KINTDIAMAY = !datos.IsDBNull(datos.GetOrdinal("KINTDIAMAY")) ? datos.GetString(datos.GetOrdinal("KINTDIAMAY")).Trim() : null;
                    }


                    // 20 CARACTERES
                    kardex.KINTVTACOM = !datos.IsDBNull(datos.GetOrdinal("KINTVTACOM")) ? datos.GetString(datos.GetOrdinal("KINTVTACOM")).Trim() : null;
                    if (kardex.KINTVTACOM != null && kardex.KINTVTACOM.Length > 20)
                    {
                        kardex.KINTVTACOM = !datos.IsDBNull(datos.GetOrdinal("KINTVTACOM")) ? datos.GetString(datos.GetOrdinal("KINTVTACOM")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        kardex.KINTVTACOM = !datos.IsDBNull(datos.GetOrdinal("KINTVTACOM")) ? datos.GetString(datos.GetOrdinal("KINTVTACOM")).Trim() : null;
                    }


                    // 20 CARACTERES
                    kardex.KINTREG = !datos.IsDBNull(datos.GetOrdinal("KINTREG")) ? datos.GetString(datos.GetOrdinal("KINTREG")).Trim() : null;
                    if (kardex.KINTREG != null && kardex.KINTREG.Length > 20)
                    {
                        kardex.KINTREG = !datos.IsDBNull(datos.GetOrdinal("KINTREG")) ? datos.GetString(datos.GetOrdinal("KINTREG")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        kardex.KINTREG = !datos.IsDBNull(datos.GetOrdinal("KINTREG")) ? datos.GetString(datos.GetOrdinal("KINTREG")).Trim() : null;
                    }

                    
                    kardexs.Add(kardex);
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

            return kardexs;
        }
    
    }
}
