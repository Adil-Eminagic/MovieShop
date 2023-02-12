
using Microsoft.EntityFrameworkCore;
using MovieShop.Core;

namespace MovieShop.Infrastructure
{
    public partial class DatabaseContext
    {
        public override int SaveChanges()
        {
            ModifyTimeStamps();

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ModifyTimeStamps();

            return base.SaveChangesAsync(cancellationToken);
        }

        private void ModifyTimeStamps()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                var entity = (BaseEntity)entry.Entity;
                if (entry.State == EntityState.Modified) entity.ModifiedAt = DateTime.UtcNow;
                else if (entry.State == EntityState.Added) entity.CreatedAt = DateTime.UtcNow;
            }
        }

        private void ApplyConfigurations(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(BaseConfiguration<>).Assembly);
        }
    
}
}
