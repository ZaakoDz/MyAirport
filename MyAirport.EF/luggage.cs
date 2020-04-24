using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZW.MyAirport.EF
{
    public class Luggage
    {
        public Luggage() { }
        
        public int LUGGAGEID { get; set; } //ID baggage 
        public int? FLIGHTID { get; set; } //ID Vol
        [ForeignKey("FLIGHTID")]
        public Flight FLIGHT { get; set; } //jointure entre le bagage et le vol par le FLIGHTID

        [StringLength(16)]
        [Display(Name = "Code IATA")]    //permet de fixer le nombre de caractères à 16 et d'écrire CODE IATA

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
