namespace APIADM2K12.Controllers
{

    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Repositorio;
    using APIADM2K12.Models;

    [Route("api/ColorArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class ColorArticuloProfitController : ControllerBase
    {

        readonly ColoresArticulosRepositorio metodo = new ColoresArticulosRepositorio();
        Response resultado;

        #region GetColoresArticulos
        // GET: api/<ColorArticuloProfitController>
        [HttpGet]
        [Route("GetColoresArticulos")]
        public IEnumerable<SaColor> GetColoresArticulos(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        // GET api/<ColorArticuloProfitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        #region Guardar
        // POST api/<ColorArticuloProfitController>
        [HttpPost]
        public IActionResult Guardar([FromBody] SaColor color, string Emp)
        {
            resultado = metodo.Save(color, Emp);
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
        
        // PUT api/<ColorArticuloProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ColorArticuloProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
