using Microsoft.EntityFrameworkCore;

namespace TestP.Models
{
   public class CarDetailDbContext : DbContext
   {
      public CarDetailDbContext(DbContextOptions options) : base(options)
      {
      }
        public DbSet<CarsDetail> CarsDetails { get; set; }
    }
}
