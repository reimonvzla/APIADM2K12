namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/LineaArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class LineaArticuloProfitController : ControllerBase
    {
        readonly LineasArticulosRepositorio metodo = new LineasArticulosRepositorio();
        Response resultado;

        #region GetLineasArticulos
        // GET: api/<LineaArticuloProfit>
        [HttpGet]
        [Route("GetLineasArticulos")]
        public IEnumerable<SaLineaArticulo> GetLineasArticulos(string Emp)
        {
            return metodo.GetAll(Emp);
        }

        #endregion

        #region GetSubLineasArticulos
        // GET: api/<LineaArticuloProfit>
        [HttpGet]
        [Route("GetSubLineasArticulos")]
        public IEnumerable<SaSubLinea> GetSubLineasArticulos(string Emp)
        {
            return metodo.GetAllSubLin(Emp);
        } 
        #endregion

        #region GetLineaArticulo
        // GET api/<LineaArticuloProfit>/5
        [HttpGet("GetLineaArticulo")]
        public SaLineaArticulo GetLineaArticulo(string CodLinea, string Emp)
        {
            return metodo.Find(CodLinea, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<ArticuloProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaLineaArticulo linea, string Emp)
        {
            resultado = metodo.Save(linea, Emp);
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
        // PUT api/<LineaArticuloProfit>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SaLineaArticulo linea, string Emp)
        {
            resultado = metodo.Update(linea, Emp);
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

        // DELETE api/<LineaArticuloProfit>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
