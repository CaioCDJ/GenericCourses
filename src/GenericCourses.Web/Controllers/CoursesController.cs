using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using GenericCourses.Web.Models;
using GenericCourses.Application.Features.Courses.GetCourse;
using GenericCourses.Application.Features.Courses;
using MediatR;


namespace GenericCourses.Web.Controllers;

public class CoursesController : Controller {
	private readonly ILogger<HomeController> _logger;
	private readonly IMediator _mediatr;

	public CoursesController(ILogger<HomeController> logger, IMediator mediatr) {
		_logger = logger;
		_mediatr = mediatr;
	}

	[Route("/courses")]
	[Route("/cursos")]
	public async Task<IActionResult> Index(int? page) {

		int index = (page.HasValue) ? page.Value : 1;

		var lst = await _mediatr.Send(new GetCoursesRequest(index));

		return View(lst);
	}

	[Route("/courses/{id}")]
	[Route("/cursos/{id}")]
	public async Task<IActionResult> Info([FromRoute] string id) {

		var guid_id = Guid.Parse(id);

		var course = await _mediatr.Send(new GetCourseInfoRequest(guid_id));

		return View(course);
	}

	[Authorize(Roles = "student")]
	[Route("/course/{id}/start")]
	public async Task<IActionResult> StartCourse([FromRoute] string id) {
		var user_Id = User.FindFirst(ClaimTypes.Hash)?.Value;

		if (user_Id is null) { }

		var response = await _mediatr.Send(new StartCourseRequest(
			course_id: Guid.Parse(id),
			user_id: Guid.Parse(user_Id)
		));

		if (response.isSuccess) return RedirectToAction("Watch", new { id = id, video_id = "llx" });
		else throw new Exception("Deu ruim");
	}

	[Route("/course/{id}/Watch/{video_id}")]
	[Authorize(Roles = "student")]
	public async Task<IActionResult> Watch([FromRoute] string id, [FromRoute] string video_id) {

		var user_Id = User.FindFirst(ClaimTypes.Hash)?.Value;

		if (user_Id is null) { }

		var user_guid = Guid.Parse(user_Id);

		var video_guid = Guid.Parse(video_id);

		var response = await _mediatr.Send(new WatchCourseRequest(
			user_id: user_guid,
			course_id: Guid.Parse(id),
			video_id: video_guid
		));

		return View(response.Value);
	}
}
