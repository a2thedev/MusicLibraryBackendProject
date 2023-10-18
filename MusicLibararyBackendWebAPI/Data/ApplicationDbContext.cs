using Microsoft.EntityFrameworkCore;
using MusicLibararyBackendWebAPI.Models;

namespace MusicLibararyBackendWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
        
        }
    }
}
