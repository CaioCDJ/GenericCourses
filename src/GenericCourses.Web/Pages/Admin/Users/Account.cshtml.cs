using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin.Users;

public class AdminAccountModel : PageModel
{
    public static Person person { get; set; }

    public void OnGet()
    {
 /*
        person = new Faker<Person>("pt_BR")
            .RuleFor(x => x.name, f => f.Name.FirstName(Bogus.DataSets.Name.Gender.Male))
            .RuleFor(x => x.email, f => f.Internet.Email()).Generate();
            

        person.imgUrl = "https://images.unsplash.com/photo-1629412541140-be2c2ef424ca?w=600&auto=format&fit=crop&q=60&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTh8fGJveGVyJTIwZG9nfGVufDB8fDB8fHww";
        */
        person = new Person();
    }
}

public class Person
{
    public string name { get; set; }
    public string email { get; set; }
    public string imgUrl { get; set; }
}
