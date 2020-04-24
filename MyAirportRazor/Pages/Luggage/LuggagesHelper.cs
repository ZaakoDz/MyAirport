using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZW.MyAirport.EF;

namespace MyAirportRazor 
{
    public static class LuggagesHelper //classe permettant d'externaliser la liste des infos sur les vols (lister défilante dans Edit et Create)
    {
        public static SelectList ListFlightInfo(ZW.MyAirport.EF.MyAirportContext context)
        {
            var flights = context.Flights
                .Select(f => new
                {
                    f.FLIGHTID,
                    Description = $"{f.CIE} {f.LIG} : {f.DHC.ToShortDateString()}"
                }).ToList();
            return new SelectList(flights, "FLIGHTID", "Description");

        }

       
    }
}
