using System;
using System.Threading.Tasks;
using BilheteriaCinema.Application.Application;
using BilheteriaCinema.Application.DTO;
using Microsoft.AspNetCore.Mvc;

namespace BilheteriaCinema.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngressoController : ControllerBase
    {
        private readonly IIngressoApplication _ingressoApplication;

        public IngressoController(IIngressoApplication ingressoApplication)
        {
            _ingressoApplication = ingressoApplication;
        }

        // GET: api/Ingresso
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] DateTime? inicio, [FromQuery] DateTime? fim, [FromQuery] string cpf, [FromQuery] int? sessao)
        {
            var ingressos = await _ingressoApplication.BuscarIngressos(inicio, fim, cpf, sessao);

            return Ok(ingressos);
        }
        
        // GET: api/Ingresso/{codigo}
        [HttpGet("{codigo}")]
        public async Task<IActionResult> Get(int codigo)
        {
            var ingressos = await _ingressoApplication.BuscarIngresso(codigo);

            return Ok(ingressos);
        }

        // POST: api/Ingresso
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] IngressoDTO ingresso)
        {
            ingresso = await _ingressoApplication.ComprarIngresso(ingresso);

            return Ok(ingresso);
        }

        // DELETE: api/Ingresso
        [HttpDelete("{codigo}")]
        public async Task<IActionResult> Delete(int codigo)
        {
            await _ingressoApplication.CancelarCompra(codigo);

            return Ok();
        }
    }
}
