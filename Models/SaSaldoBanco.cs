using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaSaldoBanco
    {
        public string CodCta { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }

        public virtual SaCuentaBancaria CodCtaNavigation { get; set; }
    }
}
