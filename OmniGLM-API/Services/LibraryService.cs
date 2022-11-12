using OmniGLM_API.Models;
using OmniGLM_API.Repositories;

namespace OmniGLM_API.Services
{
    public interface ILibraryService
    {
        Task<IEnumerable<Game>> GetLibrary();
        Task<FetchGameViewModel?> FetchEntry(Guid id);
    }

    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _repo;

        public LibraryService(ILibraryRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Game>> GetLibrary()
        {
            return await _repo.GetLibrary();
        }

        public async Task<FetchGameViewModel?> FetchEntry(Guid id)
        {
            var results = await _repo.FetchEntry(id);

            var entry = new FetchGameViewModel(results);

            return entry;
        }
    }
}