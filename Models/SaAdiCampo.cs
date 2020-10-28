using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaAdiCampo
    {
        public string CoAdigrupo { get; set; }
        public string CoAdicampo { get; set; }
        public string DesAdicampo { get; set; }
        public int Tipo { get; set; }
        public string ValStr { get; set; }
        public decimal? ValDecimal { get; set; }
        public DateTime? ValFecha { get; set; }
        public int? ValEntero { get; set; }
        public bool Fijo { get; set; }
        public string Observacion { get; set; }
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

        public virtual SaAdiGrupo CoAdigrupoNavigation { get; set; }
    }
}
