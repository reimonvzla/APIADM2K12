using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaFactCompRengPesoVolumen
    {
        public Guid RowguidDoc { get; set; }
        public decimal PesoComp { get; set; }
        public decimal VolumenComp { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }

        public virtual SaFacturaCompraReng RowguidDocNavigation { get; set; }
    }
}
