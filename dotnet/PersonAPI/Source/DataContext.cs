using Microsoft.EntityFrameworkCore;

namespace PersonAPI.Source
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Person> People { get; set; }
    }
}
