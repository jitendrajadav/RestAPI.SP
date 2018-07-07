using Microsoft.EntityFrameworkCore;

namespace LocalDatabase
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlite("Data Source=RestLocalDB.sqlite");
        }
    }

}
