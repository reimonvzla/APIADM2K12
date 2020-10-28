namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/CategoriaArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class CategoriaArticuloProfitController : ControllerBase
    {
        readonly CategoriasArticulosRepositorio metodo = new CategoriasArticulosRepositorio();
        Response resultado;

        #region GetCategoriasArticulos
        // GET: api/<CategoriaArticuloProfitController>
        [HttpGet]
        [Route("GetCategoriasArticulos")]
        public IEnumerable<SaCatArticulo> GetCategoriasArticulos(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetCategoriaArticulo
        // GET api/<CategoriaArticuloProfitController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        } 
        #endregion

        #region Guardar
        // POST api/<CategoriaArticuloProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaCatArticulo categoria, string Emp)
        {
            resultado = metodo.Save(categoria, Emp);
            if (resultado.Status == "OK")
            {
                return Ok(metodo);
            }
            else
            {
                return BadRequest(resultado);
            }
        } 
        #endregion

        // PUT api/<CategoriaArticuloProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriaArticuloProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
