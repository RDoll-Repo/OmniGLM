using OmniGLM_API.db;
using System.Text.Json.Serialization;

namespace OmniGLM_API.Models
{
    public class Game : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Series? Series { get; set; }
        public Genre? Genre { get; set; }
        public Console? Console { get; set; }
        public DateTime ReleaseDate { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public int Length { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateCompleted { get; set; }
        public Game? BlockedBy { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Format? Format { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Condition? Condition { get; set; }
        public string? Notes { get; set; }
    }
}