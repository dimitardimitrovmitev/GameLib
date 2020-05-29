using Microsoft.EntityFrameworkCore;
namespace GameLibrary.Data
{
    //The main Context class
    public class Context : DbContext
    {
        //Creates DataBase
        /// <summary>Gets or sets the libraries.</summary>
        /// <value>The libraries.</value>
        public DbSet<Library> Libraries { get; set; }
        //Ensure database Created
        public Context()
        {
            Database.EnsureCreated();
        }
        //Configuration Options
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB.;Database=GameLibrary; Integrated Security=True");
        }
    }
}
