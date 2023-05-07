using OmniGLM_API.db;

namespace OmniGLM_API.Models
{
    public class Game : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        // TODO: Enum
        public string Status { get; set; }

        // TODO: Normalize
        public string Console { get; set; }

        // TODO: Enum
        public string Format { get; set; }

        // TODO: Normalize
        public string Genre { get; set; }
        public int Length { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateCompleted { get; set; }
    }
}