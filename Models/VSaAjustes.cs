using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class VSaAjustes
    {
        public string AjueNum { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public string CoMone { get; set; }
        public decimal Tasa { get; set; }
        public int? SerialesS { get; set; }
        public int? SerialesE { get; set; }
        public bool Anulado { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoInvfisico { get; set; }
        public int? Numcom { get; set; }
        public decimal? Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string CoUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuIn { get; set; }
        public string CoSucuMo { get; set; }
    }
}
