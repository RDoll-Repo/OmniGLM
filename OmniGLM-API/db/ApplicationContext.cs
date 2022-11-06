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
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Models.Console> Consoles { get; set; }
        public DbSet<Series> Series { get; set; }

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
            var formatConverter = new EnumToStringConverter<Format>();
            var conditionConverter = new EnumToStringConverter<Condition>();

            modelBuilder
                .Entity<Game>()
                .Property(g => g.Status)
                .HasConversion(statusConverter);

            modelBuilder
                .Entity<Game>()
                .Property(g => g.Format)
                .HasConversion(formatConverter);

            modelBuilder
                .Entity<Game>()
                .Property(g => g.Condition)
                .HasConversion(conditionConverter);
        }
    }
}