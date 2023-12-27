using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin.Courses.Modules;

public class AdminModulesIndexModel : PageModel{

  private readonly ILogger<IndexModel> _logger;

  public AdminModulesIndexModel(ILogger<IndexModel> logger){
        _logger = logger;
  }

  public void OnGet(){}
}
