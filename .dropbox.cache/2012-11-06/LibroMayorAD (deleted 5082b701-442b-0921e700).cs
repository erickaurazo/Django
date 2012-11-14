using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using rSunat.ReportesSunat.Entidades;

namespace rSunat.ReportesSunat.AccesoDatos
{
    public class LibroMayorAD
    {
        public List<LibroMayorSUNAT> ListarMayorSUNAT(string c_emp, string c_cuenta1, string c_cuenta2, string c_desde, string c_hasta, string c_mon)
        {
            //SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=bdsjprueba; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "RPTLIBRO_MAYOR";
            comando.CommandTimeout = 0;
            Util.AgregarParametro(ref comando, "@c_emp", ParameterDirection.Input, SqlDbType.NVarChar, 3, c_emp);
            Util.AgregarParametro(ref comando, "@c_cuenta1", ParameterDirection.Input, SqlDbType.NVarChar, 12, c_cuenta1);
            Util.AgregarParametro(ref comando, "@c_cuenta2", ParameterDirection.Input, SqlDbType.NVarChar, 12, c_cuenta2);
            Util.AgregarParametro(ref comando, "@c_desde", ParameterDirection.Input, SqlDbType.NVarChar, 8, c_desde);
            Util.AgregarParametro(ref comando, "@c_hasta", ParameterDirection.Input, SqlDbType.NVarChar, 8, c_hasta);
            Util.AgregarParametro(ref comando, "@c_mon", ParameterDirection.Input, SqlDbType.NVarChar, 1, c_mon);

            List<LibroMayorSUNAT> librosMayorSUNAT = new List<LibroMayorSUNAT>();
            try
            {
                conexion.Open();
                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);
                while (datos.Read())
                {
                    LibroMayorSUNAT libroMayor = new LibroMayorSUNAT();
                    //Operador ? :
                    //variable = condicion ? valor_verdadero : valor_falso;
                    //de 02 caracteres
                    libroMayor.MES = !datos.IsDBNull(datos.GetOrdinal("fecha")) ? String.Format("{0:MM}", datos.GetDateTime(datos.GetOrdinal("fecha"))) : null; ;

                    //hasta 15 caracteres
                    libroMayor.VOUCHER = !datos.IsDBNull(datos.GetOrdinal("operacion")) ? datos.GetString(datos.GetOrdinal("operacion")).Trim() : null;
                    if (libroMayor.VOUCHER != null && libroMayor.VOUCHER.Length > 15)
                    {
                        libroMayor.VOUCHER = !datos.IsDBNull(datos.GetOrdinal("operacion")) ? datos.GetString(datos.GetOrdinal("operacion")).Substring(0, 15).Trim() : null;
                    }
                    else
                    {
                        libroMayor.VOUCHER = !datos.IsDBNull(datos.GetOrdinal("operacion")) ? datos.GetString(datos.GetOrdinal("operacion")).Trim() : null;
                    }



                    // Hasta 24 caracteres
                    libroMayor.CUENTA = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")).Trim() : null;
                    if (libroMayor.CUENTA != null && libroMayor.CUENTA.Length > 24)
                    {
                        libroMayor.CUENTA = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")).Substring(0, 24).Trim() : null;
                    }
                    else
                    {
                        libroMayor.CUENTA = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")).Trim() : null;
                    }


                    libroMayor.FECHA_DE_OPERACION = !datos.IsDBNull(datos.GetOrdinal("fecha")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("fecha"))) : null; ;

                    // hasta 100 caracteres
                    libroMayor.DESCRIPCION = !datos.IsDBNull(datos.GetOrdinal("denominacion")) ? datos.GetString(datos.GetOrdinal("denominacion")).Trim() : null;
                    if (libroMayor.DESCRIPCION != null && libroMayor.DESCRIPCION.Length > 100)
                    {
                        libroMayor.DESCRIPCION = !datos.IsDBNull(datos.GetOrdinal("denominacion")) ? datos.GetString(datos.GetOrdinal("denominacion")).Substring(0, 100).Trim() : null;
                    }
                    else
                    {
                        libroMayor.DESCRIPCION = !datos.IsDBNull(datos.GetOrdinal("denominacion")) ? datos.GetString(datos.GetOrdinal("denominacion")).Trim() : null;
                    }


                    libroMayor.CENTRO_DE_COSTOS = "";

                    //libroMayor.CENTRO_DE_COSTOS = !datos.IsDBNull(datos.GetOrdinal("MCENCOS")) ? datos.GetString(datos.GetOrdinal("MCENCOS")).Trim() : null;


                    libroMayor.DEBE = !datos.IsDBNull(datos.GetOrdinal("debe")) ? String.Format("{0:0.00}", datos.GetDecimal(datos.GetOrdinal("debe"))) : null; ;

                    libroMayor.HABER = !datos.IsDBNull(datos.GetOrdinal("haber")) ? String.Format("{0:0.00}", datos.GetDecimal(datos.GetOrdinal("haber"))) : null; ;

                    //hasta 20 caracteres
                    libroMayor.COD_OPERACION = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroMayor.COD_OPERACION != null && libroMayor.COD_OPERACION.Length > 20)
                    {
                        libroMayor.COD_OPERACION = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroMayor.COD_OPERACION = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }

