
namespace MovieShop.Core
{
    public class MovieBuyDto : BaseDto
    {
        public int CustomerID { get; set; }
        public User Customer { get; set; } = null!;

        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;

        public DateTime DateTime { get; set; }
    }
}
