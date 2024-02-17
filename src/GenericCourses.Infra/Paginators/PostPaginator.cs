using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Dtos.Pages;
using Microsoft.EntityFrameworkCore;
using Dapper;
using Npgsql;

namespace GenericCourses.Infra.Paginators;

public class PostPaginator<PostDTO> : List<PostDTO>
{
    public int PageIndex { get; private set; }
    public int TotalPages { get; private set; }

    public PostPaginator(List<PostDTO> items, int count, int pageIndex, int pageSize)
    {
        PageIndex = pageIndex;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);

        this.AddRange(items);
    }

    public bool HasPreviousPage => PageIndex > 1;

    public bool HasNextPage => PageIndex < TotalPages;

    public static async Task<PostPaginator<PostDTO>> CreateAsync(
        AppDbContext context, int pageIndex, int pageSize = 10
        )
    {
        pageIndex = (pageIndex > 1) ? pageIndex : 1;

        int offset = (pageIndex > 1)
          ? (pageIndex * pageSize)
          : 0;

        using var conn = new NpgsqlConnection(context.Database.GetConnectionString());

        var lst = await conn.QueryAsync<PostDTO>(@"
            SELECT b.id as postId, b.title ,b.created_at AS date ,u.name AS author ,c.category
                FROM blog_posts AS b
                    JOIN instructors AS i ON i.id = b.instructor_id
                    JOIN categories AS c ON c.id = b.category_id
                    JOIN users AS u ON u.id = i.user_id
                    ORDER BY b.created_at desc
                    LIMIT @pageSize
                    OFFSET @offset
        ", new {pageSize =pageSize, offset = offset});
       
        var qt = await context.blog_posts.CountAsync(); 
        
        conn.Close();

        return new PostPaginator<PostDTO>(
            lst.ToList(), qt, pageIndex, pageSize
        );
    }

}
