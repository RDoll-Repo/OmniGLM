using OmniGLM_API.Models;
using OmniGLM_API.Repositories;

namespace OmniGLM_API.Services
{
    public interface ILibraryService
    {
        Task<IEnumerable<Game>> GetLibrary();
        Task<ApiResponse<GameViewModel>> FetchGame(Guid id);
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
            var results = await _repo.GetLibrary();

            return results;
        }

        public async Task<ApiResponse<GameViewModel>> FetchGame(Guid id)
        {
            var result = await _repo.FetchGame(id);

            return new ApiResponse<GameViewModel>
            {
                Data = new GameViewModel(result)
            };
        }
    }
}