using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImdbAPI.Services;

namespace ImdbAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingsService _ratingsService;

        public RatingsController(IRatingsService ratingsService)
        {
            _ratingsService = ratingsService;
        }

        // POST: api/Ratings
        [HttpPost]
        public async Task<ActionResult> PostRating([FromQuery] int rating, [FromQuery] int mediaId)
        {
            var response = await _ratingsService.PostRating(rating, mediaId);
            if (!response)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
