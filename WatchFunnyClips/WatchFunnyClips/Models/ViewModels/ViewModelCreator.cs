
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WatchFunnyClips.Models.ViewModels{
    public class ViewModelCreator{
        public static WatchFunnyClipVM CreateClipVM (IGenreClipsRepository genreClipsRepository){
            return new WatchFunnyClipVM()
            {
                Clip = new Clip(),
                GenreClipSelectList = new SelectList(genreClipsRepository.Get(),"GenreClipsId", "GenreName")
            };
        }
        public ViewModelCreator(){
            
        }
    }
}