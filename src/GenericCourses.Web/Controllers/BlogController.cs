using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;
using GenericCourses.Application.Features.Blog;
using GenericCourses.Domain.Entities;
using MediatR;

namespace GenericCourses.Web.Controllers;

public class BlogController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMediator _mediatr;

    public BlogController(ILogger<HomeController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediatr = mediator;
    }

    public async Task<IActionResult> Index(int? pageNumber)
    {
        var paginatedList = await _mediatr.Send(new GetPostsRequest(
              (pageNumber is not null) ? pageNumber.Value : 0
              ));

        return View(paginatedList);
    }

    public async Task<IActionResult> Post(string id)
    {

        Guid guid;
        if (Guid.TryParse(id, out guid))
        {
            BlogPost post = await _mediatr.Send(new GetPostRequest(guid));
            return View(post);
        }
        else
            return NotFound();

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
