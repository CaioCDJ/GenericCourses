namespace GenericCourses.Domain.Entities;

public class Client
{
    public Guid id { get; set; } = Guid.NewGuid();

    public User user { get; set; }
    public Guid userId { get; set; }
    
    public Subscriptionplan? subscriptionplan { get; set; }
    public Guid? subscriptionplanId { get; set; }
}
