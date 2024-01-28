using System.Text.Json.Serialization;
using OmniGLM_API.db;

namespace OmniGLM_API.Models
{
    public class Game : IEntity<Guid>
    {
        // TODO: Move these enum converters to an actual viewmodel
        public Guid Id { get; set; }
        public string Title { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public virtual Console Console { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Format Format { get; set; }
        public virtual Genre Genre { get; set; }
        public int Length { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public DateTime? DateCompleted { get; set; }
    }
}