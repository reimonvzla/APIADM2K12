using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaCostoHistoricoEntrada
    {
        public string CoArt { get; set; }
        public string CodAlmacen { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Costo { get; set; }
        public decimal CostoPro { get; set; }
        public string TipoDocS { get; set; }
        public string NroDocS { get; set; }
        public int? RengNumS { get; set; }
        public DateTime? FechaEmisionS { get; set; }
        public string TipoDocE { get; set; }
        public string NroDocE { get; set; }
        public int? RengNumE { get; set; }
        public DateTime FechaEmisionE { get; set; }
        public Guid DocOrig { get; set; }
        public decimal CantidadUsada { get; set; }
    }
}
