using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaComisionResultado
    {
        public Guid CoComiresult { get; set; }
        public string CoGeneracion { get; set; }
        public string TablaOri { get; set; }
        public Guid IdOri { get; set; }
        public decimal? Monto01 { get; set; }
        public decimal? Monto02 { get; set; }
        public decimal? Monto03 { get; set; }
        public decimal? Monto04 { get; set; }
        public decimal? Monto05 { get; set; }
        public decimal? Monto06 { get; set; }
        public decimal? Monto07 { get; set; }
        public decimal? Monto08 { get; set; }
        public decimal? Monto09 { get; set; }
        public decimal? Monto10 { get; set; }
        public string Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string Aux03 { get; set; }
        public string Aux04 { get; set; }
        public string Aux05 { get; set; }
        public DateTime? Fecha01 { get; set; }
        public DateTime? Fecha02 { get; set; }
        public DateTime? Fecha03 { get; set; }
        public DateTime? Fecha04 { get; set; }
        public DateTime? Fecha05 { get; set; }
        public DateTime FeUsIn { get; set; }

        public virtual SaComisionGeneracion CoGeneracionNavigation { get; set; }
    }
}
