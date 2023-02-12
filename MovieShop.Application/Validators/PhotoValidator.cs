
using FluentValidation;
using MovieShop.Core;

namespace MovieShop.Application
{
    public class PhotoValidator : AbstractValidator<PhotoUpsertDto>
    {
        public PhotoValidator()
        {
            RuleFor(d => d.Data).NotNull();
            RuleFor(d=>d.ContentType).NotNull().NotEmpty();
        }
    }
}
