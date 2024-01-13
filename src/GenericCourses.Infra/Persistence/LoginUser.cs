using Microsoft.AspNetCore.Identity;
using GenericCourses.Domain.Entities;
namespace GenericCourses.Infra.Persistence;

// ilegal piece of code
public class LoginUser : IdentityUser{
  public Guid id { get; set; }
  public User user { get; set; }
}
