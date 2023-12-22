using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin.Courses;

public class AdminCoursesIndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public static List<AdminCoursesRequest> requests { get; set; }

    public AdminCoursesIndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        requests = new List<AdminCoursesRequest>(){
            new AdminCoursesRequest(Guid.NewGuid().ToString(),"curso","Boxer",false,9,19),
            new AdminCoursesRequest(Guid.NewGuid().ToString(),"curso","Boxer",false,9,19),
            new AdminCoursesRequest(Guid.NewGuid().ToString(),"curso","Boxer",false,9,19),
            new AdminCoursesRequest(Guid.NewGuid().ToString(),"curso","Boxer",true,9,19),
            new AdminCoursesRequest(Guid.NewGuid().ToString(),"curso","Boxer",false,9,19),
            new AdminCoursesRequest(Guid.NewGuid().ToString(),"curso","Boxer",false,9,19),
            new AdminCoursesRequest(Guid.NewGuid().ToString(),"curso","Boxer",false,9,19),
            new AdminCoursesRequest(Guid.NewGuid().ToString(),"curso","Boxer",false,9,19),
        };
    }
}


public record AdminCoursesRequest(
    string id,
    string name,
    string instructor,
    bool isFree,
    uint modules,
    uint videos
);
