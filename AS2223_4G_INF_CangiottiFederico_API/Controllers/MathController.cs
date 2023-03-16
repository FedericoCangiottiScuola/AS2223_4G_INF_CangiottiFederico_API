using Microsoft.AspNetCore.Mvc;
using static AS2223_4G_INF_CangiottiFederico_API.Math;

namespace AS2223_4G_INF_CangiottiFederico_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/")]
    public class MathController : Controller
    {
        [HttpGet("PariDispari")]
        public JsonResult PariDispari(int input)
        {
            Result outcome = new(Status.OK);
            
            return Json(new
            {
                result = input%2==0 ? "pari" : "dispari",
                outcome,
            });
        }

        [HttpGet("Fattoriale")]
        public JsonResult Fattoriale(int input)
        {
            Result outcome;

            if (input <= 0)
            {
                outcome = new(Status.ERROR, "Wrong input value");
                return Json(new
                {
                    result = 0,
                    outcome,
                });
            }

            outcome = new(Status.OK);

            int fattoriale = 1;
            for (int i = 1; i <= input; i++)
            {
                fattoriale *= i;
            }

            return Json(new
            {
                result = fattoriale,
                outcome,
            });
        }
    }
}
