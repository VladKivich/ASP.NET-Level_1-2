using Microsoft.EntityFrameworkCore;
using WebAppLibrary;

namespace WebAppDBWork
{
    public class WebStoreContext: DbContext
    {
        public WebStoreContext(DbContextOptions Options):base(Options)
        {

        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Brand> Brands { get; set; }
    }
}
