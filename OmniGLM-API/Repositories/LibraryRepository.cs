using OmniGLM_API.db;
using OmniGLM_API.Models;
using Microsoft.EntityFrameworkCore;

namespace OmniGLM_API.Repositories
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<Game>> SearchAsync();
        Task<Game?> FetchAsync(Guid id);
    }

    public class LibraryRepository : ILibraryRepository
    {
        private readonly IEFCoreService<Game, Guid> _efCoreService;

        public LibraryRepository(IEFCoreService<Game, Guid> efCoreService)
        {
            _efCoreService = efCoreService;
        }

        public async Task<IEnumerable<Game>> SearchAsync()
        {
            var results = await _efCoreService.QueryableWhere(Game => true)
                .Include(g => g.Genre)
                .Include(g => g.Console)
                .ToListAsync();

            return results;
        }

        public async Task<Game?> FetchAsync(Guid id)
        {
            var result = await _efCoreService.QueryableWhere(g => g.Id == id)
                .Include(g => g.Genre)
                .Include(g => g.Console)
                .FirstOrDefaultAsync();

            return result;
        }
    }
}