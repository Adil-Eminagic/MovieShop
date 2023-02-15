
using MovieShop.Application.Interfaces;
using MovieShop.Core;

namespace MovieShop.Api.Controllers
{
    public class MoviesController : BaseCrudController<MovieDto, MovieUpsertDto, IMoviesService>
    {
        public MoviesController(IMoviesService service) : base(service)
        {

        }
    }
}
