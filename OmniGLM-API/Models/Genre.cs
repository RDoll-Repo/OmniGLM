using OmniGLM_API.db;

namespace OmniGLM_API.Models
{
    public class Genre : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        public Genre() {}

        public Genre(CreateGenrePayload p)
        {
            Id = Guid.NewGuid();
            Title = p.Title;
            CreatedAt = p.CreatedAt ?? DateTime.UtcNow;
        }
    }

    public class CreateGenrePayload
    {
        public string Title { get; set; }
        public DateTime? CreatedAt { get; set; }
    }

    public class GenreViewModel
    {
        public Guid Id { get; }
        public string Title { get; }
        public DateTime CreatedAt { get; }
        public DateTime? UpdatedAt { get; }

        public GenreViewModel(Genre g)
        {
            Id = g.Id;
            Title = g.Title;
            CreatedAt = g.CreatedAt;
            UpdatedAt = g.UpdatedAt;
        }
    }
}