using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;
using GenericCourses.Domain.Enums;
using GenericCourses.Application.Features.Auth;
using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

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
	public async Task<IActionResult> LoginPost(LoginRequest request) {
		var res = await _mediatr.Send(request);
		
		var claims = new List<Claim>{
			new Claim(ClaimTypes.Surname,res.name),
			new Claim(ClaimTypes.Hash, res.Id.ToString()),
			new Claim(ClaimTypes.Role, res.role.ToString())
		};

		var claims_identity = new ClaimsIdentity(
			claims, CookieAuthenticationDefaults.AuthenticationScheme
		);

		await HttpContext.SignInAsync(
			CookieAuthenticationDefaults.AuthenticationScheme,
			new ClaimsPrincipal(claims_identity),
			new AuthenticationProperties()
		);

		return res.role switch {
			UserRole.admin => RedirectToAction("Index", "Admin"),
			UserRole.instructor => RedirectToAction("Index", "Admin"),
			UserRole.client => RedirectToAction("Account", "Student"),
			_ => throw new Exception($"Unexpected role: {res.role}")
		};
	}

	[Route("/register")]
	[Route("/cadastro")]
	public IActionResult Register() {
		return View("./Views/Auth/Register.cshtml");
	}

	[HttpPost]
	[Route("/register")]
	public async Task<IActionResult> RegisterPost(RegisterRequest request) {
		var res = await _mediatr.Send(request);

		return RedirectToAction("Login");
	}


	[Authorize]
	[Route("/logout")]
	public async Task<IActionResult> Logout() {
		await HttpContext.SignOutAsync(
			CookieAuthenticationDefaults.AuthenticationScheme
		);

		return RedirectToAction("Login");
	}

}
