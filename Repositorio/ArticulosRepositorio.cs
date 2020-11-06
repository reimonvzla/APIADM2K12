namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class ArticulosRepositorio : IRepositorio<SaArticulo>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public SaArticulo Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaArticulo.FirstOrDefault(a => a.CoArt.Trim() == key.Trim());
        }
        #endregion

        #region GetAll
        public IEnumerable<SaArticulo> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaArticulo.ToList();
        }
        #endregion

        #region Remove
        public Response Remove(string key, string user, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                SaArticulo data = Find(key, empresaDB);
                data.Anulado = true;
                data.FechaInac = DateTime.Now;
                data.CoUsMo = user;
                data.FeUsMo = DateTime.Now;
                db.Entry(data).State = EntityState.Modified;
                db.SaveChanges();
                return new Response { Status = "OK", Message = $"Se inactivó el artículo {data.CoArt.Trim()} con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Save
        public Response Save(SaArticulo item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                SaArticulo existArticulo = Find(item.CoArt, empresaDB);
                if (existArticulo != null)
                {
                    return Update(item, empresaDB);
                }
                else
                {
                    item.Garantia = "n/a";
                    db.Entry(item).State = EntityState.Added;
                    db.SaveChanges();

                    SaveArtCaracteristicas(item, empresaDB);
                    SaveArtUnidad(item, empresaDB);
                    SaveArtPrecio(item, empresaDB);

                    return new Response { Status = "OK", Message = $"Se ha registrado el artículo ID: [{item.CoArt.Trim()}]" };
                }
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region SaArtUnidad
        private void SaveArtUnidad(SaArticulo art, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

            db.Entry(
                new SaArtUnidad
                {
                    #region Campos
                    CoArt = art.CoArt,
                    CoUni = art.Campo8,
                    Relacion = true,
                    Equivalencia = 1,
                    UsoVenta = true,
                    UsoCompra = true,
                    UniPrincipal = true,
                    UsoPrincipal = true,
                    CoUsIn = art.CoUsIn,
                    FeUsIn = art.FeUsIn,
                    CoSucuIn = art.CoSucuIn,
                    CoUsMo = art.CoUsMo,
                    FeUsMo = art.FeUsMo,
                    CoSucuMo = art.CoSucuMo
                    #endregion
                })
                .State = EntityState.Added;
            db.SaveChanges();
        }
        #endregion

        #region Update
        public Response Update(SaArticulo item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                var Qry = db.SaArticulo.FirstOrDefault(a => a.CoArt.Trim() == item.CoArt.Trim());
                Qry.ArtDes = item.ArtDes;
                Qry.CoUsMo = item.CoUsIn;
                Qry.FeUsMo = item.FeUsIn;
                Qry.MontComi = item.MontComi;

                db.Entry(Qry).State = EntityState.Modified;
                db.SaveChanges();
                
                UpdateSaArtPrecio(item, empresaDB);

                return new Response { Status = "OK", Message = "Actualización realizada con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }

        }
        #endregion

        #region SaveArtCaracteristicas
        private void SaveArtCaracteristicas(SaArticulo item, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

            SaArtCaracteristica articuloC = new SaArtCaracteristica();
            articuloC.CoArt = item.CoArt;
            articuloC.CoUsIn = item.CoUsIn;
            articuloC.FeUsIn = item.FeUsIn;
            articuloC.CoUsMo = item.CoUsMo;
            articuloC.FeUsMo = item.FeUsMo;
            articuloC.SinDerCreFis = false;
            articuloC.CreditoFiscal = 1;
            db.Entry(articuloC).State = EntityState.Added;
            db.SaveChanges();
        }
        #endregion

        #region SaveSaArtPrecio
        private void SaveArtPrecio(SaArticulo art, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

            FormattableString saArtPrecio = $@"EXEC pInsertarRenglonesPrecioArticulo @iRENG_NUM=1
                        ,@demonto={art.MontComi},@dhasta=default,@sco_art={art.CoArt.Trim()}
                        ,@sCo_Precio='01',@sCo_Alma='TODOS',@dDesde='2020-01-01 00:00:00'
                        ,@bPrecioOm=0,@bInactivo=0,@sCo_Mone={db.ParEmp.FirstOrDefault().GMoneda.Trim()}
                        ,@sREVISADO=NULL,@sTRASNFE=NULL
                        ,@sco_sucu_in={art.CoSucuIn.Trim()},@sco_us_in={art.CoUsIn.Trim()},@sMaquina=''";
            db.Database.ExecuteSqlInterpolated(saArtPrecio);

            #region MyRegion
            //db.Entry(
            //    new SaArtPrecio
            //    {
            //        #region Campos
            //        CoArt = art.CoArt,
            //        CoPrecio = "01",
            //        //CoAlmaCalculado = DBNull.Value.ToString(),
            //        CoAlma = DBNull.Value.ToString(),
            //        Desde = Convert.ToDateTime("01/01/2020"),
            //        Monto = art.MontComi,
            //        CoUsIn = art.CoUsIn,
            //        CoSucuIn = art.CoSucuIn,
            //        FeUsIn = art.FeUsIn,
            //        CoUsMo = art.CoUsMo,
            //        CoSucuMo = art.CoSucuMo,
            //        FeUsMo = art.FeUsMo
            //        #endregion
            //    })
            //    .State = EntityState.Added;
            //db.SaveChanges(); 
            #endregion

            #region Actualizar articulo campos utilizados temporalmente
            art.MontComi = 0;
            art.Campo8 = null;
            db.Entry(art).State = EntityState.Modified;
            db.SaveChanges(); 
            #endregion
        }
        #endregion

        #region UpdateSaArtPrecio
        private void UpdateSaArtPrecio(SaArticulo item, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

            FormattableString saArtPrecio = $@"EXEC pActualizarRenglonesPrecioArticulo @iRENG_NUM=1
                        ,@iReng_NumOri=1,@demonto={item.MontComi},@dhasta=default,@sco_art={item.CoArt.Trim()}
                        ,@sCo_ArtOri={item.CoArt.Trim()},@sCo_Precio='01',@sCo_PrecioOri='01',@sCo_Alma='TODOS'
                        ,@sCo_AlmaOri='TODOS',@sCo_Alma_CalculadoOri='TODOS',@dDesdeOri='2020-01-01 00:00:00'
                        ,@dDesde='2020-01-01 00:00:00',@bprecioOmOri=0
                        ,@bPrecioOm=0,@bInactivo=0,@sCo_Mone={db.ParEmp.FirstOrDefault().GMoneda.Trim()}
                        ,@sREVISADO=NULL,@sTRASNFE=NULL
                        ,@sco_sucu_mo={item.CoSucuIn.Trim()},@sco_us_mo={item.CoUsIn.Trim()},@sMaquina=''";
            db.Database.ExecuteSqlInterpolated(saArtPrecio);

            #region MyRegion
            //db.Entry(
            //    new SaArtPrecio
            //    {
            //        #region Campos
            //        CoArt = item.CoArt,
            //        CoPrecio = "01",
            //        Monto = item.MontComi,
            //        Desde = Convert.ToDateTime("01/01/2020"),
            //        CoUsMo = item.CoUsIn,
            //        CoSucuMo = item.CoSucuIn,
            //        FeUsMo = DateTime.Now
            //        #endregion

            //    }).State = EntityState.Modified;
            //db.SaveChanges(); 
            #endregion

            #region Actualizar articulo campos utilizados temporalmente
            var Qry = db.SaArticulo.FirstOrDefault(a => a.CoArt.Trim() == item.CoArt.Trim());
            Qry.MontComi = 0;
            Qry.Campo8 = null;
            db.Entry(Qry).State = EntityState.Modified;
            db.SaveChanges(); 
            #endregion
        }
        #endregion

        #region Unidades de articulos
        public List<SaArtUnidad> GetAllArtUnidad(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaArtUnidad.ToList();
        }
        #endregion

        #region Tabla unidades
        public List<SaUnidad> GetAllUnidades(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaUnidad.ToList();
        }
        #endregion

    }
}
