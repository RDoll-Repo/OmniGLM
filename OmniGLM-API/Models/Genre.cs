using OmniGLM_API.db;

namespace OmniGLM_API.Models
{
    public class Genre : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public Genre() {}

        public Genre(CreateGenrePayload p)
        {
            Id = Guid.NewGuid();
            Title = p.Title;
            CreatedAt = p.CreatedAt ?? DateTime.UtcNow;
        }

        public void UpdateGenre(UpdateGenrePayload p)
        {
            Title = p.Title;
            CreatedAt = p.CreatedAt;
            UpdatedAt = DateTime.UtcNow;
        }
    }

    public class CreateGenrePayload
    {
        public string Title { get; set; }
        public DateTime? CreatedAt { get; set; }
    }

    public class UpdateGenrePayload
    {
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
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

    public class SearchGenresViewModel
    {
        public IEnumerable<GenreViewModel> Genres { get; set; }

        public SearchGenresViewModel(IEnumerable<Genre> genres)
        {
            Genres = genres.Select(g => new GenreViewModel(g));
        }
    }
}