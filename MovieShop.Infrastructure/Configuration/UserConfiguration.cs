
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieShop.Core;

namespace MovieShop.Infrastructure
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.PhoneNumber).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.PasswordHash).IsRequired();
            builder.Property(x => x.PasswordSalt).IsRequired();
            builder.Property(x => x.Role).IsRequired();
            builder.Property(x => x.Profession).IsRequired(false);


            builder.HasOne(x => x.ProfilePhoto).
                WithMany(r => r.Users).
                HasForeignKey(x => x.ProfilePhotoId).
                IsRequired(false);
        }
    }
}
