using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;

namespace GenericCourses.Web.Controllers;

public class HomeController : Controller {
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger) {
		_logger = logger;
	}
	[Route("/")]
	[Route("/index")]
	[Route("/home")]
	public IActionResult Index() {
		return View("./Views/Home/Index.cshtml");
	}

	[Route("/about")]
	[Route("/sobre")]
	public IActionResult About() {
		return View();
	}

	public IActionResult Privacy() {
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error() {
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
