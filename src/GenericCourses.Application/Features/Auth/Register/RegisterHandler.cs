using MediatR;
using GenericCourses.Domain.Entities;
using MediatR;
using GenericCourses.Infra.Persistence;

namespace GenericCourses.Application.Features.Auth;

public class RegisterHandler : IRequestHandler<RegisterRequest, Client>
{

    private readonly AppDbContext _context;

    public RegisterHandler(AppDbContext context)
      => _context = context;

    public async Task<Client> Handle(RegisterRequest request, CancellationToken ct)
    {

        return new Client();
    }
}
