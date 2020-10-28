using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtRelacionadoReng
    {
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CodRelac { get; set; }
        public decimal? Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaArticulo CoArtNavigation { get; set; }
        public virtual SaArticulo CodRelacNavigation { get; set; }
    }
}
