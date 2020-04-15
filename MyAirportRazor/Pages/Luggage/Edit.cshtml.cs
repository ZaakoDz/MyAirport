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
    public class EditModelLuggage : PageModel
    {
        private readonly ZW.MyAirport.EF.MyAirportContext _context;

        public EditModelLuggage(ZW.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        [BindProperty]
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
           ViewData["FLIGHTID"] = new SelectList(_context.Flights, "FLIGHTID", "FLIGHTID");
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

            _context.Attach(Luggage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LuggageExists(Luggage.LUGGAGEID))
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

        private bool LuggageExists(int id)
        {
            return _context.Luggages.Any(e => e.LUGGAGEID == id);
        }
    }
}
