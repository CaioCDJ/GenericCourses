using MediatR;
using GenericCourses.Domain.Enums;
using GenericCourses.Application.Common;

namespace GenericCourses.Application.Features.Auth;

public record LoginRequest(
	string email, string password
) : IRequest<Result<LoginResponse, Error>>;

public record LoginResponse(
	Guid Id,
	string name,
	UserRole role
);
