using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WatchFunnyClips.Models;
using WatchFunnyClipsAPI.Models;

namespace WatchFunnyClipsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClipController : ControllerBase
    {
        private readonly WatchFunnyClipsAPIContext _context;

        public ClipController(WatchFunnyClipsAPIContext context)
        {
            _context = context;
        }

        // GET: api/Clip
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Clip>>> GetClips()
        {
            return await _context.Clips.ToListAsync();
        }

        // GET: api/Clip/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Clip>> GetClip(int id)
        {
            var clip = await _context.Clips.FindAsync(id);

            if (clip == null)
            {
                return NotFound();
            }

            return clip;
        }

        // PUT: api/Clip/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClip(int id, Clip clip)
        {
            if (id != clip.ClipId)
            {
                return BadRequest();
            }

            _context.Entry(clip).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClipExists(id))
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

        // POST: api/Clip
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Clip>> PostClip(Clip clip)
        {
            _context.Clips.Add(clip);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetClip), new { id = clip.ClipId }, clip);
        }

        // DELETE: api/Clip/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Clip>> DeleteClip(int id)
        {
            var clip = await _context.Clips.FindAsync(id);
            if (clip == null)
            {
                return NotFound();
            }

            _context.Clips.Remove(clip);
            await _context.SaveChangesAsync();

            return clip;
        }

        private bool ClipExists(int id)
        {
            return _context.Clips.Any(e => e.ClipId == id);
        }
    }
}
