
using MovieShop.Core;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Infrastructure
{
    public class MovieBuysRepository : BaseRepository<MovieBuy, int>, IMovieBuysRepository
    {
        public MovieBuysRepository(DatabaseContext databaseContext) : base(databaseContext) { }

    }
}
