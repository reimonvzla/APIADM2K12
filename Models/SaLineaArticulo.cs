using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaLineaArticulo
    {
        public SaLineaArticulo()
        {
            SaArtCaracteristicaCoLin01Navigation = new HashSet<SaArtCaracteristica>();
            SaArtCaracteristicaCoLin02Navigation = new HashSet<SaArtCaracteristica>();
            SaArtCaracteristicaCoLin03Navigation = new HashSet<SaArtCaracteristica>();
            SaArtCaracteristicaCoLin04Navigation = new HashSet<SaArtCaracteristica>();
            SaArtCaracteristicaCoLin05Navigation = new HashSet<SaArtCaracteristica>();
            SaComisionGeneracionCoLinDesdeNavigation = new HashSet<SaComisionGeneracion>();
            SaComisionGeneracionCoLinHastaNavigation = new HashSet<SaComisionGeneracion>();
            SaComisionPrecioLinea = new HashSet<SaComisionPrecioLinea>();
            SaComisionRentabLinea = new HashSet<SaComisionRentabLinea>();
            SaDescLinea = new HashSet<SaDescLinea>();
            SaSubLinea = new HashSet<SaSubLinea>();
        }

        public string CoLin { get; set; }
        public string LinDes { get; set; }
        public string DisCen { get; set; }
        public string CoImun { get; set; }
        public string CoReten { get; set; }
        public decimal ComiLin { get; set; }
        public decimal ComiLin2 { get; set; }
        public string ILinDes { get; set; }
        public bool Va { get; set; }
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
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }

        public virtual SaConIslr CoRetenNavigation { get; set; }
        public virtual ICollection<SaArtCaracteristica> SaArtCaracteristicaCoLin01Navigation { get; set; }
        public virtual ICollection<SaArtCaracteristica> SaArtCaracteristicaCoLin02Navigation { get; set; }
        public virtual ICollection<SaArtCaracteristica> SaArtCaracteristicaCoLin03Navigation { get; set; }
        public virtual ICollection<SaArtCaracteristica> SaArtCaracteristicaCoLin04Navigation { get; set; }
        public virtual ICollection<SaArtCaracteristica> SaArtCaracteristicaCoLin05Navigation { get; set; }
        public virtual ICollection<SaComisionGeneracion> SaComisionGeneracionCoLinDesdeNavigation { get; set; }
        public virtual ICollection<SaComisionGeneracion> SaComisionGeneracionCoLinHastaNavigation { get; set; }
        public virtual ICollection<SaComisionPrecioLinea> SaComisionPrecioLinea { get; set; }
        public virtual ICollection<SaComisionRentabLinea> SaComisionRentabLinea { get; set; }
        public virtual ICollection<SaDescLinea> SaDescLinea { get; set; }
        public virtual ICollection<SaSubLinea> SaSubLinea { get; set; }
    }
}
