
using AutoMapper;
using FluentValidation;
using MovieShop.Application.Interfaces;
using MovieShop.Core;
using MovieShop.Infrastructure;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Application
{
    public class MoviesService : BaseService<Movie, MovieDto, MovieUpsertDto, IMoviesRepository>, IMoviesService
    {
        public MoviesService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<MovieUpsertDto> validator) :base(mapper,unitOfWork, validator)
        {

        }
    }
}
