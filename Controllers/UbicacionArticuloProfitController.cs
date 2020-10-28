namespace APIADM2K12.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/UbicacionArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class UbicacionArticuloProfitController : ControllerBase
    {
        readonly UbicacionesArticulosRespositorio metodo = new UbicacionesArticulosRespositorio();
        Response resultado;

        #region GetUbicaciones
        // GET: api/<UbicacionArticuloProfitController>
        [HttpGet]
        [Route("GetUbicaciones")]
        public IEnumerable<SaUbicacion> GetUbicaciones(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetUbicacion
        // GET api/<UbicacionArticuloProfitController>/5
        [HttpGet("GetUbicacion")]
        public SaUbicacion GetUbicacion(string CodUbicacion, string Emp)
        {
            return metodo.Find(CodUbicacion, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<UbicacionArticuloProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaUbicacion ubicacion, string Emp)
        {
            resultado = metodo.Save(ubicacion, Emp);
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
        // PUT api/<UbicacionArticuloProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SaUbicacion ubicacion, string Emp)
        {
            resultado = metodo.Update(ubicacion, Emp);
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

        // DELETE api/<UbicacionArticuloProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
