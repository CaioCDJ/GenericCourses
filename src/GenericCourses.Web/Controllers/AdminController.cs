using FluentValidation;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using GenericCourses.Web.Models;
using GenericCourses.Infra.Repositories;
using GenericCourses.Application.Features.Admin.Courses;
using GenericCourses.Application.Features.Admin.Subscriptions;
using GenericCourses.Application.Features.Admin.Blog;
using GenericCourses.Web.Validations;
using MediatR;

namespace GenericCourses.Web.Controllers;

[Authorize(Roles = "admin, instructor")]
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

	// ===========================================================
	//						  Blog
	// ===========================================================
	[Route("/admin/post/new")]
	public async Task<IActionResult> NewPost(
		[FromServices] ICategoriesRepository categoriesRepository
	) {
		var categories = await categoriesRepository.getAll();
		return View(categories);
	}

	[Route("/admin/posts")]
	public async Task<IActionResult> Posts(int page = 1) {
		var response = await _mediatr.Send(new GetPostsAdminRequest(
			pageIndex: page,
			pageSize: 10,
			userId: null
		));
		return View(response);
	}

	[Route("/admin/post/{id}")]
	public async Task<IActionResult> DeletePost([FromRoute] string id) {

		var post_id = Guid.Parse(id);

		var response = await _mediatr.Send(
			new DeletePostRequest(post_id)
		);

		if (response) { }

		return RedirectToAction("Posts");
	}

	// ===========================================================
	//					      Courses
	// ===========================================================
	[Route("/admin/courses")]
	public async Task<IActionResult> Courses(int? page) {
		var user = HttpContext.User;

		Console.WriteLine(user.FindFirst(ClaimTypes.Surname).Value);
		var paginatedList = await _mediatr.Send(new GetCoursesAdminRequest(page ?? 0));

		return View(paginatedList);
	}

	[HttpPost]
	[Route("/admin/courses/{id}")]
	public async Task<IActionResult> DeleteCourse([FromRoute] string id) {
		var course_id = Guid.Parse(id);
		var res = await _mediatr.Send(new DisableCourseRequest(course_id));

		return RedirectToAction("Courses");
	}

	[Route("/admin/courses/new")]
	public IActionResult newCourse() {
		return View();
	}

	[Route("/admin/courses/{id}/modules")]
	public async Task<IActionResult> Modules([FromRoute] string id, int page = 1) {
		Guid course_id = Guid.Parse(id);

		var modules = await _mediatr.Send(new GetModulesRequest(page, course_id));

		ViewBag.id = id;

		return View(modules);
	}

	[HttpPost]
	[Route("/admin/courses/{id}/modules")]
	public async Task<IActionResult> StoreModule(
			[FromRoute] string id, StoreModuleFormPost formPost) {

		Guid course_id = Guid.Parse(id);

		var response = await _mediatr.Send(new StoreModuleRequest(
			course_id: course_id, order: formPost.order, description: formPost.description, title: formPost.title
		));

		return RedirectToAction("Modules", new { id = id });
	}

	// ===========================================================
	//						  Videos
	// ===========================================================
	[Route("/admin/courses/{id}/modules/{moduleId}/videos")]
	public async Task<IActionResult> Videos(
		int page,
		[FromRoute] string id, [FromRoute] string moduleId) {

		Guid guid_module = Guid.Parse(moduleId);

		var videos = await _mediatr.Send(new GetVideosRequest(guid_module));

		return View(videos);
	}

	[HttpPost]
	[Route("/admin/courses/{id}/modules/{moduleId}/videos/{videoId}")]
	public async Task<IActionResult> RemoveVideo(
		[FromRoute] string id, [FromRoute] string moduleId, [FromRoute] string videoId
	) {
		var response = await _mediatr.Send(new DeleteVideoRequest(
			Guid.Parse(moduleId), Guid.Parse(videoId)
		));

		return RedirectToAction("Videos", new { id = id, moduleId = moduleId });
	}

	[Route("/admin/courses/{id}/modules/{moduleId}/videos/new")]
	public async Task<IActionResult> NewVideo([FromRoute] string id, [FromRoute] string moduleId) {
		return View();
	}

	[HttpPost]
	[Route("/admin/courses/{id}/modules/{moduleId}/videos/new")]
	public async Task<IActionResult> VideoPost(
		[FromRoute] string moduleId, [FromRoute] string id, [FromForm] StoreVideoForm request,
		[FromServices] IValidator<StoreVideoForm> validator
	) {
		var validation_result = await validator.ValidateAsync(request);

		if (!validation_result.IsValid) {
			validation_result.AddToModelState(this.ModelState);
			return View("NewVideo", request);
		}

		var response = await _mediatr.Send(new StoreVideoRequest(
			request.title, request.order, request.video_url, request.desc,
			Guid.Parse(moduleId)
		));

		if (!response.isSuccess) {
			return View("NewVideo", request);
		}

		return RedirectToAction("Videos", new { id = id, moduleId = moduleId });
	}

	[Route("/admin/courses/{id}/modules/{moduleId}/videos/edit/{video_id}")]
	public async Task<IActionResult> EditVideo(
		[FromRoute] string moduleId, [FromRoute] string id, [FromRoute] string video_id
	) {
		var respose = await _mediatr.Send(new GetVideoRequest(Guid.Parse(video_id)));

		if (!respose.isSuccess)
			return RedirectToAction("Videos", new { id = id, moduleId = moduleId });

		var video = respose.Value;

		return View(new StoreVideoForm {
			title = video.title,
			order = video.order,
			video_url = video.videoUrl,
			desc = video.description
		});
	}

	[HttpPost]
	[Route("/admin/courses/{id}/modules/{moduleId}/videos/edit/{video_id}")]
	public async Task<IActionResult> EditVideoPost(
		[FromRoute] string moduleId, [FromRoute] string id, [FromRoute] string video_id,
		[FromForm] StoreVideoForm request, [FromServices] IValidator<StoreVideoForm> validator
	) {
		var response = await _mediatr.Send(new UpdateVideoRequest(
			id: Guid.Parse(video_id),
			title: request.title,
			description: request.desc,
			videoUrl: request.video_url,
			order: request.order
		));

		if (!response.isSuccess) {
			ModelState.AddModelError("title", "Erro ao salvar o video!");
			ModelState.AddModelError("order", "Erro ao salvar o video!");
			ModelState.AddModelError("video_url", "Erro ao salvar o video!");
			ModelState.AddModelError("desc", "Erro ao salvar o video!");
			return View("EditVideo");
		}

		return RedirectToAction("Videos", new { id = id, moduleId = moduleId });
	}

	// ===========================================================
	//						  Users
	// ===========================================================
	[Authorize(Roles = "admin")]
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


	// ===========================================================
	//					  Subscriptions
	// ===========================================================
	// TODO:
	// - Delete 
	// - Update
	[Route("/admin/plans")]
	[Route("/admin/subscriptions")]
	public async Task<IActionResult> Plans(int? page) {
		var lst = await _mediatr.Send(new GetSubcriptionRequest(page ?? 1));

		return View(lst);
	}

	[HttpPost]
	[Route("/admin/plans")]
	public async Task<IActionResult> Store_Plans(StoreSubscriptionForm form_request) {

		var user_id = HttpContext.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Hash).Value;

		var response = await _mediatr.Send(new StoreSubscriptionRequest(
			price: form_request.price,
			description: form_request.description,
			months: form_request.months,
			admin_id: Guid.Parse(user_id)
		));

		return RedirectToAction("Plans");
	}

	// ===========================================================
	//					    Categories
	// ===========================================================
	[Route("/admin/categories")]
	public async Task<IActionResult> Categories() {
		return View();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error() {

		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
