
using MovieShop.Core;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Infrastructure
{
    public class PhotosRepository : BaseRepository<Photo, int>, IPhotosRepository
    {
        public PhotosRepository(DatabaseContext databaseContext) : base(databaseContext) { }

    }
}
