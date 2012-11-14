using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using rSunat.ReportesSunat.Entidades;

namespace rSunat.ReportesSunat.AccesoDatos
{
    public class RegistroVentasAD
    {
        public List<RegistroVentas> ListarRegistroVentas(string IDEMPRESA, string PERIODODESDE, string PERIODOHASTA, string TIPOMONEDA, string AMBITO, string PORCUENTA)
        {
            //SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=bdsjprueba; User=eaurazoc; Password=45038264; Connect Timeout=60000");

            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "OBJREPORTES_REGISTROVENTAS";
            comando.CommandTimeout = 0;

            Util.AgregarParametro(ref comando, "@IDEMPRESA", ParameterDirection.Input, SqlDbType.NVarChar, 3, IDEMPRESA);
            Util.AgregarParametro(ref comando, "@PERIODODESDE", ParameterDirection.Input, SqlDbType.NVarChar, 6, PERIODODESDE);
            Util.AgregarParametro(ref comando, "@PERIODOHASTA", ParameterDirection.Input, SqlDbType.NVarChar, 6, PERIODOHASTA);
            Util.AgregarParametro(ref comando, "@TIPOMONEDA", ParameterDirection.Input, SqlDbType.NVarChar, 1, TIPOMONEDA);
            Util.AgregarParametro(ref comando, "@AMBITO", ParameterDirection.Input, SqlDbType.NVarChar, 3, AMBITO);
            Util.AgregarParametro(ref comando, "@PORCUENTA", ParameterDirection.Input, SqlDbType.NVarChar, 1, PORCUENTA);
            List<RegistroVentas> registrosVentas = new List<RegistroVentas>();

            try
            {
                conexion.Open();
                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);
                while (datos.Read())
                {
                    RegistroVentas registroVentas = new RegistroVentas();
                    //Operador ? :
                    //variable = condicion ? valor_verdadero : valor_falso;
                    // 02 CARARTERES
                    registroVentas.VMES = !datos.IsDBNull(datos.GetOrdinal("FECHA")) ? String.Format("{0:MM}", datos.GetDateTime(datos.GetOrdinal("FECHA"))) : null;


                    //HASTA 40 CARACTERES
                    registroVentas.VNUMREGOPE = !datos.IsDBNull(datos.GetOrdinal("COMPROBANTE")) ? datos.GetString(datos.GetOrdinal("COMPROBANTE")).Trim() : null; //sin el serial
                    if (registroVentas.VNUMREGOPE != null && registroVentas.VNUMREGOPE.Length > 40)
                    {
                        registroVentas.VNUMREGOPE = !datos.IsDBNull(datos.GetOrdinal("COMPROBANTE")) ? datos.GetString(datos.GetOrdinal("COMPROBANTE")).Substring(5, 40).Trim() : null; //sin el serial
                    }
                    else
                    {
                        registroVentas.VNUMREGOPE = !datos.IsDBNull(datos.GetOrdinal("COMPROBANTE")) ? datos.GetString(datos.GetOrdinal("COMPROBANTE")).Substring(5).Trim() : null; //sin el serial
                    }

                    //10 CARACTERES EN FORMATO DD/MM/AAAA
                    registroVentas.VFECCOM = !datos.IsDBNull(datos.GetOrdinal("FECHA")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("FECHA"))) : null; 


                    //10 CARACTERES EN FORMATO DD/MM/AAAA
                    registroVentas.VFECVENPAG = !datos.IsDBNull(datos.GetOrdinal("VENCIMIENTO")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("VENCIMIENTO"))) : null; ;


                    //// 02 CARACTERES
                   registroVentas.VTIPDOCCOM = !datos.IsDBNull(datos.GetOrdinal("DOC_SUNAT")) ? datos.GetString(datos.GetOrdinal("DOC_SUNAT")).Trim() : null; //convertido al formato de sunat
                    