                    //hasta 20 caracteres
                    libroMayor.COD_KARDEX = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroMayor.COD_KARDEX != null && libroMayor.COD_KARDEX.Length > 20)
                    {
                        libroMayor.COD_KARDEX = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroMayor.COD_KARDEX = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }


                    //hasta 20 caracteres
                    libroMayor.COD_COMPRAVENTA = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroMayor.COD_COMPRAVENTA != null && libroMayor.COD_COMPRAVENTA.Length > 20)
                    {
                        libroMayor.COD_COMPRAVENTA = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroMayor.COD_COMPRAVENTA = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }




                    //hasta 20 caracteres
                    libroMayor.COD_DE_MODULO = null;
                    //libroMayor.COD_DE_MODULO = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;
                    //if (libroMayor.COD_DE_MODULO != null && libroMayor.COD_DE_MODULO.Length > 20)
                    //{
                    //    libroMayor.COD_DE_MODULO = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(0, 20).Trim() : null;
                    //}
                    //else
                    //{
                    //    libroMayor.COD_DE_MODULO = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;
                    //}

                    librosMayorSUNAT.Add(libroMayor);
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

            return librosMayorSUNAT;
        }


        public List<LibroMayor> ListarMayor(string c_emp, string c_cuenta1, string c_cuenta2, string c_desde, string c_hasta, string c_mon)
        {
            //SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=bdsjprueba; User=eaurazoc; Password=45038264; Connect Timeout=60000");

            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "RPTLIBRO_MAYOR";
            comando.CommandTimeout = 0;
            Util.AgregarParametro(ref comando, "@c_emp", ParameterDirection.Input, SqlDbType.NVarChar, 3, c_emp);
            Util.AgregarParametro(ref comando, "@c_cuenta1", ParameterDirection.Input, SqlDbType.NVarChar, 12, c_cuenta1);
            Util.AgregarParametro(ref comando, "@c_cuenta2", ParameterDirection.Input, SqlDbType.NVarChar, 12, c_cuenta2);
            Util.AgregarParametro(ref comando, "@c_desde", ParameterDirection.Input, SqlDbType.NVarChar, 8, c_desde);
            Util.AgregarParametro(ref comando, "@c_hasta", ParameterDirection.Input, SqlDbType.NVarChar, 8, c_hasta);
            Util.AgregarParametro(ref comando, "@c_mon", ParameterDirection.Input, SqlDbType.NVarChar, 1, c_mon);

            List<LibroMayor> librosMayor = new List<LibroMayor>();
           try
            {
                conexion.Open();
                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);
                while (datos.Read())
                {
                    LibroMayor libroMayor = new LibroMayor();
                    //Operador ? :
                    //variable = condicion ? valor_verdadero : valor_falso;
                    //de 02 caracteres
                    libroMayor.MMES = !datos.IsDBNull(datos.GetOrdinal("fecha")) ? String.Format("{0:MM}", datos.GetDateTime(datos.GetOrdinal("fecha"))) : null; ;
                    
                    //hasta 15 caracteres
                    libroMayor.MNUMASIOPE = !datos.IsDBNull(datos.GetOrdinal("operacion")) ? datos.GetString(datos.GetOrdinal("operacion")).Trim() : null;
                    if (libroMayor.MNUMASIOPE != null && libroMayor.MNUMASIOPE.Length > 15)
                    {
                        libroMayor.MNUMASIOPE = !datos.IsDBNull(datos.GetOrdinal("operacion")) ? datos.GetString(datos.GetOrdinal("operacion")).Substring(0, 15).Trim() : null;
                    }
                    else
                    {
                        libroMayor.MNUMASIOPE = !datos.IsDBNull(datos.GetOrdinal("operacion")) ? datos.GetString(datos.GetOrdinal("operacion")).Trim() : null;
                    }



                    // Hasta 24 caracteres
                    libroMayor.MNUMCTACON = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")).Trim() : null;
                    if (libroMayor.MNUMCTACON != null && libroMayor.MNUMCTACON.Length > 24)
                    {
                        libroMayor.MNUMCTACON = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")).Substring(0, 24).Trim() : null;
                    }
                    else
                    {
                        libroMayor.MNUMCTACON = !datos.IsDBNull(datos.GetOrdinal("idcuenta")) ? datos.GetString(datos.GetOrdinal("idcuenta")).Trim() : null;
                    }


                    libroMayor.MFECOPE = !datos.IsDBNull(datos.GetOrdinal("fecha")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("fecha"))) : null; ;
                    
                    // hasta 100 caracteres
                    libroMayor.MGLOSA = !datos.IsDBNull(datos.GetOrdinal("denominacion")) ? datos.GetString(datos.GetOrdinal("denominacion")).Trim() : null;
                    if (libroMayor.MGLOSA != null && libroMayor.MGLOSA.Length > 100)
                    {
                        libroMayor.MGLOSA = !datos.IsDBNull(datos.GetOrdinal("denominacion")) ? datos.GetString(datos.GetOrdinal("denominacion")).Substring(0, 100).Trim() : null;
                    }
                    else
                    {
                        libroMayor.MGLOSA = !datos.IsDBNull(datos.GetOrdinal("denominacion")) ? datos.GetString(datos.GetOrdinal("denominacion")).Trim() : null;
                    }


                    libroMayor.MCENCOS = "";

                    //libroMayor.MCENCOS = !datos.IsDBNull(datos.GetOrdinal("MCENCOS")) ? datos.GetString(datos.GetOrdinal("MCENCOS")).Trim() : null;


                    libroMayor.MDEBE = !datos.IsDBNull(datos.GetOrdinal("debe")) ? datos.GetDecimal(datos.GetOrdinal("debe")) : (decimal?)null;

                    libroMayor.MHABER = !datos.IsDBNull(datos.GetOrdinal("haber")) ? datos.GetDecimal(datos.GetOrdinal("haber")) : (decimal?)null;
                    
                    //hasta 20 caracteres
                    libroMayor.MINTREG = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroMayor.MINTREG != null && libroMayor.MINTREG.Length > 20)
                    {
                        libroMayor.MINTREG = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroMayor.MINTREG = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }

                    //hasta 20 caracteres
                    libroMayor.MINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroMayor.MINTKARDEX != null && libroMayor.MINTKARDEX.Length > 20)
                    {
                        libroMayor.MINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroMayor.MINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }


                    //hasta 20 caracteres
                    libroMayor.MINTVTACOM = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroMayor.MINTVTACOM != null && libroMayor.MINTVTACOM.Length > 20)
                    {
                        libroMayor.MINTVTACOM = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroMayor.MINTVTACOM = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }




                    //hasta 20 caracteres
                    libroMayor.MINTREG2 = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    if (libroMayor.MINTREG2 != null && libroMayor.MINTREG2.Length > 20)
                    {
                        libroMayor.MINTREG2 = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        libroMayor.MINTREG2 = !datos.IsDBNull(datos.GetOrdinal("idorigen")) ? datos.GetString(datos.GetOrdinal("idorigen")).Trim() : null;
                    }

		            librosMayor.Add(libroMayor);
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

            return librosMayor;
            
            
            
            
        }

    }
}

