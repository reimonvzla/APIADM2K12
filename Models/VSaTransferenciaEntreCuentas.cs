using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaTransferenciaEntreCuentas
    {
        public string CoTransBan { get; set; }
        public string DesTransBan { get; set; }
        public DateTime Fecha { get; set; }
        public bool Procesado { get; set; }
        public decimal Monto { get; set; }
        public decimal? Comision { get; set; }
        public string CtaOrigen { get; set; }
        public string CtaIngrEgrOrigen { get; set; }
        public DateTime FechaOrigen { get; set; }
        public string MovBanOrigen { get; set; }
        public string ReferenciaOrigen { get; set; }
        public string CtaComision { get; set; }
        public string CtaIngrEgrComision { get; set; }
        public string MovBanComision { get; set; }
        public string CtaDestino { get; set; }
        public string CtaIngrEgrDestino { get; set; }
        public DateTime FechaDestino { get; set; }
        public string MovBanDestino { get; set; }
        public string ReferenciaDestino { get; set; }
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
        public Guid Rowguid { get; set; }
    }
}
