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
    public class DetailsModelLuggage : PageModel
    {
        private readonly ZW.MyAirport.EF.MyAirportContext _context;

        public DetailsModelLuggage(ZW.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public Luggage Luggage { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Luggage = await _context.Luggages
                .Include(l => l.FLIGHT).FirstOrDefaultAsync(m => m.LUGGAGEID == id);

            if (Luggage == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
