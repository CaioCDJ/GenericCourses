using System.ComponentModel.DataAnnotations.Schema;
namespace GenericCourses.Domain.Entities;

public class User
{
    public Guid id { get; set; } = new Guid();
    public string name { get; set; }
    public string email { get; set; }
    public int cpf { get; set; }
    public int? phoneNumber { get; set; }
    public UserRole role { get; set; } = UserRole.client;
    public string? socialNetwork { get; set; }
    public string? github { get; set; } // why not?
    public bool is_active { get; set; } = true;
    [Column(TypeName="Date")]
    public DateTime createdAt { get; set; } = DateTime.Now;
    public Subscriptionplan? subscriptionplan { get; set; }
    public Guid? subscriptionplanId { get; set; }
    
    public ICollection<BlogPost>? posts { get; set; }
}
