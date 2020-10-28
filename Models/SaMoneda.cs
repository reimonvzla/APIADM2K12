using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaMoneda
    {
        public SaMoneda()
        {
            SaAjuste = new HashSet<SaAjuste>();
            SaArtCompuestoGen = new HashSet<SaArtCompuestoGen>();
            SaCaja = new HashSet<SaCaja>();
            SaCliente = new HashSet<SaCliente>();
            SaCobro = new HashSet<SaCobro>();
            SaCotizacionCliente = new HashSet<SaCotizacionCliente>();
            SaCotizacionProveedor = new HashSet<SaCotizacionProveedor>();
            SaCuentaBancaria = new HashSet<SaCuentaBancaria>();
            SaDevolucionCliente = new HashSet<SaDevolucionCliente>();
            SaDevolucionProveedor = new HashSet<SaDevolucionProveedor>();
            SaDocumentoCompra = new HashSet<SaDocumentoCompra>();
            SaDocumentoVenta = new HashSet<SaDocumentoVenta>();
            SaFacturaCompra = new HashSet<SaFacturaCompra>();
            SaFacturaVenta = new HashSet<SaFacturaVenta>();
            SaNotaDespachoVenta = new HashSet<SaNotaDespachoVenta>();
            SaNotaEntregaVenta = new HashSet<SaNotaEntregaVenta>();
            SaNotaRecepcionCompra = new HashSet<SaNotaRecepcionCompra>();
            SaOrdenCompra = new HashSet<SaOrdenCompra>();
            SaOrdenPago = new HashSet<SaOrdenPago>();
            SaPago = new HashSet<SaPago>();
            SaPais = new HashSet<SaPais>();
            SaPedidoVenta = new HashSet<SaPedidoVenta>();
            SaPlantillaCompra = new HashSet<SaPlantillaCompra>();
            SaPlantillaVenta = new HashSet<SaPlantillaVenta>();
            SaProveedor = new HashSet<SaProveedor>();
            SaResInventario = new HashSet<SaResInventario>();
            SaTasa = new HashSet<SaTasa>();
            SaTraslado = new HashSet<SaTraslado>();
        }

        public string CoMone { get; set; }
        public string MoneDes { get; set; }
        public decimal Cambio { get; set; }
        public bool Relacion { get; set; }
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

        public virtual ICollection<SaAjuste> SaAjuste { get; set; }
        public virtual ICollection<SaArtCompuestoGen> SaArtCompuestoGen { get; set; }
        public virtual ICollection<SaCaja> SaCaja { get; set; }
        public virtual ICollection<SaCliente> SaCliente { get; set; }
        public virtual ICollection<SaCobro> SaCobro { get; set; }
        public virtual ICollection<SaCotizacionCliente> SaCotizacionCliente { get; set; }
        public virtual ICollection<SaCotizacionProveedor> SaCotizacionProveedor { get; set; }
        public virtual ICollection<SaCuentaBancaria> SaCuentaBancaria { get; set; }
        public virtual ICollection<SaDevolucionCliente> SaDevolucionCliente { get; set; }
        public virtual ICollection<SaDevolucionProveedor> SaDevolucionProveedor { get; set; }
        public virtual ICollection<SaDocumentoCompra> SaDocumentoCompra { get; set; }
        public virtual ICollection<SaDocumentoVenta> SaDocumentoVenta { get; set; }
        public virtual ICollection<SaFacturaCompra> SaFacturaCompra { get; set; }
        public virtual ICollection<SaFacturaVenta> SaFacturaVenta { get; set; }
        public virtual ICollection<SaNotaDespachoVenta> SaNotaDespachoVenta { get; set; }
        public virtual ICollection<SaNotaEntregaVenta> SaNotaEntregaVenta { get; set; }
        public virtual ICollection<SaNotaRecepcionCompra> SaNotaRecepcionCompra { get; set; }
        public virtual ICollection<SaOrdenCompra> SaOrdenCompra { get; set; }
        public virtual ICollection<SaOrdenPago> SaOrdenPago { get; set; }
        public virtual ICollection<SaPago> SaPago { get; set; }
        public virtual ICollection<SaPais> SaPais { get; set; }
        public virtual ICollection<SaPedidoVenta> SaPedidoVenta { get; set; }
        public virtual ICollection<SaPlantillaCompra> SaPlantillaCompra { get; set; }
        public virtual ICollection<SaPlantillaVenta> SaPlantillaVenta { get; set; }
        public virtual ICollection<SaProveedor> SaProveedor { get; set; }
        public virtual ICollection<SaResInventario> SaResInventario { get; set; }
        public virtual ICollection<SaTasa> SaTasa { get; set; }
        public virtual ICollection<SaTraslado> SaTraslado { get; set; }
    }
}
