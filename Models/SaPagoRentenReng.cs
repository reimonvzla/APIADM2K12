using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaPagoRentenReng
    {
        public int RengNum { get; set; }
        public Guid RowguidRengCob { get; set; }
        public string CoIslr { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoReten { get; set; }
        public decimal MontoObj { get; set; }
        public decimal Sustraendo { get; set; }
        public decimal PorcRetn { get; set; }
        public bool Automatica { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
        public Guid? RowguidFact { get; set; }

        public virtual SaConIslr CoIslrNavigation { get; set; }
        public virtual SaPagoDocReng RowguidRengCobNavigation { get; set; }
    }
}
