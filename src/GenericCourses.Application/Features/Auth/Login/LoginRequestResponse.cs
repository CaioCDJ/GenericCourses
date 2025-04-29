using MediatR;
using GenericCourses.Domain.Enums;

namespace GenericCourses.Application.Features.Auth;

public record LoginRequest(
	string email, string password
) : IRequest<LoginResponse>;

public record LoginResponse(
	Guid Id,
	string name,
	UserRole role
);
