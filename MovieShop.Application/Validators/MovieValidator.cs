
using FluentValidation;
using MovieShop.Core;

namespace MovieShop.Application
{
    public class MovieValidator : AbstractValidator<MovieUpsertDto>
    {
        public MovieValidator()
        {        
            RuleFor(d=>d.Name).NotNull().NotEmpty();
            RuleFor(d => d.Description).NotNull().NotEmpty();
            RuleFor(d => d.Genre).NotNull();
            RuleFor(d=>d.DatePublished).NotNull();
            RuleFor(d => d.Price).NotNull();
        }
    }
}
