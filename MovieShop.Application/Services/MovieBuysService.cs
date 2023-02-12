
using AutoMapper;
using FluentValidation;
using MovieShop.Application.Interfaces;
using MovieShop.Core;
using MovieShop.Infrastructure;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Application
{
    public class MovieBuysService : BaseService<MovieBuy, MovieBuyDto, MovieBuyUpsertDto, IMovieBuysRepository>, IMovieBuysService
    {
        public MovieBuysService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<MovieBuyUpsertDto> validator) :base(mapper,unitOfWork, validator)
        {

        }
    }
}
