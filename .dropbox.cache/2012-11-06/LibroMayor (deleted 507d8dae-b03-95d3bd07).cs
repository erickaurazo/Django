using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rSunat.ReportesSunat.AccesoDatos
{
    public class LibroMayor
    {
        //MMES varchar(02) default
        private string _MMES;
        public string MMES
        {
            get { return _MMES; }
            set { _MMES = value; }
        }

        //MNUMASIOPE varchar(15)	default ''
        private string _MNUMASIOPE;
        public string MNUMASIOPE
        {
            get { return _MNUMASIOPE; }
            set { _MNUMASIOPE = value; }
        }

        //MNUMCTACON varchar(40) default ''
        private string _MNUMCTACON;
        public string MNUMCTACON
        {
            get { return _MNUMCTACON; }
            set { _MNUMCTACON = value; }
        }

        //MFECOPE    varchar(12) default '',  -- idcuenta
        private string _MFECOPE;
        public string MFECOPE
        {
            get { return _MFECOPE; }
            set { _MFECOPE = value; }
        }

        //MGLOSA	varchar(100) default '', 
        private string _MGLOSA;
        public string MGLOSA
        {
            get { return _MGLOSA; }
            set
            {
                _MGLOSA = value;
            }
        }

        // MCENCOS	varchar(50)	default '',  -- COMPROBANTE
        private string _MCENCOS;
        public string MCENCOS
        {
            get { return _MCENCOS; }
            set { _MCENCOS = value; }
        }

        //MDEBE numeric(17,2) default 0, -- 
        private Decimal? _MDEBE;
        public Decimal? MDEBE
        {
            get { return _MDEBE; }
            set { _MDEBE = value; }
        }

        //MHABER    numeric(17,2) default 0,
        private Decimal? _MHABER;
        public Decimal? MHABER
        {
            get { return _MHABER; }
            set { _MHABER = value; }
        }

        //MINTREG	varchar(20) default '')
        private string _MINTREG;
        public string MINTREG
        {
            get { return _MINTREG; }
            set { _MINTREG = value; }
        }

        //MINTKARDEX	varchar(20) default '')
        private string _MINTKARDEX;
        public string MINTKARDEX
        {
            get { return _MINTKARDEX; }
            set { _MINTKARDEX = value; }
        }

        //MINTVTACOM	varchar(20) default '')
        private string _MINTVTACOM;
        public string MINTVTACOM
        {
            get { return _MINTVTACOM; }
            set { _MINTVTACOM = value; }
        }

        //MINTREG2	varchar(20) default '')
        private string _MINTREG2;
        public string MINTREG2
        {
            get { return _MINTREG2; }
            set { _MINTREG2 = value; }
        }



    }
}
