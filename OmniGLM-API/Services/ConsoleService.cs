using OmniGLM_API.Models;
using OmniGLM_API.Repositories;
using Console = OmniGLM_API.Models.Console;

namespace OmniGLM_API.Services;

public interface IConsoleService
{
    Task<ApiResponse<ConsoleViewModel>> CreateConsoleAsync(CreateConsolePayload p);
    Task<ApiResponse<SearchConsolesViewModel>> SearchConsolesAsync();
    Task<ApiResponse<ConsoleViewModel>> FetchConsoleAsync(Guid id);
    Task<ApiResponse<ConsoleViewModel>> UpdateConsoleAsync(
        Guid id,
        UpdateConsolePayload p
    );
    Task DeleteConsoleAsync(Guid id);
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

    public async Task<ApiResponse<SearchConsolesViewModel>> SearchConsolesAsync()
    {
        var results = await _repo.SearchAsync();

        var response = new ApiResponse<SearchConsolesViewModel>
        {
            Data = new SearchConsolesViewModel(results)
        };

        return response;
    }

    public async Task<ApiResponse<ConsoleViewModel>> FetchConsoleAsync(Guid id)
    {
        var result = await _repo.FetchAsync(id);

        var response = new ApiResponse<ConsoleViewModel>
        {
            Data = new ConsoleViewModel(result)
        };

        return response;
    }

    public async Task<ApiResponse<ConsoleViewModel>> UpdateConsoleAsync(
        Guid id,
        UpdateConsolePayload p
    )
    {
        // TODO: Replace with proper not found
        var console = await _repo.FetchAsync(id) ?? throw new Exception("Not found");

        console.UpdateConsole(p);

        var result = await _repo.UpdateAsync(console);

        var response = new ApiResponse<ConsoleViewModel>
        {
            Data = new ConsoleViewModel(result)
        };

        return response;
    }

    public async Task DeleteConsoleAsync(Guid id)
    {
        // TODO: Replace with proper not found
        var console = await _repo.FetchAsync(id) ?? throw new Exception("Not found");

        await _repo.DeleteAsync(console);
    }
}
