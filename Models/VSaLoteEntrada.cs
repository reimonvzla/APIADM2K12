using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaLoteEntrada
    {
        public Guid RowguidReng { get; set; }
        public int RengNum { get; set; }
        public string TipoDoc { get; set; }
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public string NumeroLote { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaExpiracion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal StockActual { get; set; }
        public decimal Precio { get; set; }
        public Guid Rowguid { get; set; }
    }
}
