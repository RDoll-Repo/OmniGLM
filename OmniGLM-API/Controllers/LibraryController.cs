using Microsoft.AspNetCore.Mvc;
using OmniGLM_API.Models;
using OmniGLM_API.Services;

namespace OmniGLM_API.Controllers;

[ApiController]
[Route("library")]
public class LibraryController : ControllerBase
{
    private readonly ILibraryService _service;

    public LibraryController(ILibraryService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<GameViewModel>>> CreateGame(
        ApiPayload<CreateGamePayload> p
    )
    {
        var result = await _service.CreateGameAsync(p.Data);

        return Created("", result);
    }
    
    // TODO: Replace with Search
    [HttpGet]
    public async Task<ActionResult<ApiResponse<SearchGamesMeta, SearchGamesData>>> GetLibrary()
    {
        var result = await _service.GetLibraryAsync();

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<GameViewModel>>> FetchGame(Guid id)
    {
        var result = await _service.FetchGameAsync(id);

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<GameViewModel>>> UpdateGame(
        Guid id, 
        ApiPayload<UpdateGamePayload> p
    )
    {
        var result = await _service.UpdateGameAsync(id, p.Data);

        return result;
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteGame(Guid id)
    {
        await _service.DeleteGameAsync(id);

        return NoContent();
    }
}
