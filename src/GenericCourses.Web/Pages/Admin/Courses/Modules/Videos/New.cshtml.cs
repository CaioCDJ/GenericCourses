using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GenericCourses.Web.Pages.Admin.Courses.Modules.Videos;

public class AdminModulesVideosModel : PageModel{

  private readonly ILogger<IndexModel> _logger;

  public AdminModulesVideosModel(ILogger<IndexModel> logger){
        _logger = logger;
  }

  public void OnGet(){}
}
