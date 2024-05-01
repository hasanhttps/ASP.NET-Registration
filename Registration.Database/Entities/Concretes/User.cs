using Registration.Database.Entities.Abstracts;

namespace Registration.Database.Entities.Concretes;

public class User : Person {

    public string? Email { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}