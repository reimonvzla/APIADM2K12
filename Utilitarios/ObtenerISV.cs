namespace APIADM2K12.Utilitarios
{
    using System;
    using System.Linq;
    using Models;
    using Repositorio;

    public class ObtenerISV
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region GetTasaIva
        public SaImpuestoSobreVentaReng GetTasaIva(string tipoImp, DateTime fecha, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));

            var Qry = (from p in db.SaImpuestoSobreVentaReng
                       where p.TipoImp == tipoImp && p.Fecha <= fecha
                       orderby p.Fecha descending
                       select p)
                       .FirstOrDefault();
            
            if (Qry == null) throw new ArgumentException($"El tipo de impuesto [{tipoImp.Trim()}] indicado no existe.");
            
            return Qry;
        } 
        #endregion
    
    }
}
