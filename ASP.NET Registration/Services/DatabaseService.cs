using Registration.DataAccsess.Contexts;
using Registration.DataAccsess.Entities.Concretes;

namespace ASP.NET_Registration.Services;

public static class DatabaseService {

    // Fields

    private static RegistrationDbContext _context;
    public static List<User> Users { get; set; } = new();

    // Static Constructor

    static DatabaseService() {
        _context = new RegistrationDbContext();
        Users = _context.Users.ToList();
    }

    // Methods

    public async static Task AddUserAsync(User user) {
        await _context.AddAsync(user);
        await _context.SaveChangesAsync();
        Users.Add(user);
    }
}