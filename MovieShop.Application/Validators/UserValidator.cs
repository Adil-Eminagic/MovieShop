
using FluentValidation;
using MovieShop.Core;

namespace MovieShop.Application
{
    public class UserValidator : AbstractValidator<UserUpsertDto>
    {
        public UserValidator()
        {
            RuleFor(d => d.FirstName).NotNull().NotEmpty();
            RuleFor(d=>d.LastName).NotNull().NotEmpty();
            RuleFor(d => d.Email).NotNull().NotEmpty();
            RuleFor(d => d.PhoneNumber).NotNull().NotEmpty();
            RuleFor(d => d.Role).NotNull();
            RuleFor(d=>d.Password).NotNull().NotEmpty()
                .MinimumLength(8)
                .Matches(@"[A-Z]+")
                .Matches(@"[a-z]+")
                .Matches(@"[a-z]+")
                .When(d => d.Id == null || d.Password != null);
        }
    }
}
