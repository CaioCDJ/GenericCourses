using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GenericCourses.Infra.Repositories;

namespace GenericCourses.Web.Endpoints.Admin;

public static class BlogEndpoints
{
    public static void MapBlogEndpoints(this WebApplication app)
    {
        var blogRoutes = app.MapGroup("admin/blog");

        blogRoutes.MapDelete("/{id}", deletePost);
    }

    public static async Task<IResult> deletePost(
        [FromRoute] string id,
        [FromServices] PostRepository postRepository
        )
    {
        try{
            var blog  = await postRepository.remove(new Guid(id));
            
            return Results.Ok($"O post foi {blog.title} excluido com sucesso!");
        }
        catch (System.Exception e){
            return Results.BadRequest(e.Message);
            throw;
        }
        return Results.Ok();
    }
}
