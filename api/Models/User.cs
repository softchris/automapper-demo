namespace api.Models 
{
  public class User
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullname() {
      return string.Format("{0} {1}", this.FirstName, this.LastName);
    }
  }
}
