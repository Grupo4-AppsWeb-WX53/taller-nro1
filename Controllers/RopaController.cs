using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taller_nro1.Models;

namespace taller_nro1.Controllers
{
    [Route("api/ropa")]
    [ApiController]
    public class RopaController : ControllerBase
    {
        private List<Ropa> _ropas = new List<Ropa>();
        // GET: api/Ropa
        [HttpGet]
        public IActionResult GetRopa()
        {
            return Ok(_ropas);
        }

        // GET: api/Ropa/5
        [HttpGet("{id}", Name = "GetRopaById")]
        public IActionResult GetRopaById(int id)
        {
            var prenda = _ropas.FirstOrDefault(p => p.Id == id);
            if (prenda == null)
                return NotFound();
            return Ok(prenda);
        }

        // POST: api/Ropa
        [HttpPost]
        public IActionResult CreateRopa(Ropa ropa)
        {
            ropa.Id = _ropas.Count + 1;
            _ropas.Add(ropa);
            return CreatedAtAction(nameof(GetRopaById), new { id = ropa.Id }, ropa);
        }

        // PUT: api/Ropa/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Ropa/5
        [HttpDelete("{id}")]
        public IActionResult DeleteRopa(int id)
        {
            var ropa = _ropas.FirstOrDefault(p => p.Id == id);
            if (ropa == null)
                return NotFound();
            _ropas.Remove(ropa);
            return NoContent();
        }
    }
}
