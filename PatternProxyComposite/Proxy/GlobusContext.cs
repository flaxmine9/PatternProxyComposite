using Microsoft.EntityFrameworkCore;

namespace PatternProxyComposite
{
    public class GlobusContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public GlobusContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
