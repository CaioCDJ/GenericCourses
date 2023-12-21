using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Markdig;

namespace GenericCourses.Web.Pages.Courses;

public class CourseModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public static string desc { get; set; } = "";

    public CourseModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        desc = Markdown.ToHtml(@"            
## Lorem ipsum???????????
Lorem ipsum dolor sit amet, officia excepteur ex fugiat reprehenderit enim labore culpa sint ad nisi Lorem pariatur mollit ex esse exercitation amet. 
Nisi anim cupidatat excepteur officia. Reprehenderit nostrud nostrud ipsum Lorem est aliquip amet voluptate voluptate dolor minim nulla est proident. 
Nostrud officia pariatur ut officia. Sit irure elit esse ea nulla sunt ex occaecat reprehenderit commodo officia dolor Lorem duis laboris cupidatat officia voluptate. 
Culpa proident adipisicing id nulla nisi laboris ex in Lorem sunt duis officia eiusmod. 
Aliqua reprehenderit commodo ex non excepteur duis sunt velit enim. Voluptate laboris sint cupidatat ullamco ut ea consectetur et est culpa et culpa duis.
- lorem 
- ipsum
- ssjdhshadskhdla
            
-------

                ");
    }
}
