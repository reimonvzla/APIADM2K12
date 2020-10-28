using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaComisionRentabArticulo
    {
        public string CoComir { get; set; }
        public string DesComir { get; set; }
        public string TipoVen { get; set; }
        public string AplicaEn { get; set; }
        public string CoArt { get; set; }
        public decimal Hasta1 { get; set; }
        public decimal Hasta2 { get; set; }
        public decimal Hasta3 { get; set; }
        public decimal Hasta4 { get; set; }
        public decimal Hasta5 { get; set; }
        public decimal Porc1 { get; set; }
        public decimal Porc2 { get; set; }
        public decimal Porc3 { get; set; }
        public decimal Porc4 { get; set; }
        public decimal Porc5 { get; set; }
        public decimal Porc6 { get; set; }
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

        public virtual SaArticulo CoArtNavigation { get; set; }
    }
}
