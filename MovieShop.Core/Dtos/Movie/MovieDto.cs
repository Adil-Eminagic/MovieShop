
namespace MovieShop.Core
{
    public class MovieDto : BaseDto
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Genre Genre { get; set; }
        public DateTime DatePublished { get; set; }
        public float Price { get; set; }
    }
}
