
using MovieShop.Application.Interfaces;
using MovieShop.Core;

namespace MovieShop.Api.Controllers
{
    public class MovieBuysController : BaseCrudController<MovieBuyDto, MovieBuyUpsertDto, IMovieBuysService>
    {
        public MovieBuysController(IMovieBuysService service) : base(service)
        {

        }
    }
}
