using System;
using System.Collections.Generic;
using System.Linq;
using WatchFunnyClips.Models;
using Microsoft.EntityFrameworkCore;


namespace WatchFunnyClips.Models
{
    public class GenreRepository : IClipRepository
    {
        private readonly WatchFunnyClipContext _context;
        public GenreRepository(WatchFunnyClipContext _context)
        {
            this._context = _context;
        }

        public void Delete(int clipId)
        {
            _context.Clip.Remove(this.Get(clipId));
            _context.SaveChanges();

        }

        public List<Clip> Find(String submit)
        {
            var clips = from c in _context.Clip.Include(g => g.GenreClips)
                       select c;

            if (!String.IsNullOrEmpty(submit))
            {
                clips = clips.Where(Clip => Clip.GenreClips.GenreName.Contains((submit)));
            }

            return clips.ToList();

        }
        

        public List<Clip> Get()
        {
            return _context.Clip.ToList();
        }

        public Clip Get(int clipId)
        {
            return _context.Clip.Find(clipId);
        }

        public void Save(Clip c)
        {
            if (c.ClipId == 0)
            {
                _context.Clip.Add(c);
            }
            else
            {
                _context.Clip.Update(c);
            }

            _context.SaveChanges();
        }
    }
}