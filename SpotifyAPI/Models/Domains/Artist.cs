using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpotifyAPI.Models.Domains
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string ArtistDescription { get; set; }
        public string ArtistPhoto {  get; set; }

        //public ICollection<Release> Releases { get; set; } = new List<Release>();
    }
}
