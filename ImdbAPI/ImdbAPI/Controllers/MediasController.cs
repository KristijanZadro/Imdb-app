using ImdbAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ImdbAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediasController : ControllerBase
    {
        private readonly IMediasService _mediasService;
        public MediasController(IMediasService mediasService)
        {
            _mediasService = mediasService;
        }
        // GET: api/Medias
        [HttpGet]
        public async Task<ActionResult> GetMedias([FromQuery] string search, [FromQuery] int num, [FromQuery] string mediaType)
        {
            var response = await _mediasService.GetMedias(search, num, mediaType);
            if(response == null)
            {
                return BadRequest();
            }
            return Ok(response);
        }
    }
}
