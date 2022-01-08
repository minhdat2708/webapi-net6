using Microsoft.EntityFrameworkCore;

namespace WebAPI_demo.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        } 
        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