                    //// HASTA 20 CARACTERES
                   registroVentas.VNUMSER = !datos.IsDBNull(datos.GetOrdinal("NUMDOCUMENTO")) ? datos.GetString(datos.GetOrdinal("NUMDOCUMENTO")).Trim() : null;
                   if (registroVentas.VNUMSER != null && registroVentas.VNUMSER.Length > 20)
                   {
                       registroVentas.VNUMSER = !datos.IsDBNull(datos.GetOrdinal("NUMDOCUMENTO")) ? datos.GetString(datos.GetOrdinal("NUMDOCUMENTO")).Substring(0, 4).Trim() : null; //solo el serial
                   }
                   else
                   {
                       registroVentas.VNUMSER = !datos.IsDBNull(datos.GetOrdinal("NUMDOCUMENTO")) ? datos.GetString(datos.GetOrdinal("NUMDOCUMENTO")).Substring(0, 4).Trim() : null; //solo el serial
                   } 


                                        
                    //// HASTA 20 CARACTERES
                   registroVentas.VNUMDOCCOI = !datos.IsDBNull(datos.GetOrdinal("NUMDOCUMENTO")) ? datos.GetString(datos.GetOrdinal("NUMDOCUMENTO")).Trim() : null;
                   if (registroVentas.VNUMDOCCOI != null && registroVentas.VNUMDOCCOI.Length > 20)
                    {
                        registroVentas.VNUMDOCCOI = !datos.IsDBNull(datos.GetOrdinal("NUMDOCUMENTO")) ? datos.GetString(datos.GetOrdinal("NUMDOCUMENTO")).Substring(7, 20).Trim() : null; //sin el serial
                    }
                    else
                    {
                        registroVentas.VNUMDOCCOI = !datos.IsDBNull(datos.GetOrdinal("NUMDOCUMENTO")) ? datos.GetString(datos.GetOrdinal("NUMDOCUMENTO")).Substring(7).Trim() : null; //sin el serial
                    }


                   registroVentas.VNUMDOCCOF = "";
                    ////////HASTA 20 CARACTERES
                   ////registroVentas.VNUMDOCCOF = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;
                   ////if (registroVentas.VNUMDOCCOF != null && registroVentas.VNUMDOCCOF.Length > 20)
                   ////{
                   ////    registroVentas.VNUMDOCCOF = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(5, 20).Trim() : null; //sin el serial
                   ////}
                   ////else
                   ////{
                   ////    registroVentas.VNUMDOCCOF = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(5).Trim() : null; //sin el serial
                   ////} 


                   registroVentas.VTIPDIDCLI = "";
                    ////////01 CARACTER
                   ////registroVentas.VTIPDIDCLI = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;
                   ////if (registroVentas.VTIPDIDCLI != null && registroVentas.VTIPDIDCLI.Length > 1)
                   ////{
                   ////    registroVentas.VTIPDIDCLI = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(1, 1).Trim() : null; //sin el serial
                   ////}
                   ////else
                   ////{
                   ////    registroVentas.VTIPDIDCLI = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(1).Trim() : null; //sin el serial
                   ////}  


                   registroVentas.VNUMDIDCLI = "";
                    ////HASTA 15 CARACTERES
                    //registroVentas.VNUMDIDCLI = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;
                   ////if (registroVentas.VNUMDIDCLI != null && registroVentas.VNUMDIDCLI.Length > 15)
                   ////{
                   ////    registroVentas.VNUMDIDCLI = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(0, 15).Trim() : null; //sin el serial
                   ////}
                   ////else
                   ////{
                   ////    registroVentas.VNUMDIDCLI = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null; //sin el serial
                   ////} 
                    

                    ////HASTA 60 CARACTERES
                   //registroVentas.VAPENOMRSO = !datos.IsDBNull(datos.GetOrdinal("RAZON_SOCIAL")) ? datos.GetString(datos.GetOrdinal("RAZON_SOCIAL")).Trim() : null;
                   if (registroVentas.VAPENOMRSO != null && registroVentas.VAPENOMRSO.Length > 60)
                   {
                       registroVentas.VAPENOMRSO = !datos.IsDBNull(datos.GetOrdinal("RAZON_SOCIAL")) ? datos.GetString(datos.GetOrdinal("RAZON_SOCIAL")).Substring(0, 60).Trim() : null;
                   }
                   else
                   {
                       registroVentas.VAPENOMRSO = !datos.IsDBNull(datos.GetOrdinal("RAZON_SOCIAL")) ? datos.GetString(datos.GetOrdinal("RAZON_SOCIAL")).Trim() : null;
                   }



