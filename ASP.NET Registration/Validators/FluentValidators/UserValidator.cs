using FluentValidation;
using Registration.DataAccsess.Entities.Concretes;

namespace ASP.NET_Registration.Validators.FluentValidators {
    public class UserValidator : AbstractValidator<User> {

        public UserValidator() {
            RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name cant be empty")
            .Must(BeValidName).WithMessage("Name cant be have symbols")
            .MinimumLength(3).WithMessage("Name character length must be at least 3")
            .MaximumLength(20).WithMessage("Name character length must be at most 20");

            RuleFor(x => x.Surname)
            .NotEmpty().WithMessage("Surname cant be empty")
            .MinimumLength(3).WithMessage("Surname character length must be at least 3")
            .MaximumLength(30).WithMessage("Surname character length must be at most 30");

            RuleFor(p => p.Email)
            .NotEmpty().WithMessage("Email cant be empty")
            .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("Email format is wrong");

            RuleFor(x => x.Username)
            .NotEmpty().WithMessage("Username cant be empty")
            .MinimumLength(4).WithMessage("Username character length must be at least 3")
            .MaximumLength(64).WithMessage("Username character length must be at most 64");

            RuleFor(p => p.Password)
            .NotEmpty().WithMessage("Password cant be empty")
            .MinimumLength(8).WithMessage("Password can be at least 8 character")
            .MaximumLength(18).WithMessage("Password can be maximum 18 character")
            .Matches(@"[A-Z]+").WithMessage("In password there would be at least 1 big letter")
            .Matches(@"[a-z]+").WithMessage("In password there would be at least 1 little letter")
            .Matches(@"[0-9]+").WithMessage("In password there would be at least 1 digit");
        }

        private bool BeValidName(string name) {
            return name.All(Char.IsLetter);
        }
    }
}
