namespace APIADM2K12.Repositorio
{
    using System.Collections.Generic;
    using Entidades;

    interface IRepositorio<T> where T : class
    {
        #region GetAll
        IEnumerable<T> GetAll(string empresaDB);
        #endregion

        #region Find
        T Find(string key, string empresaDB);
        #endregion

        #region Save
        Response Save(T item, string empresaDB);
        #endregion

        #region Remove
        Response Remove(string key, string user, string empresaDB);
        #endregion

        #region Update
        Response Update(T item, string empresaDB); 
        #endregion
    }
}
