using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaTransporte
    {
        public SaTransporte()
        {
            SaCotizacionCliente = new HashSet<SaCotizacionCliente>();
            SaDevolucionCliente = new HashSet<SaDevolucionCliente>();
            SaFacturaVenta = new HashSet<SaFacturaVenta>();
            SaNotaDespachoVenta = new HashSet<SaNotaDespachoVenta>();
            SaNotaEntregaVenta = new HashSet<SaNotaEntregaVenta>();
            SaPedidoVenta = new HashSet<SaPedidoVenta>();
            SaPlantillaVenta = new HashSet<SaPlantillaVenta>();
        }

        public string CoTran { get; set; }
        public string DesTran { get; set; }
        public string RespTra { get; set; }
        public int? Numcom { get; set; }
        public DateTime? Feccom { get; set; }
        public string DisCen { get; set; }
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
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoSucuMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<SaCotizacionCliente> SaCotizacionCliente { get; set; }
        public virtual ICollection<SaDevolucionCliente> SaDevolucionCliente { get; set; }
        public virtual ICollection<SaFacturaVenta> SaFacturaVenta { get; set; }
        public virtual ICollection<SaNotaDespachoVenta> SaNotaDespachoVenta { get; set; }
        public virtual ICollection<SaNotaEntregaVenta> SaNotaEntregaVenta { get; set; }
        public virtual ICollection<SaPedidoVenta> SaPedidoVenta { get; set; }
        public virtual ICollection<SaPlantillaVenta> SaPlantillaVenta { get; set; }
    }
}
