using System.Text.Json.Serialization;
using OmniGLM_API.db;

namespace OmniGLM_API.Models
{
    public class Game : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Status Status { get; set; }
        public virtual Console Console { get; set; }
        public Format Format { get; set; }
        public virtual Genre Genre { get; set; }
        public int Length { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateCompleted { get; set; }
    }

    public class GameViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public string Console { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Format Format { get; set; }
        public int Length { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateCompleted { get; set; }

        public GameViewModel(Game g)
        {
            Id = g.Id;
            Title = g.Title;
            Status = g.Status;
            Console = g.Console.Title;
            Format = g.Format;
            Length = g.Length;
            DateAdded = g.DateAdded;
            DateCompleted = g.DateCompleted;
        }
    }
}