using OmniGLM_API.Models;
using OmniGLM_API.Repositories;

namespace OmniGLM_API.Services;

public interface IGenreService
{
    Task<ApiResponse<GenreViewModel>> CreateGenre(CreateGenrePayload p);
}

public class GenreService : IGenreService
{
    private readonly IGenreRepository _repo;

    public GenreService(IGenreRepository repo)
    {
        _repo = repo;
    }

    public async Task<ApiResponse<GenreViewModel>> CreateGenre(CreateGenrePayload p)
    {
        var newGenre = await _repo.CreateGenre(new Genre(p));

        var result = new ApiResponse<GenreViewModel>
        {
            Data = new GenreViewModel(newGenre)
        };

        return result;
    }
}