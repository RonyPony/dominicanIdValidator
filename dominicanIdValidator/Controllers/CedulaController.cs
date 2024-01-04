using dominicanIdValidator.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace dominicanIdValidator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CedulaController : ControllerBase
    {
        private readonly ICedulaService _CedulaService;
        public CedulaController(ICedulaService srv)
        {
            _CedulaService = srv;
        }

        //// GET: api/<TripController>
        //[HttpGet]
        //public IEnumerable<Padron> Get()
        //{
        //    return _CedulaService.getAllPadrons();
        //}
        // GET api/<TripController>/5
        [HttpGet("{id}")]
        public Padron GetAsync(string id)
        {
            return _CedulaService.getPadronById(id);
        }

        //// POST api/<TripController>
        //[HttpPost]
        //public Task<Padron> Post([FromBody] Padron value)
        //{
        //    return _CedulaService.CreatePadron(value);
        //}

        //// PUT api/<TripController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<TripController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAsync(Guid id)
        //{
        //    await _CedulaService.RemovePadron(id);
        //    return Ok();
        //}
    }
}
