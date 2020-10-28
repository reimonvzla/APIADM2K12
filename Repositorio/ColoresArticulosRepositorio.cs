namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Models;

    public class ColoresArticulosRepositorio : IRepositorio<SaColor>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        public SaColor Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaColor.Select(c => new SaColor
            {
                #region Campos
                CoColor = c.CoColor,
                DesColor = c.DesColor,
                CampoAdic = c.CampoAdic,
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
                Trasnfe = c.Trasnfe,
                Validador = c.Validador,
                Rowguid = c.Rowguid,
                SaArticulo = c.SaArticulo
                #endregion
            
            }).FirstOrDefault(c => c.CoColor.Trim() == key.Trim());
            return Qry;
        }

        public IEnumerable<SaColor> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaColor.Select(c => new SaColor
            {
                #region Campos
                CoColor = c.CoColor,
                DesColor = c.DesColor,
                CampoAdic = c.CampoAdic,
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
                Trasnfe = c.Trasnfe,
                Validador = c.Validador,
                Rowguid = c.Rowguid,
                SaArticulo = c.SaArticulo 
                #endregion

            }).ToList();
            return Qry;
        }

        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(SaColor item, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Update(SaColor item, string empresaDB)
        {
            throw new NotImplementedException();
        }
    }
}
