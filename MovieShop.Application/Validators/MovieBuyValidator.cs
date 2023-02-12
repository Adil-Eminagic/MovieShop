
using FluentValidation;
using MovieShop.Core;

namespace MovieShop.Application
{
    public class MovieBuyValidator : AbstractValidator<MovieBuyUpsertDto>
    {
        public MovieBuyValidator()
        {
            RuleFor(d => d.CustomerID).NotNull();
            RuleFor(d=>d.MovieId).NotNull();
            RuleFor(d => d.DateTime).NotNull();
        }
    }
}
