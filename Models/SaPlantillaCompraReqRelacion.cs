using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaPlantillaCompraReqRelacion
    {
        public Guid RowguidRengReq { get; set; }
        public Guid RowguidRengImp { get; set; }
        public string CoTipoDoc { get; set; }
        public bool Entregado { get; set; }
        public DateTime? FechaRealEntrega { get; set; }
        public decimal? TotalArt { get; set; }
        public string Comentario { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }
    }
}
