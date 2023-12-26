using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin.Blog.Post;

public class AdminPostIndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public static string[] categories;    

    public AdminPostIndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        categories = [
            "frontend",
            "backend",
            "Database",
            "PHP",
            "C#",
            "Angular",
            "Vue3",
            "Laravel",
            "AspNetCore",
            "Blazor",
            "Avalonia",
            "Spring",
            "Flutter",
            "Java",
        ];
    }
}
