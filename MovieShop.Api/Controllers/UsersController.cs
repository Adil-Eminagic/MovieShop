
using MovieShop.Application.Interfaces;
using MovieShop.Core;

namespace MovieShop.Api.Controllers
{
   
    public class UsersController : BaseCrudController<UserDto, UserUpsertDto, IUsersService>
    {
        public UsersController(IUsersService service):base(service) 
        {

        }
    }
}
