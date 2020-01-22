using AutoMapper;
using api.Models;

using Microsoft.AspNetCore.Mvc;

namespace api.Controllers 
{
  [ApiController]
  [Route("[controller]")]
  public class UserController 
  {
    private IMapper _mapper;
    public UserController(IMapper mapper)
    {
        _mapper = mapper;
    }

    
    [Route("/[controller]/[action]")]
    public string Get() 
    {
      var result = _mapper.Map<UserViewModel>(new User() { FirstName="Chris", LastName="Noring", Id = 1 });
      return result.FullName;
    }
  }
}