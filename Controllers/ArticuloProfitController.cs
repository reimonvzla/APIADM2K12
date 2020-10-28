namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/ArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class ArticuloProfitController : ControllerBase
    {
        readonly ArticulosRepositorio metodo = new ArticulosRepositorio();
        Response resultado;

        #region GetArticulos
        // GET: api/<ArticuloProfitController>
        [HttpGet]
        [Route("GetArticulos")]
        public IEnumerable<SaArticulo> GetArticulos(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetUnidadesArticulos
        // GET: api/<ArticuloProfitController>
        [HttpGet]
        [Route("GetUnidadesArticulos")]
        public IEnumerable<SaArtUnidad> GetUnidadesArticulos(string Emp)
        {
            return metodo.GetAllArtUnidad(Emp);
        }
        #endregion

        #region GetUnidades
        // GET: api/<ArticuloProfitController>
        [HttpGet]
        [Route("GetUnidades")]
        public IEnumerable<SaUnidad> GetUnidades(string Emp)
        {
            return metodo.GetAllUnidades(Emp);
        }
        #endregion

        #region GetArticulo
        // GET api/<ArticuloProfitController>/5
        [HttpGet("GetArticulo")]
        public SaArticulo GetArticulo(string CodArticulo, string Emp)
        {
            return metodo.Find(CodArticulo, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<ArticuloProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaArticulo articulo, string Emp)
        {
            resultado = metodo.Save(articulo, Emp);
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
        // PUT api/<ArticuloProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SaArticulo articulo, string Emp)
        {
            resultado = metodo.Update(articulo, Emp);
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
        // DELETE api/<ArticuloProfitController>/5
        [HttpDelete("Eliminar")]
        public IActionResult Eliminar(string CodArticulo, string CodUsuario, string Emp)
        {
            resultado = metodo.Remove(CodArticulo, CodUsuario, Emp);
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
