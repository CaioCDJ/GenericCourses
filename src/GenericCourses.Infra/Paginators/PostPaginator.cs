using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Dtos.Pages;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Dapper;

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
        int offset = (pageIndex > 0 && pageIndex != 1)
          ? (pageIndex * pageSize)
          : 0;
        var lst = await context.Database.SqlQueryRaw<PostDTO>(
            "SELECT b.id as postId, b.title ,b.created_at AS date ,u.name AS author " +
                  "FROM \"blogPosts\" AS b  " +
                  "JOIN users AS u ON u.id = b.\"userId\" " +
                  "ORDER BY b.created_at DESC " +
                  "LIMIT 10 " +
                  "OFFSET " + offset
            ).ToListAsync();
        // F para o Dapper
        // var lst = await conn.QueryAsync<PostDTO>(
        //   "SELECT b.title ,b.created_at AS date ,u.name AS author" +
        //           "FROM \"blogPosts\" AS b  " +
        //           "JOIN users AS u ON u.id = b.userId " +
        //           "ORDER BY b.created_at DESC" +
        //           "LIMIT 10 " +
        //           "OFFSET " + offset// sim eu sei que é meio porco
        //
        //     );
        return new PostPaginator<PostDTO>(
              lst.ToList(), lst.Count(), pageIndex, pageSize
            );
    }

}
