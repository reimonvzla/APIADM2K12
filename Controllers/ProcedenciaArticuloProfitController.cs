namespace APIADM2K12.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/ProcedenciaArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class ProcedenciaArticuloProfitController : ControllerBase
    {

        readonly ProcedenciasArticulosRepositorio metodo = new ProcedenciasArticulosRepositorio();
        Response resultado;

        #region GetProcedenciasArticulos
        // GET: api/<ProcedenciaArticuloProfitController>
        [HttpGet]
        [Route("GetProcedenciasArticulos")]
        public IEnumerable<SaProcedencia> GetProcedenciasArticulos(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        // GET api/<ProcedenciaArticuloProfitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProcedenciaArticuloProfitController>
        #region Guardar
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaProcedencia procedencia, string Emp)
        {
            resultado = metodo.Save(procedencia, Emp);
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

        // PUT api/<ProcedenciaArticuloProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProcedenciaArticuloProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
