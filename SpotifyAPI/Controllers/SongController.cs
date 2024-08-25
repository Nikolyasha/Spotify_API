using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotifyAPI.Data;
using SpotifyAPI.Models.Domains;
using SpotifyAPI.Models.DTO;

namespace SpotifyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SongController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<SongDTO>>> GetSongsByRelease(int id)
        {
            var songs = await _context.Songs
                .Where(song => song.ReleaseId == id)
                .Include(song => song.SongArtists)
                    .ThenInclude(sa => sa.Artist)
                .Select(song => new SongDTO
                {
                    Id = song.Id,
                    Title = song.Title,
                    Duration = song.Duration,
                    TrackNumber = song.TrackNumber,
                    Lyrics = song.Lyrics,
                    ReleaseId = song.ReleaseId,
                    Listeners = song.Listeners,
                    Artists = song.SongArtists.Select(sa => sa.Artist.ArtistName).ToList()
                })
                .ToListAsync();

            return Ok(songs);
        }
    }
}
