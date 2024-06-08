using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using OmniGLM_API.db;

namespace OmniGLM_API.Models;

public class Game : IEntity<Guid>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public Status Status { get; set; }
    public Guid ConsoleId { get; set; }
    public virtual Console Console { get; set; }
    public Format Format { get; set; }
    public Guid GenreId { get; set; }
    public virtual Genre Genre { get; set; }
    public int Length { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DateCompleted { get; set; }

    public Game() {}

    public Game(CreateGamePayload p)
    {
        Id = Guid.NewGuid();
        Title = p.Title;
        Status = p.Status;
        ConsoleId = p.ConsoleId;
        Format = p.Format;
        GenreId = p.GenreId;
        Length = p.Length;
        CreatedAt = p.CreatedAt ?? DateTime.UtcNow;
        DateCompleted = p.DateCompleted;
    }

    public void UpdateGame(UpdateGamePayload p)
    {
        Title = p.Title;
        Status = p.Status;
        ConsoleId = p.ConsoleId;
        Format = p.Format;
        GenreId = p.GenreId;
        Length = p.Length;
        CreatedAt = p.CreatedAt;
        DateCompleted = p.DateCompleted;
        UpdatedAt = DateTime.UtcNow;
    }
}

public class GameViewModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Status Status { get; set; }
    public ConsoleViewModel Console { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public Format Format { get; set; }
    public GenreViewModel Genre { get; set; }
    public int Length { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DateCompleted { get; set; }

    public GameViewModel(Game g)
    {
        Id = g.Id;
        Title = g.Title;
        Status = g.Status;
        Console = new ConsoleViewModel(g.Console);
        Format = g.Format;
        Length = g.Length;
        Genre = new GenreViewModel(g.Genre);
        CreatedAt = g.CreatedAt;
        UpdatedAt = g.UpdatedAt;
        DateCompleted = g.DateCompleted;
    }
}

public class CreateGamePayload
{
    // Add validation at later point: IE: cannot have completedAt if backlog
    public string Title { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(Status))]
    public Status Status { get; set; }
    public Guid ConsoleId { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(Format))]
    public Format Format { get; set; }
    public Guid GenreId { get; set; }
    public int Length { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? DateCompleted { get; set; }
}

// Identical to Create for now, but could possibly change
public class UpdateGamePayload
{
    // Add validation at later point: IE: cannot have completedAt if backlog
    public string Title { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(Status))]
    public Status Status { get; set; }
    public Guid ConsoleId { get; set; }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    [EnumDataType(typeof(Format))]
    public Format Format { get; set; }
    public Guid GenreId { get; set; }
    public int Length { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? DateCompleted { get; set; }
}

public class SearchGamesMeta
{
    public int Count { get; set; }
}

public class SearchGamesData
{
    public IEnumerable<GameViewModel> Games { get; set; }

    public SearchGamesData(IEnumerable<Game> games)
    {
        Games = games.Select(g => new GameViewModel(g));
    }
}
