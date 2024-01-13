using System.ComponentModel.DataAnnotations.Schema;

namespace GenericCourses.Domain.Entities;

public class Subscriptionplan{
  public Guid id { get; set; } = Guid.NewGuid();
  public float price { get; set; }
  [Column(TypeName="Date")]
  public DateTime createdAt { get; set; } = DateTime.Now;
  public List<User> users { get; set; }
  public int months { get; set; }
}
