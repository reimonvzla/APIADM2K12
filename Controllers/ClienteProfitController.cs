namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/ClienteProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class ClienteProfitController : ControllerBase
    {
        readonly ClientesRespositorio metodo = new ClientesRespositorio();
        Response resultado;

        #region GetClientes
        // GET: api/<ClienteProfitController>
        [HttpGet]
        [Route("GetClientes")]
        public IEnumerable<SaCliente> GetClientes(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetCliente
        // GET api/<ClienteProfitController>/5
        [HttpGet("GetCliente")]
        public SaCliente GetCliente(string CodCliente, string Emp)
        {
            return metodo.Find(CodCliente, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<ClienteProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaCliente cliente, string Emp)
        {
            resultado = metodo.Save(cliente, Emp);
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
        // PUT api/<ClienteProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SaCliente cliente, string Emp)
        {
            resultado = metodo.Update(cliente, Emp);
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

        #region Eliminar
        // DELETE api/<ClienteProfitController>/5
        [HttpDelete("Eliminar")]
        public IActionResult Eliminar(string CodCliente, string CodUsuario, string Emp)
        {
            resultado = metodo.Remove(CodCliente, CodUsuario, Emp);
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
    }
}
