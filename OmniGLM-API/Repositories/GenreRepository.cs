using Microsoft.EntityFrameworkCore;
using OmniGLM_API.db;
using OmniGLM_API.Models;

namespace OmniGLM_API.Repositories;

public interface IGenreRepository
{
    Task<Genre> CreateGenre(Genre g);
    Task<List<Genre>> SearchGenres();
}

public class GenreRepository : IGenreRepository
{
    private readonly IEFCoreService<Genre, Guid> _efCoreService;

    public GenreRepository(IEFCoreService<Genre, Guid> efCoreService)
    {
        _efCoreService = efCoreService;
    }

    public async Task<Genre> CreateGenre(Genre g)
    {
        var result = await _efCoreService.CreateAsync(g);

        return result;
    }

    public async Task<List<Genre>> SearchGenres()
    {
        var query = _efCoreService.QueryableWhere(g => true);

        return await query.ToListAsync();
    }
}