using System.Threading.Tasks;
using BilheteriaCinema.Application.Application;
using BilheteriaCinema.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BilheteriaCinema.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        private readonly ISalaApplication _salaApplication;

        public SalaController(ISalaApplication salaApplication)
        {
            _salaApplication = salaApplication;
        }

        // GET: api/Sala
        [HttpGet]
        public async Task<IActionResult> Get(bool? disponivel, int? min, int? max)
        {
            var salas = await _salaApplication.BuscarSalas(disponivel, min, max);

            return Ok(salas);
        }

        // GET: api/Sala/{codigo}
        [HttpGet("{codigo}")]
        public async Task<IActionResult> Get(int codigo)
        {
            var sala = await _salaApplication.BuscarSala(codigo);

            return Ok(sala);
        }

        // POST: api/Sala
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] SalaDTO sala)
        {
            sala = await _salaApplication.CadastrarSala(sala);

            return Ok(sala);
        }
    }
}
