namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/OrdenCompraProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class OrdenCompraProfitController : ControllerBase
    {
        readonly OrdenesCompraRepositorio metodo = new OrdenesCompraRepositorio();
        Response resultado;

        #region GetOrdenesCompra
        // GET: api/<OrdenCompraProfitController>
        [HttpGet]
        [Route("GetOrdenesCompra")]
        public IEnumerable<SaOrdenCompra> GetOrdenesCompra(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetOrdenCompra
        // GET api/<OrdenCompraProfitController>/5
        [HttpGet("GetOrdenCompra")]
        public SaOrdenCompra GetOrdenCompra(string NumOrdenCompra, string Emp)
        {
            return metodo.Find(NumOrdenCompra, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<OrdenCompraProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabOrdenCompra ordencompra, string Emp)
        {
            #region Construccion de SaOrdenCompra
            SaOrdenCompra obj = new SaOrdenCompra
            {
                #region Campos
                DocNum = ordencompra.DocNum,
                Descrip = ordencompra.Descrip,
                CoProv = ordencompra.CoProv,
                CoCond = ordencompra.CoCond,
                CoMone = ordencompra.CoMone,
                Tasa = ordencompra.Tasa,
                FecEmis = ordencompra.FecEmis,
                FecReg = ordencompra.FecReg,
                FecVenc = ordencompra.FecVenc,
                Status = ordencompra.Status,
                CoSucuIn = ordencompra.CoSucuIn,
                CoUsIn = ordencompra.CoUsIn,
                FeUsIn = ordencompra.FeUsIn,
                FeUsMo = ordencompra.FeUsMo,
                CoUsMo = ordencompra.CoUsMo,
                CoSucuMo = ordencompra.CoSucuMo,
                TotalBruto = ordencompra.TotalBruto,
                MontoImp = ordencompra.MontoImp,
                TotalNeto = ordencompra.TotalNeto,
                Saldo = ordencompra.Saldo,
                Comentario = ordencompra.Comentario
                #endregion
            };

            foreach (var iDetalle in ordencompra.DetaOrdenCompra)
            {
                obj.SaOrdenCompraReng.Add(new SaOrdenCompraReng
                {
                    #region Campos
                    DocNum = iDetalle.DocNum,
                    RengNum = iDetalle.RengNum,
                    CoArt = iDetalle.CoArt,
                    DesArt = iDetalle.DesArt,
                    TotalArt = iDetalle.TotalArt,
                    Pendiente = iDetalle.Pendiente,
                    CostUnit = iDetalle.CostUnit,
                    RengNeto = iDetalle.RengNeto,
                    CoAlma = iDetalle.CoAlma,
                    CoSucuIn = iDetalle.CoSucuIn,
                    TipoImp = iDetalle.TipoImp,
                    PorcDesc = iDetalle.PorcDesc,
                    MontoDesc = iDetalle.MontoDesc,
                    CoUsIn = iDetalle.CoUsIn,
                    FeUsIn = iDetalle.FeUsIn,
                    FeUsMo = iDetalle.FeUsMo,
                    CoUsMo = iDetalle.CoUsMo,
                    CoSucuMo = iDetalle.CoSucuMo,
                    CostUnitOm = iDetalle.CostUnitOm,
                    Comentario = iDetalle.Comentario
                    #endregion
                });
            } 
            #endregion

            resultado = metodo.Save(obj, Emp);
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
        // PUT api/<OrdenCompraProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        #endregion

        #region Eliminar
        // DELETE api/<OrdenCompraProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        #endregion
    }
}
