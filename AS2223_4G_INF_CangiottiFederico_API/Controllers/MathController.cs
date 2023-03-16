using Microsoft.AspNetCore.Mvc;
using static AS2223_4G_INF_CangiottiFederico_API.Math;

namespace AS2223_4G_INF_CangiottiFederico_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/")]
    public class MathController : Controller
    {
        [HttpGet("GetAddition")]
        public JsonResult PariDispari(int input)
        {
            Result outcome = new(Status.OK);
            
            return Json(new
            {
                result = input%2==0 ? "pari" : "dispari",
                outcome,
            });
        }
    }
}
