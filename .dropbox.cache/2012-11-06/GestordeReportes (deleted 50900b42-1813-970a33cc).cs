using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rSunat.ReportesSunat.AccesoDatos;
using rSunat.ReportesSunat.Entidades;

namespace rSunat.ReportesSunat.LogicadeNegocio
{
    public class GestordeReportes
    {
        public static List<LibroMayorSUNAT> ListarLibroMayorSUNAT(string c_emp, string c_cuenta1, string c_cuenta2, string c_desde, string c_hasta, string c_mon)
        {
            List<LibroMayorSUNAT> librosMayorSUNAT = new List<LibroMayorSUNAT>();

            try
            {

                LibroMayorAD libromayorAD = new LibroMayorAD();
                librosMayorSUNAT = libromayorAD.ListarMayorSUNAT(c_emp, c_cuenta1, c_cuenta2, c_desde, c_hasta, c_mon);
            }
            catch (Exception e)
            {
                throw e;
            }
            return librosMayorSUNAT;
        }

        public static List<LibroMayor> ListarLibroMayor(string c_emp, string c_cuenta1, string c_cuenta2, string c_desde, string c_hasta, string c_mon)
        {
            List<LibroMayor> librosMayor = new List<LibroMayor>();

            try
            {

                LibroMayorAD libromayorAD2 = new LibroMayorAD();
                librosMayor = libromayorAD2.ListarMayor(c_emp, c_cuenta1, c_cuenta2, c_desde, c_hasta, c_mon);
            }
            catch (Exception e)
            {
                throw e;
            }
            return librosMayor;
        }

        public static List<LibroDiario> ListarLibroDiario(string c_emp, string c_desde, string c_hasta, string c_mon,  string c_tipo, int c_grupo)
        {
            List<LibroDiario> librosDiario = new List<LibroDiario>();
            try
            {

                LibroDiarioAD librodiarioAD = new LibroDiarioAD();
                librosDiario = librodiarioAD.ListarLibroDiario(c_emp, c_desde, c_hasta, c_mon, c_tipo, c_grupo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return librosDiario;
        }

        public static List<RegistroVentas> ListarRegistroVentas(string IDEMPRESA, string PERIODODESDE, string PERIODOHASTA, string TIPOMONEDA, string AMBITO, string PORCUENTA)
        {
            List<RegistroVentas> registrosVentas = new List<RegistroVentas>();
            try
            {

                RegistroVentasAD registroVentasAD = new RegistroVentasAD();
                registrosVentas = registroVentasAD.ListarRegistroVentas(IDEMPRESA, PERIODODESDE, PERIODOHASTA, TIPOMONEDA, AMBITO, PORCUENTA);
            }
            catch (Exception e)
            {
                throw e;
            }
            return registrosVentas;
        }

        public static List<RegistroCompras> ListarRegistroCompras(string IDEMPRESA, string PERIODODESDE, string PERIODOHASTA, string AMBITO, string TIPOMONEDA)
        {
            List<RegistroCompras> registrosCompras = new List<RegistroCompras>();
            try
            {

                RegistroComprasAD registroComprasAD = new RegistroComprasAD();
                registrosCompras = registroComprasAD.ListarRegistroCompras(IDEMPRESA, PERIODODESDE, PERIODOHASTA, AMBITO, TIPOMONEDA);
            }
            catch (Exception e)
            {
                throw e;
            }
            return registrosCompras;
        }

        public static List<PlandeCuentaSunat> ListarPlanxCuenta(string cuenta)
        {
            List<PlandeCuentaSunat> oPlandeCuentaSunat = new List<PlandeCuentaSunat>();
            try
            {
                PlandeCuentaSunatAD oPlandeCuentaSunatAD = new PlandeCuentaSunatAD();
                oPlandeCuentaSunat = oPlandeCuentaSunatAD.ListarPlanxCuenta(cuenta);
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            return oPlandeCuentaSunat;
        }

        public static List<PlandeCuentaSunat> ListarPlanxDescripcion(string descripcion)
        {
            List<PlandeCuentaSunat> oPlandeCuentaSunat = new List<PlandeCuentaSunat>();
            try
            {
                PlandeCuentaSunatAD oPlandeCuentaSunatAD = new PlandeCuentaSunatAD();
                oPlandeCuentaSunat = oPlandeCuentaSunatAD.ListarPlanxDescripcion(descripcion);
            }
            catch (Exception e)
            {
                throw e;
            }
            return oPlandeCuentaSunat;
        }

        public static List<PlandeCuentaSunat> listarPrimerUltimaCuenta()
        {
            List<PlandeCuentaSunat> oPlandeCuentas = new List<PlandeCuentaSunat>();
            try
            {
                PlandeCuentaSunatAD oPlandeCuentaSunatAD = new PlandeCuentaSunatAD();
                oPlandeCuentas = oPlandeCuentaSunatAD.ListarCuentaMaximaMinima();
            }
            catch
            {
            
            }
            return oPlandeCuentas;
        }

        public static List<PlandeCuentaSunat> ListarPlanxCuentaExacta(string cuenta)
        {
            List<PlandeCuentaSunat> oPlandeCuentaSunat = new List<PlandeCuentaSunat>();
            try
            {
                PlandeCuentaSunatAD oPlandeCuentaSunatAD = new PlandeCuentaSunatAD();
                oPlandeCuentaSunat = oPlandeCuentaSunatAD.ListarPlanxCuentaExacta(cuenta);
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return oPlandeCuentaSunat;
        }

        public static List<KARDEX> ListarKardex(string c_emp, string c_desde, string c_hasta, string c_mon, string c_tipo, string c_grupo)
        {
            List<KARDEX> kardex = new List<KARDEX>();
            try
            {

                KARDEXAD kardexAD = new KARDEXAD();
                kardex = kardexAD.ListarKardex(c_emp, c_desde, c_hasta, c_mon, c_tipo, c_grupo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return kardex;
        }

    }
}
