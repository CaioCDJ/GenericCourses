using GenericCourses.Infra.Persistence;
using GenericCourses.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericCourses.Infra.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly AppDbContext _context;

    public CourseRepository(AppDbContext context)
      => _context = context;

    public async Task<Course> single(Guid id)
      => await _context.courses.FirstOrDefaultAsync(x => x.id == id);

    public async Task<Course> store(Course course)
    {
        var check = await _context.courses.FirstOrDefaultAsync(x =>
            x.title == course.title);
        
        if (check is not null) throw new Exception(message: $"Já existe um curso com o nome: {course.title}");

        await _context.courses.AddAsync(course);
        await _context.SaveChangesAsync();
        return course;
    }

    public async Task<Course> update(Guid id, Course course)
    {
        var courseCheck = await this.single(id);

        if (courseCheck is null) throw new Exception(message: $"O usuario não foi encontrado!");

        _context.courses.Update(course);
        await _context.SaveChangesAsync();

        return course;
    }

    public async Task delete(Guid id)
    {
        var course = await _context.courses.FirstOrDefaultAsync(x => x.id == id);

        if (course is null) throw new Exception(message: $"O Curso não foi encontrado!");

        _context.courses.Remove(course);

        await _context.SaveChangesAsync();
    }
}
