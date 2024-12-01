using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;
using GenericCourses.Application.Features.Courses.GetCourse;
using MediatR;

namespace GenericCourses.Web.Controllers;

public class CoursesController : Controller {
	private readonly ILogger<HomeController> _logger;
	private readonly IMediator _mediatr;

	public CoursesController(ILogger<HomeController> logger, IMediator mediatr){
		_logger = logger;
		_mediatr = mediatr;
	}

	[Route("/courses")]
	[Route("/cursos")]
	public IActionResult Index() {
		return View();
	}

	[Route("/courses/{id}")]
	[Route("/cursos/{id}")]
	public async Task<IActionResult> Info([FromRoute]string id){
		
		var guid_id = Guid.Parse(id);
		
		var course = await _mediatr.Send(new GetCourseInfoRequest(guid_id));
		
		return View(course);
	}

	[Route("/course/{id}/Watch/{video_id}")]
	public IActionResult Watch(string id)
	  => View();

}
