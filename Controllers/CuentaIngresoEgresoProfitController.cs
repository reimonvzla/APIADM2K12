namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/CuentaIngresoEgresoProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class CuentaIngresoEgresoProfitController : ControllerBase
    {
        readonly CuentasIngrEgreRepositorio metodo = new CuentasIngrEgreRepositorio();
        Response resultado;

        #region GetCuentasIngrEgr
        // GET: api/<CuentaIngresoEgresoProfitController>
        [HttpGet]
        [Route("GetCuentasIngrEgr")]
        public IEnumerable<SaCuentaIngEgr> GetCuentasIngrEgr(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetCuentaIngrEgr
        // GET api/<CuentaIngresoEgresoProfitController>/5
        [HttpGet("GetCuentaIngrEgr")]
        public SaCuentaIngEgr GetCuentaIngrEgr(string CodCtaIngrEgr, string Emp)
        {
            return metodo.Find(CodCtaIngrEgr, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<CuentaIngresoEgresoProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaCuentaIngEgr cuenta, string Emp)
        {
            resultado = metodo.Save(cuenta, Emp);
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
        // PUT api/<CuentaIngresoEgresoProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SaCuentaIngEgr cuenta, string Emp)
        {
            resultado = metodo.Update(cuenta, Emp);
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

        // DELETE api/<CuentaIngresoEgresoProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
