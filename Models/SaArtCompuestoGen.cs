using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtCompuestoGen
    {
        public SaArtCompuestoGen()
        {
            SaArtCompuestoGenReng = new HashSet<SaArtCompuestoGenReng>();
        }

        public string GeneNum { get; set; }
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public string CoUni { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Tasa { get; set; }
        public string CoMone { get; set; }
        public string DisCen { get; set; }
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }
        public decimal TotalArt { get; set; }
        public decimal StotalArt { get; set; }
        public decimal CostoTot { get; set; }
        public bool GeneArt { get; set; }
        public int? SerialesS { get; set; }
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
        public string ScoUni { get; set; }

        public virtual SaArtUnidad Co { get; set; }
        public virtual SaAlmacen CoAlmaNavigation { get; set; }
        public virtual SaArtCompuesto CoArtNavigation { get; set; }
        public virtual SaMoneda CoMoneNavigation { get; set; }
        public virtual ICollection<SaArtCompuestoGenReng> SaArtCompuestoGenReng { get; set; }
    }
}
