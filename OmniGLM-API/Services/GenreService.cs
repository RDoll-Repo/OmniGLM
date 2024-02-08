using OmniGLM_API.Models;

namespace OmniGLM_API.Services;

public interface IGenreService
{
    Task<ApiResponse<GenreViewModel>> CreateGenre(ApiPayload<CreateGenrePayload> payload);
}