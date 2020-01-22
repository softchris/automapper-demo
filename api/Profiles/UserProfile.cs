// using AutoMapper.Extensions.Microsoft.DependencyInjection;
using AutoMapper;
using api.Models;

namespace api.Profiles 
{
  public class UserProfile: Profile 
  {  
    public UserProfile()
    {
      CreateMap<User, UserViewModel>()
        .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + src.LastName));
    }
  }
}