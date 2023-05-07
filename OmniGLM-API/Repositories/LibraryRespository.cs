using OmniGLM_API.db;
using OmniGLM_API.Models;
using Microsoft.EntityFrameworkCore;

namespace OmniGLM_API.Repositories
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<Game>> GetLibrary();
        Task<Game?> FetchEntry(Guid id);
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
            .ToListAsync();

            return results;
        }

        public async Task<Game?> FetchEntry(Guid id)
        {
            var results = await _efCoreService.QueryableWhere(g => g.Id == id)
            .FirstOrDefaultAsync();

            return results;
        }
    }
}