using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformWellController : ControllerBase
    {
        public static readonly IList<GetPlatformWellActual> PlatformWell = new List<GetPlatformWellActual>()
        {
            new GetPlatformWellActual()
            {

            }

        };

        [HttpGet("GetPlatformWellActual")]

        public IResult Post(GetPlatformWellActual GetPlatformWellActual)
        {
            return TypedResults.Ok();
        }

        [HttpGet("GetPlatformWellDummy")]

        public IResult Post(GetPlatformWellDummy GetPlatformWellDummy)
        {
            return TypedResults.Ok();
        }
    }
}
