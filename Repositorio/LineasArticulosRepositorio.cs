namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Models;

    public class LineasArticulosRepositorio : IRepositorio<SaLineaArticulo>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public SaLineaArticulo Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaLineaArticulo.Select(l => new SaLineaArticulo
            {
                #region Campos
                CoLin = l.CoLin,
                LinDes = l.LinDes,
                DisCen = l.DisCen,
                CoImun = l.CoImun,
                CoReten = l.CoReten,
                ComiLin = l.ComiLin,
                ComiLin2 = l.ComiLin2,
                ILinDes = l.ILinDes,
                Va = l.Va,
                Movil = l.Movil,
                Campo1 = l.Campo1,
                Campo2 = l.Campo2,
                Campo3 = l.Campo3,
                Campo4 = l.Campo4,
                Campo5 = l.Campo5,
                Campo6 = l.Campo6,
                Campo7 = l.Campo7,
                Campo8 = l.Campo8,
                CoUsIn = l.CoUsIn,
                CoSucuIn = l.CoSucuIn,
                FeUsIn = l.FeUsIn,
                CoUsMo = l.CoUsMo,
                CoSucuMo = l.CoSucuMo,
                FeUsMo = l.FeUsMo,
                Revisado = l.Revisado,
                Trasnfe = l.Trasnfe,
                Validador = l.Validador,
                Rowguid = l.Rowguid,
                Feccom = l.Feccom,
                Numcom = l.Numcom,
                SaSubLinea = l.SaSubLinea
                #endregion

            }).FirstOrDefault(l => l.CoLin.Trim() == key.Trim());

            return Qry;
        }
        #endregion

        #region GetAll
        public IEnumerable<SaLineaArticulo> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaLineaArticulo.Select(l => new SaLineaArticulo
            {
                #region Campos
                CoLin = l.CoLin,
                LinDes = l.LinDes,
                DisCen = l.DisCen,
                CoImun = l.CoImun,
                CoReten = l.CoReten,
                ComiLin = l.ComiLin,
                ComiLin2 = l.ComiLin2,
                ILinDes = l.ILinDes,
                Va = l.Va,
                Movil = l.Movil,
                Campo1 = l.Campo1,
                Campo2 = l.Campo2,
                Campo3 = l.Campo3,
                Campo4 = l.Campo4,
                Campo5 = l.Campo5,
                Campo6 = l.Campo6,
                Campo7 = l.Campo7,
                Campo8 = l.Campo8,
                CoUsIn = l.CoUsIn,
                CoSucuIn = l.CoSucuIn,
                FeUsIn = l.FeUsIn,
                CoUsMo = l.CoUsMo,
                CoSucuMo = l.CoSucuMo,
                FeUsMo = l.FeUsMo,
                Revisado = l.Revisado,
                Trasnfe = l.Trasnfe,
                Validador = l.Validador,
                Rowguid = l.Rowguid,
                Feccom = l.Feccom,
                Numcom = l.Numcom,
                SaSubLinea = l.SaSubLinea
                #endregion

            }).ToList();

            return Qry;
        }
        #endregion

        #region GetAllSublin
        public ICollection<SaSubLinea> GetAllSubLin(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaSubLinea.ToList();
        } 
        #endregion


        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(SaLineaArticulo item, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Update(SaLineaArticulo item, string empresaDB)
        {
            throw new NotImplementedException();
        }
    }
}
