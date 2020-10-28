using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaTabuladorIslrReng
    {
        public string CoTab { get; set; }
        public int RengNum { get; set; }
        public string CoIslr { get; set; }
        public decimal PorcRet { get; set; }
        public decimal PorcImp { get; set; }
        public decimal Sustraen { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaConIslr CoIslrNavigation { get; set; }
        public virtual SaTabuladorIslr CoTabNavigation { get; set; }
    }
}
