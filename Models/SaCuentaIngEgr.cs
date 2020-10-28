using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaCuentaIngEgr
    {
        public SaCuentaIngEgr()
        {
            ParEmpCCtaIngEgrNavigation = new HashSet<ParEmp>();
            ParEmpVCtaIngEgrNavigation = new HashSet<ParEmp>();
            PvParEmpCoCtaIngrEgrFacDevNavigation = new HashSet<PvParEmp>();
            PvParEmpCoCtaIngrEgrNavigation = new HashSet<PvParEmp>();
            SaCliente = new HashSet<SaCliente>();
            SaCotizacionCliente = new HashSet<SaCotizacionCliente>();
            SaDepositoBanco = new HashSet<SaDepositoBanco>();
            SaDevolucionCliente = new HashSet<SaDevolucionCliente>();
            SaDevolucionProveedor = new HashSet<SaDevolucionProveedor>();
            SaDocumentoCompra = new HashSet<SaDocumentoCompra>();
            SaDocumentoVenta = new HashSet<SaDocumentoVenta>();
            SaFacturaCompra = new HashSet<SaFacturaCompra>();
            SaFacturaVenta = new HashSet<SaFacturaVenta>();
            SaMovimientoBanco = new HashSet<SaMovimientoBanco>();
            SaMovimientoCaja = new HashSet<SaMovimientoCaja>();
            SaNotaDespachoVenta = new HashSet<SaNotaDespachoVenta>();
            SaNotaEntregaVenta = new HashSet<SaNotaEntregaVenta>();
            SaNotaRecepcionCompra = new HashSet<SaNotaRecepcionCompra>();
            SaOrdenCompra = new HashSet<SaOrdenCompra>();
            SaOrdenPagoReng = new HashSet<SaOrdenPagoReng>();
            SaPedidoVenta = new HashSet<SaPedidoVenta>();
            SaPlantillaVenta = new HashSet<SaPlantillaVenta>();
            SaProveedor = new HashSet<SaProveedor>();
            SaTransferenciaEntreCuentasCtaIngrEgrComisionNavigation = new HashSet<SaTransferenciaEntreCuentas>();
            SaTransferenciaEntreCuentasCtaIngrEgrDestinoNavigation = new HashSet<SaTransferenciaEntreCuentas>();
            SaTransferenciaEntreCuentasCtaIngrEgrOrigenNavigation = new HashSet<SaTransferenciaEntreCuentas>();
        }

        public string CoCtaIngrEgr { get; set; }
        public string Descrip { get; set; }
        public string CoIslr { get; set; }
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

        public virtual SaConIslr CoIslrNavigation { get; set; }
        public virtual ICollection<ParEmp> ParEmpCCtaIngEgrNavigation { get; set; }
        public virtual ICollection<ParEmp> ParEmpVCtaIngEgrNavigation { get; set; }
        public virtual ICollection<PvParEmp> PvParEmpCoCtaIngrEgrFacDevNavigation { get; set; }
        public virtual ICollection<PvParEmp> PvParEmpCoCtaIngrEgrNavigation { get; set; }
        public virtual ICollection<SaCliente> SaCliente { get; set; }
        public virtual ICollection<SaCotizacionCliente> SaCotizacionCliente { get; set; }
        public virtual ICollection<SaDepositoBanco> SaDepositoBanco { get; set; }
        public virtual ICollection<SaDevolucionCliente> SaDevolucionCliente { get; set; }
        public virtual ICollection<SaDevolucionProveedor> SaDevolucionProveedor { get; set; }
        public virtual ICollection<SaDocumentoCompra> SaDocumentoCompra { get; set; }
        public virtual ICollection<SaDocumentoVenta> SaDocumentoVenta { get; set; }
        public virtual ICollection<SaFacturaCompra> SaFacturaCompra { get; set; }
        public virtual ICollection<SaFacturaVenta> SaFacturaVenta { get; set; }
        public virtual ICollection<SaMovimientoBanco> SaMovimientoBanco { get; set; }
        public virtual ICollection<SaMovimientoCaja> SaMovimientoCaja { get; set; }
        public virtual ICollection<SaNotaDespachoVenta> SaNotaDespachoVenta { get; set; }
        public virtual ICollection<SaNotaEntregaVenta> SaNotaEntregaVenta { get; set; }
        public virtual ICollection<SaNotaRecepcionCompra> SaNotaRecepcionCompra { get; set; }
        public virtual ICollection<SaOrdenCompra> SaOrdenCompra { get; set; }
        public virtual ICollection<SaOrdenPagoReng> SaOrdenPagoReng { get; set; }
        public virtual ICollection<SaPedidoVenta> SaPedidoVenta { get; set; }
        public virtual ICollection<SaPlantillaVenta> SaPlantillaVenta { get; set; }
        public virtual ICollection<SaProveedor> SaProveedor { get; set; }
        public virtual ICollection<SaTransferenciaEntreCuentas> SaTransferenciaEntreCuentasCtaIngrEgrComisionNavigation { get; set; }
        public virtual ICollection<SaTransferenciaEntreCuentas> SaTransferenciaEntreCuentasCtaIngrEgrDestinoNavigation { get; set; }
        public virtual ICollection<SaTransferenciaEntreCuentas> SaTransferenciaEntreCuentasCtaIngrEgrOrigenNavigation { get; set; }
    }
}
