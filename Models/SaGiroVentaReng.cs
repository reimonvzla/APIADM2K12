using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaGiroVentaReng
    {
        public string CoGiro { get; set; }
        public int RengNum { get; set; }
        public string CoTipoDoc { get; set; }
        public string NroDoc { get; set; }
        public decimal MontoCob { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaGiroVenta CoGiroNavigation { get; set; }
        public virtual SaDocumentoVenta SaDocumentoVenta { get; set; }
    }
}
