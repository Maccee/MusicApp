using Microsoft.AspNetCore.Mvc;
using MusicApp.DTOs;
using MusicApp.Services.Interfaces;

namespace MusicApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistsController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArtistsAsync()
        {
            return Ok(await _artistService.GetAllArtistsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArtistByIdAsync(int id)
        {
            return Ok(await _artistService.GetArtistByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateArtistAsync([FromBody] ArtistRequest artistRequest)
        {
            return Ok(await _artistService.CreateArtistAsync(artistRequest));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArtistAsync(int id, [FromBody] ArtistRequest artistRequest)
        {
            return Ok(await _artistService.UpdateArtistAsync(id, artistRequest));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArtistAsync(int id)
        {
            return Ok(await _artistService.DeleteArtistAsync(id));
        }
    }
}
