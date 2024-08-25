using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SpotifyAPI.Models.Domains;

namespace SpotifyAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)  
        {
        }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Release> Releases { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongArtists> SongsArtists { get; set; }
        public DbSet<ReleaseArtists> ReleasesArtists { get; set; }

    }
}
