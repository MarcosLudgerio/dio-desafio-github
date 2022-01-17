using Microsoft.AspNetCore.Mvc;

namespace LocalizaFrota.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SingletonController : ControllerBase
    {
        [HttpGet()]
        public IActionResult Get()
        {
            var singleton = Singleton.Instance;
            return Ok(singleton);
        }
    }
}