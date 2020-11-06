namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;
    using Utilitarios;

    public class PedidosVentaRepositorio : IRepositorio<SaPedidoVenta>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        SaCliente cliente;
        SaArticulo articulo;
        SaArtUnidad artunidad;
        SaMoneda moneda;
        SaTransporte transporte;

        #region Find
        public SaPedidoVenta Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaPedidoVenta.Select(p => new SaPedidoVenta
            {
                #region Campos
                DocNum = p.DocNum,
                Descrip = p.Descrip,
                CoCli = p.CoCli,
                CoTran = p.CoTran,
                CoMone = p.CoMone,
                CoVen = p.CoVen,
                CoCond = p.CoCond,
                FecEmis = p.FecEmis,
                FecVenc = p.FecVenc,
                FecReg = p.FecReg,
                Anulado = p.Anulado,
                Status = p.Status,
                NControl = p.NControl,
                VenTer = p.VenTer,
                Tasa = p.Tasa,
                PorcDescGlob = p.PorcDescGlob,
                MontoDescGlob = p.MontoDescGlob,
                PorcReca = p.PorcReca,
                MontoReca = p.MontoReca,
                TotalBruto = p.TotalBruto,
                MontoImp = p.MontoImp,
                MontoImp2 = p.MontoImp2,
                MontoImp3 = p.MontoImp3,
                Otros1 = p.Otros1,
                Otros2 = p.Otros2,
                Otros3 = p.Otros3,
                TotalNeto = p.TotalNeto,
                Saldo = p.Saldo,
                DirEnt = p.DirEnt,
                Comentario = p.Comentario,
                DisCen = p.DisCen,
                Feccom = p.Feccom,
                Numcom = p.Numcom,
                Contrib = p.Contrib,
                Impresa = p.Impresa,
                SerialesS = p.SerialesS,
                Salestax = p.Salestax,
                Impfis = p.Impfis,
                Impfisfac = p.Impfisfac,
                Campo1 = p.Campo1,
                Campo2 = p.Campo2,
                Campo3 = p.Campo3,
                Campo4 = p.Campo4,
                Campo5 = p.Campo5,
                Campo6 = p.Campo6,
                Campo7 = p.Campo7,
                Campo8 = p.Campo8,
                CoUsIn = p.CoUsIn,
                CoSucuIn = p.CoSucuIn,
                FeUsIn = p.FeUsIn,
                CoUsMo = p.CoUsMo,
                CoSucuMo = p.CoSucuMo,
                FeUsMo = p.FeUsMo,
                Revisado = p.Revisado,
                Trasnfe = p.Trasnfe,
                Validador = p.Validador,
                Rowguid = p.Rowguid,
                CoCtaIngrEgr = p.CoCtaIngrEgr,
                SaPedidoVentaReng = p.SaPedidoVentaReng
                #endregion

            }).FirstOrDefault(p => p.DocNum.Trim() == key.Trim());

            return Qry;
        }
        #endregion

        #region GetAll
        public IEnumerable<SaPedidoVenta> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaPedidoVenta.Select(p => new SaPedidoVenta
            {
                #region Campos
                DocNum = p.DocNum,
                Descrip = p.Descrip,
                CoCli = p.CoCli,
                CoTran = p.CoTran,
                CoMone = p.CoMone,
                CoVen = p.CoVen,
                CoCond = p.CoCond,
                FecEmis = p.FecEmis,
                FecVenc = p.FecVenc,
                FecReg = p.FecReg,
                Anulado = p.Anulado,
                Status = p.Status,
                NControl = p.NControl,
                VenTer = p.VenTer,
                Tasa = p.Tasa,
                PorcDescGlob = p.PorcDescGlob,
                MontoDescGlob = p.MontoDescGlob,
                PorcReca = p.PorcReca,
                MontoReca = p.MontoReca,
                TotalBruto = p.TotalBruto,
                MontoImp = p.MontoImp,
                MontoImp2 = p.MontoImp2,
                MontoImp3 = p.MontoImp3,
                Otros1 = p.Otros1,
                Otros2 = p.Otros2,
                Otros3 = p.Otros3,
                TotalNeto = p.TotalNeto,
                Saldo = p.Saldo,
                DirEnt = p.DirEnt,
                Comentario = p.Comentario,
                DisCen = p.DisCen,
                Feccom = p.Feccom,
                Numcom = p.Numcom,
                Contrib = p.Contrib,
                Impresa = p.Impresa,
                SerialesS = p.SerialesS,
                Salestax = p.Salestax,
                Impfis = p.Impfis,
                Impfisfac = p.Impfisfac,
                Campo1 = p.Campo1,
                Campo2 = p.Campo2,
                Campo3 = p.Campo3,
                Campo4 = p.Campo4,
                Campo5 = p.Campo5,
                Campo6 = p.Campo6,
                Campo7 = p.Campo7,
                Campo8 = p.Campo8,
                CoUsIn = p.CoUsIn,
                CoSucuIn = p.CoSucuIn,
                FeUsIn = p.FeUsIn,
                CoUsMo = p.CoUsMo,
                CoSucuMo = p.CoSucuMo,
                FeUsMo = p.FeUsMo,
                Revisado = p.Revisado,
                Trasnfe = p.Trasnfe,
                Validador = p.Validador,
                Rowguid = p.Rowguid,
                CoCtaIngrEgr = p.CoCtaIngrEgr,
                SaPedidoVentaReng = p.SaPedidoVentaReng
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
        public Response Save(SaPedidoVenta item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                #region Validar datos
                ValidarDatos(item, empresaDB);
                #endregion

                #region Actualizar stock comprometido
                foreach (var iPedidoReng in item.SaPedidoVentaReng)
                {
                    iPedidoReng.CoUni = artunidad.CoUni; //;-)

                    FormattableString stockComprometido = $@"EXEC pStockActualizar @sCo_Alma={iPedidoReng.CoAlma.Trim()}
                                                        ,@sCo_Art={iPedidoReng.CoArt.Trim()}
                                                        ,@sCo_Uni={iPedidoReng.CoUni.Trim()}
                                                        ,@deCantidad={iPedidoReng.TotalArt}
                                                        ,@sTipoStock='COM'
                                                        ,@bSumarStock={true}
                                                        ,@bPermiteStockNegativo={false}";
                    int result2 = db.Database.ExecuteSqlInterpolated(stockComprometido);
                }
                #endregion

                #region Consecutivo numero de pedido
                string codigoConsecutivoPedido = "PCLI_NUM";
                string numeroPedido = new ObtenerProximoConsecutivo().GetProximoNumero(codigoConsecutivoPedido, item.CoSucuIn, empresaDB);
                #endregion

                #region Insertar pedido
                item.DocNum = numeroPedido;
                item.CoCond = cliente.CondPag;
                //item.Tasa = moneda.Cambio;
                item.CoVen = cliente.CoVen;
                item.CoTran = transporte.CoTran;
                db.Entry(item).State = EntityState.Added;
                #endregion

                #region Insertar renglones de pedido
                foreach (var iPedidoReng in item.SaPedidoVentaReng)
                {
                    decimal PorcTasa = new ObtenerISV().GetTasaIva(iPedidoReng.TipoImp, item.FecEmis, empresaDB).PorcTasa;
                    
                    iPedidoReng.DocNum = numeroPedido;
                    iPedidoReng.PorcImp = PorcTasa;
                    iPedidoReng.DesArt = !articulo.Generico ? string.Empty : iPedidoReng.DesArt;
                    iPedidoReng.MontoImp = iPedidoReng.RengNeto * PorcTasa / 100;

                    db.Entry(iPedidoReng).State = EntityState.Added;
                }
                #endregion

                db.SaveChanges();

                return new Response { Status = "OK", Message = "Transacción realizada con éxito.", NroDocumentoGenerado01 = numeroPedido};

            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }

        } 
        #endregion

        #region Update
        public Response Update(SaPedidoVenta item, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Validar datos
        private void ValidarDatos(SaPedidoVenta obj, string empresaDB)
        {
            #region Verificar cliente
            cliente = new ClientesRespositorio().Find(obj.CoCli, empresaDB);
            if (cliente == null) throw new ArgumentException($"El cliente [{obj.CoCli.Trim()}] no existe.");
            if(cliente.Inactivo) throw new ArgumentException($"El cliente [{obj.CoCli.Trim()}] se encuentra inactivo.");
            #endregion

            #region Verificar sucursal
            SaSucursal sucu = new SucursalesRepositorio().Find(obj.CoSucuIn, empresaDB);
            if (sucu == null) throw new ArgumentException($"La sucursal [{obj.CoSucuIn.Trim()}] no existe.");
            #endregion

            #region Verificar datos en renglones
            foreach (var iReng in obj.SaPedidoVentaReng)
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
                    if (almacen.Noventa)
                    {
                        throw new ArgumentException($"El almacén [{iReng.CoAlma.Trim()}] suministrado en el renglón [{iReng.RengNum}] no está permitido utilizarlo en el módulo de ventas.");
                    }
                }
                #endregion
            }
            #endregion

            #region Verificar moneda
            moneda = new ObtenerMoneda().GetOtraMoneda(obj.CoMone, empresaDB);
            if (moneda == null) throw new ArgumentException($"La moneda [{obj.CoMone.Trim()}] no existe.");
            #endregion

            #region Verificar transporte
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            transporte = db.SaTransporte.FirstOrDefault(t => !string.IsNullOrEmpty(t.Campo8));
            if (transporte == null) throw new ArgumentException("No se encontró un transporte marcado en campo adicional 8...");
            #endregion

        }
        #endregion

    }
}
