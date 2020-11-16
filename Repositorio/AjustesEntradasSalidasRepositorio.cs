namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;
    using Utilitarios;

    public class AjustesEntradasSalidasRepositorio : IRepositorio<SaAjuste>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        SaArticulo articulo;
        SaMoneda moneda;
        SaArtUnidad artunidad;

        #region Find
        public SaAjuste Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

            SaAjuste Qry = db.SaAjuste.Select(a => new SaAjuste
            {
                #region Campos
                AjueNum = a.AjueNum,
                Fecha = a.Fecha,
                Motivo = a.Motivo,
                CoMone = a.CoMone,
                Tasa = a.Tasa,
                SerialesS = a.SerialesS,
                SerialesE = a.SerialesE,
                Feccom = a.Feccom,
                Numcom = a.Numcom,
                Anulado = a.Anulado,
                CoInvfisico = a.CoInvfisico,
                Aux01 = a.Aux01,
                Aux02 = a.Aux02,
                DisCen = a.DisCen,
                Campo1 = a.Campo1,
                Campo2 = a.Campo2,
                Campo3 = a.Campo3,
                Campo4 = a.Campo4,
                Campo5 = a.Campo5,
                Campo6 = a.Campo6,
                Campo7 = a.Campo7,
                Campo8 = a.Campo8,
                CoUsIn = a.CoUsIn,
                CoSucuIn = a.CoSucuIn,
                FeUsIn = a.FeUsIn,
                CoUsMo = a.CoUsMo,
                CoSucuMo = a.CoSucuMo,
                FeUsMo = a.FeUsMo,
                Revisado = a.Revisado,
                Trasnfe = a.Trasnfe,
                Validador = a.Validador,
                Rowguid = a.Rowguid,
                SaAjusteReng = a.SaAjusteReng
                #endregion

            }).FirstOrDefault(a => a.AjueNum.Trim() == key.Trim());

            return Qry;
        } 
        #endregion

        #region GetAll
        public IEnumerable<SaAjuste> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

            var Qry = db.SaAjuste.Select(a => new SaAjuste
            {
                #region Campos
                AjueNum = a.AjueNum,
                Fecha = a.Fecha,
                Motivo = a.Motivo,
                CoMone = a.CoMone,
                Tasa = a.Tasa,
                SerialesS = a.SerialesS,
                SerialesE = a.SerialesE,
                Feccom = a.Feccom,
                Numcom = a.Numcom,
                Anulado = a.Anulado,
                CoInvfisico = a.CoInvfisico,
                Aux01 = a.Aux01,
                Aux02 = a.Aux02,
                DisCen = a.DisCen,
                Campo1 = a.Campo1,
                Campo2 = a.Campo2,
                Campo3 = a.Campo3,
                Campo4 = a.Campo4,
                Campo5 = a.Campo5,
                Campo6 = a.Campo6,
                Campo7 = a.Campo7,
                Campo8 = a.Campo8,
                CoUsIn = a.CoUsIn,
                CoSucuIn = a.CoSucuIn,
                FeUsIn = a.FeUsIn,
                CoUsMo = a.CoUsMo,
                CoSucuMo = a.CoSucuMo,
                FeUsMo = a.FeUsMo,
                Revisado = a.Revisado,
                Trasnfe = a.Trasnfe,
                Validador = a.Validador,
                Rowguid = a.Rowguid,
                SaAjusteReng = a.SaAjusteReng
                #endregion

            }).ToList();

            return Qry;
        } 
        #endregion

        #region Remove
        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region Save
        public Response Save(SaAjuste item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                #region Validar datos
                ValidarDatos(item, empresaDB);
                #endregion

                #region Consecutivo numero de ajuste
                string codigoConsecutivoAjuste = "AJUS_NUM";
                string numeroAjuste = new ObtenerProximoConsecutivo().GetProximoNumero(codigoConsecutivoAjuste, item.CoSucuIn, empresaDB);
                #endregion

                #region Actualizar stock
                foreach (var iAjuste in item.SaAjusteReng)
                {
                    iAjuste.CoUni = artunidad.CoUni; //;-)

                    FormattableString stockPorLlegar = $@"EXEC pStockActualizar @sCo_Alma={iAjuste.CoAlma.Trim()}
                    ,@sCo_Art={iAjuste.CoArt.Trim()}
                    ,@sCo_Uni={iAjuste.CoUni.Trim()}
                    ,@deCantidad={iAjuste.TotalArt}
                    ,@sTipoStock='ACT'
                    ,@bSumarStock={true}
                    ,@bPermiteStockNegativo={false}";
                    int result = db.Database.ExecuteSqlInterpolated(stockPorLlegar);
                }
                #endregion

                item.AjueNum = numeroAjuste;
                db.Entry(item).State = EntityState.Added;

                foreach (var iReng in item.SaAjusteReng)
                {
                    iReng.AjueNum = numeroAjuste;
                    iReng.CoUni = artunidad.CoUni.Trim();
                    db.Entry(iReng).State = EntityState.Added;
                }

                db.SaveChanges();

                return new Response { Status = "OK", Message = "Transacción realizada con éxito.", NroDocumentoGenerado01 = numeroAjuste };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }

        }
        #endregion

        #region Update
        public Response Update(SaAjuste item, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Validar datos
        private void ValidarDatos(SaAjuste obj, string empresaDB)
        {

            #region Verificar sucursal
            SaSucursal sucu = new SucursalesRepositorio().Find(obj.CoSucuIn, empresaDB);
            if (sucu == null) throw new ArgumentException($"La sucursal [{obj.CoSucuIn.Trim()}] no existe.");
            #endregion

            #region Verificar datos en renglones
            foreach (var iReng in obj.SaAjusteReng)
            {
                #region Verificar articulo
                articulo = new ArticulosRepositorio().Find(iReng.CoArt, empresaDB);
                if (articulo == null) throw new ArgumentException($"El artículo [{iReng.CoArt.Trim()}] suministrado en el renglón [{iReng.RengNum}] no existe.");
                if (articulo.Anulado) throw new ArgumentException($"El artículo [{iReng.CoArt.Trim()}] suministrado en el renglón [{iReng.RengNum}] se encuentra anulado.");

                artunidad = new ArticulosRepositorio().GetAllArtUnidad(empresaDB).FirstOrDefault(u => u.CoArt.Trim() == iReng.CoArt.Trim() && u.UniPrincipal == true);
                if (artunidad == null) throw new ArgumentException($"El artículo [{iReng.CoArt.Trim()}] suministrado en el renglón [{iReng.RengNum}] no posee unidad principal registrada.");
                #endregion

                #region Verificar almacen
                SaAlmacen almacen = new AlmacenesRepositorio().Find(iReng.CoAlma, empresaDB);
                if (almacen == null)
                {
                    throw new ArgumentException($"El almacén [{iReng.CoAlma.Trim()}] suministrado en el renglón [{iReng.RengNum}] no existe.");
                }
                else
                {
                    if (almacen.CoSucur.Trim() != iReng.CoSucuIn.Trim())
                    {
                        throw new ArgumentException($"El almacén [{iReng.CoAlma.Trim()}] suministrado en el renglón [{iReng.RengNum}] no está permitido utilizarlo en la sucursal suministrada {obj.CoSucuIn.Trim()}.");
                    }
                    if (almacen.Nocompra)
                    {
                        throw new ArgumentException($"El almacén [{iReng.CoAlma.Trim()}] suministrado en el renglón [{iReng.RengNum}] no está permitido utilizarlo en el módulo de compras.");
                    }
                }
                #endregion
            }
            #endregion

            #region Verificar moneda
            moneda = new ObtenerMoneda().GetOtraMoneda(obj.CoMone, empresaDB);
            if (moneda == null) throw new ArgumentException($"La moneda [{obj.CoMone.Trim()}] no existe.");
            #endregion
        } 
        #endregion
    }
}
