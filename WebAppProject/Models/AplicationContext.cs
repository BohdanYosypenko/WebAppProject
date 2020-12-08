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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User[]
                {
                    new User{ Id=1,Name="Ivan",Age=4},
                    new User{ Id=2,Name="Petro",Age=46},
                    new User{ Id=3,Name="Stepan",Age=21},
                    new User{ Id=4,Name="Oleh",Age=32},
                    new User{ Id=5,Name="Bohdan",Age=65},
                    new User{ Id=6,Name="Andriy",Age=16},
                    new User{ Id=7,Name="Kolya",Age=34},
                    new User{ Id=8,Name="Roman",Age=41},
                    new User{ Id=9,Name="Nazar",Age=31},
                });

            modelBuilder.Entity<Position>().HasData(
                new Position[]
                {
                    new Position{Id=1 , Location="Berlin"},
                    new Position{Id=2 , Location="Ivano-Frankivsk"},
                    new Position{Id=3 , Location="Lviv"},
                    new Position{Id=4 , Location="Doluna"},
                    new Position{Id=5 , Location="Paris"},
                    new Position{Id=6 , Location="Tokio"},
                    new Position{Id=7 , Location="New York"},
                    new Position{Id=8 , Location="Kiyv"}
                });

            modelBuilder.Entity<UserPosition>().HasData(
                new UserPosition[]
                {
                    new UserPosition{ Id=1, PositionId=1,UserId=1},
                    new UserPosition{ Id=2, PositionId=3,UserId=2},
                    new UserPosition{ Id=3, PositionId=2,UserId=5},
                    new UserPosition{ Id=4, PositionId=6,UserId=6},
                    new UserPosition{ Id=5, PositionId=1,UserId=4},
                });

        }
    }
}
