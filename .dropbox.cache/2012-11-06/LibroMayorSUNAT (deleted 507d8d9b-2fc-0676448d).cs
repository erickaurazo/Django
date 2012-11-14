using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rSunat.ReportesSunat.Entidades
{
    public class LibroMayorSUNAT
    {
        public string MES { get; set; }
        public string VOUCHER {get; set;}
        public string CUENTA { get; set; }
        public string FECHA_DE_OPERACION { get; set; }
        public string DESCRIPCION { get; set; }
        public string CENTRO_DE_COSTOS { get; set; }
        public string DEBE { get; set; }
        public string HABER { get; set; }
        public string COD_OPERACION { get; set; }
        public string COD_KARDEX { get; set; }
        public string COD_COMPRAVENTA { get; set; }
        public string COD_DE_MODULO { get; set; }
    }
}