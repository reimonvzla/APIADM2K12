using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaImpuestoSobreVentaReng
    {
        public DateTime Fecha { get; set; }
        public int RengNum { get; set; }
        public string TipoImp { get; set; }
        public bool Ventas { get; set; }
        public bool Compras { get; set; }
        public bool ConsumoSuntuario { get; set; }
        public decimal PorcTasa { get; set; }
        public decimal PorcSuntuario { get; set; }
        public string CoUsIn { get; set; }
        public string CoSucuIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaImpuestoSobreVenta FechaNavigation { get; set; }
    }
}
