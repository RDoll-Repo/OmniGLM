using OmniGLM_API.Models;
using OmniGLM_API.Repositories;

namespace OmniGLM_API.Services
{
    public interface ILibraryService
    {
        Task<IEnumerable<Game>> GetLibraryAsync();
        Task<ApiResponse<GameViewModel>> FetchGameAsync(Guid id);
    }

    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _repo;

        public LibraryService(ILibraryRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<Game>> GetLibraryAsync()
        {
            var results = await _repo.SearchAsync();

            return results;
        }

        public async Task<ApiResponse<GameViewModel>> FetchGameAsync(Guid id)
        {
            var result = await _repo.FetchAsync(id);

            return new ApiResponse<GameViewModel>
            {
                Data = new GameViewModel(result)
            };
        }
    }
}