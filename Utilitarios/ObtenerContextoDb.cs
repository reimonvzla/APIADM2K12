namespace APIADM2K12.Utilitarios
{
    using Models;
    using Repositorio;
   
    public class ObtenerContextoDb
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region GetDb
        public ProfitAdmin2K12 GetDb(string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conn.GetDbContextOptions(empresaDB));
            return db;
        } 
        #endregion

    }
}
