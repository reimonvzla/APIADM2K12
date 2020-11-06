namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;
    using Utilitarios;

    public class OrdenesCompraRepositorio : IRepositorio<SaOrdenCompra>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        SaProveedor proveedor;
        SaArticulo articulo;
        SaMoneda moneda;
        SaArtUnidad artunidad;

        #region Find
        public SaOrdenCompra Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

            var Qry = db.SaOrdenCompra.Select(o => new SaOrdenCompra
            {
                #region Campos
                DocNum = o.DocNum,
                NroFact = o.NroFact,
                Descrip = o.Descrip,
                CoProv = o.CoProv,
                CoMone = o.CoMone,
                CoCond = o.CoCond,
                PorcDescGlob = o.PorcDescGlob,
                PorcReca = o.PorcReca,
                Status = o.Status,
                NControl = o.NControl,
                FecEmis = o.FecEmis,
                FecVenc = o.FecVenc,
                FecReg = o.FecReg,
                Tasa = o.Tasa,
                Saldo = o.Saldo,
                TotalBruto = o.TotalBruto,
                TotalNeto = o.TotalNeto,
                MontoDescGlob = o.MontoDescGlob,
                MontoReca = o.MontoReca,
                Otros1 = o.Otros1,
                Otros2 = o.Otros2,
                Otros3 = o.Otros3,
                MontoImp = o.MontoImp,
                MontoImp2 = o.MontoImp2,
                MontoImp3 = o.MontoImp3,
                Anulado = o.Anulado,
                Impresa = o.Impresa,
                SerialesE = o.SerialesE,
                Salestax = o.Salestax,
                DisCen = o.DisCen,
                Feccom = o.Feccom,
                Numcom = o.Numcom,
                DirEnt = o.DirEnt,
                Comentario = o.Comentario,
                Campo1 = o.Campo1,
                Campo2 = o.Campo2,
                Campo3 = o.Campo3,
                Campo4 = o.Campo4,
                Campo5 = o.Campo5,
                Campo6 = o.Campo6,
                Campo7 = o.Campo7,
                Campo8 = o.Campo8,
                CoUsIn = o.CoUsIn,
                CoSucuIn = o.CoSucuIn,
                FeUsIn = o.FeUsIn,
                CoUsMo = o.CoUsMo,
                CoSucuMo = o.CoSucuMo,
                FeUsMo = o.FeUsMo,
                Revisado = o.Revisado,
                Trasnfe = o.Trasnfe,
                Validador = o.Validador,
                Rowguid = o.Rowguid,
                Nac = o.Nac,
                CoCtaIngrEgr = o.CoCtaIngrEgr,
                SaOrdenCompraReng = o.SaOrdenCompraReng
                #endregion

            }).FirstOrDefault(o => o.DocNum.Trim() == key.Trim());

            return Qry;
        }
        #endregion

        #region GetAll
        public IEnumerable<SaOrdenCompra> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

            var Qry = db.SaOrdenCompra.Select(o => new SaOrdenCompra
            {
                #region Campos
                DocNum = o.DocNum,
                NroFact = o.NroFact,
                Descrip = o.Descrip,
                CoProv = o.CoProv,
                CoMone = o.CoMone,
                CoCond = o.CoCond,
                PorcDescGlob = o.PorcDescGlob,
                PorcReca = o.PorcReca,
                Status = o.Status,
                NControl = o.NControl,
                FecEmis = o.FecEmis,
                FecVenc = o.FecVenc,
                FecReg = o.FecReg,
                Tasa = o.Tasa,
                Saldo = o.Saldo,
                TotalBruto = o.TotalBruto,
                TotalNeto = o.TotalNeto,
                MontoDescGlob = o.MontoDescGlob,
                MontoReca = o.MontoReca,
                Otros1 = o.Otros1,
                Otros2 = o.Otros2,
                Otros3 = o.Otros3,
                MontoImp = o.MontoImp,
                MontoImp2 = o.MontoImp2,
                MontoImp3 = o.MontoImp3,
                Anulado = o.Anulado,
                Impresa = o.Impresa,
                SerialesE = o.SerialesE,
                Salestax = o.Salestax,
                DisCen = o.DisCen,
                Feccom = o.Feccom,
                Numcom = o.Numcom,
                DirEnt = o.DirEnt,
                Comentario = o.Comentario,
                Campo1 = o.Campo1,
                Campo2 = o.Campo2,
                Campo3 = o.Campo3,
                Campo4 = o.Campo4,
                Campo5 = o.Campo5,
                Campo6 = o.Campo6,
                Campo7 = o.Campo7,
                Campo8 = o.Campo8,
                CoUsIn = o.CoUsIn,
                CoSucuIn = o.CoSucuIn,
                FeUsIn = o.FeUsIn,
                CoUsMo = o.CoUsMo,
                CoSucuMo = o.CoSucuMo,
                FeUsMo = o.FeUsMo,
                Revisado = o.Revisado,
                Trasnfe = o.Trasnfe,
                Validador = o.Validador,
                Rowguid = o.Rowguid,
                Nac = o.Nac,
                CoCtaIngrEgr = o.CoCtaIngrEgr,
                SaOrdenCompraReng = o.SaOrdenCompraReng
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
        public Response Save(SaOrdenCompra item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                #region Validar datos
                ValidarDatos(item, empresaDB); 
                #endregion

                #region Actualizar stock por llegar
                foreach (var iOrdCompra in item.SaOrdenCompraReng)
                {
                    iOrdCompra.CoUni = artunidad.CoUni; //;-)

                    FormattableString stockPorLlegar = $@"EXEC pStockActualizar @sCo_Alma={iOrdCompra.CoAlma.Trim()}
                    ,@sCo_Art={iOrdCompra.CoArt.Trim()}
                    ,@sCo_Uni={iOrdCompra.CoUni.Trim()}
                    ,@deCantidad={iOrdCompra.TotalArt}
                    ,@sTipoStock='LLE'
                    ,@bSumarStock={true}
                    ,@bPermiteStockNegativo={false}";
                    int result = db.Database.ExecuteSqlInterpolated(stockPorLlegar);
                }
                #endregion


                #region Consecutivo numero de orden de compra
                //string codigoConsecutivoOrdenCompra = "OCOM_NUM";
                //string numeroOrdenCompra =  new ObtenerProximoConsecutivo().GetProximoNumero(codigoConsecutivoOrdenCompra, item.CoSucuIn, empresaDB);
                string numeroOrdenCompra = item.DocNum;

                #endregion

                #region Insertar orden de compra
                item.DocNum = numeroOrdenCompra;
                item.CoCond = proveedor.CondPag;
                //item.Tasa = moneda.Cambio;
                item.Nac = proveedor.Nacional;
                db.Entry(item).State = EntityState.Added;
                #endregion

                #region Insertar renglones de ordenes de compra
                foreach (var iOrdenCompra in item.SaOrdenCompraReng)
                {
                    decimal PorcTasa = new ObtenerISV().GetTasaIva(iOrdenCompra.TipoImp, item.FecEmis, empresaDB).PorcTasa;

                    iOrdenCompra.DocNum = numeroOrdenCompra;
                    iOrdenCompra.PorcImp = PorcTasa;
                    iOrdenCompra.DesArt = !articulo.Generico ? string.Empty : iOrdenCompra.DesArt;
                    iOrdenCompra.MontoImp = iOrdenCompra.RengNeto * PorcTasa / 100;
                    db.Entry(iOrdenCompra).State = EntityState.Added;
                    item.MontoImp += iOrdenCompra.RengNeto * PorcTasa / 100;
                    item.TotalBruto += iOrdenCompra.RengNeto;
                    item.TotalNeto += iOrdenCompra.RengNeto + (iOrdenCompra.RengNeto * PorcTasa / 100);
                    item.Saldo += iOrdenCompra.RengNeto + (iOrdenCompra.RengNeto * PorcTasa / 100);

                }
                #endregion

                db.SaveChanges();

                return new Response { Status = "OK", Message = "Transacción realizada con éxito.", NroDocumentoGenerado01 = numeroOrdenCompra };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }        
        }
        #endregion

        #region Update
        public Response Update(SaOrdenCompra item, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Validar datos
        private void ValidarDatos(SaOrdenCompra obj,string empresaDB)
        {
            #region Verificar proveedor
            proveedor = new ProveedoresRepositorio().Find(obj.CoProv, empresaDB);
            if (proveedor == null) throw new ArgumentException($"El proveedor [{obj.CoProv.Trim()}] no existe.");
            if (proveedor.Inactivo) throw new ArgumentException($"El proveedor [{obj.CoProv.Trim()}] se encuentra inactivo.");
            #endregion

            #region Verificar sucursal
            SaSucursal sucu = new SucursalesRepositorio().Find(obj.CoSucuIn, empresaDB);
            if (sucu == null) throw new ArgumentException($"La sucursal [{obj.CoSucuIn.Trim()}] no existe.");
            #endregion

            #region Verificar datos en renglones
            foreach (var iReng in obj.SaOrdenCompraReng)
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
