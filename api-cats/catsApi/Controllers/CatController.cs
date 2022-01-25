using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace catsApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatController : ControllerBase
    {
        public static string URL_BASE = "";

        private readonly ILogger<CatController> _logger;
        private readonly IConfiguration Configuration;


        public CatController(ILogger logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }

        public IActionResult Get(bool image)
        {
            var random = new Random();
            var url = URL_BASE + random.Next(1, 10) + ".jpg";

            if (image)
            {
                using (var webClient = new WebClient())
                {
                    byte[] imagesByte = webClient.DownloadData(url);
                    return File(imagesByte, "images/jpg");
                }

            }
            else
            {
                return Ok(url);
            }
        }
    }
}
