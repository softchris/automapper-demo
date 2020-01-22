using AutoMapper;

using api.Models;

namespace api.Profiles
{
  public class LocationProfile : Profile
  {
    public LocationProfile()
    {
      CreateMap<Location, LocationViewModel>()
        .ReverseMap();
    }
  }
}