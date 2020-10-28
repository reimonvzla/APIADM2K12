namespace APIADM2K12.Utilitarios
{
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Repositorio;
    using Models;

    public class ObtenerProximoConsecutivo
    {
        readonly ConexionAlterna conne = new ConexionAlterna();

        #region GetNumero
        public string GetProximoNumero(string codigoConsecutivo, string codigoSucursal, string empresaDB)
        {
            string proximoConsecutivo = "";
            var usaSucursal = GetUsoSucursalConsecutivoTipo(codigoConsecutivo, empresaDB).UsoSucursal;

            /*Esta propiedad no pertenece al esquema de la base de datos si a un alias creado dentro del sp q se invoca. (Se agregó al modelo)*/
            var manejaSucursal = GetUsoSucursalConsecutivoTipo(codigoConsecutivo, empresaDB).maneja_sucursal;

            if (usaSucursal && manejaSucursal)
            {
                proximoConsecutivo = GetProximoConsecutivo(codigoConsecutivo, codigoSucursal, empresaDB);
            }
            return proximoConsecutivo;
        }
        #endregion

        #region Consulta a la tabla saConsecutivoTipo para saber si el campo UsoSucursal se encuentra encendido.
        public UsoSucursalConsecutivoTipo GetUsoSucursalConsecutivoTipo(string codigoConsecutivo, string empresaDB)
        {

            using var db = new ProfitAdmin2K12(conne.GetDbContextOptions(empresaDB));

            UsoSucursalConsecutivoTipo row = new UsoSucursalConsecutivoTipo();

            var conn = db.Database.GetDbConnection();
            conn.Open();
            var command = conn.CreateCommand();
            string query = $"EXEC pSeleccionarUsoSucursalConsecutivoTipo @sCo_Consecutivo={codigoConsecutivo}";
            command.CommandText = query;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                row.UsoSucursal = reader.GetBoolean(0);
                row.maneja_sucursal = reader.GetBoolean(0);
            }
            reader.Close();
            conn.Close();

            return row;
        }
        #endregion

        #region Obtiene el próximo consecutivo de la serie en una sucursal.
        public string GetProximoConsecutivo(string codigoConsecutivo, string codigoSucursal, string empresaDB)
        {
            using var db = new ProfitAdmin2K12(conne.GetDbContextOptions(empresaDB));

            string valor = "";
            var conn = db.Database.GetDbConnection();
            conn.Open();
            var command = conn.CreateCommand();
            string query = $"EXEC pConsecutivoProximo @sCo_Consecutivo='{codigoConsecutivo.Trim()}',@sCo_Sucur='{codigoSucursal.Trim()}'";
            command.CommandText = query;
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                valor = reader.GetString(0);
            }
            reader.Close();
            conn.Close();
            return valor;
        }
        #endregion
    }
}
