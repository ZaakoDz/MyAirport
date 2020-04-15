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
    public class DeleteModelFlight : PageModel
    {
        private readonly ZW.MyAirport.EF.MyAirportContext _context;

        public DeleteModelFlight(ZW.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Flight Flight { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight = await _context.Flights.FirstOrDefaultAsync(m => m.FLIGHTID == id);

            if (Flight == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Flight = await _context.Flights.FindAsync(id);

            if (Flight != null)
            {
                _context.Flights.Remove(Flight);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
