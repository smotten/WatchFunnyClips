using System.Collections.Generic;

namespace WatchFunnyClips.Models{
    public interface IGenreClipsRepository{
        public void Save(GenreClips g);

        public List <GenreClips> Get();

        public GenreClips Get(int genreId);

        public void Delete(int genreId);
    }

}