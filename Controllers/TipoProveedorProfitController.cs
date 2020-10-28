namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/TipoProveedorProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class TipoProveedorProfitController : ControllerBase
    {
        readonly TiposProveedorRepositorio metodo = new TiposProveedorRepositorio();
        Response resultado;

        #region GetTiposProveedores
        // GET: api/<TipoProveedorProfitController>
        [HttpGet]
        [Route("GetTiposProveedores")]
        public IEnumerable<SaTipoProveedor> GetTiposProveedores(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetTipoProveedor
        // GET api/<TipoProveedorProfitController>/5
        [HttpGet("GetTipoProveedor")]
        public SaTipoProveedor GetTipoProveedor(string CodTipo, string Emp)
        {
            return metodo.Find(CodTipo, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<TipoProveedorProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaTipoProveedor tipo, string Emp)
        {
            resultado = metodo.Save(tipo, Emp);
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
        // PUT api/<TipoProveedorProfitController>/5
        [HttpPut("{id}")]
        public IActionResult Actualizar([FromBody] SaTipoProveedor tipo, string Emp)
        {
            resultado = metodo.Update(tipo, Emp);
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

        // DELETE api/<TipoProveedorProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
