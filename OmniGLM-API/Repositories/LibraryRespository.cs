using OmniGLM_API.db;
using OmniGLM_API.Models;
using Microsoft.EntityFrameworkCore;

namespace OmniGLM_API.Repositories
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<Game>> GetLibrary();
        Task<Game?> FetchEntry(Guid id);
        Task<Game> CreateEntry(Game payload);
    }

    public class LibraryRepository : ILibraryRepository
    {
        private readonly IEFCoreService<Game, Guid> _efCoreService;

        public LibraryRepository(IEFCoreService<Game, Guid> efCoreService)
        {
            _efCoreService = efCoreService;
        }

        public async Task<IEnumerable<Game>> GetLibrary()
        {
            var results = await _efCoreService.QueryableWhere(Game => true)
            .Include(g => g.Series)
            .Include(g => g.Genre)
            .Include(g => g.Console)
            .Include(g => g.BlockedBy)
            .ToListAsync();

            return results;
        }

        public async Task<Game?> FetchEntry(Guid id)
        {
            var results = await _efCoreService.QueryableWhere(g => g.Id == id)
            .Include(g => g.Series)
            .Include(g => g.Genre)
            .Include(g => g.Console)
            .Include(g => g.BlockedBy)
            .FirstOrDefaultAsync();

            return results;
        }

        public async Task<Game> CreateEntry(Game payload)
        {
            var result = await _efCoreService.CreateAsync(payload);

            return result;
        }
    }
}