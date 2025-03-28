using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class EnergyDBContext : DbContext
    {
        public EnergyDBContext(DbContextOptions<EnergyDBContext> options) : base(options)
        {
        }
        public DbSet<System> Systems { get; set; }
        public DbSet<WaterConsum> WaterConsums { get; set; }
        public DbSet<EnergyIndicator> EnergyIndicators { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<System>().ToTable("System");
            modelBuilder.Entity<WaterConsum>().ToTable("WaterConsum");
            modelBuilder.Entity<EnergyIndicator>().ToTable("EnergyIndicator");
        }
    }
}
