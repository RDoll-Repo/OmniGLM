using Microsoft.AspNetCore.Mvc;
using OmniGLM_API.Models;
using OmniGLM_API.Services;

namespace OmniGLM_API.Controllers;

[ApiController]
[Route("consoles")]
public class ConsoleController : ControllerBase
{
    private readonly IConsoleService _service;

    public ConsoleController(IConsoleService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<ApiResponse<ConsoleViewModel>>> CreateConsole(
        ApiPayload<CreateConsolePayload> p
    )
    {
        var result = await _service.CreateConsoleAsync(p.Data);

        return Created("", result);
    }

    // TODO: Replace with Search
    [HttpGet]
    public async Task<ActionResult<ApiResponse<SearchConsolesViewModel>>> SearchConsoles()
    {
        var results = await _service.SearchConsolesAsync();

        return results;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ApiResponse<ConsoleViewModel>>> FetchConsole(Guid id)
    {
        var result = await _service.FetchConsoleAsync(id);

        return result;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<ApiResponse<ConsoleViewModel>>> UpdateConsole(
        Guid id,
        ApiPayload<UpdateConsolePayload> p
    )
    {
        var result = await _service.UpdateConsoleAsync(id, p.Data);

        return result;
    }
}