                   //NUMERICO CON 12 ENTER0S Y 02 DECIMALES
                   registroVentas.VVALFACEXP = !datos.IsDBNull(datos.GetOrdinal("BASEIMP_EXPO")) ? datos.GetDecimal(datos.GetOrdinal("BASEIMP_EXPO")) : (decimal?)null;




                   //NUMERICO CON 12 ENTER0S Y 02 DECIMALES
                   registroVentas.VBASIMPGRA = !datos.IsDBNull(datos.GetOrdinal("BASEIMP_AFEC")) ? datos.GetDecimal(datos.GetOrdinal("BASEIMP_AFEC")) : (decimal?)null;




                   //NUMERICO CON 12 ENTER0S Y 02 DECIMALES
                   registroVentas.VIMPTOTEXO = !datos.IsDBNull(datos.GetOrdinal("BASEIMP_EXON")) ? datos.GetDecimal(datos.GetOrdinal("BASEIMP_EXON")) : (decimal?)null;




                   //NUMERICO CON 12 ENTER0S Y 02 DECIMALES
                   registroVentas.VIMPTOTINA = !datos.IsDBNull(datos.GetOrdinal("INAFECTO")) ? datos.GetDecimal(datos.GetOrdinal("INAFECTO")) : (decimal?)null;




                   //NUMERICO CON 12 ENTER0 Y 02 DECIMALES
                   registroVentas.VISC = !datos.IsDBNull(datos.GetOrdinal("ISC")) ? datos.GetDecimal(datos.GetOrdinal("ISC")) : (decimal?)null;




                   //NUMERICO CON 12 ENTER0S Y 02 DECIMALES
                   registroVentas.VIGVIPM = !datos.IsDBNull(datos.GetOrdinal("IMPTO_AFEC")) ? datos.GetDecimal(datos.GetOrdinal("IMPTO_AFEC")) : (decimal?)null;




                   //NUMERICO CON 12 ENTER0S Y 02 DECIMALES                    
                  
                    if (registroVentas.BIVAP != 0)
                        {
                            registroVentas.VBASIMIVAP = !datos.IsDBNull(datos.GetOrdinal("BASEIMP_AFEC")) ? datos.GetDecimal(datos.GetOrdinal("BASEIMP_AFEC")) : (decimal?)null;

                        }
                    else
                        {
                            registroVentas.VBASIMIVAP = 0;
                        }


                   //NUMERICO CON 12 ENTER0S Y 02 DECIMALES
                   registroVentas.BIVAP = !datos.IsDBNull(datos.GetOrdinal("OTROS")) ? datos.GetDecimal(datos.GetOrdinal("OTROS")) : (decimal?)null;

                    //Por el momento le doy formato a este campo
                   string otros = String.Format("{0:0.00}",0);
                   registroVentas.VOTRTRICGO = Convert.ToDecimal(otros);
                   
                   ////NUMERICO CON 12 ENTER0S Y 02 DECIMALES
                   //registroVentas.VOTRTRICGO = !datos.IsDBNull(datos.GetOrdinal("0")) ? datos.GetDecimal(datos.GetOrdinal("0")) : (decimal?)null;
                 

                   //NUMERICO CON 12 ENTER0S Y 02 DECIMALES
                   registroVentas.VIMPTOTCOM = !datos.IsDBNull(datos.GetOrdinal("TOTAL")) ? datos.GetDecimal(datos.GetOrdinal("TOTAL")) : (decimal?)null;



                   //NUMERICO CON 01 ENTER0 Y 03 DECIMALES
                   //registroVentas.VTIPCAM = !datos.IsDBNull(datos.GetOrdinal("TCAMBIO")) ? datos.GetDecimal(datos.GetOrdinal("TCAMBIO")) : (decimal?)null;


                   registroVentas.VTIPCAM = !datos.IsDBNull(datos.GetOrdinal("TCAMBIO")) ? String.Format("{0:0.000}", datos.GetDecimal(datos.GetOrdinal("TCAMBIO"))) : null; ;
                   //String.Format("{0:0.00}", 123.0); 



                    //OTRA HOJA
                   //10 CARACTERES EN FORMATO DD/MM/AAAA
                   registroVentas.VFECMOD = !datos.IsDBNull(datos.GetOrdinal("FECHA")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("FECHA"))) : null; ;


