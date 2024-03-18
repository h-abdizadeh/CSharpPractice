using Microsoft.EntityFrameworkCore;
using WareHouse.Models;

namespace WareHouse.Context;

public class DatabaseContext : DbContext
{
    //model -> table 
    public DbSet<Group> Groups { get; set; }
    public DbSet<Product> Products { get; set; }

    //database config
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        //base.OnConfiguring(options);
        options.UseSqlite($"data source={Application.StartupPath}\\WareHouseApp.db");
    }


    //default values (seed)
    protected override void OnModelCreating(ModelBuilder builder)
    {
        //base.OnModelCreating(builder);
        var defaultGroup = new List<Group>()
        {
            new Group(){Id=1,Title="لوازم خانگی"},
            new Group(){Id=2,Title="محصولات بهداشتی"},
            new Group(){Id=3,Title="مواد خوراکی"}
        };

        builder.Entity<Group>().HasData(defaultGroup);
    }
}
