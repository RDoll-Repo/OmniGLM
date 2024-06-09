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
        var result = await _service.CreateGenreAsync(p.Data);

        return Created("", result);
    }

    // TODO: Replace with search
    [HttpGet]
    public async Task<ActionResult<ApiResponse<SearchGenresViewModel>>> SearchGenres()
    {
        var results = await _service.SearchGenresAsync();

        return results;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GenreViewModel>>> FetchGenre(Guid id)
    {
        var result = await _service.FetchGenreAsync(id);

        return result;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<GenreViewModel>>> UpdateGenre(
        Guid id, 
        ApiPayload<UpdateGenrePayload> p
    )
    {
        var result = await _service.UpdateGenreAsync(id, p.Data);

        return result;
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteGenre(Guid id)
    {
        await _service.DeleteGenreAsync(id);

        return NoContent();
    }
}
