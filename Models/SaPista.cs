using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaPista
    {
        public DateTime Fecha { get; set; }
        public string TablaOri { get; set; }
        public Guid? RowguidOri { get; set; }
        public string UsuarioId { get; set; }
        public string CoSucu { get; set; }
        public string TipoOp { get; set; }
        public string Maquina { get; set; }
        public string Campos { get; set; }
        public decimal? Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
    }
}
