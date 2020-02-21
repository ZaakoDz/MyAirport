using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZW.MyAirport.EF
{
    public class Luggage
    {
        public int LUGGAGEID { get; set; }
        public int FLIGHTID { get; set; }
        [ForeignKey("FLIGHTID")]
        public Flight FLIGHT { get; set; } //jointure entre le bagage et le vol par le FLIGHTID
        public string CODE_IATA { get; set; }
        public DateTime DATE_CREATION { get; set; }
        public string CLASSE { get; set; }
        public bool PRIORITAIRE { get; set; }
        public string STA { get; set; }
        public string SSUR { get; set; }
        public string DESTINATION { get; set; }
        public string ESCALE {get; set;}

    }
}
