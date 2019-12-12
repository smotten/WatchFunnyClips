using Microsoft.EntityFrameworkCore;
using WatchFunnyClipsAPI.Models;

namespace WatchFunnyClipsAPI.Models
{
    public class WatchFunnyClipsAPIContext : DbContext
    {
        public WatchFunnyClipsAPIContext(DbContextOptions<WatchFunnyClipsAPI.Models.WatchFunnyClipsAPIContext> options)
            : base(options)
        {
            
        }

        public DbSet<WatchFunnyClips.Models.Clip> Clips { get; set; }
       
    }
}