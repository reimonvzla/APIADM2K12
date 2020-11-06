namespace APIADM2K12.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/PedidoVentaProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class PedidoVentaProfitController : ControllerBase
    {
        readonly PedidosVentaRepositorio metodo = new PedidosVentaRepositorio();
        Response resultado;

        #region GetPedidos
        // GET: api/<PedidoVentaProfitController>
        [HttpGet]
        [Route("GetPedidos")]
        public IEnumerable<SaPedidoVenta> GetPedidos(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetPedido
        // GET api/<PedidoVentaProfitController>/5
        [HttpGet("GetPedido")]
        public SaPedidoVenta GetPedido(string NumPedido,string Emp)
        {
            return metodo.Find(NumPedido, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<PedidoVentaProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabPedidoVenta pedido,string Emp)
        {
            #region Construccion de SaPedidoVenta
            SaPedidoVenta obj = new SaPedidoVenta
            {
                #region Campos
                DocNum = pedido.DocNum,
                Descrip = pedido.Descrip,
                CoCli = pedido.CoCli,
                CoTran = pedido.CoTran,
                CoMone = pedido.CoMone,
                CoVen = pedido.CoVen,
                CoCond = pedido.CoCond,
                FecEmis = pedido.FecEmis,
                FecVenc = pedido.FecVenc,
                FecReg = pedido.FecReg,
                Tasa = pedido.Tasa,
                CoSucuIn = pedido.CoSucuIn,
                CoUsIn = pedido.CoUsIn,
                FeUsIn = pedido.FeUsIn,
                FeUsMo = pedido.FeUsMo,
                CoUsMo = pedido.CoUsMo,
                CoSucuMo = pedido.CoSucuMo,
                TotalBruto = pedido.TotalBruto,
                MontoImp = pedido.MontoImp,
                TotalNeto = pedido.TotalNeto,
                Saldo = pedido.Saldo,
                Status=pedido.Status
                #endregion
            };
            foreach (var iDetalle in pedido.DetaPedidoVenta)
            {
                obj.SaPedidoVentaReng.Add(new SaPedidoVentaReng
                {
                    #region Campos
                    DocNum = iDetalle.DocNum,
                    RengNum = iDetalle.RengNum,
                    CoArt = iDetalle.CoArt,
                    DesArt = iDetalle.DesArt,
                    CoAlma = iDetalle.CoAlma,
                    TotalArt = iDetalle.TotalArt,
                    CoPrecio = iDetalle.CoPrecio,
                    PrecVta = iDetalle.PrecVta,
                    PrecVtaOm = iDetalle.PrecVtaOm,
                    PorcDesc = iDetalle.PorcDesc,
                    MontoDesc = iDetalle.MontoDesc,
                    TipoImp = iDetalle.TipoImp,
                    RengNeto = iDetalle.RengNeto,
                    Pendiente = iDetalle.Pendiente,
                    CoUsIn = iDetalle.CoUsIn,
                    FeUsIn = iDetalle.FeUsIn,
                    CoSucuIn = iDetalle.CoSucuIn,
                    CoUsMo = iDetalle.CoUsMo,
                    FeUsMo = iDetalle.FeUsMo,
                    CoSucuMo = iDetalle.CoSucuMo,
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
        // PUT api/<PedidoVentaProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SaPedidoVenta pedido, string Emp)
        {
            resultado = metodo.Update(pedido, Emp);
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
        // DELETE api/<PedidoVentaProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        } 
        #endregion

    }
}
