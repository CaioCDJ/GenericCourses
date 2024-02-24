using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Dtos.Querys;
using GenericCourses.Domain.Dtos.Pages;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Dapper;

namespace GenericCourses.Infra.Repositories;

public class PostRepository : IPostRepository
{
    private readonly AppDbContext _context;
    private readonly string _connString;

    public PostRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
        _connString = appDbContext.Database.GetConnectionString();
    }

    public async Task<BlogPost> single(Guid id)
      => await _context.blog_posts.FirstOrDefaultAsync(x => x.id == id);

    public async Task<List<PostDTO>> paginate(int offset, int size = 8)
    {
        using var conn = new NpgsqlConnection(_connString);
        var lst = await conn.QueryAsync<PostDTO>(@"
            SELECT b.id as postId, b.title ,b.created_at AS date ,u.name AS author ,c.category
                FROM blog_posts AS b
                    JOIN instructors AS i ON i.id = b.instructor_id
                    JOIN categories AS c ON c.id = b.category_id
                    JOIN users AS u ON u.id = i.user_id
                    ORDER BY b.created_at desc
                    LIMIT @size
                    OFFSET @offset
        ", new { size = size, offset = offset });
        return lst.ToList();
    }

    public async Task<List<GetPostAdminQuery>> paginateAdmin(Guid id, int offset, int size = 8)
    {
        using var conn = new NpgsqlConnection(_connString);
        var lst = await conn.QueryAsync<GetPostAdminQuery>(@"
            SELECT b.id as postId, b.title ,b.created_at ,u.name AS author 
                FROM blog_posts AS b
                    JOIN instructors AS i ON i.id = b.instructor_id
                    JOIN categories AS c ON c.id = b.category_id
                    JOIN users AS u ON u.id = i.user_id
                    WHERE b.instructor_id = @id
                    ORDER BY b.created_at desc
                    LIMIT @size
                    OFFSET @offset
        ", new { size = size, offset = offset, id = id });
        return lst.ToList();
    }
    public async Task<int> QtByUsers(Guid id)
    {
        using var conn = new NpgsqlConnection(_connString);
        return await conn.QuerySingleAsync<int>(@"
            SELECT COUNT(*) FROM blog_posts
                JOIN instructors AS i ON i.id = b.instructor_id
                WHERE b.instructor_id = @id
        ", new { id = id });
    }

    public async Task<BlogPost> store(BlogPost post)
    {
        await _context.blog_posts.AddAsync(post);
        await _context.SaveChangesAsync();
        return new BlogPost();
    }

    public async Task<BlogPost> update(BlogPost post)
    {
        _context.Update(post);
        await _context.SaveChangesAsync();
        return new BlogPost();
    }

    public async Task<BlogPost> remove(Guid id)
    {
        var post = await this.single(id);
        _context.blog_posts.Remove(post);
        await _context.SaveChangesAsync();
        return new BlogPost();
    }
}
