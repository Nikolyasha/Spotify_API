using System.ComponentModel.DataAnnotations;

namespace SpotifyAPI.Models.Domains
{
    public class ReleaseArtists
    {
        [Key]
        public int Id { get; set; }
        public int ReleaseId { get; set; }
        public int ArtistId { get; set; }
    }
}
