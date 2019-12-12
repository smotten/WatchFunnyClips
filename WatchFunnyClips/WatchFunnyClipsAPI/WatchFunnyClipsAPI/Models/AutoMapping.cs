using AutoMapper;

namespace WatchFunnyClipsAPI.Models
{
public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<WatchFunnyClips.Models.Clip, WatchFunnyClips.Models.ViewModels.ClipVM>(); // means you want to map from User to UserDTO
    }
}
}