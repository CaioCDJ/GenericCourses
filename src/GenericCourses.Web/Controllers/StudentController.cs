using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;

namespace GenericCourses.Web.Controllers;

public class StudentController : Controller {

	private readonly ILogger<StudentController> _logger;

	[Route("/account")]
	[Route("/account/index")]
	public IActionResult Account() {
		return View();
	}

	[Route("/account/info")]
	public IActionResult Configuration() {
		return View();
	}
	//
	// [Route("/account/courses")]
	// public IActionResult Courses() {
	// 	return View("");
	// }

	// public IActionResult Account(){
	// 	return View("");
	// }
}
