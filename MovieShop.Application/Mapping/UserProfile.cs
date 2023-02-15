using MovieShop.Core;

namespace MovieShop.Application
{
    public class UserProfile : BaseProfile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<UserUpsertDto,User>();
        }
    }
}
