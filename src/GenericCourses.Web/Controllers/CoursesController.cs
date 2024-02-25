using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;

namespace GenericCourses.Web.Controllers;

public class CoursesController : Controller
{
  private readonly ILogger<HomeController> _logger;

  public CoursesController(ILogger<HomeController> logger)
    => _logger = logger;

  public IActionResult Index()
  {
    return View();
  }

  public IActionResult Info(string id)
    => View();

  public IActionResult Watch(string id)
    => View();

}
