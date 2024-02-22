using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Models;
using GenericCourses.Application.Common;
using GenericCourses.Application.Features.Blog;
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

    public async Task<IActionResult> Posts(int? pageNumber)
    {
        var paginatedList = await _mediatr.Send(new GetPostsRequest(
              (pageNumber is not null) ? pageNumber.Value : 0
              ));
        
        return View(paginatedList);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
