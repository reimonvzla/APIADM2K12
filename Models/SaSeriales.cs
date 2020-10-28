using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaSeriales
    {
        public Guid Rowguid { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public string Serial { get; set; }
        public string DocTipE { get; set; }
        public Guid? DocNumE { get; set; }
        public string DocTipS { get; set; }
        public Guid? DocNumS { get; set; }
        public int? NumGara { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }

        public virtual SaAlmacen CoAlmaNavigation { get; set; }
        public virtual SaArticulo CoArtNavigation { get; set; }
    }
}
