using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;
using MediatR;

namespace GenericCourses.Web.Controllers;

public class AuthController : Controller {

	private readonly ILogger<HomeController> _logger;
	private readonly IMediator _mediatr;

	public AuthController(ILogger<HomeController> logger, IMediator mediator) {
		_logger = logger;
		_mediatr = mediator;
	}

	[Route("/login")]
	public IActionResult Login() {
		return View("./Views/Auth/Login.cshtml");
	}

	[HttpPost]
	[Route("/login")]
	public async Task<IActionResult> LoginPost() {
		return View();
	}

	[Route("/register")]
	[Route("/cadastro")]
	public IActionResult Register() {
		return View("./Views/Auth/Register.cshtml");
	}

	[HttpPost]
	[Route("/register")]
	public async Task<IActionResult> RegisterPost() {
		return View();
	}

}
