using MediatR;
using GenericCourses.Domain.Entities;
using GenericCourses.Application.Common;

namespace GenericCourses.Application.Features.Auth;

public class RegisterRequest : IRequest<Result<User,Error>> {
	public string name { get; set; }
	public string email { get; set; }
	public string password { get; set; }
	public string confirmPassword { get; set; }
	public string phone { get; set; }
	public string cpf { get; set; }
}
