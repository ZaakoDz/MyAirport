using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZW.MyAirport.EF;

namespace MyAirportRazor
{
    public class EditModelFlight : PageModel
    {
        private readonly ZW.MyAirport.EF.MyAirportContext _context;

        public EditModelFlight(ZW.MyAirport.EF.MyAirportContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Flight).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FlightExists(Flight.FLIGHTID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FlightExists(int id)
        {
            return _context.Flights.Any(e => e.FLIGHTID == id);
        }
    }
}
