using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaAjusteReng
    {
        public string AjueNum { get; set; }
        public int RengNum { get; set; }
        public string CoTipo { get; set; }
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public string CoUni { get; set; }
        public string ScoUni { get; set; }
        public string DisCen { get; set; }
        public decimal TotalArt { get; set; }
        public decimal StotalArt { get; set; }
        public decimal CostUnit { get; set; }
        public bool LoteAsignado { get; set; }
        public decimal CostoAdi1 { get; set; }
        public decimal CostoAdi2 { get; set; }
        public decimal CostoAdi3 { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaAjuste AjueNumNavigation { get; set; }
        public virtual SaArtUnidad Co { get; set; }
        public virtual SaAlmacen CoAlmaNavigation { get; set; }
        public virtual SaTipoAjuste CoTipoNavigation { get; set; }
        public virtual SaArtUnidad SaArtUnidad { get; set; }
    }
}
