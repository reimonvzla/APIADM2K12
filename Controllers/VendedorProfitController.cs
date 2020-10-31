namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Repositorio;

    [Route("api/VendedorProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class VendedorProfitController : ControllerBase
    {
        readonly VendedoresRepositorio metodo = new VendedoresRepositorio();

        #region GetVendedores
        // GET: api/<VendedorProfitController>
        [HttpGet]
        [Route("GetVendedores")]
        public IEnumerable<SaVendedor> GetVendedores(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetVendedor
        // GET api/<VendedorProfitController>/5
        [HttpGet("GetVendedor")]
        public SaVendedor Get(string codVendedor, string Emp)
        {
            return metodo.Find(codVendedor, Emp);
        } 
        #endregion

        // POST api/<VendedorProfitController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VendedorProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VendedorProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
