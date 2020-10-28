using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaConcBanco
    {
        public string CoAutoCon { get; set; }
        public int RengNum { get; set; }
        public string MovNum { get; set; }
        public DateTime FecConc { get; set; }
        public bool ConAuto { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaMovimientoBanco MovNumNavigation { get; set; }
        public virtual SaConciliacionDetalle SaConciliacionDetalle { get; set; }
    }
}
