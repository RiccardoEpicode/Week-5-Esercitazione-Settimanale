using MusicLibrary.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace MusicLibrary.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
