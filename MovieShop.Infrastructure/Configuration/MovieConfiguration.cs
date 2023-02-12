
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShop.Core;

namespace MovieShop.Infrastructure
{
    public class MovieConfiguration : BaseConfiguration<Movie>
    {
        public override void Configure(EntityTypeBuilder<Movie> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Genre).IsRequired();
            builder.Property(x => x.DatePublished).IsRequired();
            builder.Property(x => x.Price).IsRequired();
           
        }
    }
}
