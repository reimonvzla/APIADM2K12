namespace APIADM2K12.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;
    using Utilitarios;

    public class ProveedoresRepositorio : IRepositorio<SaProveedor>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public SaProveedor Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaProveedor.FirstOrDefault(p => p.CoProv.Trim() == key.Trim());
        } 
        #endregion

        #region GetAll
        public IEnumerable<SaProveedor> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaProveedor.ToList();
        }
        #endregion

        #region Remove
        public Response Remove(string key, string user, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                SaProveedor data = Find(key, empresaDB);
                data.Inactivo = true;
                data.CoUsMo = user;
                data.FeUsMo = DateTime.Now;
                db.Entry(data).State = EntityState.Modified;
                db.SaveChanges();
                return new Response { Status = "OK", Message = $"Se inactivó al proveedor {data.CoProv.Trim()} {data.ProvDes.Trim()} con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion

        #region Save
        public Response Save(SaProveedor item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

                SaProveedor existProveedor = Find(item.CoProv, empresaDB);
                if (existProveedor != null)
                {
                    throw new ArgumentException($"El codigo proveedor '{item.CoProv.Trim()}' se encuentra registrado.");
                }
                else
                {
                    #region Proveedor rapido como configuracion de nuevos proveedores
                    //ParEmp proveedorRapido = db.ParEmp.FirstOrDefault();
                    //if (string.IsNullOrEmpty(proveedorRapido.CTipPro)) throw new ArgumentException("No existe configurado el tipo de proveedor en parametros de la empresa (Proveedor rápido).");
                    //if (string.IsNullOrEmpty(proveedorRapido.CCondPago)) throw new ArgumentException("No existe configurado la condicion de pago en parametros de la empresa (Proveedor rápido).");
                    //if (string.IsNullOrEmpty(proveedorRapido.CCtaIngEgr)) throw new ArgumentException("No existe configurado la cuenta ingreso/egreso en parametros de la empresa (Proveedor rápido).");
                    //if (string.IsNullOrEmpty(proveedorRapido.CCoSeg)) throw new ArgumentException("No existe configurado el segmento en parametros de la empresa (Proveedor rápido).");
                    //if (string.IsNullOrEmpty(proveedorRapido.CCoZon)) throw new ArgumentException("No existe configurado la zona en parametros de la empresa (Proveedor rápido).");
                    //if (string.IsNullOrEmpty(proveedorRapido.CTipoPer)) throw new ArgumentException("No existe configurado el tipo de persona en parametros de la empresa (Proveedor rápido).");
                    #endregion

                    //item.TipPro = proveedorRapido.CTipPro;
                    //item.CondPag = proveedorRapido.CCondPago;
                    //item.CoCtaIngrEgr = proveedorRapido.CCtaIngEgr;
                    //item.CoSeg = proveedorRapido.CCoSeg;
                    //item.CoZon = proveedorRapido.CCoZon;
                    //item.TipoPer = proveedorRapido.CTipoPer;
                    item.FechaReg = DateTime.Now;
                    //item.CoMone = proveedorRapido.GMoneda;
                    //item.CoTab = null;

                    db.Entry(item).State = EntityState.Added;
                    db.SaveChanges();
                    return new Response { Status = "OK", Message = $"Se ha registrado el proveedor ID: [{item.CoProv.Trim()}]" };
                }
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(SaProveedor item, string empresaDB)
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
