using OmniGLM_API.db;

namespace OmniGLM_API.Models
{
    public class Game : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Series? Series { get; set; }
        public Genre Genre { get; set; }
        public Console Console { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Status Status { get; set; }
        public int Length { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateCompleted { get; set; }
        public Game? BlockedBy { get; set; }
        public Format? Format { get; set; }
        public Condition? Condition { get; set; }
        public string? Notes { get; set; }
    }
}