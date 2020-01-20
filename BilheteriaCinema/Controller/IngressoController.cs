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
    public class IngressoController : ControllerBase
    {
        private readonly IIngressoApplication _ingressoApplication;

        public IngressoController(IIngressoApplication ingressoApplication)
        {
            _ingressoApplication = ingressoApplication;
        }
        
        // GET: api/Ingresso/{codigo}
        [HttpGet("{codigo}")]
        [ProducesResponseType(typeof(IngressoDTO),StatusCodes.Status200OK)]
        public async Task<IActionResult> Get(int codigo)
        {
            var ingressos = await _ingressoApplication.BuscarIngresso(codigo);

            return Ok(ingressos);
        }

        // POST: api/Ingresso
        [HttpPost]
        [ProducesResponseType(typeof(IngressoDTO),StatusCodes.Status200OK)]
        public async Task<IActionResult> Post([FromBody] IngressoDTO ingresso)
        {
            ingresso = await _ingressoApplication.ComprarIngresso(ingresso);

            return Ok(ingresso);
        }

        // DELETE: api/Ingresso
        [HttpDelete("{codigo}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Delete(int codigo)
        {
            await _ingressoApplication.CancelarCompra(codigo);

            return Ok();
        }
    }
}
