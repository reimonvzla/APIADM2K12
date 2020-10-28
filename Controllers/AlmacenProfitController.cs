namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using APIADM2K12.Models;
    using APIADM2K12.Repositorio;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/AlmacenProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class AlmacenProfitController : ControllerBase
    {
        readonly AlmacenesRepositorio metodo = new AlmacenesRepositorio();

        #region GetAlmacenes
        // GET: api/<AlmacenProfitController>
        [HttpGet]
        [Route("GetAlmacenes")]
        public IEnumerable<SaAlmacen> GetAlmacenes(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        // GET api/<AlmacenProfitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AlmacenProfitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AlmacenProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AlmacenProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
