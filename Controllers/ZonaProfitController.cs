namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/ZonaProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class ZonaProfitController : ControllerBase
    {
        readonly ZonasRepositorio metodo = new ZonasRepositorio();
        Response resultado;

        #region GetZonas
        // GET: api/<ZonaProfitController>
        [HttpGet]
        [Route("GetZonas")]
        public IEnumerable<SaZona> GetZonas(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetZona
        // GET api/<ZonaProfitController>/5
        [HttpGet("GetZona")]
        public SaZona GetZona(string CodZona,string Emp)
        {
            return metodo.Find(CodZona,Emp);
        }
        #endregion

        #region Guardar
        // POST api/<ZonaProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaZona zona, string Emp)
        {
            resultado = metodo.Save(zona, Emp);
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
        // PUT api/<ZonaProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SaZona zona, string Emp)
        {
            resultado = metodo.Update(zona, Emp);
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

        // DELETE api/<ZonaProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
