using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaUbicacion
    {
        public SaUbicacion()
        {
            SaArtUbicacionCoUbicacion2Navigation = new HashSet<SaArtUbicacion>();
            SaArtUbicacionCoUbicacion3Navigation = new HashSet<SaArtUbicacion>();
            SaArtUbicacionCoUbicacionNavigation = new HashSet<SaArtUbicacion>();
            SaArticulo = new HashSet<SaArticulo>();
            SaPlantillaCompraReq = new HashSet<SaPlantillaCompraReq>();
        }

        public string CoUbicacion { get; set; }
        public string DesUbicacion { get; set; }
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

        public virtual ICollection<SaArtUbicacion> SaArtUbicacionCoUbicacion2Navigation { get; set; }
        public virtual ICollection<SaArtUbicacion> SaArtUbicacionCoUbicacion3Navigation { get; set; }
        public virtual ICollection<SaArtUbicacion> SaArtUbicacionCoUbicacionNavigation { get; set; }
        public virtual ICollection<SaArticulo> SaArticulo { get; set; }
        public virtual ICollection<SaPlantillaCompraReq> SaPlantillaCompraReq { get; set; }
    }
}
