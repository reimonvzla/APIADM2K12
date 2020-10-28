using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtUbicacion
    {
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public string CoUbicacion { get; set; }
        public string CoUbicacion2Calculado { get; set; }
        public string CoUbicacion3Calculado { get; set; }
        public int Orden { get; set; }
        public string CoUbicacion2 { get; set; }
        public string CoUbicacion3 { get; set; }
        public string DesUbicacion { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid? Rowguid { get; set; }

        public virtual SaAlmacen CoAlmaNavigation { get; set; }
        public virtual SaArticulo CoArtNavigation { get; set; }
        public virtual SaUbicacion CoUbicacion2Navigation { get; set; }
        public virtual SaUbicacion CoUbicacion3Navigation { get; set; }
        public virtual SaUbicacion CoUbicacionNavigation { get; set; }
    }
}
