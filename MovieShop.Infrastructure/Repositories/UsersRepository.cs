
using MovieShop.Core;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Infrastructure
{
    public class UsersRepository : BaseRepository<User, int>, IUsersRepository
    {
        public UsersRepository(DatabaseContext databaseContext) : base(databaseContext) { }

    }
}
