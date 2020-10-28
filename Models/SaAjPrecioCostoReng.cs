using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaAjPrecioCostoReng
    {
        public string CodAjuste { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public decimal Monto { get; set; }
        public DateTime Desde { get; set; }
        public DateTime? Hasta { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaAjPrecioCostoM CodAjusteNavigation { get; set; }
    }
}
