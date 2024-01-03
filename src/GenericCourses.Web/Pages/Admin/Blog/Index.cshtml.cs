using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bogus;
using Bogus.Extensions.Brazil;

namespace GenericCourses.Web.Pages.Admin.Blog;

public class IndexModel : PageModel
{
    public static List<test> posts { get; set; }

    public void OnGet()
    {
        posts = new List<test>();
        posts = new Faker<test>("pt_BR")
            .RuleFor(x => x.title, f => f.Company.Bs())
            .RuleFor(x => x.author, f => f.Name.FirstName(Bogus.DataSets.Name.Gender.Female))
            .RuleFor(x => x.qt_comments, f => f.PickRandomParam<int>([1, 2, 3, 4, 5]))
            .RuleFor(x => x.created_at, f => f.Date.Recent().ToString("dd/MM/yyyy")
                    ).Generate(10);
    }
}

public class test
{
    public string title { get; set; }
    public string author { get; set; }
    public string created_at { get; set; }
    public int qt_comments { get; set; }
}

