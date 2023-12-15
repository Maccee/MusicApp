using System.Collections.Generic;
using MusicApp.Models;

namespace MusicApp.Repositories.Interfaces
{
    public interface IArtistRepository
    {
        Task<List<Artist>> GetAllArtistsAsync();
        Task<Artist> GetArtistByIdAsync(int id); // import the Artist model
        Task<Artist> CreateArtistAsync(Artist artist);
        Task<Artist> UpdateArtistAsync(Artist artist);
        Task<bool> DeleteArtistAsync(int id);
    }
}
