namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Cors;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/SegmentoProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class SegmentoProfitController : ControllerBase
    {
        readonly SegmentosRepositorio metodo = new SegmentosRepositorio();
        Response resultado;

        #region GetSegmentos
        // GET: api/<SegmentoProfitController>
        [HttpGet]
        [Route("GetSegmentos")]
        public IEnumerable<SaSegmento> GetSegmentos(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetSegmento
        // GET api/<SegmentoProfitController>/5
        [HttpGet("GetSegmento")]
        public SaSegmento GetSegmento(string CodSegmento, string Emp)
        {
            return metodo.Find(CodSegmento, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<SegmentoProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaSegmento segmento, string Emp)
        {
            resultado = metodo.Save(segmento, Emp);
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
        // PUT api/<SegmentoProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SaSegmento segmento, string Emp)
        {
            resultado = metodo.Update(segmento, Emp);
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

        // DELETE api/<SegmentoProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
