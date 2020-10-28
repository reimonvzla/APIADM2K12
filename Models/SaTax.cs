using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaTax
    {
        public SaTax()
        {
            SaCotizacionCliente = new HashSet<SaCotizacionCliente>();
            SaCotizacionProveedor = new HashSet<SaCotizacionProveedor>();
            SaDevolucionCliente = new HashSet<SaDevolucionCliente>();
            SaDevolucionProveedor = new HashSet<SaDevolucionProveedor>();
            SaDocumentoVenta = new HashSet<SaDocumentoVenta>();
            SaFacturaCompra = new HashSet<SaFacturaCompra>();
            SaFacturaVenta = new HashSet<SaFacturaVenta>();
            SaNotaDespachoVenta = new HashSet<SaNotaDespachoVenta>();
            SaNotaEntregaVenta = new HashSet<SaNotaEntregaVenta>();
            SaNotaRecepcionCompra = new HashSet<SaNotaRecepcionCompra>();
            SaOrdenCompra = new HashSet<SaOrdenCompra>();
            SaPedidoVenta = new HashSet<SaPedidoVenta>();
            SaPlantillaCompra = new HashSet<SaPlantillaCompra>();
            SaPlantillaVenta = new HashSet<SaPlantillaVenta>();
        }

        public string TaxId { get; set; }
        public string TaxDes { get; set; }
        public string Entidad { get; set; }
        public decimal Tasa1 { get; set; }
        public decimal Tasa2 { get; set; }
        public decimal Tasa3 { get; set; }
        public bool Formula { get; set; }
        public decimal Limite { get; set; }
        public decimal Porc1 { get; set; }
        public decimal Porc2 { get; set; }
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
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucuIn { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }
        public string CoSucuMo { get; set; }

        public virtual ICollection<SaCotizacionCliente> SaCotizacionCliente { get; set; }
        public virtual ICollection<SaCotizacionProveedor> SaCotizacionProveedor { get; set; }
        public virtual ICollection<SaDevolucionCliente> SaDevolucionCliente { get; set; }
        public virtual ICollection<SaDevolucionProveedor> SaDevolucionProveedor { get; set; }
        public virtual ICollection<SaDocumentoVenta> SaDocumentoVenta { get; set; }
        public virtual ICollection<SaFacturaCompra> SaFacturaCompra { get; set; }
        public virtual ICollection<SaFacturaVenta> SaFacturaVenta { get; set; }
        public virtual ICollection<SaNotaDespachoVenta> SaNotaDespachoVenta { get; set; }
        public virtual ICollection<SaNotaEntregaVenta> SaNotaEntregaVenta { get; set; }
        public virtual ICollection<SaNotaRecepcionCompra> SaNotaRecepcionCompra { get; set; }
        public virtual ICollection<SaOrdenCompra> SaOrdenCompra { get; set; }
        public virtual ICollection<SaPedidoVenta> SaPedidoVenta { get; set; }
        public virtual ICollection<SaPlantillaCompra> SaPlantillaCompra { get; set; }
        public virtual ICollection<SaPlantillaVenta> SaPlantillaVenta { get; set; }
    }
}
