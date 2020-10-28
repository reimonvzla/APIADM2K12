using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtCaracteristica
    {
        public string CoArt { get; set; }
        public string CoLin01 { get; set; }
        public string CoLin02 { get; set; }
        public string CoLin03 { get; set; }
        public string CoLin04 { get; set; }
        public string CoLin05 { get; set; }
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
        public string Transfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }
        public bool SinDerCreFis { get; set; }
        public int CreditoFiscal { get; set; }

        public virtual SaArticulo CoArtNavigation { get; set; }
        public virtual SaLineaArticulo CoLin01Navigation { get; set; }
        public virtual SaLineaArticulo CoLin02Navigation { get; set; }
        public virtual SaLineaArticulo CoLin03Navigation { get; set; }
        public virtual SaLineaArticulo CoLin04Navigation { get; set; }
        public virtual SaLineaArticulo CoLin05Navigation { get; set; }
    }
}
