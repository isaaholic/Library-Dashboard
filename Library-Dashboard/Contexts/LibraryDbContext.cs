using Library_Dashboard.Configurations;
using Library_Dashboard.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Library_Dashboard.Contexts;

public class LibraryDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SCardsConfigurations());
        modelBuilder.ApplyConfiguration(new TCardsConfigurations());
        modelBuilder.ApplyConfiguration(new StudentsConfigurations());
        modelBuilder.ApplyConfiguration(new TeachersConfigurations());
        modelBuilder.ApplyConfiguration(new BooksConfigurations());
        modelBuilder.ApplyConfiguration(new GroupsConfigurations());

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfigurationRoot? configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory() + "../../../../")
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
        string connectionString = configuration.GetConnectionString("DefaultDb");
        optionsBuilder.UseSqlServer(connectionString);
        base.OnConfiguring(optionsBuilder);
    }


    public DbSet<Author> Authors { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<Categories> Categories { get; set; }
    public DbSet<Departments> Departments { get; set; }
    public DbSet<Faculties> Faculties { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Libs> Libs { get; set; }
    public DbSet<Press> Press { get; set; }
    public DbSet<S_Cards> S_Cards { get; set; }
    public DbSet<Students> Students { get; set; }
    public DbSet<T_Cards> T_Cards { get; set; }
    public DbSet<Teachers> Teachers { get; set; }
    public DbSet<Themes> Themes { get; set; }
}
