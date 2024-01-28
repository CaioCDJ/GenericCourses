using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Domain.Dtos.Forms;
using GenericCourses.Infra.Reposiitories;

namespace GenericCourses.Web.Pages.Admin.Blog.Post;

public class AdminPostIndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public static string[] categories;

    [BindProperty]
    public NewPostDTO newPostDTO { get; set; }

    [BindProperty]
    public List<string> checkboxes { get; set; } = new List<string>();

    public AdminPostIndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }


    public async Task OnGetAsync()
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

    public async Task<IActionResult> OnPostAsync([FromServices] PostRepository postRepository)
    {

        Console.WriteLine(@$"
                {newPostDTO.title}\n
                {newPostDTO.thumb}\n
                {checkboxes.Count()}
                {newPostDTO.text}\n\n     
                ");

        var post = await postRepository.store(new BlogPost()
        {
            title = newPostDTO.title,
            text = newPostDTO.text,
            thumb = newPostDTO.thumb
        });

        return RedirectToPage("/Index/admin");


        return Page();
    }
}
