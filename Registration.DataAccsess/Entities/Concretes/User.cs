using Registration.DataAccsess.Entities.Abstracts;

namespace Registration.DataAccsess.Entities.Concretes {
    public class User : Person {

        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}