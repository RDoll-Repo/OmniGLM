using OmniGLM_API.db;
using OmniGLM_API.Models;
using Microsoft.EntityFrameworkCore;

namespace OmniGLM_API.Repositories;

public interface ILibraryRepository
{
    Task<Game> CreateAsync(Game g);
    Task<IEnumerable<Game>> SearchAsync();
    Task<Game?> FetchAsync(Guid id);
    Task<Game> UpdateAsync(Game g);
    Task DeleteAsync(Game g);
}

public class LibraryRepository : ILibraryRepository
{
    private readonly IEFCoreService<Game, Guid> _efCoreService;

    public LibraryRepository(IEFCoreService<Game, Guid> efCoreService)
    {
        _efCoreService = efCoreService;
    }

    public async Task<Game> CreateAsync(Game g)
    {
        var result = await _efCoreService.CreateAsync(g);

        return result;
    }

    public async Task<IEnumerable<Game>> SearchAsync()
    {
        var results = await _efCoreService.QueryableWhere(Game => true)
            .Include(g => g.Genre)
            .Include(g => g.Console)
            .ToListAsync();

        return results;
    }

    public async Task<Game?> FetchAsync(Guid id)
    {
        var result = await _efCoreService.QueryableWhere(g => g.Id == id)
            .Include(g => g.Genre)
            .Include(g => g.Console)
            .FirstOrDefaultAsync();

        return result;
    }

    public async Task<Game> UpdateAsync(Game g)
    {
        var result = await _efCoreService.UpdateAsync(g);

        return result;
    }

    public async Task DeleteAsync(Game g)
    {
        await _efCoreService.DeleteAsync(g);
    }
}
