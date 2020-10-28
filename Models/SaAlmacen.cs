using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaAlmacen
    {
        public SaAlmacen()
        {
            SaAjPrecioCostoAuto = new HashSet<SaAjPrecioCostoAuto>();
            SaAjusteReng = new HashSet<SaAjusteReng>();
            SaArtCompuestoGen = new HashSet<SaArtCompuestoGen>();
            SaArtCompuestoGenReng = new HashSet<SaArtCompuestoGenReng>();
            SaArtPrecio = new HashSet<SaArtPrecio>();
            SaArtUbicacion = new HashSet<SaArtUbicacion>();
            SaCostoHistoricoEntrada = new HashSet<SaCostoHistoricoEntrada>();
            SaCostoHistoricoSalida = new HashSet<SaCostoHistoricoSalida>();
            SaCotizacionClienteReng = new HashSet<SaCotizacionClienteReng>();
            SaCotizacionProveedorReng = new HashSet<SaCotizacionProveedorReng>();
            SaDevolucionClienteReng = new HashSet<SaDevolucionClienteReng>();
            SaDevolucionProveedorReng = new HashSet<SaDevolucionProveedorReng>();
            SaFacturaCompraReng = new HashSet<SaFacturaCompraReng>();
            SaFacturaVentaReng = new HashSet<SaFacturaVentaReng>();
            SaInventarioFisico = new HashSet<SaInventarioFisico>();
            SaLoteEntrada = new HashSet<SaLoteEntrada>();
            SaLoteSalida = new HashSet<SaLoteSalida>();
            SaNotaDespachoVentaReng = new HashSet<SaNotaDespachoVentaReng>();
            SaNotaEntregaVentaReng = new HashSet<SaNotaEntregaVentaReng>();
            SaNotaRecepcionCompraReng = new HashSet<SaNotaRecepcionCompraReng>();
            SaOrdenCompraReng = new HashSet<SaOrdenCompraReng>();
            SaPedidoVentaReng = new HashSet<SaPedidoVentaReng>();
            SaPlantillaCompraReng = new HashSet<SaPlantillaCompraReng>();
            SaPlantillaVentaReng = new HashSet<SaPlantillaVentaReng>();
            SaResInventario = new HashSet<SaResInventario>();
            SaSeriales = new HashSet<SaSeriales>();
            SaStockAlmacen = new HashSet<SaStockAlmacen>();
            SaTrasladoAlmDestNavigation = new HashSet<SaTraslado>();
            SaTrasladoAlmOrigNavigation = new HashSet<SaTraslado>();
            SaTrasladoAlmTmpNavigation = new HashSet<SaTraslado>();
        }

        public string CoAlma { get; set; }
        public string DesAlma { get; set; }
        public string CoSucur { get; set; }
        public bool Noventa { get; set; }
        public bool Nocompra { get; set; }
        public bool Materiales { get; set; }
        public bool Produccion { get; set; }
        public bool AlmTemp { get; set; }
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

        public virtual SaSucursal CoSucurNavigation { get; set; }
        public virtual ICollection<SaAjPrecioCostoAuto> SaAjPrecioCostoAuto { get; set; }
        public virtual ICollection<SaAjusteReng> SaAjusteReng { get; set; }
        public virtual ICollection<SaArtCompuestoGen> SaArtCompuestoGen { get; set; }
        public virtual ICollection<SaArtCompuestoGenReng> SaArtCompuestoGenReng { get; set; }
        public virtual ICollection<SaArtPrecio> SaArtPrecio { get; set; }
        public virtual ICollection<SaArtUbicacion> SaArtUbicacion { get; set; }
        public virtual ICollection<SaCostoHistoricoEntrada> SaCostoHistoricoEntrada { get; set; }
        public virtual ICollection<SaCostoHistoricoSalida> SaCostoHistoricoSalida { get; set; }
        public virtual ICollection<SaCotizacionClienteReng> SaCotizacionClienteReng { get; set; }
        public virtual ICollection<SaCotizacionProveedorReng> SaCotizacionProveedorReng { get; set; }
        public virtual ICollection<SaDevolucionClienteReng> SaDevolucionClienteReng { get; set; }
        public virtual ICollection<SaDevolucionProveedorReng> SaDevolucionProveedorReng { get; set; }
        public virtual ICollection<SaFacturaCompraReng> SaFacturaCompraReng { get; set; }
        public virtual ICollection<SaFacturaVentaReng> SaFacturaVentaReng { get; set; }
        public virtual ICollection<SaInventarioFisico> SaInventarioFisico { get; set; }
        public virtual ICollection<SaLoteEntrada> SaLoteEntrada { get; set; }
        public virtual ICollection<SaLoteSalida> SaLoteSalida { get; set; }
        public virtual ICollection<SaNotaDespachoVentaReng> SaNotaDespachoVentaReng { get; set; }
        public virtual ICollection<SaNotaEntregaVentaReng> SaNotaEntregaVentaReng { get; set; }
        public virtual ICollection<SaNotaRecepcionCompraReng> SaNotaRecepcionCompraReng { get; set; }
        public virtual ICollection<SaOrdenCompraReng> SaOrdenCompraReng { get; set; }
        public virtual ICollection<SaPedidoVentaReng> SaPedidoVentaReng { get; set; }
        public virtual ICollection<SaPlantillaCompraReng> SaPlantillaCompraReng { get; set; }
        public virtual ICollection<SaPlantillaVentaReng> SaPlantillaVentaReng { get; set; }
        public virtual ICollection<SaResInventario> SaResInventario { get; set; }
        public virtual ICollection<SaSeriales> SaSeriales { get; set; }
        public virtual ICollection<SaStockAlmacen> SaStockAlmacen { get; set; }
        public virtual ICollection<SaTraslado> SaTrasladoAlmDestNavigation { get; set; }
        public virtual ICollection<SaTraslado> SaTrasladoAlmOrigNavigation { get; set; }
        public virtual ICollection<SaTraslado> SaTrasladoAlmTmpNavigation { get; set; }
    }
}
