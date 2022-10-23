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
        
        // Doesn't work yet.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetLibrary()
        {
            var result =  await _service.TestGet();

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetEntry(Guid id)
        {
            var result =  await _service.FetchEntry(id);

            return Ok(result);
        }
    }
}

