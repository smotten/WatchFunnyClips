using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WatchFunnyClips.Models;
using WatchFunnyClips.Models.ViewModels;

namespace WatchFunnyClips.Controllers
{
    public class ClipController : Controller
    {

        private IClipRepository clipRepository;
        private IGenreClipsRepository genreClipsRepository;

    
        public ClipController(IClipRepository clipRepository, IGenreClipsRepository genreClipsRepositor)
        {
            this.clipRepository = clipRepository;
            this.genreClipsRepository = genreClipsRepositor;
        }

        // GET: Clip
        
        public IActionResult Index(String id)
        {
            List<Clip> clips = this.clipRepository.Find(id);
            return View("Index", clips.ToList());
        }

        // GET: Clip/Details/5
        /*
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clip = await _context.Clip
                .FirstOrDefaultAsync(m => m.ClipId == id);
            if (clip == null)
            {
                return NotFound();
            }

            return View(clip);
        }*/

        // GET: Clip/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View(ViewModelCreator.CreateClipVM(genreClipsRepository));
        }

        // POST: Clip/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(WatchFunnyClipVM vm)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Thanks = vm.Clip.Title;
                ViewBag.Clip = vm.Clip;

                clipRepository.Save(vm.Clip);

                return View("Thanks", vm.Clip);
            }
            return View(ViewModelCreator.CreateClipVM(genreClipsRepository));
            
        }
        

        // GET: Clip/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clips = clipRepository.Get((int)id);
            if (clips == null)
            {
                return NotFound();
            }
            return View(clips);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("ClipId,Title,Description,Url,GenreClipsId")] Clip clips)
        {
            if (id != clips.ClipId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    clipRepository.Save(clips);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClipExists(clips.ClipId))
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
            return View(clips);
        }

        // GET: Clip/Delete/5
        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var clips = clipRepository.Get((int)id);
            if(clips == null)
            {
                return NotFound();
            }
            return View(clips);
        }

        // POST: Clip/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            clipRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        private bool ClipExists(int id)
        {
            return false;
        }


/* 
        public ActionResult Index(String searching){
            var genres = from c in _context.GenreClips select c;
            if (!String.IsNullOrEmpty(searching))
            {
                genres = genres.Where(c => c.GenreClipsId.Contains(searching));
            }


            return View(genres.ToList());

        }*/
    }
}
