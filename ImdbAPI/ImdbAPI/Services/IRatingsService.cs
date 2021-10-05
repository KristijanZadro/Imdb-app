using System.Threading.Tasks;

namespace ImdbAPI.Services
{
    public interface IRatingsService
    {
        Task<bool> PostRating(int rating, int mediaId);
    }
}
