using DadJokesWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DadJokesWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Joke> Jokes { get; set; }
    }
}
