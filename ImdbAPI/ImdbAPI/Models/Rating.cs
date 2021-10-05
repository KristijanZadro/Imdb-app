using ImdbAPI.Models.Base;

namespace ImdbAPI.Models
{
    public class Rating : BaseEntity
    {
        public int StarRating { get; set; }
        public int MediaId { get; set; }
        public Media Media { get; set; }
    }
}
