using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtCaracteristicaMov
    {
        public Guid RowguidDoc { get; set; }
        public string TipoDoc { get; set; }
        public string CoLin01 { get; set; }
        public string CoSubl01 { get; set; }
        public string CoLin02 { get; set; }
        public string CoSubl02 { get; set; }
        public string CoLin03 { get; set; }
        public string CoSubl03 { get; set; }
        public string CoLin04 { get; set; }
        public string CoSubl04 { get; set; }
        public string CoLin05 { get; set; }
        public string CoSubl05 { get; set; }
        public decimal Cantidad { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaSubLinea Co { get; set; }
        public virtual SaSubLinea Co1 { get; set; }
        public virtual SaSubLinea Co2 { get; set; }
        public virtual SaSubLinea Co3 { get; set; }
        public virtual SaSubLinea CoNavigation { get; set; }
    }
}
