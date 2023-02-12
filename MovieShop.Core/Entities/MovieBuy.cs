
namespace MovieShop.Core
{
    public class MovieBuy : BaseEntity
    {
        public int CustomerID { get; set; }
        public User Customer { get; set; } = null!;//you can name foreign key set diffrent then entity name

        public int MovieId { get; set; }
        public Movie Movie { get; set; } = null!;

        public DateTime DateTime { get; set; }
    }
}
