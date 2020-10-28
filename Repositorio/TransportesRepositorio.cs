namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Models;

    public class TransportesRepositorio : IRepositorio<SaTransporte>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        public SaTransporte Find(string key, string empresaDB)
        {
            throw new NotImplementedException();
        }

        #region GetAll
        public IEnumerable<SaTransporte> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaTransporte.ToList();

        } 
        #endregion

        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(SaTransporte item, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Update(SaTransporte item, string empresaDB)
        {
            throw new NotImplementedException();
        }
    }
}
