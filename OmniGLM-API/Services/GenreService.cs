using Microsoft.AspNetCore.Http.HttpResults;
using OmniGLM_API.Models;
using OmniGLM_API.Repositories;

namespace OmniGLM_API.Services;

public interface IGenreService
{
    Task<ApiResponse<GenreViewModel>> CreateGenreAsync(CreateGenrePayload p);
    Task<ApiResponse<SearchGenresViewModel>> SearchGenresAsync();
    Task<ApiResponse<GenreViewModel>> FetchGenreAsync(Guid id);
    Task<ApiResponse<GenreViewModel>> UpdateGenreAsync(
        Guid id,
        UpdateGenrePayload p
    );
    Task DeleteGenreAsync(Guid id);
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

    public async Task<ApiResponse<GenreViewModel>> UpdateGenreAsync(
        Guid id,
        UpdateGenrePayload p
    )
    {
        // TODO: Replace with proper not found
        var genre = await _repo.FetchAsync(id) ?? throw new Exception("Not found");

        genre.UpdateGenre(p);

        var result = await _repo.UpdateAsync(genre);

        var response = new ApiResponse<GenreViewModel>
        {
            Data = new GenreViewModel(result)
        };

        return response;
    }

    public async Task DeleteGenreAsync(Guid id)
    {
        // TODO: Replace with proper not found
        var genre = await _repo.FetchAsync(id) ?? throw new Exception("Not found");

        await _repo.DeleteAsync(genre);
    }
}