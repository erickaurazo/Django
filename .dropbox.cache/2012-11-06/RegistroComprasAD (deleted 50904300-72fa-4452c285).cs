using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rSunat.ReportesSunat.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace rSunat.ReportesSunat.AccesoDatos
{
    public class RegistroComprasAD
    {

        public List<RegistroCompras> ListarRegistroCompras(string c_emp, string c_desde, string c_hasta, string c_tipo, string c_mon)
        {
            SqlConnection conexion = new SqlConnection("Data Source=192.168.30.99 ;Initial Catalog=Bdsanjuan; User=eaurazoc; Password=45038264; Connect Timeout=60000");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "cp_registrocompras_2008";
            comando.CommandTimeout = 0;
            Util.AgregarParametro(ref comando, "@c_emp", ParameterDirection.Input, SqlDbType.NVarChar, 3, c_emp);
            Util.AgregarParametro(ref comando, "@c_desde", ParameterDirection.Input, SqlDbType.NVarChar, 8, c_desde);
            Util.AgregarParametro(ref comando, "@c_hasta", ParameterDirection.Input, SqlDbType.NVarChar, 8, c_hasta);
            Util.AgregarParametro(ref comando, "@c_tipo", ParameterDirection.Input, SqlDbType.NVarChar, 1, c_tipo);
            Util.AgregarParametro(ref comando, "@c_mon", ParameterDirection.Input, SqlDbType.NVarChar, 1, c_mon);
            List<RegistroCompras> registrosCompra = new List<RegistroCompras>();
            try
            {
                conexion.Open();
                SqlDataReader datos = comando.ExecuteReader(CommandBehavior.CloseConnection);
                while (datos.Read())
                {
                    RegistroCompras registrocompra = new RegistroCompras();
                    /*      
                                Operador ? :
                                variable = condicion ? valor_verdadero : valor_falso;
                    */
                    /*
                                        MES CORRESPONDIENTE AL REGISTRO DE LA OPERACION
                                02 CARACTERES          -->> FECHA <<--
                    */
                    registrocompra.CMES = !datos.IsDBNull(datos.GetOrdinal("FECHA")) ? String.Format("{0:MM}", datos.GetDateTime(datos.GetOrdinal("FECHA"))) : null;





                    /*          
                                        NUMERO CORRELATIVO DEL REGISTRO O CODIGO UNICO DE LA OPERACION
                                10 CARACTERES EN FORMATO DD/MM/AAAA          -->>NUMOPERACION <<--
                    */ 
                    registrocompra.CNUMREGOPE = !datos.IsDBNull(datos.GetOrdinal("NUMOPERACION")) ? datos.GetString(datos.GetOrdinal("NUMOPERACION")).Trim() : null;

                    registrocompra.CNUMREGOPE = !datos.IsDBNull(datos.GetOrdinal("NUMOPERACION")) ? datos.GetString(datos.GetOrdinal("NUMOPERACION")).Trim() : null; //sin el serial
                    if (registrocompra.CNUMREGOPE != null && registrocompra.CNUMREGOPE.Length > 40)
                    {
                        registrocompra.CNUMREGOPE = !datos.IsDBNull(datos.GetOrdinal("NUMOPERACION")) ? datos.GetString(datos.GetOrdinal("NUMOPERACION")).Substring(5, 40).Trim() : null; //sin el serial
                    }
                    else
                    {
                        registrocompra.CNUMREGOPE = !datos.IsDBNull(datos.GetOrdinal("NUMOPERACION")) ? datos.GetString(datos.GetOrdinal("NUMOPERACION")).Substring(5).Trim() : null; //sin el serial
                    }





                    /*          
                                        FECHA DE EMISION DEL COMPROBANTE DE PAGO
                                10 CARACTERES EN FORMATO DD/MM/AAAA             -->>FECHA <<--
                    */
                    registrocompra.CFECCOM = !datos.IsDBNull(datos.GetOrdinal("FECHA")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("FECHA"))) : null;






                    /*          
                                        FECHA DE VENCIMIENTO DEL COMPROBANTE DE PAGO
                                10 CARACTERES EN FORMATO DD/MM/AAAA               -->>VENCIMIENTO <<--
                    */
                    registrocompra.CFECVENPAG = !datos.IsDBNull(datos.GetOrdinal("VENCIMIENTO")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("VENCIMIENTO"))) : null;






                    /*      
                                        TIPO DE COMPROBANTE DE PAGO -----> VALIDAR CON TABLA M° 10
                                02 CARACTERES            -->> CODIGO_SUNAT<<--
                     */
                    registrocompra.CTIPDOCCOM = !datos.IsDBNull(datos.GetOrdinal("CODIGO_SUNAT")) ? datos.GetString(datos.GetOrdinal("CODIGO_SUNAT")).Trim() : null;
                    if (registrocompra.CTIPDOCCOM != null && registrocompra.CTIPDOCCOM.Length>2)
                    {
                        registrocompra.CTIPDOCCOM = !datos.IsDBNull(datos.GetOrdinal("CODIGO_SUNAT")) ? datos.GetString(datos.GetOrdinal("CODIGO_SUNAT")).Substring(0, 2).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CTIPDOCCOM = !datos.IsDBNull(datos.GetOrdinal("CODIGO_SUNAT")) ? datos.GetString(datos.GetOrdinal("CODIGO_SUNAT")).Trim() : null;
                    }






                    /*      
                                        NUMERO DE SERIE DEL COMPROBANTE DE PAGO.
                                        EN LOS CASOS DE LA DECLARACION UNICA DE ADUANAS (DUA) O DE LA DECLARACION SIMPLIFICADA 
                                        DE IMPORTACION (DSA) SE CONSIGNARA EL CODIDO
                                        EL CODIGO DE LA DEPENDENCIA ADUANERA
                     
                                    20 CARACTERES            -->> NUMVOUCHER <<--
                    */
                    registrocompra.CNUMSER = !datos.IsDBNull(datos.GetOrdinal("NUMVOUCHER")) ? datos.GetString(datos.GetOrdinal("NUMVOUCHER")).Trim() : null;
                    if (registrocompra.CNUMSER != null && registrocompra.CNUMSER.Length > 20)
                    {
                        registrocompra.CNUMSER = !datos.IsDBNull(datos.GetOrdinal("NUMVOUCHER")) ? datos.GetString(datos.GetOrdinal("NUMVOUCHER")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CNUMSER = !datos.IsDBNull(datos.GetOrdinal("NUMVOUCHER")) ? datos.GetString(datos.GetOrdinal("NUMVOUCHER")).Trim() : null;
                    }








                    /*
                                        AÑO DE EMISIÓN DE LA DUA O DSI
                                    4 CARACTERES            -->>FECHADUA <<--
                    
                    */
                    registrocompra.CEMIDUADSI = !datos.IsDBNull(datos.GetOrdinal("FECHADUA")) ? datos.GetInt32(datos.GetOrdinal("FECHADUA")) : (Int32?)null;







                    /*  
                                        NUMERO DEL COMPROBANTE DE PAGO
                                        TRATANDOSE DE LIQUIDACIONES DE COMPRA, UTILIZACIÓN DE SERVICIOS PRESTADOS 
                     *                  POR NO DOMICILIADOS U OTROS, CONSIGNAR NUMERO DE DOCUMENTO O NUMERO DE 
                     *                  ORDEN DEL FORMULARIO FISICO O FORMULARIO VIRTUAL DONDE CONSTE EL PAGO DEL IMPUESTO.
                     *                  EN LA IMPORTACION DE BIENES, CONSIGNAR NUMERO DE DUA, DE LA DSI, DE LA LIQUIDACION 
                     *                  DE COBRANZA O DE OTROS DOCUMENTOS EMITIDOS POR LA SUNAT QUE ACREDITEN EL CREDITO FISCAL
                   
                                    20 CARACTERES            -->> NUMVOUCHER <<--
                    */
                    registrocompra.CNUMDCODFV = !datos.IsDBNull(datos.GetOrdinal("NUMVOUCHER")) ? datos.GetString(datos.GetOrdinal("NUMVOUCHER")).Trim() : null;
                    if (registrocompra.CNUMDCODFV != null && registrocompra.CNUMDCODFV.Length > 20)
                    {
                        registrocompra.CNUMDCODFV = !datos.IsDBNull(datos.GetOrdinal("NUMVOUCHER")) ? datos.GetString(datos.GetOrdinal("NUMVOUCHER")).Substring(4, 20).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CNUMDCODFV = !datos.IsDBNull(datos.GetOrdinal("NUMVOUCHER")) ? datos.GetString(datos.GetOrdinal("NUMVOUCHER")).Trim() : null;
                    }








                    /* 
                                        EN CASO OPTAR POR ANOTAR, EN FORMA CONSOLIDADA, EL IMPORTE TOTAL DE LAS OPERACIONES
                     *                  DIARIAS QUE NO OTORGAN DERECHO A CREDITO FISCAL, SE REGISTRARÁ SÓLO EL NUMERO DEL ULTIMO
                     *                  COMPROBANTE DE PAGO
                     *                  
                                    20 CARACTERES            -->> NULL <<--
                    */
                    registrocompra.COSDCREFIS = "";
                    /*
                    registrocompra.COSDCREFIS = !datos.IsDBNull(datos.GetOrdinal("COSDCREFIS")) ? datos.GetString(datos.GetOrdinal("DNUMCTACON")).Trim() : null;
                    if (registrocompra.COSDCREFIS != null && registrocompra.COSDCREFIS.Length > 20)
                    {
                        registrocompra.COSDCREFIS = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        registrocompra.COSDCREFIS = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Trim() : null;
                    }
                    */






                    /*
                                    TIPO DE DOCUMENTO DE IDENTIDAD DEL PROVEEDOR
                                    1 CARACTERES         -->> NULL <<--
                    */
                    registrocompra.CTIPDIDPRO = "";
                    /*
                    registrocompra.CTIPDIDPRO = !datos.IsDBNull(datos.GetOrdinal("CTIPDIDPRO")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("DFECOPE"))) : null; ;
                    if (registrocompra.CTIPDIDPRO != null && registrocompra.CTIPDIDPRO.Length > 1)
                    {
                        registrocompra.CTIPDIDPRO = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Substring(0, 1).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CTIPDIDPRO = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Trim() : null;
                    }
                     */

                




                    /*
                                    NUMERO DE RUC DEL PROVEEDOR
                                    15 CARACTERES           -->> RUC <<--
                    */

                    registrocompra.CNUMDIDPRO = !datos.IsDBNull(datos.GetOrdinal("RUC")) ? datos.GetString(datos.GetOrdinal("RUC")).Trim() : null;
                    if (registrocompra.CNUMDIDPRO != null && registrocompra.CNUMDIDPRO.Length > 15)
                    {
                        registrocompra.CNUMDIDPRO = !datos.IsDBNull(datos.GetOrdinal("RUC")) ? datos.GetString(datos.GetOrdinal("RUC")).Substring(0, 15).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CNUMDIDPRO = !datos.IsDBNull(datos.GetOrdinal("RUC")) ? datos.GetString(datos.GetOrdinal("RUC")).Trim() : null;
                    }






                    /*
                                    APELLIDOS Y NOMBRES, DENOMINACION O RAZON SOCIAL
                                60 CARACTERES           -->> RAZON_SOCIAL <<--
                    */

                    registrocompra.CNOMRSOPRO = !datos.IsDBNull(datos.GetOrdinal("RAZON_SOCIAL")) ? datos.GetString(datos.GetOrdinal("RAZON_SOCIAL")).Trim() : null;
                    if (registrocompra.CNOMRSOPRO != null && registrocompra.CNOMRSOPRO.Length > 15)
                    {
                        registrocompra.CNOMRSOPRO = !datos.IsDBNull(datos.GetOrdinal("RAZON_SOCIAL")) ? datos.GetString(datos.GetOrdinal("RAZON_SOCIAL")).Substring(0, 15).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CNOMRSOPRO = !datos.IsDBNull(datos.GetOrdinal("RAZON_SOCIAL")) ? datos.GetString(datos.GetOrdinal("RAZON_SOCIAL")).Trim() : null;
                    }







                    /*
                                    BASE IMPOSITIVA DE LAS OPERACIONES GRAVADAS QUE DAN DERECHO A CREDITO FISCAL Y/O SALDO
                                    A FAVOR POR EXPORTACION, DESTINADAS EXCLUSIVAMENTE A OPERACIONES GRAVADAS Y/O DE EXPORTACION
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> AFECTO1 <<--
                    */
                    registrocompra.CBASIMPGRA = !datos.IsDBNull(datos.GetOrdinal("AFECTO1")) ? datos.GetDecimal(datos.GetOrdinal("AFECTO1")) : (decimal?)null;







                    /*
                                    MONTO DEL IMPUESTO GENERAL A LAS VENTAS (IGV) O IMPUESTO DE PROMOCION MUNICIPAL (IPM)
                     *              DE LA OPERACION GRAVADA
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> NULL <<--
                    */
                    registrocompra.CIGVGRA = !datos.IsDBNull(datos.GetOrdinal("IMPTO1")) ? datos.GetDecimal(datos.GetOrdinal("IMPTO1")) : (decimal?)null;
                   






                    /*
                                    BASE IMPONIBLE DE LAS ADQUISICIONES GRAVADAS QUE DAN DERECHO 
                     *              A CREDITO FISCAL Y/0 SALDO A FAVOR POR EXPORTACION, DESTINADAS EXLUSIVAMENTE
                     *              
                     *              A OPERACIONES GRAVADAS Y/O DE EXPORTACION A OPERACIONES NO GRAVADAS
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> NULL <<--
                    */
                    registrocompra.CBASIMPGNG = !datos.IsDBNull(datos.GetOrdinal("AFECTO2")) ? datos.GetDecimal(datos.GetOrdinal("AFECTO2")) : (decimal?)null;





                    /*
                                   MONTO DEL IGV O IPM DE LAS OPERACIONES GRAVADAS Y NO GRABADAS 
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> NULL <<--
                    */
                    registrocompra.CIGVGRANGV = !datos.IsDBNull(datos.GetOrdinal("IMPTO2")) ? datos.GetDecimal(datos.GetOrdinal("IMPTO2")) : (decimal?)null;







                    /*
                                    BASE IMPONIBLE DE LAS OPERACIONES GRAVADAS QUE NO DAN 
                     *              DERECHO A CREDITO FISCAL Y/O SALDO A FAVOR
                     *              POR EXPORTACION, POR NO ESTAR DESTINADAS A OPERACINES 
                     *              GRAVADAS O DE EXPORTACION
                     *              
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> NULL <<--
                    */
                    registrocompra.CBASIMPSCF = !datos.IsDBNull(datos.GetOrdinal("AFECTO3")) ? datos.GetDecimal(datos.GetOrdinal("AFECTO3")) : (decimal?)null;



                    /*
                                    MONTO DEL IGV O IPM DE LAS OPERACIONES GRAVADAS QUE NO 
                     *              DAN DERECHO A CREDITO FISCAL O SALDO A FAVOR POR EXPORTACION
                     *              
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> NULL <<--
                    */
                    registrocompra.CIGVSCF = !datos.IsDBNull(datos.GetOrdinal("IMPTO3")) ? datos.GetDecimal(datos.GetOrdinal("IMPTO3")) : (decimal?)null;







                    /*
                                    
                     *              VALOR DE LAS ADQUISICIONES NO GRAVADAS
                     *              
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> NULL <<--
                     
                      
                     registrocompra.CIMPTOTNGV = !datos.IsDBNull(datos.GetOrdinal("NULL")) ? datos.GetDecimal(datos.GetOrdinal("NULL")) : (decimal?)null;


                    */
                    registrocompra.CIMPTOTNGV = 00;




                    /*
                                    
                     *              MONTO DEL IMPUESTO SELECTIVO AL CONSUMO, EN LOS CASOS EN 
                     *              QUE EL SUJETO PUEDA UTILIZARLO COMO DEDUCCION
                     *              
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> NULL <<--
                    */
                    registrocompra.CISC = !datos.IsDBNull(datos.GetOrdinal("ISC")) ? datos.GetDecimal(datos.GetOrdinal("ISC")) : (decimal?)null;








                    /*
                                    
                     *              OTROS TRIBUTOS Y CARGOS QUE NO FORMAN PARTE DE LA BASE IMPONIBLE
                     *              
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> NULL <<--
                    */
                    registrocompra.COTRTRICGO = !datos.IsDBNull(datos.GetOrdinal("IMPTO4")) ? datos.GetDecimal(datos.GetOrdinal("IMPTO4")) : (decimal?)null;








                    /*
                                    
                     *              IMPORTE TOTAL DE LAS ADQUISICIONES REGISTRADAS SEGUN COMPROBANTE DE PAGO
                     *              
                                NUMERICO CON 12 ENTEROS Y 02 DECIMALES          -->> NULL <<--
                    */
                    registrocompra.CIMPTOTCOM = !datos.IsDBNull(datos.GetOrdinal("TOTAL")) ? datos.GetDecimal(datos.GetOrdinal("TOTAL")) : (decimal?)null;





                    /*
                                    
                     *              TIPO DE CAMBIO
                     *              
                                NUMERICO CON 1 ENTERO Y 03 DECIMALES          -->> NULL <<--
                    */
                    ////registrocompra.CTIPCAM = !datos.IsDBNull(datos.GetOrdinal("VVALFACEXP")) ? datos.GetString(datos.GetOrdinal("CTIPDOCMOD")).Trim() : null;
                    registrocompra.CTIPCAM = !datos.IsDBNull(datos.GetOrdinal("TCAMBIO")) ? String.Format("{0:0.000}", datos.GetDecimal(datos.GetOrdinal("TCAMBIO"))) : null; ;






                    /*
                     *              FECHA DE EMISION DEL COMPROBANTE DE PAGO QUE SE MODIFICA
                     * 
                     *              10 CARACTERES EN FORMATO DD/MM/AAAA
                                   
                     
                     registrocompra.CFECMOD = !datos.IsDBNull(datos.GetOrdinal("FECHA")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("FECHA"))) : null; ;


                    */
                    registrocompra.CFECMOD = "";





                    /*
                     *              TIPO DE COMPROBANTE DE PAGO QUE SE MODIFICA
                     * 
                     *              02 CARACTERES

                    
                    registrocompra.CTIPDOCMOD = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCMOD")) ? datos.GetString(datos.GetOrdinal("CTIPDOCMOD")).Trim() : null;
                    if (registrocompra.CTIPDOCMOD != null && registrocompra.CTIPDOCMOD.Length > 2)
                    {
                        registrocompra.CTIPDOCMOD = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Substring(0, 2).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CTIPDOCMOD = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Trim() : null;
                    }
                    */
                    registrocompra.CTIPDOCMOD = "";






                    /*
                     *              NUMERO DE SERIE DEL COMPROBANTE DE PAGO QUE SE MODIFICA
                     * 
                     *              20 CARACTERES

                    
                    registrocompra.CNUMSERMOD = !datos.IsDBNull(datos.GetOrdinal("CNUMSERMOD")) ? datos.GetString(datos.GetOrdinal("CNUMSERMOD")).Trim() : null;
                    if (registrocompra.CNUMSERMOD != null && registrocompra.CNUMSERMOD.Length > 20)
                    {
                        registrocompra.CNUMSERMOD = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CNUMSERMOD = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Trim() : null;
                    }

                    */
                    registrocompra.CNUMSERMOD = "";





                    /*
                     *              NUMERO DEL COMPROBANTE DE PAGO QUE SE MODIFICA
                     * 
                     *              20 CARACTERES

                    
                    registrocompra.CNUMDOCMOD = !datos.IsDBNull(datos.GetOrdinal("CNUMDOCMOD")) ? datos.GetString(datos.GetOrdinal("CNUMDOCMOD")).Trim() : null;
                    if (registrocompra.CNUMDOCMOD != null && registrocompra.CNUMDOCMOD.Length > 20)
                    {
                        registrocompra.CNUMDOCMOD = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CNUMDOCMOD = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Trim() : null;
                    }
                    */
                    registrocompra.CNUMDOCMOD = "";





                    /*
                     *              NUMERO DEL COMPROBANTE DE PAGO EMITIDO POR EL SUJETO NO DOMICIALIADO
                     * 
                     *              20 CARACTERES

                    
                    registrocompra.CCOMNODOMI = !datos.IsDBNull(datos.GetOrdinal("CNUMDOCMOD")) ? datos.GetString(datos.GetOrdinal("CNUMDOCMOD")).Trim() : null;
                    if (registrocompra.CCOMNODOMI != null && registrocompra.CCOMNODOMI.Length > 20)
                    {
                        registrocompra.CCOMNODOMI = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CCOMNODOMI = !datos.IsDBNull(datos.GetOrdinal("CTIPDOCCOM")) ? datos.GetString(datos.GetOrdinal("DGLOSA")).Trim() : null;
                    }
                    */
                    registrocompra.CCOMNODOMI = "";





                    /*
                     *              FECHA DE EMISION DE LA CONSTANCIA DEL DEPOSITO DE DETRACCION
                     * 
                     *              10 CARACTERES EN FORMATO DD/MM/AAAA

                    */
                    registrocompra.CEMIDEPDET = !datos.IsDBNull(datos.GetOrdinal("FEC_DETRACCION")) ? String.Format("{0:d}", datos.GetDateTime(datos.GetOrdinal("FEC_DETRACCION"))) : null; ;






                     /*
                                    NUMERO DE CONSTANCIA DE DEPOSITVO DE DETRACCION
                       
                                    05 CARACTERES

                    */
                    registrocompra.CNUMCONDET = !datos.IsDBNull(datos.GetOrdinal("DOC_DETRACCION")) ? datos.GetString(datos.GetOrdinal("DOC_DETRACCION")).Trim() : null;




                    /*
                                        MARCA DEL COMPROBANTE DE PAGO SUJETO A RETENCION
                       
                                   05 CARACTERES

                   
                    registrocompra.CCOMPGORET = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;
                    if (registrocompra.CCOMPGORET != null && registrocompra.CCOMPGORET.Length > 1)
                    {
                        registrocompra.CCOMPGORET = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Substring(0, 1).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CCOMPGORET = !datos.IsDBNull(datos.GetOrdinal("")) ? datos.GetString(datos.GetOrdinal("")).Trim() : null;
                    }
                    */
                    registrocompra.CCOMPGORET = "";




   
                    /*
                                        CODIGO INTERNO O NUMERO DE REGISTRO DE LA OPERACION GENERADO 
                     *                  POR EL SISTEMA, QUE PERMITE RASTREAR LA OPERACION DENTRO 
                     *                  DEL LIBRO DIARIO O MAYOR. PODRIA SER IGUAL AL CAMPO CHUMREGOPE
                       
                                  20 CARACTERES

                   */
                    registrocompra.CINTDIMAY = !datos.IsDBNull(datos.GetOrdinal("IDCOBRARPAGARDOC")) ? datos.GetString(datos.GetOrdinal("IDCOBRARPAGARDOC")).Trim() : null;
                    if (registrocompra.CINTDIMAY != null && registrocompra.CINTDIMAY.Length > 20)
                    {
                        registrocompra.CINTDIMAY = !datos.IsDBNull(datos.GetOrdinal("IDCOBRARPAGARDOC")) ? datos.GetString(datos.GetOrdinal("IDCOBRARPAGARDOC")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CINTDIMAY = !datos.IsDBNull(datos.GetOrdinal("IDCOBRARPAGARDOC")) ? datos.GetString(datos.GetOrdinal("IDCOBRARPAGARDOC")).Trim() : null;
                    }



                    /*
                                        CODIGO INTERNO O NUMERO DE REGISTRO DE LA OPERACION GENERADO 
                     *                  POR EL SISTEMA, QUE PERMITE RASTREAR LA OPERACION DENTRO 
                     *                  DEL LIBRO KARDEX
                       
                                  20 CARACTERES

                   */
                    registrocompra.CINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("IDCOBRARPAGARDOC")) ? datos.GetString(datos.GetOrdinal("IDCOBRARPAGARDOC")).Trim() : null;
                    if (registrocompra.CINTKARDEX != null && registrocompra.CINTKARDEX.Length > 20)
                    {
                        registrocompra.CINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("IDCOBRARPAGARDOC")) ? datos.GetString(datos.GetOrdinal("IDCOBRARPAGARDOC")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CINTKARDEX = !datos.IsDBNull(datos.GetOrdinal("IDCOBRARPAGARDOC")) ? datos.GetString(datos.GetOrdinal("IDCOBRARPAGARDOC")).Trim() : null;
                    }



                    /*
                                        CODIGO INTERNO O NUMERO DE REGISTRO DE LA OPERACION GENERADO 
                     *                  POR EL SISTEMA, QUE PERMITE RASTREAR LA OPERACION EN TODOS LOS MODULOS
                       
                                  20 CARACTERES

                   */
                    registrocompra.CINTREG = !datos.IsDBNull(datos.GetOrdinal("IDCOBRARPAGARDOC")) ? datos.GetString(datos.GetOrdinal("IDCOBRARPAGARDOC")).Trim() : null;
                    if (registrocompra.CINTREG != null && registrocompra.CINTREG.Length > 20)
                    {
                        registrocompra.CINTREG = !datos.IsDBNull(datos.GetOrdinal("IDCOBRARPAGARDOC")) ? datos.GetString(datos.GetOrdinal("IDCOBRARPAGARDOC")).Substring(0, 20).Trim() : null;
                    }
                    else
                    {
                        registrocompra.CINTREG = !datos.IsDBNull(datos.GetOrdinal("IDCOBRARPAGARDOC")) ? datos.GetString(datos.GetOrdinal("IDCOBRARPAGARDOC")).Trim() : null;
                    }   



                    registrosCompra.Add(registrocompra);

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

            return registrosCompra;
        }
    

    }
}
