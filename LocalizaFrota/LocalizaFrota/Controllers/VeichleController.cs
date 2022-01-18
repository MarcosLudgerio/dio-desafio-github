using Microsoft.AspNetCore.Mvc;

namespace LocalizaFrota.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeichleController : ControllerBase
    {
        private readonly VeiclherRepository veiclherRepository;
        private readonly VeihcleDetran veihcleDetran;

        public VeiculosController(IVeiculoRepository repository, IVeiculoDetran veiculoDetran)
        {
            this.repository = repository;
            this.veiculoDetran = veiculoDetran;
        }
        // GET: api/<VeiculosController>
        [HttpGet]
        public IActionResult Get() => Ok(repository.GetAll());

        // GET api/<VeiculosController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var veiculo = repository.GetById(id);
            if (veiculo == null)
                return NotFound();
            return Ok(veiculo);
        }

        // POST api/<VeiculosController>
        [HttpPost]
        public IActionResult Post([FromBody] Veiculo veiculo)
        {
            repository.Add(veiculo);
            return CreatedAtAction(nameof(Get), new { id = veiculo.Id }, veiculo);
        }

        // PUT api/<VeiculosController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Veiculo veiculo)
        {
            repository.Update(veiculo);

            return NoContent();
        }

        // PUT api/<VeiculosController>/5
        [HttpPut("{id}/vistoria")]
        public IActionResult Put(Guid id)
        {
            veiculoDetran.AgendarVistoriaDetran(id);

            return NoContent();
        }

        // DELETE api/<VeiculosController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var veiculo = repository.GetById(id);
            if (veiculo == null)
                return NotFound();

            repository.Delete(veiculo);

            return NoContent();
        }
    }
}