using Microsoft.EntityFrameworkCore;
using OmniGLM_API.Models;

namespace OmniGLM_API.db
{
    public class ApplicationContext : DbContext
    {
        private readonly ApplicationConfig _appConfig;
        private string _connectionString => _appConfig.ConnectionString;
        public DbSet<Sample> Samples { get; set; }

        public ApplicationContext(
            ApplicationConfig appConfig
        )
        {
            _appConfig = appConfig;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql(_connectionString)
                .EnableSensitiveDataLogging()
                .UseSnakeCaseNamingConvention();
        }
    }
}