using System;
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
    public class SessaoController : ControllerBase
    {
        private readonly ISessaoApplication _sessaoApplication;

        public SessaoController(ISessaoApplication sessaoApplication)
        {
            _sessaoApplication = sessaoApplication;
        }

        // GET: api/Sessao
        [HttpGet]
        [ProducesResponseType(typeof(List<SessaoDTO>),StatusCodes.Status200OK)]
        public async Task<IActionResult> Get([FromQuery] DateTime? inicio, [FromQuery]DateTime? fim, [FromQuery]int? sala, [FromQuery]int? filme)
        {
            var sessoes = await _sessaoApplication.BuscarSessoes(inicio, fim, sala, filme);

            return Ok(sessoes);
        }
        
        // GET: api/Sessao/{codigo}
        [HttpGet("{codigo}")]
        [ProducesResponseType(typeof(SessaoDTO),StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int codigo)
        {
            var sessao = await _sessaoApplication.BuscarSessao(codigo);

            return Ok(sessao);
        }

        // POST: api/Sessao
        [HttpPost]
        [ProducesResponseType(typeof(SessaoDTO),StatusCodes.Status200OK)]
        public async Task<IActionResult> Post([FromBody] SessaoDTO sessao)
        {
            sessao = await _sessaoApplication.CadastrarSessao(sessao);

            return Ok(sessao);
        }

        // DELETE: api/Sessao/{codigo}
        [HttpDelete("{codigo}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(int codigo)
        {
            await _sessaoApplication.CancelarSessao(codigo);

            return Ok();
        }
    }
}
