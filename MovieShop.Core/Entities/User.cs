

namespace MovieShop.Core
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;
        public Role Role { get; set; }
        public string? Profession { get; set; }

        public int? ProfilePhotoId { get; set; }
        public Photo? ProfilePhoto { get; set; } = null!;

        public ICollection<MovieBuy>? Movies { get; set; }
        // is it ok zo be nullable, beacuse administrator cann't buy movies so he won't have them
    }
}
