using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaResInventarioReng
    {
        public string NumResinv { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoUni { get; set; }
        public string ScoUni { get; set; }
        public decimal TotalArtTeo { get; set; }
        public decimal TotalArt { get; set; }
        public decimal StotalArtTeo { get; set; }
        public decimal StotalArt { get; set; }
        public decimal CostUnit { get; set; }
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

        public virtual SaArtUnidad Co { get; set; }
        public virtual SaResInventario NumResinvNavigation { get; set; }
        public virtual SaArtUnidad SaArtUnidad { get; set; }
    }
}
