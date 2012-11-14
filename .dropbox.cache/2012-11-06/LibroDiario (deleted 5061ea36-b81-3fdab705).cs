using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rSunat.ReportesSunat.Entidades
{
    public class LibroDiario
    {

        //DMES varchar(02) default
        private string _DMES;
        public string DMES
        {
            get { return _DMES; }
            set { _DMES = value; }
        }

        //DNUMASIOPE varchar(15)	default ''
        private string _DNUMASIOPE;
        public string DNUMASIOPE
        {
            get { return _DNUMASIOPE; }
            set { _DNUMASIOPE = value; }
        }

        //DNUMCTACON varchar(40) default ''
        private string _DNUMCTACON;
        public string DNUMCTACON
        {
            get { return _DNUMCTACON; }
            set { _DNUMCTACON = value; }
        }

        //DFECOPE    varchar(12) default '',  -- idcuenta
        private string _DFECOPE;
        public string DFECOPE
        {
            get { return _DFECOPE; }
            set { _DFECOPE = value; }
        }

        //DGLOSA	varchar(100) default '', 
        private string _DGLOSA;
        public string DGLOSA
        {
            get { return _DGLOSA; }
            set { 
                _DGLOSA = value;}
        }

        // DCENCOS	varchar(50)	default '',  -- COMPROBANTE
        private string _DCENCOS;
        public string DCENCOS
        {
            get { return _DCENCOS; }
            set { _DCENCOS = value; }
        }

        public string DDEBE { get; set; }
        //DDEBE numeric(17,2) default 0, -- 
        //private Decimal? _DDEBE;
        //public Decimal? DDEBE
        //    {
        //        get { return _DDEBE; }
        //        set { _DDEBE = value; }
        //    }
        
        //MHABER    numeric(17,2) default 0,

        public string DHABER { get; set; }
        //private Decimal? _DHABER;
        //public Decimal? DHABER
        //    {
        //        get { return _DHABER; }
        //        set { _DHABER = value; }
        //    }

        //MINTREG	varchar(20) default '')
        private string _DINTREG;
        public string DINTREG
        {
            get { return _DINTREG; }
            set { _DINTREG = value; }
        }

        //DINTKARDEX	varchar(20) default '')
        private string _DINTKARDEX;
        public string DINTKARDEX
        {
            get { return _DINTKARDEX; }
            set { _DINTKARDEX = value; }
        }

        //DINTVTACOM	varchar(20) default '')
        private string _DINTVTACOM;
        public string DINTVTACOM
        {
            get { return _DINTVTACOM; }
            set { _DINTVTACOM = value; }
        }

        //DINTREG2	varchar(20) default '')
        private string _DINTREG2;
        public string DINTREG2
        {
            get { return _DINTREG2; }
            set { _DINTREG2 = value; }
        }

    }
}

