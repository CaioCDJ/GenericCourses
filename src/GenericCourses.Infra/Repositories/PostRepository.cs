using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Contracts.Repositories;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GenericCourses.Infra.Repositories;

public class PostRepository : IPostReepsitory
{
    private readonly AppDbContext _context;

    public PostRepository(AppDbContext appDbContext)
      => _context = appDbContext;

    public async Task<BlogPost> single(Guid id)
      => await _context.blog_posts.FirstOrDefaultAsync(x => x.id == id);

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
