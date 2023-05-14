using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashboardController : ControllerBase
    {
        public static readonly IList<DashboardDto> Dashboard = new List<DashboardDto>()
        {
             new DashboardDto ()
             {

             }

        };

        [HttpGet("Dashboard")]
        public IResult Get()
        {
            return TypedResults.Ok(Dashboard);
        }

    };
}