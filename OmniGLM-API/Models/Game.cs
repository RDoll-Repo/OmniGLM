using OmniGLM_API.db;

namespace OmniGLM_API.Models
{
    public class Game : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; }
        public Guid ConsoleId { get; set; }
        public Format Format { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public int Length { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateCompleted { get; set; }

        public Game()
        {

        }
    }

    public class AddGamePayload : IValidatable
    {
        public string Title { get; set; }
        public Status Status { get; set; }
        public Guid ConsoleId { get; set; }
        public Format Format { get; set; }
        public List<Guid> GenreIds { get; set; }
        public int Length { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateCompleted { get; set; }

        public bool IsValid() =>
            !String.IsNullOrWhiteSpace(Title)
                && ConsoleId != Guid.Empty
                && GenreIds.Count > 0
                && Length > 0;
    }
}