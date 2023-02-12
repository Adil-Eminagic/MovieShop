
using AutoMapper;
using FluentValidation;
using MovieShop.Application.Interfaces;
using MovieShop.Core;
using MovieShop.Infrastructure;
using MovieShop.Infrastructure.Interfaces;

namespace MovieShop.Application
{
    public class PhotosService : BaseService<Photo, PhotoDto, PhotoUpsertDto, IPhotosRepository>, IPhotosService
    {
        public PhotosService(IMapper mapper, IUnitOfWork unitOfWork, IValidator<PhotoUpsertDto> validator) :base(mapper,unitOfWork, validator)
        {

        }
    }
}
