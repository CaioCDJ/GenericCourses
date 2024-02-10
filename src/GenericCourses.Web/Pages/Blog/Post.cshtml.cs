using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Markdig;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Web.Pages.Blog;

public class PostModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly PostRepository _postRepository;

    public static BlogPost article { get; set; }

    public PostModel(ILogger<IndexModel> logger, [FromServices] PostRepository postRepository)
    {
        _logger = logger;
        _postRepository = postRepository;
    }

    public async Task OnGetAsync(string id = "")
    {
        if (string.IsNullOrWhiteSpace(id) || string.IsNullOrEmpty(id))
            throw new Exception();

        Guid guid;
        if (Guid.TryParse(id, out guid))
            article = await _postRepository.single(guid);

        Console.WriteLine((article is null) ? "fudeu" : "");
    }

}
