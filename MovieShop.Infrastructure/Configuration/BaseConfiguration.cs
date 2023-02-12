
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShop.Core;

namespace MovieShop.Infrastructure
{
    public abstract class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CreatedAt)
                .IsRequired();

            builder.Property(x => x.ModifiedAt).IsRequired(false);

            builder.Property(x => x.IsDeleted)
                .IsRequired()
                .HasDefaultValue(false);

            builder.HasQueryFilter(x => !x.IsDeleted);// explore
        }
    }
}
