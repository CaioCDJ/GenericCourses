using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin.Courses;

public class AdminNewCoursesIndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public AdminNewCoursesIndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
