using FluentValidation;
using Registration.DataAccsess.Entities.Concretes;

namespace ASP.NET_Registration.Validators.FluentValidators {
    public class UserValidator : AbstractValidator<User> {

        public UserValidator() {
            RuleFor(x => x.Username)
            .NotEmpty().WithMessage("Name bos ola bilmez")
            .MinimumLength(3).WithMessage("Name minimum 3 simvol olmalidir")
            .MaximumLength(10).WithMessage("Name maximum 10 simvol olmalidir");

            RuleFor(x => x.Surname)
            .NotEmpty().WithMessage("Name bos ola bilmez")
            .MinimumLength(3).WithMessage("Name minimum 3 simvol olmalidir")
            .MaximumLength(10).WithMessage("Name maximum 10 simvol olmalidir");

            RuleFor(p => p.Email)
            .NotEmpty().WithMessage("Email bos ola bilmez")
            .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("Email duzgun formatda deyil");

            RuleFor(p => p.Password)
            .NotEmpty().WithMessage("Password bos ola bilmez")
            .MinimumLength(8).WithMessage("Password minimum 8 simvol olmalidir")
            .MaximumLength(18).WithMessage("Password maximum 18 simvol olmalidir")
            .Matches(@"[A-Z]+").WithMessage("Passwordda minimum bir boyuk herf olmalidir")
            .Matches(@"[a-z]+").WithMessage("Passwordda minimum bir kicik herf olmalidir")
            .Matches(@"[0-9]+").WithMessage("Passwordda minimum bir reqem olmalidir");

        }
    }
}
