using Microsoft.AspNetCore.Http.HttpResults;
using OmniGLM_API.Models;
using OmniGLM_API.Repositories;

namespace OmniGLM_API.Services
{
    public interface ILibraryService
    {
        Task<ApiResponse<GameViewModel>> CreateGameAsync(CreateGamePayload p);
        Task<IEnumerable<Game>> GetLibraryAsync();
        Task<ApiResponse<GameViewModel>> FetchGameAsync(Guid id);
        Task DeleteGameAsync(Guid id);
    }

    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _repo;

        public LibraryService(ILibraryRepository repo)
        {
            _repo = repo;
        }

        public async Task<ApiResponse<GameViewModel>> CreateGameAsync(CreateGamePayload p)
        {
            var result = await _repo.CreateAsync(new Game(p));

            // TODO: Find a better way to do this
            var entity = await _repo.FetchAsync(result.Id);

            var response = new ApiResponse<GameViewModel>
            {
                Data = new GameViewModel(entity)
            };

            return response;
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

        public async Task DeleteGameAsync(Guid id)
        {
            var toBeDeleted = await _repo.FetchAsync(id);

            await _repo.DeleteAsync(toBeDeleted);
        }
    }
}