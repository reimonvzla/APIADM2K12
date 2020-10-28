namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/TipoClienteProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class TipoClienteProfitController : ControllerBase
    {
        readonly TiposClienteRepositorio metodo = new TiposClienteRepositorio();
        Response resultado;

        #region GetTiposCliente
        // GET: api/<TipoClienteProfitController>
        [HttpGet]
        [Route("GetTiposCliente")]
        public IEnumerable<SaTipoCliente> GetTiposCliente(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetTipoCliente
        // GET api/<TipoClienteProfitController>/5
        [HttpGet("GetTipoCliente")]
        public SaTipoCliente GetTipoCliente(string CodTipoCliente, string Emp)
        {
            return metodo.Find(CodTipoCliente, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<TipoClienteProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaTipoCliente tipocliente, string Emp)
        {
            resultado = metodo.Save(tipocliente, Emp);
            if (resultado.Status == "OK")
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest(resultado);
            }
        }
        #endregion

        #region Actualizar
        // PUT api/<TipoClienteProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        } 
        #endregion

        // DELETE api/<TipoClienteProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
