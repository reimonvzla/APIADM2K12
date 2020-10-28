using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaPagoTpreng
    {
        public int RengNum { get; set; }
        public string CobNum { get; set; }
        public string FormaPag { get; set; }
        public string CodCta { get; set; }
        public string CodCaja { get; set; }
        public string MovNumC { get; set; }
        public string MovNumB { get; set; }
        public string NumDoc { get; set; }
        public bool Devuelto { get; set; }
        public decimal MontDoc { get; set; }
        public DateTime FechaChe { get; set; }
        public string CoSucuIn { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoSucuMo { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaPago CobNumNavigation { get; set; }
        public virtual SaCaja CodCajaNavigation { get; set; }
        public virtual SaCuentaBancaria CodCtaNavigation { get; set; }
        public virtual SaMovimientoBanco MovNumBNavigation { get; set; }
        public virtual SaMovimientoCaja MovNumCNavigation { get; set; }
    }
}
