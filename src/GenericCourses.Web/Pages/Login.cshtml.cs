using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using GenericCourses.Infra.Persistence;

namespace GenericCourses.Web.Pages;

public class LoginModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly AppDbContext _dbContext ;

    public LoginModel(ILogger<IndexModel> logger, AppDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    public void OnGet()
    {
    }
}
