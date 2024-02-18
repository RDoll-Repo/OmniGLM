using Microsoft.AspNetCore.Mvc;
using OmniGLM_API.Models;
using OmniGLM_API.Services;

namespace OmniGLM_API.Controllers;

[ApiController]
[Route("genres")]
public class GenreController : ControllerBase
{
    private readonly IGenreService _service;

    public GenreController(IGenreService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<GenreViewModel>>> CreateGenre(
        ApiPayload<CreateGenrePayload> p
    )
    {
        var result = await _service.CreateGenre(p.Data);

        return Created("", result);
    }

    // TODO: Replace with search
    [HttpGet]
    public async Task<ActionResult<ApiResponse<SearchGenresViewModel>>> SearchGenres()
    {
        var results = await _service.SearchGenres();

        return results;
    }
}