using Microsoft.AspNetCore.Mvc;
using OmniGLM_API.Models;
using OmniGLM_API.Services;

namespace OmniGLM_API.Controllers
{
    [ApiController]
    [Route("library")]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _service;

        public LibraryController(ILibraryService service)
        {
            _service = service;
        }
        
        // TODO: Replace with Search
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetLibrary()
        {
            var result =  await _service.GetLibraryAsync();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApiResponse<GameViewModel>>> FetchGame(Guid id)
        {
            var result = await _service.FetchGameAsync(id);

            return Ok(result);
        }
    }
}

