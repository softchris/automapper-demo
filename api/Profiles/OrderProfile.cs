using AutoMapper;
using api.Models;

namespace api.Profiles 
{
  public class OrderProfile: Profile
  {
    public OrderProfile()
    {
      CreateMap<Order, OrderViewModel>()
        .ReverseMap();
    }
  }
}
