
using MovieShop.Core;

namespace MovieShop.Application.Interfaces
{
    public interface IMoviesService : IBaseService<int, MovieDto, MovieUpsertDto>
    {
        
    }
}
