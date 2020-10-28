using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaDocumentoElectronico
    {
        public string CoDocElec { get; set; }
        public string DesDocElec { get; set; }
        public DateTime FecDocElec { get; set; }
        public string CoGrupoRep { get; set; }
        public string CoReporte { get; set; }
        public string SpDocElec { get; set; }
        public string DocNumDesde { get; set; }
        public string DocNumHasta { get; set; }
        public DateTime? FecEmisDesde { get; set; }
        public DateTime? FecEmisHasta { get; set; }
        public DateTime? FecVencDesde { get; set; }
        public DateTime? FecVencHasta { get; set; }
        public string CoCliDesde { get; set; }
        public string CoCliHasta { get; set; }
        public string CoProvDesde { get; set; }
        public string CoProvHasta { get; set; }
        public string Status { get; set; }
        public int? TipoDocSalida { get; set; }
        public bool Enviarcorreo { get; set; }
        public bool Mantenerarchivos { get; set; }
        public string RutaArch { get; set; }
        public string CorreoAsunto { get; set; }
        public string CorreoCc { get; set; }
        public string CorreoBcc { get; set; }
        public string CorreoCuerpo { get; set; }
        public string CorreoFirma { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid? Rowguid { get; set; }
        public bool Procesado { get; set; }
        public string Log { get; set; }
        public string TipoDocumento { get; set; }
    }
}
