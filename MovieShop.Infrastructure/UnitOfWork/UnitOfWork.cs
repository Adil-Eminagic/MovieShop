
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _dbContext;

        public readonly IUsersRepository UserRepository;
        public readonly IMoviesRepository MoviesRepository;
        public readonly IMovieBuysRepository MoviesBuysRepository;
        public readonly IPhotosRepository MoviesPhotoRepository;

        public UnitOfWork(DatabaseContext databaseContext, IUsersRepository userRepository, IMoviesRepository moviesRepository, IMovieBuysRepository moviesBuysRepository, IPhotosRepository moviesPhotoRepository)
        {
            _dbContext = databaseContext;
            UserRepository = userRepository;
            MoviesRepository = moviesRepository;
            MoviesBuysRepository = moviesBuysRepository;
            MoviesPhotoRepository = moviesPhotoRepository;
        }


        public Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return _dbContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitTransaction(CancellationToken cancellationToken = default)
        {
            await _dbContext.Database.CommitTransactionAsync(cancellationToken);
        }

        public async Task RollBackTransaction(CancellationToken cancellationToken = default)
        {
            await _dbContext.Database.RollbackTransactionAsync(cancellationToken);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
