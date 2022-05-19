using Microsoft.EntityFrameworkCore;

namespace WordAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options): base(options)
        {

        }
        public DbSet<User> Users { get; set; } 
        public DbSet<Has> Hass { get; set; }   

    }
}
 