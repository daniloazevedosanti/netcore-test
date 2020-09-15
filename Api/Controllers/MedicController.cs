using System.Collections.Generic;
using Api.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class MedicController : ControllerBase
    {
        private IMedicDomain _medicDomain;

        public MedicController(IMedicDomain medicDomain)
        {
            _medicDomain = medicDomain;
        }

        // GET: api/<MedicController>
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_medicDomain.FindAll());
        }

        // GET api/<MedicController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MedicController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MedicController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MedicController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
