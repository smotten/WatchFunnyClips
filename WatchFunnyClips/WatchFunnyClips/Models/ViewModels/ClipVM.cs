using Microsoft.AspNetCore.Mvc.Rendering;

namespace WatchFunnyClips.Models.ViewModels
{
    public class ClipVM{
        public int ClipId{get;set;}

        public string Title{get;set;}

        public string Description{get;set;}

        public string Url{get;set;}
               

        public ClipVM() {

        }
    }
}