namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;
    using Utilitarios;

    public class TiposClienteRepositorio : IRepositorio<SaTipoCliente>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public SaTipoCliente Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaTipoCliente.FirstOrDefault(tp => tp.TipCli.Trim() == key.Trim());
        }
        #endregion

        #region GetAll
        public IEnumerable<SaTipoCliente> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaTipoCliente.ToList();
        }
        #endregion

        #region Remove
        public Response Remove(string key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(SaTipoCliente item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                SaTipoCliente existTipCliente = Find(item.TipCli, empresaDB);
                if (existTipCliente != null)
                {
                    throw new ArgumentException($"El codigo tipo cliente '{item.TipCli.Trim()}' se encuentra registrado.");
                }
                else
                {

                    db.Entry(item).State = EntityState.Added;
                    db.SaveChanges();
                    return new Response { Status = "OK", Message = $"Se ha registrado el tipo de cliente ID: [{item.TipCli.Trim()}]" };
                }
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(SaTipoCliente item, string empresaDB)
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
