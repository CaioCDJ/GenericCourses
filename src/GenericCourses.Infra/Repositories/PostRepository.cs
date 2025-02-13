using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Repositories.Queries;
using GenericCourses.Domain.Dtos.Pages;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using Dapper;

namespace GenericCourses.Infra.Repositories;

internal sealed class PostRepository : Repository<BlogPost>, IPostRepository {

	private readonly string _connString;

	public PostRepository(AppDbContext appDbContext) : base(appDbContext) {
		_connString = appDbContext.Database.GetConnectionString();
	}

	public async Task<BlogPost> single(Guid id)
	  => await _context.blog_posts.FirstOrDefaultAsync(x => x.id == id);

	public async Task<List<PostDTO>> paginate(
		int offset,
		int size = 8,
		string[]? categories = null,
		string? searchParam = null
	) {
		using var conn = new NpgsqlConnection(_connString);

		string where = null;

		if (searchParam is not null && (categories is not null && categories.Length > 0)) {
			where = "WHERE b.title LIKE @searchTitle" + " AND " + "c.name = any(@categories)";
		}
		else if (searchParam is not null) {
			where = "WHERE b.title LIKE @searchTitle";
		}
		else if (categories is not null && categories.Length > 0) {
			where = "WHERE c.name = any (@categories)";
		}

		string query = @$"
			SELECT b.id as postId, b.title ,b.created_at AS date ,u.name AS author ,c.name as category
                FROM blog_posts AS b
                    JOIN instructors AS i ON i.id = b.instructor_id
                    JOIN post_categories AS cc ON cc.blog_post_id = b.id
                    JOIN categories AS c ON c.id = cc.category_id
                    JOIN users AS u ON u.id = i.user_id
                    {(string.IsNullOrEmpty(where) ? "" : where)}
                    ORDER BY b.created_at desc
                    LIMIT @size
                    OFFSET @offset";

		var lst = await conn.QueryAsync<PostDTO>(query, new {
			size = size,
			offset = offset,
			categories = categories,
			searchTitle = "%" + searchParam + "%"
		});

		return lst.ToList();
	}

	public async Task<List<GetPostAdminQuery>> paginateAdmin(Guid id, int offset, int size = 8) {
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

	public async Task<int> QtByUsers(Guid id) {
		using var conn = new NpgsqlConnection(_connString);
		return await conn.QuerySingleAsync<int>(@"
            SELECT COUNT(*) FROM blog_posts
                JOIN instructors AS i ON i.id = b.instructor_id
                WHERE b.instructor_id = @id
        ", new { id = id });
	}

}
