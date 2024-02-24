using OmniGLM_API.db;

namespace OmniGLM_API.Models;

public class Console : IEntity<Guid>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public Console() {}

    public Console(CreateConsolePayload p)
    {
        Id = Guid.NewGuid();
        Title = p.Title;
        CreatedAt = p.CreatedAt ?? DateTime.UtcNow;
    }
}

public class CreateConsolePayload
{
    public string Title { get; set; }
    public DateTime? CreatedAt { get; set; }
}

public class ConsoleViewModel
{
    public Guid Id { get; }
    public string Title { get; }
    public DateTime CreatedAt { get; }
    public DateTime? UpdatedAt { get; }

    public ConsoleViewModel(Console c)
    {
        Id= c.Id;
        Title = c.Title;
        CreatedAt = c.CreatedAt;
        UpdatedAt = c.UpdatedAt;
    }
}