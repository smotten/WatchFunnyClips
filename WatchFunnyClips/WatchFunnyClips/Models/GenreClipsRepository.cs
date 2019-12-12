﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WatchFunnyClips.Models
{
    public class GenreClipsRepository : IGenreClipsRepository
    {
        private readonly WatchFunnyClipContext _context;
        public GenreClipsRepository(WatchFunnyClipContext context)
        {
            this._context = context;
        }


        public void Delete(int genreId)
        {
            _context.GenreClips.Remove(this.Get(genreId));
        }

        public List<GenreClips> Get()
        {
            return _context.GenreClips.ToList();
        }

        public GenreClips Get(int genreId)
        {
            return _context.GenreClips.Find(genreId);
        }

        public void Save(GenreClips g)
        {
            if (g.GenreClipsId == 0)
            {
                _context.GenreClips.Add(g);
            } else
            {
                _context.GenreClips.Update(g);
            }

            _context.SaveChanges();
        }
    }
}