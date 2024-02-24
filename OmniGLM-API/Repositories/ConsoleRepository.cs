using Microsoft.EntityFrameworkCore;
using OmniGLM_API.db;
using OmniGLM_API.Models;
using Console = OmniGLM_API.Models.Console;

namespace OmniGLM_API.Repositories;

public interface IConsoleRepository
{
    Task<Console> CreateAsync(Console c);
    Task<List<Console>> SearchAsync();
    Task<Console?> FetchAsync(Guid id);
    Task<Console> UpdateAsync(Console g);
}

public class ConsoleRepository : IConsoleRepository
{
    private readonly IEFCoreService<Console, Guid> _efCoreService;

    public ConsoleRepository(IEFCoreService<Console, Guid> efCoreService)
    {
        _efCoreService = efCoreService;
    }

    public async Task<Console> CreateAsync(Console c)
    {
        var result = await _efCoreService.CreateAsync(c);

        return result;
    }

    public async Task<List<Console>> SearchAsync()
    {
        // TODO: Use an actual expression
        var query = _efCoreService.QueryableWhere(c => true);

        var results = await query.ToListAsync();

        return results;
    }

    public async Task<Console?> FetchAsync(Guid id)
    {
        var result = await _efCoreService.FetchAsync(id);

        return result;
    }

    public async Task<Console> UpdateAsync(Console g)
    {
        var result = await _efCoreService.UpdateAsync(g);

        return result;
    }
}