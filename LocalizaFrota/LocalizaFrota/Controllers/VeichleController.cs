using Microsoft.AspNetCore.Mvc;

namespace LocalizaFrota.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeichleController : ControllerBase
    {
        private readonly VeiclherRepository veiclherRepository;
        public VeichleController(VeiclherRepository veiclherRepository)
        {
            this.veiclherRepository = veiclherRepository;
        }

        [HttpGet]
        public IActionResult Get() => Ok(veiclherRepository.getAll());

        [HttpGet("(id)")]
        public IActionResult Get(Guild id)
        {
            var veichle = veiclherRepository.GetById(id);
            if (veichle == null) return NotFound();
            return Ok(veichle);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Veihcle veihcle)
        {
            veiclherRepository.Add(id);
            return CreatedAtAction(nanmeof(Get), new { id = veihcle.id }, veihcle);

        }

        [HttpPut("(id)")]
        public IActionResult Put(Guild id, [FromBody] Veihcle veihcle)
        {
            veiclherRepository.Update(veihcle);
            return NoContent();

        }

        [HttpGet("(id)")]
        public IActionResult Delete(Guild id)
        {
            veiclherRepository.Delete(id);
            return NoContent();

        }

    }
}