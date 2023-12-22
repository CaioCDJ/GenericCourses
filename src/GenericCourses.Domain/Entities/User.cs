namespace GenericCourses.Domain.Entities;

public class User
{
    public Guid id { get; set; }
    public string? name { get; set; }
    public string? email { get; set; }
    public int cpf { get; set; }
    public int phoneNumber { get; set; }
    public bool isAdmim { get; set; } = false;
    public bool isTeacher { get; set; } = false;
    public UserRole roles { get; set; } = UserRole.client;
    public string? socialNetwork { get; set; }
    public string? github { get; set; } // why not?
    public bool is_active { get; set; }
}
