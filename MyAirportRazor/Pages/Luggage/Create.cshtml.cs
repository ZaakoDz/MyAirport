using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ZW.MyAirport.EF;

namespace MyAirportRazor
{
    public class CreateModelLuggage : PageModel
    {
        private readonly ZW.MyAirport.EF.MyAirportContext _context;

        public CreateModelLuggage(ZW.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["FLIGHTID"] = new SelectList(_context.Flights, "FLIGHTID", "FLIGHTID");
            return Page();
        }

        [BindProperty]
        public Luggage Luggage { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Luggages.Add(Luggage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
