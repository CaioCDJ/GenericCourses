using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Dtos.Forms;

namespace GenericCourses.Web.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public LoginDTO LoginReq { get; set; }

    public LoginModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (ModelState.IsValid)
        {
                return RedirectToPage("/Index");
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }

    }
}

