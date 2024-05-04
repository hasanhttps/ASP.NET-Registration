using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Registration.DataAccsess.Configurations;
using Registration.DataAccsess.Entities.Concretes;

namespace Registration.DataAccsess.Contexts;

public class RegistrationDbContext : DbContext {

    // Functions

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

        var connectionStr = new ConfigurationBuilder().AddJsonFile("databasesettings.json").Build().GetConnectionString("Sql");
        optionsBuilder.UseLazyLoadingProxies(true).UseSqlServer(connectionStr);

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

        modelBuilder.ApplyConfiguration(new UserConfiguration());
        base.OnModelCreating(modelBuilder); 
    }

    // Tables

    public virtual DbSet<User> Users { get; set; }
}