using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Infra.Persistence;

namespace GenericCourses.Web.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public loginReq LoginReq { get; set; }

    public LoginModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> OnPostAsync([FromServices] SignInManager<LoginUser> signInManager)
    {
        if (ModelState.IsValid)
        {
            var result = await signInManager.PasswordSignInAsync(
                    LoginReq.email,
                    LoginReq.password,
                    false,
                    lockoutOnFailure: false);
            
            return RedirectToPage("/Index");
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }

    }
}

public class loginReq
{

    [Required]
    [EmailAddress]
    public string email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string password { get; set; }
}
