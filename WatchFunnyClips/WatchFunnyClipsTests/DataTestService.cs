using System;
using System.Collections.Generic;
using WatchFunnyClips.Models;

namespace WatchFunnyClipsTests
{
    public class DataTestService
    {
        public static List<GenreClips> GetTestGenreClips()
        {
            var sessions = new List<GenreClips>();
            sessions.Add(new GenreClips()
            {
                GenreClipsId = 1,
                GenreName = "Animal"
            });
            sessions.Add(new GenreClips()
            {
                GenreClipsId = 2,
                GenreName = "Baby"
            });
            return sessions;
        }

        public DataTestService()
        {
        }
    }
}