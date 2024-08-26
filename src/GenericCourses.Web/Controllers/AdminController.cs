using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Web.Controllers;

public class AdminController : Controller {
	private readonly ILogger<HomeController> _logger;

	public AdminController(ILogger<HomeController> logger) {
		_logger = logger;
	}

	[Route("/admin")]
	[Route("/admin/index")]
	[Route("/admin/dashboard")]
	public IActionResult Index() {
		return View();
	}

	[Route("/admin/account")]
	public IActionResult Account() {
		return View();
	}

	[Route("/admin/post/new")]
	public async Task<IActionResult> NewPost(
		[FromServices] ICategoriesRepository categoriesRepository
	) {
		var categories = await categoriesRepository.getAll();
		return View(categories);
	}

	[Route("/admin/posts")]
	public async Task<IActionResult> Posts(
		[FromServices] IPostRepository postRepository
	) {
		return View();
	}

	[Route("/admin/courses")]
	public async Task<IActionResult> Courses() {
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error() {

		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
