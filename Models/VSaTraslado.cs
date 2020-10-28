using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaTraslado
    {
        public string TrasNum { get; set; }
        public string MotivoGlo { get; set; }
        public DateTime Fecha { get; set; }
        public string AlmOrig { get; set; }
        public string AlmDest { get; set; }
        public string Expr1 { get; set; }
        public decimal Tasa { get; set; }
        public string CoMone { get; set; }
        public string AlmTmp { get; set; }
        public decimal? MontoDist { get; set; }
        public bool Confirma { get; set; }
        public bool Anulado { get; set; }
        public int? SerialesS { get; set; }
        public int? SerialesE { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
    }
}
