using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KB.MyAirport.EF;

namespace MyAirportWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class VolsController : ControllerBase
    {
        private readonly MyAirportContext _context;

        public VolsController(MyAirportContext context)
        {
            _context = context;
        }

        // GET: api/Vols
        /// <summary>
        /// Gets all Vol.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Vols
        ///
        /// </remarks>
        /// <response code="200">Returns all the flights</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vol>>> GetVols()
        {
            return await _context.Vols.ToListAsync();
        }

        // GET: api/Vols/5
        /// <summary>
        /// Gets a specific Vol.
        /// L'option "bagages" permet d'affichier la liste de bagage du vol.
        /// Si false pas d'affichage.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /api/Vols/1?bagages
        ///
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="bagages"></param>
        /// <response code="200">Returns the flight with specified id</response>
        /// <response code="404">No flight with the specified id</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public async Task<ActionResult<Vol>> GetVol(int id, [FromQuery] bool bagages = false)
        {
            Vol vol;
            if (bagages)
                vol = await _context.Vols.Include(v => v.Bagages).FirstAsync(v => v.VoldID==id);
            else
                vol = await _context.Vols.FindAsync(id);
            if (vol == null)
            {
                return NotFound();
            }
            return vol;
        }

        // PUT: api/Vols/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        /// <summary>
        /// Updates a Vol.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     PUT /api/Vols/1
        ///     {
        ///         "Cie" : "LH",
        ///         "Des" : "BKK",
        ///         "Dhc" : Convert.ToDateTime("14/01/2020 16:45"),
        ///         "Imm" : "RZ62",
        ///         "Lig" : "1232",
        ///         "Pkg" : "R52",
        ///         "Pax" : 238
        ///     }
        ///
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="vol"></param>
        /// <response code="200">Returns the flight with specified id</response>
        /// <response code="404">No flight with the specified id</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVol(int id, Vol vol)
        {
            if (id != vol.VoldID)
            {
                return BadRequest();
            }

            _context.Entry(vol).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VolExists(id))
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

        // POST: api/Vols
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        /// <summary>
        /// Creates a Vol.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /api/Vols
        ///     {
        ///         "Cie" : "LH",
        ///         "Des" : "BKK",
        ///         "Dhc" : Convert.ToDateTime("14/01/2020 16:45"),
        ///         "Imm" : "RZ62",
        ///         "Lig" : "1232",
        ///         "Pkg" : "R52",
        ///         "Pax" : 238
        ///     }
        ///
        /// </remarks>
        /// <param name="vol"></param>
        /// <returns></returns>
        /// <response code="201">Flight created</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public async Task<ActionResult<Vol>> PostVol(Vol vol)
        {
            _context.Vols.Add(vol);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVol", new { id = vol.VoldID }, vol);
        }

        // DELETE: api/Vols/5
        /// <summary>
        /// Deletes a specific Vol.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     DELETE /api/Vols/1
        ///
        /// </remarks>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vol>> DeleteVol(int id)
        {
            var vol = await _context.Vols.FindAsync(id);
            if (vol == null)
            {
                return NotFound();
            }

            _context.Vols.Remove(vol);
            await _context.SaveChangesAsync();

            return vol;
        }

        /// <summary>
        /// Vérifie que le vol d'identifiant spécifié existe.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool VolExists(int id)
        {
            return _context.Vols.Any(e => e.VoldID == id);
        }
    }
}
