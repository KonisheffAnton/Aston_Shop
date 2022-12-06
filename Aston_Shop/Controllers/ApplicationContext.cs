using Aston_Shop.Models;
using Microsoft.EntityFrameworkCore;

namespace Aston_Shop.Controllers
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Item> Items { get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Aston_shop;Username=postgres;Password=1234");
        }
    }
}
