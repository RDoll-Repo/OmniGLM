using OmniGLM_API.db;
using OmniGLM_API.Models;

namespace OmniGLM_API.Repositories
{
    public interface ILibraryRepository
    {
        Task<IEnumerable<Game>> TestGet();
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
    }
}