
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShop.Core;

namespace MovieShop.Infrastructure
{
    public class PhotoConfiguration : BaseConfiguration<Photo>
    {
        public override void Configure(EntityTypeBuilder<Photo> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Data).IsRequired();
            builder.Property(x => x.ContentType).IsRequired();
            
        }
    }
}
