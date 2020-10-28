using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaCobroCliente
    {
        public string CobNum { get; set; }
        public string CoCli { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Recibo { get; set; }
    }
}
