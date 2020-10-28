using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtIdentificadorReng
    {
        public string CoArt { get; set; }
        public int RengNum { get; set; }
        public string CoIden { get; set; }
        public string CoUni { get; set; }
        public string DesIden { get; set; }
        public decimal Cantidad { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaArtUnidad Co { get; set; }
    }
}
