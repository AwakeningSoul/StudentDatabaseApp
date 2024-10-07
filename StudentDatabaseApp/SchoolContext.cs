using Microsoft.EntityFrameworkCore;

namespace StudentDatabaseApp
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Adjust the connection string as needed
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentDB;Trusted_Connection=True;");
        }
    }
}

