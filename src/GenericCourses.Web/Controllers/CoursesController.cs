using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;

namespace GenericCourses.Web.Controllers;

public class CoursesController : Controller {
	private readonly ILogger<HomeController> _logger;

	public CoursesController(ILogger<HomeController> logger)
	  => _logger = logger;

	[Route("/courses")]
	[Route("/cursos")]
	public IActionResult Index() {
		return View();
	}

	[Route("/courses/{id}")]
	[Route("/cursos/{id}")]
	public IActionResult Info(string id)
	  => View();

	[Route("/course/{id}/Watch/{video_id}")]
	public IActionResult Watch(string id)
	  => View();

}
