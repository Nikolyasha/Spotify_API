using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Models.Domains
{
    public class Release
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ReleaseType { get; set; } = string.Empty; // 'album', 'ep', 'single'
        public DateTime? ReleaseDate { get; set; }
        public string ReleasePreview { get; set; } = string.Empty;

        // Внешний ключ для связи с артистом
        public int ArtistId { get; set; }
        //public Artist Artist { get; set; }

        // Навигационное свойство для связи с песнями
        public ICollection<Song> Songs { get; set; } = new List<Song>();
    }
}
