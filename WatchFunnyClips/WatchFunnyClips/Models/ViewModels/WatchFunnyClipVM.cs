using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WatchFunnyClips.Models.ViewModels
{
    public class WatchFunnyClipVM
    {
        public Clip Clip{ get; set; }
        public SelectList GenreClipSelectList{ get; set; }

        public WatchFunnyClipVM()
        {
        }
    }
}