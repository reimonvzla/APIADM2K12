using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaDistribCostoRelaReng
    {
        public string DistribNumDestino { get; set; }
        public int RengNumDestino { get; set; }
        public string DistribNumOrigen { get; set; }
        public int RengNumOrigen { get; set; }
        public string TipoDistrib { get; set; }
        public decimal Monto { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaDistribCostoDestinoReng SaDistribCostoDestinoReng { get; set; }
        public virtual SaDistribCostoOrigenReng SaDistribCostoOrigenReng { get; set; }
    }
}
