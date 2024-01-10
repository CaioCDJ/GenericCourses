namespace GenericCourses.Domain.Entities;

public class Subscriptionplan{
  public Guid id { get; set; }
  public float price { get; set; }
  public DateTime createdAt { get; set; }
  public List<User> users { get; set; }
  public int months { get; set; }
}
