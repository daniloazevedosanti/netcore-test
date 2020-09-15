using Api.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Api.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        private IConsultationDomain _ConsultationDomain;

        public ConsultasController(IConsultationDomain ConsultationDomain)
        {
            _ConsultationDomain = ConsultationDomain;
        }

        // GET: api/<ConsultationController>
        [HttpGet]
        public IActionResult Get()
        {
            return new OkObjectResult(_ConsultationDomain.FindAll());
        }

        // GET api/<ConsultationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ConsultationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ConsultationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ConsultationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
