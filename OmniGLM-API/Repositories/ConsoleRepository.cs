using Microsoft.EntityFrameworkCore;
using OmniGLM_API.db;
using Console = OmniGLM_API.Models.Console;

namespace OmniGLM_API.Repositories;

public interface IConsoleRepository
{
    Task<Console> CreateAsync(Console c);
    Task<List<Console>> SearchAsync();
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
}