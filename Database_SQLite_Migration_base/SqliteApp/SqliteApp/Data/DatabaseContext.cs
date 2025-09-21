

using Microsoft.EntityFrameworkCore;
using SqliteApp.Models;

namespace SqliteApp.Data;

public class DatabaseContext : DbContext
{

    //1 model (.cs) ==> table (database)
    public DbSet<Person> Persons { get; set; }

    //2 database info : name, type, address
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite($"data source={AppContext.BaseDirectory}\\mydata.db");
    }

    //3 default values
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var defaultPerson = new List<Person>()
        {
            new Person(){Id=1,Fname="reza",Lname="asadi",Age=13},
            new Person(){Id=2,Fname="sara",Lname="sadegi",Age=15}
        };

        modelBuilder.Entity<Person>().HasData(defaultPerson);

    }

}
