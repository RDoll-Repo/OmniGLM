using OmniGLM_API.db;

namespace OmniGLM_API.Models
{
    public class Console : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}