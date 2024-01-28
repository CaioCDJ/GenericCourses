using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin.Courses.Modules.Videos;

public class AdminModulesVideosIndexModel : PageModel
{

    private readonly ILogger<IndexModel> _logger;

    public static List<test> reqs;

    public AdminModulesVideosIndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        reqs = new List<test>();
        /*reqs = new Faker<test>("pt_BR")
          .RuleFor(x => x.title, f => f.Rant.Review())
          .RuleFor(x=>x.created_at,f=>f.Date.Recent().ToString("dd/MM/yyyy"))
          .Generate(10);

        for(int i=0;i<reqs.Count();i++)
          reqs[i].order = i + 1;
*/
    }
}

public class test
{
    public string title { get; set; }
    public string created_at { get; set; }
    public int order { get; set; }
}
