using ImdbAPI.Data;
using ImdbAPI.Models;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbAPI.Services
{
    public class RatingsService : IRatingsService
    {
        private readonly AppDbContext _context;
        public RatingsService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> PostRating(int rating, int mediaId)
        {
            var mappedRating = new Rating
            {
                StarRating = rating,
                MediaId = mediaId
            };
            _context.Ratings.Add(mappedRating);

            double count = _context.Ratings.Where(x => x.MediaId == mediaId).Count();
            double sum = _context.Ratings.Where(x => x.MediaId == mediaId).Sum(x => x.StarRating);
            double avgRating = (sum + rating) / (count + 1);

            var media = _context.Medias.Where(x => x.Id == mediaId).FirstOrDefault();

            if (media == null)
            {
                return false;
            }
           
            media.AverageRating = avgRating;

            await _context.SaveChangesAsync();

            return true;
        }
    }
}
