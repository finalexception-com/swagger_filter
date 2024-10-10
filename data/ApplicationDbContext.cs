

using Microsoft.EntityFrameworkCore;
using Product_manager.models;
// using Product_manager.Seeders;

namespace Product_manager.data;
public class ApplicationDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    //     CategorySeeder.Seed(modelBuilder);
  
    // }

}
