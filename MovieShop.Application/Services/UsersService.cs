
using AutoMapper;
using FluentValidation;
using MovieShop.Application.Interfaces;
using MovieShop.Core;
using MovieShop.Infrastructure;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Application
{
    public class UsersService : BaseService<User, UserDto, UserUpsertDto, IUsersRepository>, IUsersService
    {
        public UsersService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<UserUpsertDto> validator) :base(mapper,unitOfWork, validator)
        {

        }
    }
}
