using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin.Blog.Post;

public class AdminPostIndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public AdminPostIndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}
