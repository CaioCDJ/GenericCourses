using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;
using GenericCourses.Infra.Repositories;
using GenericCourses.Application.Features.Admin.Courses;
using GenericCourses.Application.Features.Admin.Subscriptions;
using MediatR;

namespace GenericCourses.Web.Controllers;

public class AdminController : Controller {
	private readonly ILogger<HomeController> _logger;
	private readonly IMediator _mediatr;

	public AdminController(ILogger<HomeController> logger, IMediator mediator) {
		_logger = logger;
		_mediatr = mediator;
	}

	[Route("/admin")]
	[Route("/admin/index")]
	[Route("/admin/dashboard")]
	public IActionResult Index() {
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
	public async Task<IActionResult> Posts() {
		return View();
	}

	[Route("/admin/courses")]
	public async Task<IActionResult> Courses(int? page) {

		var paginatedList = await _mediatr.Send(new GetCoursesAdminRequest(page ?? 0));

		return View(paginatedList);
	}
	
	[Route("/admin/courses/new")]
	public IActionResult newCourse(){
		return View();
	}

	[Route("/admin/courses/new")]
	public async Task<IActionResult> NewCourse() {
		return View();
	}

	[Route("/admin/courses/{id}/modules")]
	public async Task<IActionResult> Modules([FromRoute] string id, int? page) {
		Guid course_id = Guid.Parse(id);

		var modules = await _mediatr.Send(new GetModulesRequest(page ?? 0, course_id));

		return View(modules);
	}

	[Route("/admin/courses/{id}/modules/{moduleId}/videos")]
	public async Task<IActionResult> Videos(
		[FromRoute] string id, [FromRoute] string moduleId) {
		return View();
	}

	[Route("/admin/clients")]
	[Route("/admin/users")]
	public async Task<IActionResult> Users() {
		return View();
	}

	[Route("/admin/account")]
	[Route("/admin/profile")]
	public async Task<IActionResult> Account() {
		return View();
	}


	[Route("/admin/plans")]
	[Route("/admin/subscriptions")]
	public async Task<IActionResult> Plans(int? page) {
		var lst = await _mediatr.Send(new GetSubcriptionRequest(page ?? 0));
		return View(lst);
	}

	[Route("/admin/categories")]
	public async Task<IActionResult> Categories() {
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error() {

		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
