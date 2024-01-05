using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin;

public class AdminCategoriesModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public AdminCategoriesModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
