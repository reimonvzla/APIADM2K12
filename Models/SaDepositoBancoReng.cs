using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaDepositoBancoReng
    {
        public string DepNum { get; set; }
        public int RengNum { get; set; }
        public string Codigo { get; set; }
        public string MovAfecC { get; set; }
        public string MovGeneC { get; set; }
        public decimal Monto { get; set; }
        public decimal Comision { get; set; }
        public decimal Impuesto { get; set; }
        public string TipoPlazo { get; set; }
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaCaja CodigoNavigation { get; set; }
        public virtual SaDepositoBanco DepNumNavigation { get; set; }
        public virtual SaMovimientoCaja MovAfecCNavigation { get; set; }
        public virtual SaMovimientoCaja MovGeneCNavigation { get; set; }
    }
}
