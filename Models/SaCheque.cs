using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaCheque
    {
        public string CoCheq { get; set; }
        public string CoChra { get; set; }
        public string MovNum { get; set; }
        public string Status { get; set; }
        public string Descrip { get; set; }
        public DateTime? FecEmis { get; set; }
        public DateTime? FecEnt { get; set; }
        public string EntregA { get; set; }
        public string Comentario { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
        public byte[] Validador { get; set; }

        public virtual SaChequera CoChraNavigation { get; set; }
        public virtual SaMovimientoBanco MovNumNavigation { get; set; }
    }
}
