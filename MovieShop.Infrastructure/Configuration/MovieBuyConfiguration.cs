
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShop.Core;

namespace MovieShop.Infrastructure
{
    public class MovieBuyConfiguration : BaseConfiguration<MovieBuy>
    {
        public override void Configure(EntityTypeBuilder<MovieBuy> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.DateTime).IsRequired();
           

            builder.HasOne(x => x.Customer).
                WithMany(r => r.Movies).
                HasForeignKey(x => x.CustomerID).
                IsRequired();


            builder.HasOne(x => x.Movie).
                WithMany(r => r.Customers).
                HasForeignKey(x => x.MovieId).
                IsRequired();
        }
    }
}
