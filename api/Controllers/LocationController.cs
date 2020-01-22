using AutoMapper;
using api.Models;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class LocationController
  {
    private IMapper _mapper;
    public LocationController(IMapper mapper)
    {
      _mapper = mapper;
    }


    [Route("/[controller]/[action]")]
    public string Get()
    {
      var locationViewmodel = _mapper.Map<LocationViewModel>(new Location() { Street = "abc", City= "Sthlm", Country = "Sweden"  });
      var location = _mapper.Map<Location>(new LocationViewModel{ Location = "Country City Street" });
      return "";
    }
  }
}