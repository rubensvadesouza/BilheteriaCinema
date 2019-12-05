using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BilheteriaCinema.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngressoController : ControllerBase
    {
        // GET: api/Ingresso
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Ingresso/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Ingresso
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Ingresso/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
