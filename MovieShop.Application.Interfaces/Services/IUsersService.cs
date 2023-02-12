
using MovieShop.Core;

namespace MovieShop.Application.Interfaces
{
    public interface IUsersService : IBaseService<int, UserDto, UserUpsertDto>
    {
        
    }
}
