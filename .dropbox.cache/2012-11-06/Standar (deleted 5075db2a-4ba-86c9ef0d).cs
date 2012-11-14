using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace mantenimientoStandares.Entidades
{
    public class Standar
    {
        public string IdStandar { get; set; }
        public string IdArea { get; set; }
        public decimal? HorasTrabajadas	{ get; set; }
        public decimal? Estandar { get; set; }
        public decimal? EstandarExtra { get; set; }
        public decimal? Jornal	{ get; set; }
        public decimal? PrecioUnitario	{ get; set; }
        public decimal? PrecioUnitarioExtra	{ get; set; }
        public decimal? UserDecimal01 { get; set; }
        public string UserVarchar01 { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string IdFormato { get; set; }
        public decimal? EstandarPorcentajePrimerDia	{ get; set; }
        public decimal? EstandarPorcentajeSegundoDia	{ get; set; }
        public decimal? EstandarPrimerDia { get; set; }
        public decimal? EstandarSegundoDia { get; set; }
        public decimal? PrecioPrimerDia	{ get; set; }
        public decimal? PrecioSegundoDia	{ get; set; }



    }
}
