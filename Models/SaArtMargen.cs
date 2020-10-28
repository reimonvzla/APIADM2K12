using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtMargen
    {
        public string CoArt { get; set; }
        public string CoPrecio { get; set; }
        public decimal MontoMin { get; set; }
        public decimal MontoMax { get; set; }
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

        public virtual SaArticulo CoArtNavigation { get; set; }
        public virtual SaTipoPrecio CoPrecioNavigation { get; set; }
    }
}
