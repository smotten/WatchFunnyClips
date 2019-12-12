using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WatchFunnyClips.Models;

namespace WatchFunnyClips.Controllers
{
    public class GenreClipsController : Controller
    {        
        private readonly IGenreClipsRepository repo;

        public GenreClipsController(IGenreClipsRepository repo)
        {
            this.repo = repo;
        }

        // GET: Species
        public IActionResult Index()
        {
            return View(repo.Get());
        }

        // GET: Species/Details/5
        public IActionResult Details(int? genreClipsId)
        {
            if (genreClipsId == null)
            {
                return NotFound();
            }

            var genreClips = repo.Get((int)genreClipsId);
            if (genreClips == null)
            {
                return NotFound();
            }

            return View(genreClips);
        }

        // GET: Species/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Species/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("GenreClipsId,GenreName")] GenreClips genreClips)
        {
            if (ModelState.IsValid)
            {
                repo.Save(genreClips);

                return RedirectToAction(nameof(Index));
            }
            return View(genreClips);
        }

        // GET: Species/Edit/5
        public IActionResult Edit(int? genreClipId)
        {
            if (genreClipId == null)
            {
                return NotFound();
            }

            var genreClips = repo.Get((int)genreClipId);
            if (genreClips == null)
            {
                return NotFound();
            }
            return View(genreClips);
        }

        // POST: Species/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int genreClipsId, [Bind("GenreClipsId,GenreName2")] GenreClips genreClips)
        {
            if (genreClipsId != genreClips.GenreClipsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    repo.Save(genreClips);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenreClipsExists(genreClips.GenreClipsId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(genreClips);
        }

        // GET: Species/Delete/5
        public IActionResult Delete(int? genreClipsId)
        {
            if (genreClipsId == null)
            {
                return NotFound();
            }

            var genreClips = repo.Get((int)genreClipsId);
            if (genreClips == null)
            {
                return NotFound();
            }

            return View(genreClips);
        }

        // POST: Species/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int genreClipId)
        {
            repo.Delete(genreClipId);

            return RedirectToAction(nameof(Index));
        }

        private bool GenreClipsExists(int genreClipId)
        {
            // I did this so we could unit test. TODO: Fix this..
            return false;
        }
    }
}