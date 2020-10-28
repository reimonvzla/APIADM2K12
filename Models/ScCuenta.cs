using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class ScCuenta
    {
        public string CoCue { get; set; }
        public string DesCue { get; set; }
        public bool Detalle { get; set; }
        public bool AjIslr { get; set; }
        public int MeIslr { get; set; }
        public bool AjDpc { get; set; }
        public int MeDpc { get; set; }
        public int Opciones { get; set; }
        public decimal? SaldoIni { get; set; }
        public decimal Saldan { get; set; }
        public string CentroCo { get; set; }
        public bool MonedaAdi { get; set; }
        public bool ManAux { get; set; }
        public string Tipoaux { get; set; }
        public bool ManDoc { get; set; }
        public bool ManFecdoc { get; set; }
        public bool CueGasto { get; set; }
        public string CoGas { get; set; }
        public bool ManAdi { get; set; }
        public string CoTab { get; set; }
        public bool ManAdi2 { get; set; }
        public string CoTab2 { get; set; }
        public bool ManAdi3 { get; set; }
        public string CoTab3 { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public bool Inactivo { get; set; }
        public DateTime? FecInac { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoCuepadre { get; set; }
        public int TipoPat { get; set; }
        public bool FlujoEfe { get; set; }
        public bool? AfectaPm { get; set; }
        public int TipoInv { get; set; }
        public int IpcIslr { get; set; }
        public int IpcDpc { get; set; }
        public bool ExcPat { get; set; }
        public int MesesRotacion { get; set; }
        public byte[] Validador { get; set; }
    }
}
