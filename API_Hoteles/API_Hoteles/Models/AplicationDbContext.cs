using Microsoft.EntityFrameworkCore;

namespace API_Hoteles.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
    }
}
