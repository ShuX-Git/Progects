using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HospitalPetRegist.Models;

namespace HospitalPetRegist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalAPIController : ControllerBase
    {
        private readonly HospitalAPIContext _context;

        public HospitalAPIController(HospitalAPIContext context)
        {
            _context = context;
        }

        // GET: api/HospitalAPI
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HospitalAPI>>> GetHospitalAPIs()
        {
            return await _context.HospitalAPIs.ToListAsync();
        }

        // GET: api/HospitalAPI/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HospitalAPI>> GetHospitalAPI(int id)
        {
            var hospitalAPI = await _context.HospitalAPIs.FindAsync(id);

            if (hospitalAPI == null)
            {
                return NotFound();
            }

            return hospitalAPI;
        }

        // PUT: api/HospitalAPI/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHospitalAPI(int id, HospitalAPI hospitalAPI)
        {
            if (id != hospitalAPI.NumberId)
            {
                return BadRequest();
            }

            _context.Entry(hospitalAPI).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HospitalAPIExists(id))
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

        // POST: api/HospitalAPI
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HospitalAPI>> PostHospitalAPI(HospitalAPI hospitalAPI)
        {
            _context.HospitalAPIs.Add(hospitalAPI);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHospitalAPI", new { id = hospitalAPI.NumberId }, hospitalAPI);
        }

        // DELETE: api/HospitalAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHospitalAPI(int id)
        {
            var hospitalAPI = await _context.HospitalAPIs.FindAsync(id);
            if (hospitalAPI == null)
            {
                return NotFound();
            }

            _context.HospitalAPIs.Remove(hospitalAPI);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HospitalAPIExists(int id)
        {
            return _context.HospitalAPIs.Any(e => e.NumberId == id);
        }
    }
}
