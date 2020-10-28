namespace APIADM2K12.Repositorio
{
    using System;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Models;

    public class ConexionAlterna
    {
        #region Conexion Core 3.x
        internal DbContextOptions<ProfitAdmin2K12> GetDbContextOptions(string dataBase)
        {
            /*Buscar el servidor en appsetting.json*/
            /*R.M.: 02/10/2020*/

            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            string DataSource = configuration["Servidor"];
            String connString = $"Server={DataSource};Database={dataBase};User Id=profit;Password=profit;";

            return new DbContextOptionsBuilder<ProfitAdmin2K12>()
                  .UseSqlServer(connString).Options;

        }
        #endregion
    }
}
