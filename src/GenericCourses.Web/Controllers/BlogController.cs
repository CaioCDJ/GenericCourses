using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;
using GenericCourses.Application.Features.Blog;
using GenericCourses.Domain.Entities;
using MediatR;

namespace GenericCourses.Web.Controllers;

public class BlogController : Controller {
	private readonly ILogger<HomeController> _logger;
	private readonly IMediator _mediatr;

	public BlogController(ILogger<HomeController> logger, IMediator mediator) {
		_logger = logger;
		_mediatr = mediator;
	}

	[Route("/blog")]
	[Route("/articles")]
	public async Task<IActionResult> Index(
		int? page,
		[FromQuery] string? categories,
		[FromQuery] string? search
		) {

		string[] categoriesParams = null;

		if (categories is not null) {
			categoriesParams = (categories.Contains(","))
				? categories.Split(',')
				: [categories];
		}

		var response = await _mediatr.Send(new GetPostsRequest(
			  pageIndex: (page is not null) ? page.Value : 1,
			  pageSize: 10,
			  categories: (categoriesParams is not null) ? categoriesParams : null,
			  searchParam: (search is not null) ? search : null
			  ));

		return View(response);
	}

	[Route("/blog/{id}")]
	[Route("/articles/{id}")]
	public async Task<IActionResult> Post(string id) {

		Guid guid;
		if (Guid.TryParse(id, out guid)) {
			BlogPost post = await _mediatr.Send(new GetPostRequest(guid));
			return View(post);
		}
		else
			return NotFound();
	}

	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public IActionResult Error() {
		return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	}
}
