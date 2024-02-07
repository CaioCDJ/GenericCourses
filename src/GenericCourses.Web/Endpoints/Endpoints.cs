using GenericCourses.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Web.Endpoints.Admin;

namespace GenericCourses.Web.Endpoints;

public static class Endpoints{

  public static void MapEndpoints(this WebApplication app){

    app.MapBlogEndpoints();
  }
}
