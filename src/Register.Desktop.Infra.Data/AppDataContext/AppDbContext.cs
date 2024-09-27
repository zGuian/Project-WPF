using Microsoft.EntityFrameworkCore;
using Register.Desktop.Domain.Entities;
using Register.Desktop.Infra.Data.MapDataBase;

namespace Register.Desktop.Infra.Data.AppDataContext
{
    public class AppDbContext(DbContextOptions<AppDbContext> opts) : DbContext(opts)
    {
        public DbSet<Equipment> Equipments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MapEquipment());
        }
    }
}