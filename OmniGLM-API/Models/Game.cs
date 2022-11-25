using OmniGLM_API.db;
using System.Text.Json.Serialization;

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

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
        public int Length { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateCompleted { get; set; }
        public Game? BlockedBy { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Format Format { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Condition? Condition { get; set; }
        public string? Notes { get; set; }

        public Game() 
        {
            // Empty
        }

        public Game(PostGamePayload p)
        {
            Title = p.Title;

            if (p.SeriesId != null)
            {
                Series = new Series
                {
                    Id = (Guid)p.SeriesId
                };
            }

            Genre = new Genre
            {
                Id = p.GenreId
            };

            Console = new Console
            {
                Id = p.ConsoleId
            };

            ReleaseDate = p.ReleaseDate;
            
            if (p.DateCompleted != null)
            {
                DateCompleted = p.DateCompleted;
                Status = Status.Completed;
            }
            else
            {
                Status = Status.Unfinished;
            }

            // TODO: Remove when HLTB support is added.
            Length = 0;
            DateAdded = DateTime.Now;

            if (p.BlockedBy != null)
            {
                BlockedBy = p.BlockedBy;
            }

            Format = p.Format;

            if (p.Condition != null)
            {
                Condition = p.Condition;
            }

            if (p.Notes != null)
            {
                Notes = p.Notes;
            }
        }
    }

    public class BlockingGameViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Series? Series { get; set; }
        public int Length { get; set; }
        public string? Notes { get; set; }

        public BlockingGameViewModel()
        {

        }

        public BlockingGameViewModel(Game game)
        {
            Id = game.Id;
            Title = game.Title;
            Series = game.Series;
            Length = game.Length;
            Notes = game.Notes;
        }
    }

    public class FetchGameViewModel
    {
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
        public BlockingGameViewModel? BlockedBy { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Format? Format { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Condition? Condition { get; set; }
        public string? Notes { get; set; }

        public FetchGameViewModel()
        {
            
        }

        public FetchGameViewModel(Game game)
        {
            Title = game.Title;
            Series = game.Series;
            Genre = game.Genre;
            Console = game.Console;
            ReleaseDate = game.ReleaseDate;
            Status = game.Status;
            Length = game.Length;
            DateAdded = game.DateAdded;
            DateCompleted = game.DateCompleted;
            Format = game.Format;
            Condition = game.Condition;
            Notes = game.Notes;

            if (game.BlockedBy != null)
            {
                BlockedBy = new BlockingGameViewModel(game.BlockedBy);
            }
        }
    }

    public class PostGamePayload
    {
        public string Title { get; set; }
        public Guid? SeriesId { get; set; }
        public Guid GenreId { get; set; }
        public Guid ConsoleId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public Game? BlockedBy { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Format Format { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Condition? Condition { get; set; }
        public string? Notes { get; set; }
    }
}