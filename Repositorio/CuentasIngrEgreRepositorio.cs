namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class CuentasIngrEgreRepositorio : IRepositorio<SaCuentaIngEgr>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public SaCuentaIngEgr Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaCuentaIngEgr.FirstOrDefault(c => c.CoCtaIngrEgr.Trim() == key.Trim());
        }
        #endregion

        #region GetAll
        public IEnumerable<SaCuentaIngEgr> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaCuentaIngEgr.ToList();
        }
        #endregion

        #region Remove
        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(SaCuentaIngEgr item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                SaCuentaIngEgr existCuenta = Find(item.CoCtaIngrEgr, empresaDB);
                if (existCuenta != null)
                {
                    throw new ArgumentException($"El codigo de la Cuenta Ingreso/Egreso '{item.CoCtaIngrEgr.Trim()}' se encuentra registrado.");
                }
                else
                {

                    db.Entry(item).State = EntityState.Added;
                    db.SaveChanges();
                    return new Response { Status = "OK", Message = $"Se ha registrado la cuenta ingreso/egreso ID: [{item.CoCtaIngrEgr.Trim()}]" };
                }
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(SaCuentaIngEgr item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return new Response { Status = "OK", Message = "Actualización realizada con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion
    }
}
