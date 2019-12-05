using System.Threading.Tasks;
using BilheteriaCinema.Application.Application;
using Microsoft.AspNetCore.Mvc;

namespace BilheteriaCinema.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeApplication _filmeApplication;

        public FilmeController(IFilmeApplication filmeApplication)
        {
            _filmeApplication = filmeApplication;
        }

        // GET: api/Filme
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var filmes = await _filmeApplication.BuscarFilmes();

            return Ok(filmes);
        }

        // GET: api/Filme/{codigo}
        [HttpGet("{codigo}")]
        public async Task<IActionResult> Get(int codigo)
        {
            var filme = await _filmeApplication.BuscarFilme(codigo);

            return Ok(filme);
        }
    }
}
