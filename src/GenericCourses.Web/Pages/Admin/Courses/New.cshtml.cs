using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin.Courses;

public class AdminCoursesNewModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public AdminCoursesNewModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
   }
}
