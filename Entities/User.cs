namespace GenericCourses.Entities;


public class User
{
    public Guid id { get; set; }
    public string? name { get; set; }
    public string? email { get; set; }
    public int cpf { get; set; }
    public int phoneNumber { get; set; }
    public bool isAdmim { get; set; } = false;
}
