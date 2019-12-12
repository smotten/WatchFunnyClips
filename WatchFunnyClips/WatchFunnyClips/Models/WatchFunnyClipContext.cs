using Microsoft.EntityFrameworkCore;
using WatchFunnyClips.Models;

namespace WatchFunnyClips.Models
{
    public class WatchFunnyClipContext : DbContext
    {
        public WatchFunnyClipContext (DbContextOptions<WatchFunnyClipContext> options)
            : base(options)
        {
        }

        public DbSet<Clip> Clip { get; set; }

        public DbSet<GenreClips> GenreClips { get; set; }
    }
}