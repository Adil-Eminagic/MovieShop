
namespace MovieShop.Core
{
    public class MovieBuyUpsertDto : BaseUpsertDto
    {
        public int CustomerID { get; set; }

        public int MovieId { get; set; }

        public DateTime DateTime { get; set; }
    }
}
