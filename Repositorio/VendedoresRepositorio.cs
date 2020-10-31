namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Models;

    public class VendedoresRepositorio : IRepositorio<SaVendedor>
    {

        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public SaVendedor Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaVendedor.FirstOrDefault(v => v.CoVen.Trim() == key.Trim());
        } 
        #endregion

        #region GetAll
        public IEnumerable<SaVendedor> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaVendedor.ToList();
        }
        #endregion

        #region Remove
        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(SaVendedor item, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Update
        public Response Update(SaVendedor item, string empresaDB)
        {
            throw new NotImplementedException();
        } 
        #endregion
    }
}
