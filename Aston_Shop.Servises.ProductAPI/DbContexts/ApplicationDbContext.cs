using Aston_Shop.Servises.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Aston_Shop.Servises.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
           
        }
        public DbSet<Product> Product { get; set; }
    }
}
