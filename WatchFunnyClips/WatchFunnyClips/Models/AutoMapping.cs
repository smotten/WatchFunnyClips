using AutoMapper;

namespace WatchFunnyClips.Models{
public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<Clip, ClipDTO>(); // means you want to map from User to UserDTO
    }
}
}