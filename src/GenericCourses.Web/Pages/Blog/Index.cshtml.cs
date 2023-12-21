using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Blog;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public string text {get;set;}

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet(string id="id")
    {
        
    }
}