                   registroVentas.VTIPDOCMOD = "";
                    ////HASTA 02 CARACTERES
                   //registroVentas.VTIPDOCMOD = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;

                   // if (registroVentas.VTIPDOCMOD != null && registroVentas.VTIPDOCMOD.Length > 2)
                   // {
                   //     registroVentas.VTIPDOCMOD = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(0, 2).Trim() : null;                   
                   // }
                   // else
                   // {
                   //     registroVentas.VTIPDOCMOD = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null; //convertido al formato de sunat

                   // }

                   registroVentas.VNUMSERMOD = "";
                    ////HASTA 20 CARACTERES
                    //registroVentas.VNUMSERMOD = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;
                    //if (registroVentas.VNUMSERMOD != null && registroVentas.VNUMSERMOD.Length > 20)
                    //{
                    //    registroVentas.VNUMSERMOD = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(5, 20).Trim() : null; //sin el serial
                    //}
                    //else
                    //{
                    //    registroVentas.VNUMSERMOD = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(5).Trim() : null; //sin el serial
                    //}

                   registroVentas.VNUMDOCMOD = "";
                    ////HASTA 20 CARACTERES
                    //registroVentas.VNUMDOCMOD = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;
                    //if (registroVentas.VNUMDOCMOD != null && registroVentas.VNUMDOCMOD.Length > 20)
                    //{
                    //    registroVentas.VNUMDOCMOD = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(5, 20).Trim() : null; //sin el serial
                    //}
                    //else
                    //{
                    //    registroVentas.VNUMDOCMOD = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(5).Trim() : null; //sin el serial
                    //} 


                    //HASTA 20 CARACTERES
                    registroVentas.VINTDIAMAY = !datos.IsDBNull(datos.GetOrdinal("IDREFERENCIA")) ? datos.GetString(datos.GetOrdinal("IDREFERENCIA")).Trim() : null;
                    if (registroVentas.VINTDIAMAY != null && registroVentas.VINTDIAMAY.Length > 20)
                    {
                        registroVentas.VINTDIAMAY = !datos.IsDBNull(datos.GetOrdinal("IDREFERENCIA")) ? datos.GetString(datos.GetOrdinal("IDREFERENCIA")).Substring(0, 20).Trim() : null; //sin el serial
                    }
                    else
                    {
                        registroVentas.VINTDIAMAY = !datos.IsDBNull(datos.GetOrdinal("IDREFERENCIA")) ? datos.GetString(datos.GetOrdinal("IDREFERENCIA")).Substring(0).Trim() : null; //sin el serial
                    } 

                    //HASTA 20 CARACTERES
                    registroVentas.VINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("IDREFERENCIA")) ? datos.GetString(datos.GetOrdinal("IDREFERENCIA")).Trim() : null;
                    if (registroVentas.VINTKARDEX != null && registroVentas.VINTKARDEX.Length > 20)
                    {
                        registroVentas.VINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("IDREFERENCIA")) ? datos.GetString(datos.GetOrdinal("IDREFERENCIA")).Substring(0, 20).Trim() : null; //sin el serial
                    }
                    else
                    {
                        registroVentas.VINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("IDREFERENCIA")) ? datos.GetString(datos.GetOrdinal("IDREFERENCIA")).Substring(0).Trim() : null; //sin el serial
                    } 

                    //HASTA 20 CARACTERES
                    registroVentas.VINTREG = !datos.IsDBNull(datos.GetOrdinal("IDREFERENCIA")) ? datos.GetString(datos.GetOrdinal("IDREFERENCIA")).Trim() : null;
                    if (registroVentas.VINTREG != null && registroVentas.VINTREG.Length > 20)
                    {
                        registroVentas.VINTREG = !datos.IsDBNull(datos.GetOrdinal("IDREFERENCIA")) ? datos.GetString(datos.GetOrdinal("IDREFERENCIA")).Substring(0, 20).Trim() : null; //sin el serial
                    }
                    else
                    {
                        registroVentas.VINTREG = !datos.IsDBNull(datos.GetOrdinal("IDREFERENCIA")) ? datos.GetString(datos.GetOrdinal("IDREFERENCIA")).Substring(0).Trim() : null; //sin el serial
                    } 

                    registrosVentas.Add(registroVentas);
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
            return registrosVentas;
        }    
    }
}
