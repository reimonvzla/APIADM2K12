using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaSubLinea
    {
        public SaSubLinea()
        {
            SaArtCaracteristicaMovCo = new HashSet<SaArtCaracteristicaMov>();
            SaArtCaracteristicaMovCo1 = new HashSet<SaArtCaracteristicaMov>();
            SaArtCaracteristicaMovCo2 = new HashSet<SaArtCaracteristicaMov>();
            SaArtCaracteristicaMovCo3 = new HashSet<SaArtCaracteristicaMov>();
            SaArtCaracteristicaMovCoNavigation = new HashSet<SaArtCaracteristicaMov>();
            SaArticulo = new HashSet<SaArticulo>();
        }

        public string CoLin { get; set; }
        public string CoSubl { get; set; }
        public string SublDes { get; set; }
        public string CoImun { get; set; }
        public string CoReten { get; set; }
        public string ISublDes { get; set; }
        public bool Movil { get; set; }
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

        public virtual SaLineaArticulo CoLinNavigation { get; set; }
        public virtual SaConIslr CoRetenNavigation { get; set; }
        public virtual ICollection<SaArtCaracteristicaMov> SaArtCaracteristicaMovCo { get; set; }
        public virtual ICollection<SaArtCaracteristicaMov> SaArtCaracteristicaMovCo1 { get; set; }
        public virtual ICollection<SaArtCaracteristicaMov> SaArtCaracteristicaMovCo2 { get; set; }
        public virtual ICollection<SaArtCaracteristicaMov> SaArtCaracteristicaMovCo3 { get; set; }
        public virtual ICollection<SaArtCaracteristicaMov> SaArtCaracteristicaMovCoNavigation { get; set; }
        public virtual ICollection<SaArticulo> SaArticulo { get; set; }
    }
}
