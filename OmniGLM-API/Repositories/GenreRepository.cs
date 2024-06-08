using Microsoft.EntityFrameworkCore;
using OmniGLM_API.db;
using OmniGLM_API.Models;

namespace OmniGLM_API.Repositories;

public interface IGenreRepository
{
    Task<Genre> CreateAsync(Genre g);
    Task<List<Genre>> SearchAsync();
    Task<Genre?> FetchAsync(Guid id);
    Task<Genre> UpdateAsync(Genre g);
    Task DeleteAsync(Genre g);
}

public class GenreRepository : IGenreRepository
{
    private readonly IEFCoreService<Genre, Guid> _efCoreService;

    public GenreRepository(IEFCoreService<Genre, Guid> efCoreService)
    {
        _efCoreService = efCoreService;
    }

    public async Task<Genre> CreateAsync(Genre g)
    {
        var result = await _efCoreService.CreateAsync(g);

        return result;
    }

    public async Task<List<Genre>> SearchAsync()
    {
        // TODO: Use an actual expression
        var query = _efCoreService.QueryableWhere(g => true);

        var results = await query.ToListAsync();

        return results;
    }

    public async Task<Genre?> FetchAsync(Guid id)
    {
        var result = await _efCoreService.FetchAsync(id);

        return result;
    }

    public async Task<Genre> UpdateAsync(Genre g)
    {
        var result = await _efCoreService.UpdateAsync(g);

        return result;
    }

    public async Task DeleteAsync(Genre g)
    {
        await _efCoreService.DeleteAsync(g);
    }
}
