using System.ComponentModel.DataAnnotations;

namespace SpotifyAPI.Models.Domains
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string ArtistDescription { get; set; }
        public string ArtistPhoto {  get; set; }
    }
}
