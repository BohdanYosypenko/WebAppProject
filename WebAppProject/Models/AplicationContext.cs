using Microsoft.EntityFrameworkCore;

namespace WebAppProject.Models
{
    public class AplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions { get; set; }
        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        { 
        
        }
    }
}
