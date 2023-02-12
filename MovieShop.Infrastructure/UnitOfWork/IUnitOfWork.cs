
using Microsoft.EntityFrameworkCore.Storage;

namespace MovieShop.Infrastructure
{
    public interface IUnitOfWork
    {
        Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
        Task CommitTransaction(CancellationToken cancellationToken = default);
        Task RollBackTransaction(CancellationToken cancellationToken = default);
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
