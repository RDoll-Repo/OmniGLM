using OmniGLM_API.Models;
using OmniGLM_API.Repositories;

namespace OmniGLM_API.Services
{
    public interface ILibraryService
    {
        Task<IEnumerable<Game>> TestGet();
        Task<Game?> FetchEntry(Guid id);
    }

    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _repo;

        public LibraryService(ILibraryRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Game>> TestGet()
        {
            return await _repo.TestGet();
        }

        public async Task<Game?> FetchEntry(Guid id)
        {
            var results = await _repo.FetchEntry(id);
            
            // if (results.BlockedById != null && results.BlockedById != null)
            // {
            //     // Empty guid is mostly here to keep the compiler happy.
            //     var x = await _repo.FetchBlockingGame(results.BlockedById ?? Guid.Empty);
            // }

            return results;
        }
    }
}