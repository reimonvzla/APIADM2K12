namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Repositorio;

    [Route("api/TransporteProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class TransporteProfitController : ControllerBase
    {
        readonly TransportesRepositorio metodo = new TransportesRepositorio();

        #region GetTransportes
        // GET: api/<TransporteProfitController>
        [HttpGet]
        [Route("GetTransportes")]
        public IEnumerable<SaTransporte> GetTransportes(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        // GET api/<TransporteProfitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TransporteProfitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TransporteProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TransporteProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
