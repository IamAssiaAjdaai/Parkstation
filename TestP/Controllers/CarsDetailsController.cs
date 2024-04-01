using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestP.Models;

namespace TestP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsDetailsController : ControllerBase
    {
        private readonly CarDetailDbContext _context;

        public CarsDetailsController(CarDetailDbContext context)
        {
            _context = context;
        }

        // GET: api/CarsDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CarsDetail>>> GetCarsDetails()
        {
         if (_context.CarsDetails == null) { return NotFound(); }
         return await _context.CarsDetails.ToListAsync();
        }

        // GET: api/CarsDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CarsDetail>> GetCarsDetail(int id)
        {
            var carsDetail = await _context.CarsDetails.FindAsync(id);

            if (carsDetail == null)
            {
                return NotFound();
            }

            return carsDetail;
        }

        // PUT: api/CarsDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCarsDetail(int id, CarsDetail carsDetail)
        {
            if (id != carsDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(carsDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarsDetailExists(id))
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

        // POST: api/CarsDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CarsDetail>> PostCarsDetail(CarsDetail carsDetail)
        {
         if (_context.CarsDetails == null) { return Problem("Entitx set 'CarDetailDbContext.CarsDetails' ist null."); }
            _context.CarsDetails.Add(carsDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCarsDetail", new { id = carsDetail.Id }, carsDetail);
        }

        // DELETE: api/CarsDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCarsDetail(int id)
        {
            var carsDetail = await _context.CarsDetails.FindAsync(id);
            if (carsDetail == null)
            {
                return NotFound();
            }

            _context.CarsDetails.Remove(carsDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CarsDetailExists(int id)
        {
            return _context.CarsDetails.Any(e => e.Id == id);
        }

   }
}
