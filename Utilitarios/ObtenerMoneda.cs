namespace APIADM2K12.Utilitarios
{
    using System.Linq;
    using Models;
    using Repositorio;

    public class ObtenerMoneda
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
      
        #region GetMonedaBase
        public SaMoneda GetMonedaBase(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaMoneda.FirstOrDefault(m => m.CoMone.Trim() == db.ParEmp.FirstOrDefault().GMoneda.Trim());
        } 
        #endregion

        #region GetOtraMoneda
        public SaMoneda GetOtraMoneda(string CodMoneda, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db.SaMoneda.FirstOrDefault(m => m.CoMone.Trim() == CodMoneda.Trim());
        } 
        #endregion
    }
}
