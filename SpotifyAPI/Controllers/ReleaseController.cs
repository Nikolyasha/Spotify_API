using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpotifyAPI.Data;
using SpotifyAPI.Migrations;
using SpotifyAPI.Models.Domains;

namespace SpotifyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReleaseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ReleaseController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("artist/{id}")]
        public async Task<ActionResult<List<Release>>> GetArtistReleases( int id) 
        {
            var releases = await _context.Releases
                .Where(release => release.ArtistId == id)
                .ToListAsync();

            return Ok(releases);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Release>>> GetReleaseById(int id)
        {
            var releases = await _context.Releases
                .Where(release => release.Id == id)
                .ToListAsync();

            return Ok(releases);
        }

    }
}
