using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SpotifyAPI.Models.Domains
{
    public class Song
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public TimeSpan? Duration { get; set; } // Продолжительность песни
        public int TrackNumber { get; set; } // Номер трека в релизе
        public string? Lyrics { get; set; } // Текст песни (опционально)

        // Внешний ключ для связи с релизом
        public int ReleaseId { get; set; }
        public long Listeners { get; set; } = 0;
        public ICollection<SongArtists> SongArtists { get; set; } = new List<SongArtists>();
        //public Release Release { get; set; }
    }
}
