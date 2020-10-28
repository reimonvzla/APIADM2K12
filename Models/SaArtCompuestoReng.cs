using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtCompuestoReng
    {
        public string CoArtc { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoUni { get; set; }
        public decimal TotalArt { get; set; }
        public string ScoUni { get; set; }
        public decimal StotalArt { get; set; }
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
        public virtual SaArtCompuesto CoArtcNavigation { get; set; }
    }
}
