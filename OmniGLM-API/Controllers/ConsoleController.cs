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
}