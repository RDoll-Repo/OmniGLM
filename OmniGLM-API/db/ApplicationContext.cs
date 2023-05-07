using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OmniGLM_API.Models;

namespace OmniGLM_API.db
{
    public class ApplicationContext : DbContext
    {
        private readonly ApplicationConfig _appConfig;
        private string _connectionString => _appConfig.ConnectionString;
        public DbSet<Game> Games { get; set; }

        public ApplicationContext(
            ApplicationConfig appConfig,
            DbContextOptions options
        )
        : base(options)
        {
            _appConfig = appConfig;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseNpgsql(_connectionString)
                .EnableSensitiveDataLogging()
                .UseSnakeCaseNamingConvention();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var statusConverter = new EnumToStringConverter<Status>();
        }
    }
}