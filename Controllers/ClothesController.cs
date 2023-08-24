using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using taller_nro1.Properties.Model;

namespace taller_nro1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ClothesController : ControllerBase
    {
        private static List<Clothes> _clothesData = new List<Clothes>
        {
            new Clothes { Id = 1, Name = "Camiseta", Type = "t-shirt", Price = 19.99, Size = 'S'},
            new Clothes { Id = 2, Name = "Supreme Shorts", Type = "shorts", Price = 559.99, Size = 'S'}
        };
        // GET: api/Clothes
        [HttpGet]
        public IEnumerable<Clothes> Get()
        {
            return _clothesData;
        }

        // GET: api/Clothes/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Clothes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Clothes/5
        [HttpPut("{id}")]
        public StatusCodeResult Put(int id, [FromBody] Clothes germand)
        {
            try
            {
                if (germand.Price == 0 || germand.Id == 0)
                    return StatusCode(400);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        // DELETE: api/Clothes/5
        [HttpDelete("{id}")]
        public StatusCodeResult Delete(Clothes germand)
        {
            try
            {
                if (germand.Id == 0)
                    return StatusCode(400);
                return StatusCode(200);
            }
            catch (Exception e)
            {
                return StatusCode(500);
            }
        }
    }
}
