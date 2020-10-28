using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaArtUnidad
    {
        public SaArtUnidad()
        {
            SaAjusteRengCo = new HashSet<SaAjusteReng>();
            SaAjusteRengSaArtUnidad = new HashSet<SaAjusteReng>();
            SaArtCompuesto = new HashSet<SaArtCompuesto>();
            SaArtCompuestoGen = new HashSet<SaArtCompuestoGen>();
            SaArtCompuestoGenReng = new HashSet<SaArtCompuestoGenReng>();
            SaArtCompuestoReng = new HashSet<SaArtCompuestoReng>();
            SaArtIdentificadorReng = new HashSet<SaArtIdentificadorReng>();
            SaCotizacionClienteRengCo = new HashSet<SaCotizacionClienteReng>();
            SaCotizacionClienteRengSaArtUnidad = new HashSet<SaCotizacionClienteReng>();
            SaCotizacionProveedorRengCo = new HashSet<SaCotizacionProveedorReng>();
            SaCotizacionProveedorRengSaArtUnidad = new HashSet<SaCotizacionProveedorReng>();
            SaDevolucionClienteRengCo = new HashSet<SaDevolucionClienteReng>();
            SaDevolucionClienteRengSaArtUnidad = new HashSet<SaDevolucionClienteReng>();
            SaDevolucionProveedorRengCo = new HashSet<SaDevolucionProveedorReng>();
            SaDevolucionProveedorRengSaArtUnidad = new HashSet<SaDevolucionProveedorReng>();
            SaDocumentoCompraReng = new HashSet<SaDocumentoCompraReng>();
            SaDocumentoVentaReng = new HashSet<SaDocumentoVentaReng>();
            SaFacturaCompraRengCo = new HashSet<SaFacturaCompraReng>();
            SaFacturaCompraRengSaArtUnidad = new HashSet<SaFacturaCompraReng>();
            SaFacturaVentaRengCo = new HashSet<SaFacturaVentaReng>();
            SaFacturaVentaRengSaArtUnidad = new HashSet<SaFacturaVentaReng>();
            SaNotaDespachoVentaRengCo = new HashSet<SaNotaDespachoVentaReng>();
            SaNotaDespachoVentaRengSaArtUnidad = new HashSet<SaNotaDespachoVentaReng>();
            SaNotaEntregaVentaRengCo = new HashSet<SaNotaEntregaVentaReng>();
            SaNotaEntregaVentaRengSaArtUnidad = new HashSet<SaNotaEntregaVentaReng>();
            SaNotaRecepcionCompraRengCo = new HashSet<SaNotaRecepcionCompraReng>();
            SaNotaRecepcionCompraRengSaArtUnidad = new HashSet<SaNotaRecepcionCompraReng>();
            SaOrdenCompraRengCo = new HashSet<SaOrdenCompraReng>();
            SaOrdenCompraRengSaArtUnidad = new HashSet<SaOrdenCompraReng>();
            SaPedidoVentaRengCo = new HashSet<SaPedidoVentaReng>();
            SaPedidoVentaRengSaArtUnidad = new HashSet<SaPedidoVentaReng>();
            SaPlantillaCompraRengCo = new HashSet<SaPlantillaCompraReng>();
            SaPlantillaCompraRengSaArtUnidad = new HashSet<SaPlantillaCompraReng>();
            SaPlantillaVentaRengCo = new HashSet<SaPlantillaVentaReng>();
            SaPlantillaVentaRengSaArtUnidad = new HashSet<SaPlantillaVentaReng>();
            SaResInventarioRengCo = new HashSet<SaResInventarioReng>();
            SaResInventarioRengSaArtUnidad = new HashSet<SaResInventarioReng>();
            SaTrasladoRengCo = new HashSet<SaTrasladoReng>();
            SaTrasladoRengSaArtUnidad = new HashSet<SaTrasladoReng>();
        }

        public string CoArt { get; set; }
        public string CoUni { get; set; }
        public bool Relacion { get; set; }
        public decimal Equivalencia { get; set; }
        public bool UsoVenta { get; set; }
        public bool UsoCompra { get; set; }
        public bool UniPrincipal { get; set; }
        public bool UsoPrincipal { get; set; }
        public bool UniSecundaria { get; set; }
        public bool UsoSecundaria { get; set; }
        public bool UsoNumDecimales { get; set; }
        public int NumDecimales { get; set; }
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

        public virtual SaArticulo CoArtNavigation { get; set; }
        public virtual SaUnidad CoUniNavigation { get; set; }
        public virtual ICollection<SaAjusteReng> SaAjusteRengCo { get; set; }
        public virtual ICollection<SaAjusteReng> SaAjusteRengSaArtUnidad { get; set; }
        public virtual ICollection<SaArtCompuesto> SaArtCompuesto { get; set; }
        public virtual ICollection<SaArtCompuestoGen> SaArtCompuestoGen { get; set; }
        public virtual ICollection<SaArtCompuestoGenReng> SaArtCompuestoGenReng { get; set; }
        public virtual ICollection<SaArtCompuestoReng> SaArtCompuestoReng { get; set; }
        public virtual ICollection<SaArtIdentificadorReng> SaArtIdentificadorReng { get; set; }
        public virtual ICollection<SaCotizacionClienteReng> SaCotizacionClienteRengCo { get; set; }
        public virtual ICollection<SaCotizacionClienteReng> SaCotizacionClienteRengSaArtUnidad { get; set; }
        public virtual ICollection<SaCotizacionProveedorReng> SaCotizacionProveedorRengCo { get; set; }
        public virtual ICollection<SaCotizacionProveedorReng> SaCotizacionProveedorRengSaArtUnidad { get; set; }
        public virtual ICollection<SaDevolucionClienteReng> SaDevolucionClienteRengCo { get; set; }
        public virtual ICollection<SaDevolucionClienteReng> SaDevolucionClienteRengSaArtUnidad { get; set; }
        public virtual ICollection<SaDevolucionProveedorReng> SaDevolucionProveedorRengCo { get; set; }
        public virtual ICollection<SaDevolucionProveedorReng> SaDevolucionProveedorRengSaArtUnidad { get; set; }
        public virtual ICollection<SaDocumentoCompraReng> SaDocumentoCompraReng { get; set; }
        public virtual ICollection<SaDocumentoVentaReng> SaDocumentoVentaReng { get; set; }
        public virtual ICollection<SaFacturaCompraReng> SaFacturaCompraRengCo { get; set; }
        public virtual ICollection<SaFacturaCompraReng> SaFacturaCompraRengSaArtUnidad { get; set; }
        public virtual ICollection<SaFacturaVentaReng> SaFacturaVentaRengCo { get; set; }
        public virtual ICollection<SaFacturaVentaReng> SaFacturaVentaRengSaArtUnidad { get; set; }
        public virtual ICollection<SaNotaDespachoVentaReng> SaNotaDespachoVentaRengCo { get; set; }
        public virtual ICollection<SaNotaDespachoVentaReng> SaNotaDespachoVentaRengSaArtUnidad { get; set; }
        public virtual ICollection<SaNotaEntregaVentaReng> SaNotaEntregaVentaRengCo { get; set; }
        public virtual ICollection<SaNotaEntregaVentaReng> SaNotaEntregaVentaRengSaArtUnidad { get; set; }
        public virtual ICollection<SaNotaRecepcionCompraReng> SaNotaRecepcionCompraRengCo { get; set; }
        public virtual ICollection<SaNotaRecepcionCompraReng> SaNotaRecepcionCompraRengSaArtUnidad { get; set; }
        public virtual ICollection<SaOrdenCompraReng> SaOrdenCompraRengCo { get; set; }
        public virtual ICollection<SaOrdenCompraReng> SaOrdenCompraRengSaArtUnidad { get; set; }
        public virtual ICollection<SaPedidoVentaReng> SaPedidoVentaRengCo { get; set; }
        public virtual ICollection<SaPedidoVentaReng> SaPedidoVentaRengSaArtUnidad { get; set; }
        public virtual ICollection<SaPlantillaCompraReng> SaPlantillaCompraRengCo { get; set; }
        public virtual ICollection<SaPlantillaCompraReng> SaPlantillaCompraRengSaArtUnidad { get; set; }
        public virtual ICollection<SaPlantillaVentaReng> SaPlantillaVentaRengCo { get; set; }
        public virtual ICollection<SaPlantillaVentaReng> SaPlantillaVentaRengSaArtUnidad { get; set; }
        public virtual ICollection<SaResInventarioReng> SaResInventarioRengCo { get; set; }
        public virtual ICollection<SaResInventarioReng> SaResInventarioRengSaArtUnidad { get; set; }
        public virtual ICollection<SaTrasladoReng> SaTrasladoRengCo { get; set; }
        public virtual ICollection<SaTrasladoReng> SaTrasladoRengSaArtUnidad { get; set; }
    }
}
