using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ZW.MyAirport.EF;

namespace MyAirportRazor
{
    public class IndexModelFlight : PageModel
    {
        private readonly ZW.MyAirport.EF.MyAirportContext _context;

        public IndexModelFlight(ZW.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IList<Flight> Flight { get;set; }

        public async Task OnGetAsync()
        {
            Flight = await _context.Flights.ToListAsync();
        }
    }
}
