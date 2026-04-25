using Microsoft.EntityFrameworkCore;

namespace HobbyHub.Models
{
    public class HobbyContext : DbContext
    {
        public HobbyContext(DbContextOptions<HobbyContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}