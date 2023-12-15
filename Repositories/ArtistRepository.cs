using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicApp.Data;
using MusicApp.Models;
using MusicApp.Repositories.Interfaces;

namespace MusicApp.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        private readonly AppDbContext _context;

        public ArtistRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Artist>> GetAllArtistsAsync()
        {
            return await _context.Artists.ToListAsync();
        }

        public async Task<Artist> GetArtistByIdAsync(int id)
        {
            return await _context.Artists.FindAsync(id);
        }

        public async Task<Artist> CreateArtistAsync(Artist artist)
        {
            _context.Artists.Add(artist);
            await _context.SaveChangesAsync();
            return artist;
        }

        public async Task<Artist> UpdateArtistAsync(Artist artist)
        {
            _context.Artists.Update(artist);
            await _context.SaveChangesAsync();
            return artist;
        }

        public async Task<bool> DeleteArtistAsync(int id)
        {
            var artist = await GetArtistByIdAsync(id);
            _context.Artists.Remove(artist);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
