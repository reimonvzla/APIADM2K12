using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaConIslr
    {
        public SaConIslr()
        {
            SaArticulo = new HashSet<SaArticulo>();
            SaCatArticulo = new HashSet<SaCatArticulo>();
            SaCobroRentenReng = new HashSet<SaCobroRentenReng>();
            SaCuentaIngEgr = new HashSet<SaCuentaIngEgr>();
            SaLineaArticulo = new HashSet<SaLineaArticulo>();
            SaOrdenPagoReng = new HashSet<SaOrdenPagoReng>();
            SaPagoRentenReng = new HashSet<SaPagoRentenReng>();
            SaSubLinea = new HashSet<SaSubLinea>();
            SaTabuladorIslrReng = new HashSet<SaTabuladorIslrReng>();
        }

        public string CoIslr { get; set; }
        public string IslrDes { get; set; }
        public string IslrDeslarga { get; set; }
        public string Numeral { get; set; }
        public string Literal { get; set; }
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

        public virtual ICollection<SaArticulo> SaArticulo { get; set; }
        public virtual ICollection<SaCatArticulo> SaCatArticulo { get; set; }
        public virtual ICollection<SaCobroRentenReng> SaCobroRentenReng { get; set; }
        public virtual ICollection<SaCuentaIngEgr> SaCuentaIngEgr { get; set; }
        public virtual ICollection<SaLineaArticulo> SaLineaArticulo { get; set; }
        public virtual ICollection<SaOrdenPagoReng> SaOrdenPagoReng { get; set; }
        public virtual ICollection<SaPagoRentenReng> SaPagoRentenReng { get; set; }
        public virtual ICollection<SaSubLinea> SaSubLinea { get; set; }
        public virtual ICollection<SaTabuladorIslrReng> SaTabuladorIslrReng { get; set; }
    }
}
