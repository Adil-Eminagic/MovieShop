
using MovieShop.Core;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Infrastructure
{
    public class MoviesRepository : BaseRepository<Movie, int>, IMoviesRepository
    {
        public MoviesRepository(DatabaseContext databaseContext) : base(databaseContext) { }

    }
}
