using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos.Forms;
using GenericCourses.Infra.Security;

namespace GenericCourses.Web.Pages;

public class RegisterModel : PageModel
{
    [BindProperty]
    public RegisterDTO dto { get; set; }
    
    private readonly ILogger<IndexModel> _logger;


    public RegisterModel(ILogger<IndexModel> logger )
    {
        _logger = logger;
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if(ModelState.IsValid && (dto.password == dto.confirmPassword)){ 
                     return RedirectToPage("/Index");

        }else{
            return Page();
        }
    }
}
