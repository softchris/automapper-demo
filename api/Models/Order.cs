using System;

namespace api.Models
{
  public class Order
  {
      public Customer Customer { get; set; }
      public DateTime Created { get; set; }
  }
}