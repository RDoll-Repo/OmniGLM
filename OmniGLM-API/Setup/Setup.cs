using OmniGLM_API.db;
using OmniGLM_API.Models;

namespace OmniGLM_API.Setup
{
    public static partial class Setup
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            SetupConfig(builder);
            SetupEfCore(builder);
        }

        public static void SetupConfig(WebApplicationBuilder builder)
        {
            var configManager = builder.Configuration;
            var config = new ApplicationConfig();
            configManager.Bind("Application", config);
            builder.Services.AddSingleton<ApplicationConfig>(provider => config);
        }

        public static void SetupEfCore(WebApplicationBuilder builder)
        {
            builder.Services.AddDbContext<ApplicationContext>();
        }
    }
}