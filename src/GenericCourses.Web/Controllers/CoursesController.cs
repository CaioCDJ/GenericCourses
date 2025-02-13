using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
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

	[Route("/course/{id}/Watch/{video_id}")]
	public IActionResult Watch(string id)
	  => View();

}
