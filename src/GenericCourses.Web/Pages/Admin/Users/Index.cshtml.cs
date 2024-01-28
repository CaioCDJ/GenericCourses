using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Domain.Entities;

namespace GenericCourses.Web.Pages.Admin.Users;

public class AdminUsersIndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public static List<Request> reqs;
    
    public AdminUsersIndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        reqs = new List<Request>();
        // var faker = new Faker<Request>("pt_BR")
        //     .RuleFor(x=> x.name, f => f.Name.FirstName(Bogus.DataSets.Name.Gender.Male))
        //     .RuleFor(x=>x.email, f => f.Internet.Email(f.Person.FirstName.ToLower()))
        //     .RuleFor(x=>x.cpf, f=> f.Person.Cpf())
        //     .RuleFor(x=>x.active,f=> f.PickRandomParam(new bool[]{true,false}));
        //
        // reqs = faker.Generate(10);
    }
}

public class Request(){
    public string name { get; set; }
    public string email { get; set; }
    public string cpf { get; set; }
    public bool active { get; set; }
    // string cpf,
    // UserRole role,
    // bool active
}
