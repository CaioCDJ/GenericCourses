using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Domain.Entities;
using Bogus;
using Bogus.Extensions.Brazil;

namespace GenericCourses.Web.Pages.Admin.Users;

public class AdminWorkersModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public static List<RequestWorkers> reqs;
    
    public AdminWorkersModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        reqs = new List<RequestWorkers>();
        var faker = new Faker<RequestWorkers>("pt_BR")
            .RuleFor(x=> x.name, f => f.Name.FirstName(Bogus.DataSets.Name.Gender.Male))
            .RuleFor(x=>x.email, f => f.Internet.Email(f.Person.FirstName.ToLower()))
            .RuleFor(x=>x.role, f => f.PickRandomParam(new int[]{0,1}))
            .RuleFor(x=>x.qt_courses, f => f.PickRandomParam<uint>(new uint[]{1,4,3,7}));

        reqs = faker.Generate(10);
    }
}

public class RequestWorkers{
    public string name { get; set; }
    public string email { get; set; }
    public int role { get; set; }
    public uint qt_courses { get; set; }
    // string cpf,
    // UserRole role,
    // bool active
}
