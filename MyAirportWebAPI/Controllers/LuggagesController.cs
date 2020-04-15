using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZW.MyAirport.EF;

namespace MyAirportWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LuggagesController : ControllerBase
    {
        private readonly MyAirportContext _context;

        public LuggagesController(MyAirportContext context)
        {
            _context = context;
        }

        // GET: api/Luggages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Luggage>>> GetLuggages()
        {
            return await _context.Luggages.ToListAsync();
        }

        // GET: api/Luggages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Luggage>> GetLuggage(int id)
        {
            var luggage = await _context.Luggages.FindAsync(id);

            if (luggage == null)
            {
                return NotFound();
            }

            return luggage;
        }

        // PUT: api/Luggages/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLuggage(int id, Luggage luggage)
        {
            if (id != luggage.LUGGAGEID)
            {
                return BadRequest();
            }

            _context.Entry(luggage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LuggageExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Luggages
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Luggage>> PostLuggage(Luggage luggage)
        {
            _context.Luggages.Add(luggage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLuggage", new { id = luggage.LUGGAGEID }, luggage);
        }

        // DELETE: api/Luggages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Luggage>> DeleteLuggage(int id)
        {
            var luggage = await _context.Luggages.FindAsync(id);
            if (luggage == null)
            {
                return NotFound();
            }

            _context.Luggages.Remove(luggage);
            await _context.SaveChangesAsync();

            return luggage;
        }

        private bool LuggageExists(int id)
        {
            return _context.Luggages.Any(e => e.LUGGAGEID == id);
        }
    }
}
