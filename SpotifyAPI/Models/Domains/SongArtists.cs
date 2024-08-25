using System.ComponentModel.DataAnnotations;

namespace SpotifyAPI.Models.Domains
{
    public class SongArtists
    {
        [Key]
        public int Id {  get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; } // Навигационное свойство для песни

        public int ArtistId { get; set; }
        public Artist Artist { get; set; } // Навигационное свойство для исполнителя
    }
}
