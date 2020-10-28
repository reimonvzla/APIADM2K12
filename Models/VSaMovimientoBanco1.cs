using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaMovimientoBanco1
    {
        public string MovNum { get; set; }
        public string CodCta { get; set; }
        public DateTime Fecha { get; set; }
        public decimal MontoD { get; set; }
        public decimal MontoH { get; set; }
        public bool Conciliado { get; set; }
        public string DocNum { get; set; }
    }
}
