using AutoMapper;
using api.Models;
using System;

using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class OrderController
  {
    private IMapper _mapper;
    public OrderController(IMapper mapper)
    {
      _mapper = mapper;
    }


    [Route("/[controller]/[action]")]
    public string Get()
    {
      var orderViewModel = _mapper.Map<OrderViewModel>(new Order { 
        Customer = new Customer(){ Name = "Chris" }, 
        Created = DateTime.Now 
      });
      var order = _mapper.Map<Order>(orderViewModel);
      var name = order.Customer.Name;
      
      return orderViewModel.CustomerName;
    }
  }
}