using Microsoft.EntityFrameworkCore;
namespace GameLibrary.Data
{
   public class Context : DbContext
    {
        public DbSet<Library> Libraries { get; set; }

        public Context()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB.;Database=GameLibrary; Integrated Security=True");
        }
    }
}
