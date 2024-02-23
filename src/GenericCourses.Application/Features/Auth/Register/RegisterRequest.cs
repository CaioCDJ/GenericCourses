using MediatR;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Application.Features.Auth;

public class RegisterRequest : IRequest<Client>
{
    public string name { get; set; }
    public string email { get; set; }
    public string password { get; set; }
    public string confirmPassword { get; set; }
    public string phone { get; set; }
    public string cpf { get; set; }
}
