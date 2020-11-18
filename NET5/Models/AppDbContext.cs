using Microsoft.EntityFrameworkCore;
using NET5.Models.Entities;

namespace NET5.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Function> Functions { get; set; }
        public DbSet<Page> Pages { get; set; }

    }
}
