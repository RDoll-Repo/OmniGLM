using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OmniGLM_API.db;
using OmniGLM_API.Models;

namespace OmniGLM_API.Controllers;

[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
    private readonly ApplicationContext _context;
    private DbSet<Sample> _dbSet => _context.Set<Sample>();

    public TestController(ApplicationContext appContext)
    {
        _context = appContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Sample>>> TestGet()
    {
        return await _dbSet.Where(Sample => true).ToListAsync();
    }
}
