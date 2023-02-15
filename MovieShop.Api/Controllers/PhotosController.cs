
using MovieShop.Application.Interfaces;
using MovieShop.Core;

namespace MovieShop.Api.Controllers
{
    public class PhotosController : BaseCrudController<PhotoDto, PhotoUpsertDto, IPhotosService>
    {
        public PhotosController(IPhotosService service) : base(service)
        {

        }
    }
}
