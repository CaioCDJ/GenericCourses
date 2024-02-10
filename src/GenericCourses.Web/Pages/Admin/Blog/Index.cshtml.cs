using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Infra.Repositories;
using GenericCourses.Infra.Paginators;
using GenericCourses.Infra.Persistence;

namespace GenericCourses.Web.Pages.Admin.Blog;

public class IndexModel : PageModel
{
    // public static List<BlogPost> posts { get; set; }
    public static PaginatedList<BlogPost> posts { get; set; }

    public static int currentPage { get; set; }

    [BindProperty]
    public string id {get;set;}

    private readonly PostRepository postRepository;

    public IndexModel([FromServices] PostRepository postRepository)
    {
        this.postRepository = postRepository;
    }

    // pagina para page por que o mvc nao interpreta page na query
    public async Task OnGetAsync(
            [FromQuery] int? pagina,
            [FromServices] AppDbContext appDbContext
    )
    {
        currentPage = pagina ?? 1;

        // posts = await postRepository.paginate(currentPage);

        posts = await PaginatedList<BlogPost>.CreateAsync(
                from p in appDbContext.blog_posts select p,
                currentPage
                );
    }
}
