using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaCobroRetenIvaReng
    {
        public int RengNum { get; set; }
        public Guid RowguidRengCob { get; set; }
        public string RifContribuyente { get; set; }
        public decimal PeriodoImpositivo { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string TipoOperacion { get; set; }
        public string TipoDocumento { get; set; }
        public string RifComprador { get; set; }
        public string NumeroDocumento { get; set; }
        public string NumeroControlDocumento { get; set; }
        public decimal MontoDocumento { get; set; }
        public decimal BaseImponible { get; set; }
        public decimal MontoRetImp { get; set; }
        public string NumeroDocumentoAfectado { get; set; }
        public string NumComprobante { get; set; }
        public decimal MontoExcento { get; set; }
        public decimal Alicuota { get; set; }
        public bool RetenTercero { get; set; }
        public string NumeroExpediente { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaCobroDocReng RowguidRengCobNavigation { get; set; }
    }
}
