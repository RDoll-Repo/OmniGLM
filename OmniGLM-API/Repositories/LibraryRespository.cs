using OmniGLM_API.db;
using OmniGLM_API.Models;
using Microsoft.EntityFrameworkCore;

namespace OmniGLM_API.Repositories
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<Game>> TestGet();
        Task<Game?> FetchEntry(Guid id);
    }

    public class LibraryRepository : ILibraryRepository
    {
        private readonly IEFCoreService<Game, Guid> _efCoreService;

        public LibraryRepository(IEFCoreService<Game, Guid> efCoreService)
        {
            _efCoreService = efCoreService;
        }

        public async Task<IEnumerable<Game>> TestGet()
        {
            return await _efCoreService.WhereAsync(Game => true);
        }

        public async Task<Game?> FetchEntry(Guid id)
        {
            //return await _efCoreService.FetchAsync(id);

            var results = await _efCoreService.QueryableWhere(g => g.Id == id)
            .Include(g => g.Series)
            .Include(g => g.Genre)
            .Include(g => g.Console)
            .Include(g => g.BlockedBy)
            .FirstOrDefaultAsync();

            return results;
        }
    }
}