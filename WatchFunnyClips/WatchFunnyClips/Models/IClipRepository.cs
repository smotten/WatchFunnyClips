using System.Collections.Generic;

namespace WatchFunnyClips.Models
{
    public interface IClipRepository
    {

        public void Save(Clip c);

        public List<Clip> Get();

        public Clip Get(int clipId);

        public void Delete(int clipId);

       public List<Clip> Find(string submit);


    }


}

