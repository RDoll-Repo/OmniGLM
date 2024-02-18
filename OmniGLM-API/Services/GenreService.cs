using OmniGLM_API.Models;
using OmniGLM_API.Repositories;

namespace OmniGLM_API.Services;

public interface IGenreService
{
    Task<ApiResponse<GenreViewModel>> CreateGenreAsync(CreateGenrePayload p);
    Task<ApiResponse<SearchGenresViewModel>> SearchGenresAsync();
    Task<ApiResponse<GenreViewModel>> FetchGenreAsync(Guid id);
}

public class GenreService : IGenreService
{
    private readonly IGenreRepository _repo;

    public GenreService(IGenreRepository repo)
    {
        _repo = repo;
    }

    public async Task<ApiResponse<GenreViewModel>> CreateGenreAsync(CreateGenrePayload p)
    {
        var newGenre = await _repo.CreateAsync(new Genre(p));

        var result = new ApiResponse<GenreViewModel>
        {
            Data = new GenreViewModel(newGenre)
        };

        return result;
    }

    public async Task<ApiResponse<SearchGenresViewModel>> SearchGenresAsync()
    {
        var results = await _repo.SearchAsync();

        var response = new ApiResponse<SearchGenresViewModel>
        {
            Data = new SearchGenresViewModel(results)
        };

        return response;
    }

    public async Task<ApiResponse<GenreViewModel>> FetchGenreAsync(Guid id)
    {
        var result = await _repo.FetchAsync(id);

        var response = new ApiResponse<GenreViewModel>
        {
            Data = new GenreViewModel(result)
        };

        return response;
    }
}