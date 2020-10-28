namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;
    using Utilitarios;

    public class TiposProveedorRepositorio : IRepositorio<SaTipoProveedor>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public SaTipoProveedor Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaTipoProveedor.FirstOrDefault(tp => tp.TipPro.Trim() == key.Trim());
        }
        #endregion

        #region GetAll
        public IEnumerable<SaTipoProveedor> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaTipoProveedor.ToList();
        }
        #endregion

        #region Remove
        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(SaTipoProveedor item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                SaTipoProveedor existTipProveedor = Find(item.TipPro, empresaDB);
                if (existTipProveedor != null)
                {
                    throw new ArgumentException($"El codigo tipo proveedor '{item.TipPro.Trim()}' se encuentra registrado.");
                }
                else
                {

                    db.Entry(item).State = EntityState.Added;
                    db.SaveChanges();
                    return new Response { Status = "OK", Message = $"Se ha registrado el tipo de proveedor ID: [{item.TipPro.Trim()}]" };
                }
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion

        #region Update
        public Response Update(SaTipoProveedor item, string empresaDB)
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
