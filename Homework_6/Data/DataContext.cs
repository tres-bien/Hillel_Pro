using Microsoft.EntityFrameworkCore;

namespace Homework_6.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=peopledb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Person> Person { get; set; }
    }
}
