using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace WatchFunnyClips.Models
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WatchFunnyClipContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WatchFunnyClipContext>>()))
            {

                // You add more code here to seed database.
                // See: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-3.0&tabs=visual-studio
                if (!context.GenreClips.Any())
                {
                    var genreClips = new GenreClips[] {

                        new GenreClips { GenreName="Animal" },
                        new GenreClips { GenreName="Baby" },
                        new GenreClips { GenreName="Sport" },
                        new GenreClips { GenreName="Random" }
                    
                    };

                    context.GenreClips.AddRange(genreClips);
                    //foreach(var spec in species)
                    //{
                    //    context.Species.Add(spec);
                    //}

                    context.SaveChanges();
                }

                if (!context.Clip.Any())
                {
                    var genreClipsType = context.GenreClips.ToList();

                    var clips = new Clip[]
                    {
                        new Clip{ Title="Man Whip himself", Description="Funny man", Url="https://www.youtube.com/embed/uMGBvcGBZL8", GenreClipsId = 3},
                        
                    };
                    context.Clip.AddRange(clips);

                    
                    context.SaveChanges();
                }


            }


        }
    }
}