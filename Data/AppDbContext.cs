using Microsoft.EntityFrameworkCore;
using MusicApp.Models;

namespace MusicApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        // Create a DbSet for each model class
        public DbSet<Artist> Artists { get; set; } = null!;
    }
}
