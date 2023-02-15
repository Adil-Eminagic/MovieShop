using MovieShop.Core;

namespace MovieShop.Application
{
    public class PhotoProfile : BaseProfile
    {
        public PhotoProfile()
        {
            CreateMap<Photo, PhotoDto>().ReverseMap();
            CreateMap<PhotoUpsertDto,Photo >();
        }
    }
}
