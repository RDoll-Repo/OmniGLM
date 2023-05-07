using OmniGLM_API.db;
using System.Text.Json.Serialization;

namespace OmniGLM_API.Models
{
    public class Game : IEntity<Guid>
    {
        public Guid Id { get; set; }
    }
}