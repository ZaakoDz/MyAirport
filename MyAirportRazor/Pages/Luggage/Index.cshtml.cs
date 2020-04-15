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
    public class IndexModelLuggage : PageModel
    {
        private readonly ZW.MyAirport.EF.MyAirportContext _context;

        public IndexModelLuggage(ZW.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IList<Luggage> Luggage { get;set; }

        public async Task OnGetAsync()
        {
            Luggage = await _context.Luggages
                .Include(l => l.FLIGHT).ToListAsync();
        }
    }
}
