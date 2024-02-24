using OmniGLM_API.Models;
using OmniGLM_API.Repositories;
using Console = OmniGLM_API.Models.Console;

namespace OmniGLM_API.Services;

public interface IConsoleService
{
    Task<ApiResponse<ConsoleViewModel>> CreateConsoleAsync(CreateConsolePayload p);
}

public class ConsoleService : IConsoleService
{
    private readonly IConsoleRepository _repo;

    public ConsoleService(IConsoleRepository repo)
    {
        _repo = repo;
    }

    public async Task<ApiResponse<ConsoleViewModel>> CreateConsoleAsync(CreateConsolePayload p)
    {
        var result = await _repo.CreateAsync(new Console(p));

        var response = new ApiResponse<ConsoleViewModel>
        {
            Data = new ConsoleViewModel(result)
        };

        return response;
    }
}