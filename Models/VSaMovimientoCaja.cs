using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaMovimientoCaja
    {
        public string MovNum { get; set; }
        public string CodCaja { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoD { get; set; }
        public decimal MontoH { get; set; }
        public bool Depositado { get; set; }
        public string DocNum { get; set; }
    }
}
