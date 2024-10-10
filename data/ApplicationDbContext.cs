

using Microsoft.EntityFrameworkCore;

namespace Product_manager.data;
public class ApplicationDbContext : DbContext
{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

}
