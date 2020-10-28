namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/ProveedorProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class ProveedorProfitController : ControllerBase
    {
        readonly ProveedoresRepositorio metodo = new ProveedoresRepositorio();
        Response resultado;

        #region GetProveedores
        // GET: api/<ProveedorProfitController>
        [HttpGet]
        [Route("GetProveedores")]
        public IEnumerable<SaProveedor> GetProveedores(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetProveedor
        // GET api/<ProveedorProfitController>/5
        [HttpGet("GetProveedor")]
        public SaProveedor GetProveedor(string CodProveedor, string Emp)
        {
            return metodo.Find(CodProveedor, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<ProveedorProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SaProveedor proveedor, string Emp)
        {
            resultado = metodo.Save(proveedor, Emp);
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
        // PUT api/<ProveedorProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SaProveedor proveedor, string Emp)
        {
            resultado = metodo.Update(proveedor, Emp);
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
        // DELETE api/<ProveedorProfitController>/5
        [HttpDelete("Eliminar")]
        public IActionResult Eliminar(string CodCliente, string CodUsuario, string Emp)
        {
            resultado = metodo.Remove(CodCliente, CodUsuario, Emp);
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
