using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaConciliacionAutoReng
    {
        public SaConciliacionAutoReng()
        {
            SaConciliacionDetalle = new HashSet<SaConciliacionDetalle>();
        }

        public string CoAutoCon { get; set; }
        public string CodCta { get; set; }
        public int MesArchivo { get; set; }
        public int AnoArchivo { get; set; }
        public DateTime FecImpor { get; set; }
        public string Status { get; set; }
        public byte[] Archivo { get; set; }
        public decimal SaldoEc { get; set; }
        public int TamanoPaquete { get; set; }
        public int TotalMov { get; set; }
        public int TotalCon { get; set; }
        public int TotalRep { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaCuentaBancaria CodCtaNavigation { get; set; }
        public virtual ICollection<SaConciliacionDetalle> SaConciliacionDetalle { get; set; }
    }
}
