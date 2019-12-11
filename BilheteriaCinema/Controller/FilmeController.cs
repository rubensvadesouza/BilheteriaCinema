using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Application.Application;
using BilheteriaCinema.Application.DTO;
using Microsoft.AspNetCore.Http;
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

        [HttpGet]
        [ProducesResponseType(typeof(List<FilmeDTO>),StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var filmes = await _filmeApplication.BuscarFilmes();

            return Ok(filmes);
        }

        // GET: api/Filme/{codigo}
        [HttpGet("{codigo}")]
        [ProducesResponseType(typeof(FilmeDTO),StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int codigo)
        {
            var filme = await _filmeApplication.BuscarFilme(codigo);

            return Ok(filme);
        }
    }
}
