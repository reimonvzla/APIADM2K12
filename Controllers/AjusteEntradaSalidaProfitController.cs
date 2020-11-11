namespace APIADM2K12.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;


    [Route("api/AjusteEntradaSalidaProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class AjusteEntradaSalidaProfitController : ControllerBase
    {
        readonly AjustesEntradasSalidasRepositorio metodo = new AjustesEntradasSalidasRepositorio();
        Response resultado;

        #region GetAjustes
        // GET: api/<AjusteEntradaSalidaProfitController>
        [HttpGet]
        [Route("GetAjustes")]
        public IEnumerable<SaAjuste> GetAjustes(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetAjuste
        // GET api/<AjusteEntradaSalidaProfitController>/5
        [HttpGet("GetAjuste")]
        public SaAjuste GetAjuste(string NumAjuste, string Emp)
        {
            return metodo.Find(NumAjuste, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<AjusteEntradaSalidaProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabAjusteInventario ajuste, string Emp)
        {
            #region Construccion de SaAjuste
            SaAjuste obj = new SaAjuste
            {
                #region Campos
                AjueNum = ajuste.AjueNum,
                Fecha = ajuste.Fecha,
                Motivo = ajuste.Motivo,
                CoMone = ajuste.CoMone,
                Tasa = ajuste.Tasa,
                SerialesS = ajuste.SerialesS,
                SerialesE = ajuste.SerialesE,
                Feccom = ajuste.Feccom,
                Numcom = ajuste.Numcom,
                Anulado = ajuste.Anulado,
                CoInvfisico = ajuste.CoInvfisico,
                Aux01 = ajuste.Aux01,
                Aux02 = ajuste.Aux02,
                DisCen = ajuste.DisCen,
                Campo1 = ajuste.Campo1,
                Campo2 = ajuste.Campo2,
                Campo3 = ajuste.Campo3,
                Campo4 = ajuste.Campo4,
                Campo5 = ajuste.Campo5,
                Campo6 = ajuste.Campo6,
                Campo7 = ajuste.Campo7,
                Campo8 = ajuste.Campo8,
                CoUsIn = ajuste.CoUsIn,
                CoSucuIn = ajuste.CoSucuIn,
                FeUsIn = ajuste.FeUsIn,
                CoUsMo = ajuste.CoUsMo,
                CoSucuMo = ajuste.CoSucuMo,
                FeUsMo = ajuste.FeUsMo,
                Revisado = ajuste.Revisado,
                Trasnfe = ajuste.Trasnfe,
                Validador = ajuste.Validador,
                Rowguid = ajuste.Rowguid
                #endregion
            };

            foreach (var iDetalle in ajuste.DetaAjusteInventario)
            {
                obj.SaAjusteReng.Add(new SaAjusteReng
                {
                    #region Campos
                    AjueNum = iDetalle.AjueNum,
                    RengNum = iDetalle.RengNum,
                    CoTipo = iDetalle.CoTipo,
                    CoArt = iDetalle.CoArt,
                    CoAlma = iDetalle.CoAlma,
                    CoUni = iDetalle.CoUni,
                    ScoUni = iDetalle.ScoUni,
                    DisCen = iDetalle.DisCen,
                    TotalArt = iDetalle.TotalArt,
                    StotalArt = iDetalle.StotalArt,
                    CostUnit = iDetalle.CostUnit,
                    LoteAsignado = iDetalle.LoteAsignado,
                    CostoAdi1 = iDetalle.CostoAdi1,
                    CostoAdi2 = iDetalle.CostoAdi2,
                    CostoAdi3 = iDetalle.CostoAdi3,
                    CoUsIn = iDetalle.CoUsIn,
                    CoSucuIn = iDetalle.CoSucuIn,
                    FeUsIn = iDetalle.FeUsIn,
                    CoUsMo = iDetalle.CoUsMo,
                    CoSucuMo = iDetalle.CoSucuMo,
                    FeUsMo = iDetalle.FeUsMo,
                    Revisado = iDetalle.Revisado,
                    Trasnfe = iDetalle.Trasnfe
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

        // PUT api/<AjusteEntradaSalidaProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AjusteEntradaSalidaProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
