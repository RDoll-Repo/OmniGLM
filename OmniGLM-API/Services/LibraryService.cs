using OmniGLM_API.Models;
using OmniGLM_API.Repositories;

namespace OmniGLM_API.Services;

public interface ILibraryService
{
    Task<ApiResponse<GameViewModel>> CreateGameAsync(CreateGamePayload p);
    Task<ApiResponse<SearchGamesMeta, SearchGamesData>> GetLibraryAsync();
    Task<ApiResponse<GameViewModel>> FetchGameAsync(Guid id);
    Task<ApiResponse<GameViewModel>> UpdateGameAsync(Guid id, UpdateGamePayload p);
    Task DeleteGameAsync(Guid id);
}

public class LibraryService : ILibraryService
{
    private readonly ILibraryRepository _repo;

    public LibraryService(ILibraryRepository repo)
    {
        _repo = repo;
    }

    public async Task<ApiResponse<GameViewModel>> CreateGameAsync(CreateGamePayload p)
    {
        var result = await _repo.CreateAsync(new Game(p));

        // TODO: Find a better way to do this
        var entity = await _repo.FetchAsync(result.Id);

        var response = new ApiResponse<GameViewModel>
        {
            Data = new GameViewModel(entity)
        };

        return response;
    }

    public async Task<ApiResponse<SearchGamesMeta, SearchGamesData>> GetLibraryAsync()
    {
        var results = await _repo.SearchAsync();

        var response = new ApiResponse<SearchGamesMeta, SearchGamesData>
        {
            Meta = new SearchGamesMeta
            {
                Count = results.Count()
            },
            Data = new SearchGamesData(results)
        };

        return response;
    }

    public async Task<ApiResponse<GameViewModel>> FetchGameAsync(Guid id)
    {
        var result = await _repo.FetchAsync(id);

        return new ApiResponse<GameViewModel>
        {
            Data = new GameViewModel(result)
        };
    }

    public async Task<ApiResponse<GameViewModel>> UpdateGameAsync(Guid id, UpdateGamePayload p)
    {
        var game = await _repo.FetchAsync(id) ?? throw new Exception("Not found");

        game.UpdateGame(p);

        var result = await _repo.UpdateAsync(game);

        // TODO: Find a better way to do this
        var entity = await _repo.FetchAsync(result.Id);

        var response = new ApiResponse<GameViewModel>
        {
            Data = new GameViewModel(entity)
        };

        return response;
    }

    public async Task DeleteGameAsync(Guid id)
    {
        var toBeDeleted = await _repo.FetchAsync(id);

        await _repo.DeleteAsync(toBeDeleted);
    }
}
