using OmniGLM_API.db;
using Console = OmniGLM_API.Models.Console;

namespace OmniGLM_API.Repositories;

public interface IConsoleRepository
{
    Task<Console> CreateAsync(Console c);
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
}