using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaPlantillaCompraReqRenglon
    {
        public Guid RowguidPlantillaRenglon { get; set; }
        public DateTime? FechaRequerida { get; set; }
        public DateTime? FechaRealEntrega { get; set; }
        public string Comentario { get; set; }
        public bool Satisface { get; set; }
        public string Estatus { get; set; }
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

        public virtual SaPlantillaCompraReng RowguidPlantillaRenglonNavigation { get; set; }
    }
}
