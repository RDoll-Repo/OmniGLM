using OmniGLM_API.Repositories;

namespace OmniGLM_API.Setup
{
    public static partial class Setup
    {
        private static void SetupRepositories(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<ILibraryRepository, LibraryRepository>();
            builder.Services.AddScoped<IGenreRepository, GenreRepository>();
        }
    }
}