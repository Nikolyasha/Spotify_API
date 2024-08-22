using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotifyAPI.Data;
using SpotifyAPI.Models.Domains;

namespace SpotifyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly AppDbContext _context;
        public ArtistController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Artist>>> GetAllArtists()
        {
            var artists = await _context.Artists.ToListAsync();
            return Ok(artists);
        }
        [HttpGet("{id}")]
        public async Task <ActionResult<List<Artist>>> GetArtistsById(int id)
        {
            var artist = await _context.Artists.FindAsync(id);
            return Ok(artist);
        }
    }
}
