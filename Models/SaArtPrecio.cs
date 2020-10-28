using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtPrecio
    {
        public string CoArt { get; set; }
        public string CoPrecio { get; set; }
        public string CoAlmaCalculado { get; set; }
        public DateTime Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public string CoAlma { get; set; }
        public decimal Monto { get; set; }
        public decimal? Montoadi1 { get; set; }
        public decimal? Montoadi2 { get; set; }
        public decimal? Montoadi3 { get; set; }
        public decimal? Montoadi4 { get; set; }
        public decimal? Montoadi5 { get; set; }
        public bool PrecioOm { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public string CoMone { get; set; }
        public bool Inactivo { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaAlmacen CoAlmaNavigation { get; set; }
        public virtual SaArticulo CoArtNavigation { get; set; }
        public virtual SaTipoPrecio CoPrecioNavigation { get; set; }
    }
}
