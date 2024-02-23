using GenericCourses.Domain.Dtos.Pages;
using GenericCourses.Domain.Entities;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Dapper;
using Npgsql;

namespace GenericCourses.Infra.Repositories;

public class InstructorRepository : IInstructorRepository
{
    private readonly AppDbContext _context;
    private readonly NpgsqlConnection _conn;

    public InstructorRepository(AppDbContext context)
    {
        _context = context;
        _conn = new NpgsqlConnection(context.Database.GetConnectionString());
    }


    public async Task<AdminAccountDTO> accountInfo(Guid id)
    {
        _conn.Open();
        // 
        var queryResult = await _conn.QueryFirstAsync<queryResult>(@$"
            SELECT
             (SELECT COUNT(*) FROM courses WHERE instructor_id = @id) as qtCourses,
             (SELECT COUNT(*) FROM blog_posts WHERE instructor_id = @id) as qtBlogPosts,
             (SELECT COUNT(*) FROM course_progresses WHERE course_id = @id AND done = TRUE) as qtStudentsFinished,
             (SELECT COUNT(*) FROM course_progresses WHERE course_id = @id ) as qtStudents;
            ", new {id=id});

        await _conn.CloseAsync();
        
        var dto = new AdminAccountDTO
        {
            qtStudents = queryResult.qtStudents,
            qtBlogPosts = queryResult.qtBlogPosts,
            qtCourses = queryResult.qtCourses,
            qtStudentsFinished = queryResult.qtStudentsFinished

        };

        dto.lastPosts = _context.blog_posts
          .Where(x => x.instructorId == id)
          .OrderByDescending(x => x.created_at)
          .Take(4);
        dto.lastCourses = _context.courses
          .Where(x => x.instructorId == id)
          .OrderByDescending(x => x.created_at)
          .Take(5);
        return dto;
    }
}

public class queryResult
{
    public int qtCourses { get; set; }
    public int qtBlogPosts { get; set; }
    public int qtStudentsFinished { get; set; }
    public int qtStudents { get; set; }
}
