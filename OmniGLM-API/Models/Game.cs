using OmniGLM_API.db;

namespace OmniGLM_API.Models
{
    public class Game : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; }
        public Console Console { get; set; }
        public Format Format { get; set; }
        public Genre Genre { get; set; }
        public int Length { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateCompleted { get; set; }
    }
}