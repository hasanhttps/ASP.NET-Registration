using Microsoft.EntityFrameworkCore;

namespace Registration.Database.Contexts;

public class RegistrationDbContext : DbContext {

    // Functions

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        

    }
}