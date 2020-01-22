namespace api.Models
{
  public class LocationViewModel
  {
   public string Location { get; set; }

   public string GetCountry() 
   {
     return Location.Split(" ")[0];
   }

  public string GetCity()
  {
    return Location.Split(" ")[1];
  }

  public string GetStreet()
  {
    return Location.Split(" ")[2];
  }
  }
}