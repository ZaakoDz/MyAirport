using System;
using System.Collections.Generic;
using System.Text;

namespace ZW.MyAirport.EF
{

    public class Flight
    {
       

        public Flight()
        {
            this.Luggages = new HashSet<Luggage>();  //**
        }
        public int FLIGHTID { get; set; }
        public  int CIE { get; set; } //numéro de compagnie
        public string LIG { get; set; } //ligne
        public int JEX { get; set; }
        public DateTime DHC { get; set; }
        public string PKG { get; set; }
        public string IMM { get; set; }
        public int PAX { get; set; }
        public string DES { get; set; } //destination
        public virtual ICollection<Luggage> Luggages { get; set; } //**affecter baggage à vol

    }
}
