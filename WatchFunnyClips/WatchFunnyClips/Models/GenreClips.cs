using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WatchFunnyClips.Models;

public class GenreClips{

    public int GenreClipsId{get;set;}

    [Required] public string GenreName{get;set;}
    
    public ICollection<Clip> Clips{get;set;}
}
