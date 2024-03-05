using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;
using MediatR;

namespace GenericCourses.Web.Controllers;

public class LoginController : Controller {
	private readonly ILogger<HomeController> _logger;
	private readonly IMediator _mediatr;

	public LoginController(ILogger<HomeController> logger, IMediator mediator) {
		_logger = logger;
		_mediatr = mediator;
	}

	public IActionResult Index() {
		return View("./Views/Auth/Login.cshtml");
	}
}
