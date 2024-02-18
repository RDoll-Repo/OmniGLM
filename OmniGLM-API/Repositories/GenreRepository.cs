using Microsoft.EntityFrameworkCore;
using OmniGLM_API.db;
using OmniGLM_API.Models;

namespace OmniGLM_API.Repositories;

public interface IGenreRepository
{
    Task<Genre> CreateAsync(Genre g);
    Task<List<Genre>> SearchAsync();
    Task<Genre?> FetchAsync(Guid id);
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

        var result = await query.ToListAsync();

        return result;
    }

    public async Task<Genre?> FetchAsync(Guid id)
    {
        var result = await _efCoreService.FetchAsync(id);

        return result;
    }
}