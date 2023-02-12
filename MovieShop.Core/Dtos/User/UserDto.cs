
namespace MovieShop.Core
{
    public class UserDto : BaseDto
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public Role Role { get; set; }
        public string? Profession { get; set; }

        public int? ProfilePhotoId { get; set; }
        public Photo? ProfilePhoto { get; set; } = null!;
    }
}
