using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public static readonly IList<LoginRequest> Account = new List<LoginRequest>()
        {
            new LoginRequest()
            {
                Username = "user@eomenersol.com",
                Password = "Test@123"
            }
        };

        [HttpPost("Login")]
            public IResult Post()
            {
                return TypedResults.Ok(Account);
            }

     }
}