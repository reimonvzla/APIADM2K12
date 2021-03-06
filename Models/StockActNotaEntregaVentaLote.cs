﻿using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class StockActNotaEntregaVentaLote
    {
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public decimal? TotalArt { get; set; }
        public string TipoStock { get; set; }
        public DateTime? Fecha { get; set; }
        public Guid Rowguid { get; set; }
        public string DocNum { get; set; }
    }
}
