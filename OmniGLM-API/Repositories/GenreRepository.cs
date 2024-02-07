using OmniGLM_API.db;
using OmniGLM_API.Models;

namespace OmniGLM_API.Repositories;

public interface IGenreRepository
{
    Task<Genre> CreateGenre(Genre g);
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
}