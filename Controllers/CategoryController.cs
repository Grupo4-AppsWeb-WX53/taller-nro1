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
    public class CategoryController : ControllerBase
    {
        // GET: api/Category
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Category/5
        [HttpGet("{id}", Name = "GetCategory")]
        public Category Get(int id)
        {
            Category category = new Category();
            category.Id = id;
            category.Name = "Name " + id.ToString();
            category.Count = 10;
            return category;
        }

        // POST: api/Category
        [HttpPost]
        public StatusCodeResult Post([FromBody] Category category)
        {
            try
            {
                if (category.Name == "")
                    return StatusCode(400);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        // PUT: api/Category/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Category/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
