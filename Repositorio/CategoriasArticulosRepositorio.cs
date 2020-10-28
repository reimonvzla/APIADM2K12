namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Models;

    public class CategoriasArticulosRepositorio : IRepositorio<SaCatArticulo>
    {

        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public SaCatArticulo Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaCatArticulo.Select(c => new SaCatArticulo
            {
                #region Campo
                CoCat = c.CoCat,
                CatDes = c.CatDes,
                CoImun = c.CoImun,
                CoReten = c.CoReten,
                Feccom = c.Feccom,
                Numcom = c.Numcom,
                DisCen = c.DisCen,
                Movil = c.Movil,
                Campo1 = c.Campo1,
                Campo2 = c.Campo2,
                Campo3 = c.Campo3,
                Campo4 = c.Campo4,
                Campo5 = c.Campo5,
                Campo6 = c.Campo6,
                Campo7 = c.Campo7,
                Campo8 = c.Campo8,
                CoUsIn = c.CoUsIn,
                CoSucuIn = c.CoSucuIn,
                FeUsIn = c.FeUsIn,
                CoUsMo = c.CoUsMo,
                CoSucuMo = c.CoSucuMo,
                FeUsMo = c.FeUsMo,
                Revisado = c.Revisado,
                Trasnfe = c.Revisado,
                Validador = c.Validador,
                Rowguid = c.Rowguid
                #endregion

            }).FirstOrDefault(c => c.CoCat.Trim() == key.Trim());
            return Qry;
        }

        #endregion

        #region GetAll
        public IEnumerable<SaCatArticulo> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaCatArticulo.Select(c => new SaCatArticulo
            {
                #region Campo
                CoCat = c.CoCat,
                CatDes = c.CatDes,
                CoImun = c.CoImun,
                CoReten = c.CoReten,
                Feccom = c.Feccom,
                Numcom = c.Numcom,
                DisCen = c.DisCen,
                Movil = c.Movil,
                Campo1 = c.Campo1,
                Campo2 = c.Campo2,
                Campo3 = c.Campo3,
                Campo4 = c.Campo4,
                Campo5 = c.Campo5,
                Campo6 = c.Campo6,
                Campo7 = c.Campo7,
                Campo8 = c.Campo8,
                CoUsIn = c.CoUsIn,
                CoSucuIn = c.CoSucuIn,
                FeUsIn = c.FeUsIn,
                CoUsMo = c.CoUsMo,
                CoSucuMo = c.CoSucuMo,
                FeUsMo = c.FeUsMo,
                Revisado = c.Revisado,
                Trasnfe = c.Revisado,
                Validador = c.Validador,
                Rowguid = c.Rowguid
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
        public Response Save(SaCatArticulo item, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Update
        public Response Update(SaCatArticulo item, string empresaDB)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
