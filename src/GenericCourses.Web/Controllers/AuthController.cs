using Microsoft.AspNetCore.Mvc;
using GenericCourses.Domain.Enums;
using GenericCourses.Application.Features.Auth;
using GenericCourses.Web.Validations;
using MediatR;
using FluentValidation;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace GenericCourses.Web.Controllers;

public class AuthController : Controller {

	private readonly ILogger<HomeController> _logger;
	private readonly IMediator _mediatr;
	private readonly IValidator<LoginRequest> _validator;
	private readonly IValidator<RegisterRequest> _register_validator;

	public AuthController(
			ILogger<HomeController> logger,
			IMediator mediator,
			IValidator<LoginRequest> validator,
			IValidator<RegisterRequest> register_validator
			) {
		_logger = logger;
		_mediatr = mediator;
		_validator = validator;
		_register_validator = register_validator;
	}

	[Route("/login")]
	public IActionResult Login() {
		return View("./Views/Auth/Login.cshtml");
	}

	[HttpPost]
	[Route("/login")]
	public async Task<IActionResult> LoginPost(LoginRequest request) {

		var validation_result = await _validator.ValidateAsync(request);

		if (!validation_result.IsValid) {
			validation_result.AddToModelState(this.ModelState);
			return View("Login", request);
		}

		var result = await _mediatr.Send(request);

		if (!result.isSuccess) {
			ModelState.AddModelError("email", "E-mail ou senha incorretos.");
			ModelState.AddModelError("password", "E-mail ou senha incorretos.");
			return View("Login", request);
		}

		var res = result.Value;

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
			UserRole.student => RedirectToAction("Account", "Student"),
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
	public async Task<IActionResult> RegisterPost([FromForm]RegisterRequest request) {
		var validation_result = await _register_validator.ValidateAsync(request);

		if(!validation_result.IsValid){
			validation_result.AddToModelState(this.ModelState);
			return View("Register", request);
		}

		var res = await _mediatr.Send(request);

		if(!res.isSuccess){
			return View("Register", request);
		}

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
