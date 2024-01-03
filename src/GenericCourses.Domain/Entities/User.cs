namespace GenericCourses.Domain.Entities;

public class User
{
    public Guid id { get; set; }
    public string? name { get; set; }
    public string? email { get; set; }
    public int cpf { get; set; }
    public int phoneNumber { get; set; }
    public UserRole role { get; set; } = UserRole.client;
    public string? socialNetwork { get; set; }
    public string? github { get; set; } // why not?
    public bool is_active { get; set; }
    public DateTime created_at { get; set; }
}
