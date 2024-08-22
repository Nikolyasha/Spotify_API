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

    }
}
