using MovieShop.Core;

namespace MovieShop.Application
{
    public class MovieBuyProfile : BaseProfile
    {
        public MovieBuyProfile()
        {
            CreateMap<MovieBuy, MovieBuyDto>().ReverseMap();
            CreateMap<MovieBuy, MovieBuyUpsertDto>();
        }
    }
}
