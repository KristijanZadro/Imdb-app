using ImdbAPI.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImdbAPI.Services
{
    public interface IMediasService
    {
        Task<IEnumerable<MediasResponse>> GetMedias(string search, int num, string mediaType);
    }
}
