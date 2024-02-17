using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Infra.Persistence;
using GenericCourses.Infra.Paginators;
using GenericCourses.Domain.Dtos.Pages;
using MediatR;

namespace GenericCourses.Web.Pages.Blog;

public class IndexModel : PageModel
{
    public static PostPaginator<PostDTO> posts { get; set; }

    private readonly ILogger<IndexModel> _logger;
    private readonly IMediator _mediator;

    public string text { get; set; }

    public IndexModel(ILogger<IndexModel> logger, [FromServices]IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    public async Task OnGetAsync(
            [FromQuery] int? pagina,
            [FromServices] AppDbContext context)
    {
        posts = await PostPaginator<PostDTO>.CreateAsync(
                context, (pagina ?? 0)
        );
    }

    public IActionResult OnGetPartial()
        => Partial("_BlogPaginator", posts);
}
