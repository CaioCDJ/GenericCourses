using GenericCourses.Domain.Entities;
using GenericCourses.Domain.Contracts.Repositories;
using GenericCourses.Infra.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GenericCourses.Infra.Reposiitories;

public class PostRepository : IPostReepsitory
{
    private readonly AppDbContext _conteext;

    public PostRepository(AppDbContext appDbContext)
      => _conteext = appDbContext;

    public async Task<Post> single(Guid id)
      => await _conteext.posts.FirstOrDefaultAsync(x => x.id == id);


    public async Task<List<Post>> paginate(int page, int size = 10)
    {
        var list = _conteext.posts.Take(size).ToList();

        return list;
    }

    public async Task<Post> store(Post post)
    {
        await _conteext.posts.AddAsync(post);
        await _conteext.SaveChangesAsync();
        return new Post();
    }

    public async Task<Post> update(Post post)
    {
        _conteext.Update(post);
        await _conteext.SaveChangesAsync();
        return new Post();
    }

    public async Task<Post> remove(Guid id)
    {
        var post = await this.single(id);
        _conteext.posts.Remove(post);
        await _conteext.SaveChangesAsync();
        return new Post();
    }
}
