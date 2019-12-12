using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace WatchFunnyClips.Models
{


public class Clip
{
    public int ClipId {get;set;}
    public string Title{get;set;}

    public string Description{get;set;}

    public string Url{get;set;}

    public int GenreClipsId{get;set;}

    public GenreClips GenreClips { get; set; }

    public Clip(){

    }


}
}