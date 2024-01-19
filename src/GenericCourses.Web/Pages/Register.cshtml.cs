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

    public async Task<IActionResult> OnPostAsync([FromServices]UserManager<LoginUser> userManager)
    {
        if(ModelState.IsValid && (dto.password == dto.confirmPassword)){ 
            var newlog = new LoginUser(){
                NormalizedEmail = dto.email,
                PasswordHash = Hasing.hash(dto.password),
                UserName = dto.name,
                user = new User(){
                    phoneNumber = dto.phoneNumber,
                    cpf = dto.cpf,
                }
            };
            await userManager.CreateAsync(newlog);
            return RedirectToPage("/Index");

        }else{
            return Page();
        }
    }
}
