using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaImpuestoReng
    {
        public string CodImpuesto { get; set; }
        public DateTime FechaRegis { get; set; }
        public decimal ValorPorcent { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaImpuesto CodImpuestoNavigation { get; set; }
    }
}
