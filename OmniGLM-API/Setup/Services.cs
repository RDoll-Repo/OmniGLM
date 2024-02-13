using OmniGLM_API.db;
using OmniGLM_API.Services;

namespace OmniGLM_API.Setup
{
    public static partial class Setup
    {
        private static void SetupServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped(typeof(IEFCoreService<,>), typeof(EFCoreService<,>));
            builder.Services.AddScoped<ILibraryService, LibraryService>();
            builder.Services.AddScoped<IGenreService, GenreService>();
        }
    }
}