using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Infra.Persistence;
using GenericCourses.Infra.Paginators;
using GenericCourses.Domain.Dtos.Pages;

namespace GenericCourses.Web.Pages.Blog;

public class IndexModel : PageModel
{
    public static PostPaginator<PostDTO> posts { get; set; }

    private readonly ILogger<IndexModel> _logger;

    public string text { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public async Task OnGetAsync(
            [FromQuery] int? pagina,
            [FromServices] AppDbContext context)
    {
        posts = await PostPaginator<PostDTO>.CreateAsync(
                context, (pagina ?? 0)
        );
    }
}
