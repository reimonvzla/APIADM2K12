namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Models;


    public class UbicacionesArticulosRespositorio : IRepositorio<SaUbicacion>
    {

        readonly ConexionAlterna conn = new ConexionAlterna();
        
        public SaUbicacion Find(string key, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaUbicacion> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaUbicacion.ToList();
        }

        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(SaUbicacion item, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Update(SaUbicacion item, string empresaDB)
        {
            throw new NotImplementedException();
        }
    }
}
