using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaImpMun
    {
        public string CoImun { get; set; }
        public string CoSucur { get; set; }
        public string ImpDes { get; set; }
        public string NAct { get; set; }
        public decimal Alicuota { get; set; }
        public decimal MTrib { get; set; }
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

        public virtual SaSucursal CoSucurNavigation { get; set; }
    }
}
