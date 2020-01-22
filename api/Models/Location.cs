namespace api.Models 
{
  public class Location
  {
    public string Street { get; set; }      
    public string City { get; set; }
    public string Country  { get; set; }

    public string GetLocation() 
    {
      return string.Format("{0} {1} {2}", Country, City, Street);
    }
  }
}