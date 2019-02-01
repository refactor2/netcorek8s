using Microsoft.AspNetCore.Mvc;

namespace netcorek8s.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HealthController : Controller
    {
        private static int requestCount = 0;
        
        [HttpGet]
        public ActionResult<string> Get()
        {
            requestCount++;
            if (requestCount>3)
            {
                return new BadRequestResult();
            }
            return "hello world";
        }
    }
}