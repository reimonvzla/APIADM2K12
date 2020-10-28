using APIADM2K12.Entidades;
using APIADM2K12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIADM2K12.Repositorio
{
    public class ProcedenciasArticulosRepositorio : IRepositorio<SaProcedencia>
    {

        readonly ConexionAlterna conn = new ConexionAlterna();
        public SaProcedencia Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaProcedencia.Select(p => new SaProcedencia
            {
                #region Campos
                CodProc = p.CodProc,
                DesProc = p.DesProc,
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
                SaArticulo = p.SaArticulo,
                #endregion
            }).FirstOrDefault(p => p.CodProc.Trim() == key.Trim());
            return Qry;
        }

        public IEnumerable<SaProcedencia> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            var Qry = db.SaProcedencia.Select(p => new SaProcedencia
            {
                #region Campos
                CodProc = p.CodProc,
                DesProc = p.DesProc,
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
                SaArticulo = p.SaArticulo, 
                #endregion
            }).ToList();
            return Qry;
        }

        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(SaProcedencia item, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Update(SaProcedencia item, string empresaDB)
        {
            throw new NotImplementedException();
        }
    }
}
