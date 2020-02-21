using System;
using System.Collections.Generic;
using System.Text;

namespace ZW.MyAirport.EF
{

    public class Flight
    {
        public int FLIGHTID { get; set; }
        public  int CIE { get; set; }
        public string LIG { get; set; }
        public int JEX { get; set; }
        public DateTime DHC { get; set; }
        public string PKG { get; set; }
        public string IMM { get; set; }
        public int PAX { get; set; }
        public string DES { get; set; }
    }
}
