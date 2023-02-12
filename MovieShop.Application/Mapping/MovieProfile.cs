using MovieShop.Core;

namespace MovieShop.Application
{
    public class MovieProfile : BaseProfile
    {
        public MovieProfile()
        {
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<Movie, MovieUpsertDto>();
        }
    }
}
