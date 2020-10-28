using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaMovimientoBanco
    {
        public SaMovimientoBanco()
        {
            SaCheque = new HashSet<SaCheque>();
            SaCobroTpreng = new HashSet<SaCobroTpreng>();
            SaConcBanco = new HashSet<SaConcBanco>();
            SaDevolucionCliente = new HashSet<SaDevolucionCliente>();
            SaDevolucionProveedor = new HashSet<SaDevolucionProveedor>();
            SaDocumentoCompra = new HashSet<SaDocumentoCompra>();
            SaDocumentoVenta = new HashSet<SaDocumentoVenta>();
            SaOrdenPago = new HashSet<SaOrdenPago>();
            SaPagoTpreng = new HashSet<SaPagoTpreng>();
            SaTransferenciaEntreCuentasMovBanComisionNavigation = new HashSet<SaTransferenciaEntreCuentas>();
            SaTransferenciaEntreCuentasMovBanDestinoNavigation = new HashSet<SaTransferenciaEntreCuentas>();
            SaTransferenciaEntreCuentasMovBanOrigenNavigation = new HashSet<SaTransferenciaEntreCuentas>();
        }

        public string MovNum { get; set; }
        public string Descrip { get; set; }
        public string CodCta { get; set; }
        public string CoCtaIngrEgr { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Tasa { get; set; }
        public string TipoOp { get; set; }
        public string DocNum { get; set; }
        public decimal MontoD { get; set; }
        public decimal MontoH { get; set; }
        public decimal Idb { get; set; }
        public bool SaldoIni { get; set; }
        public string Origen { get; set; }
        public string CobPag { get; set; }
        public string DepNum { get; set; }
        public bool Conciliado { get; set; }
        public bool OriDep { get; set; }
        public bool Anulado { get; set; }
        public int DepCon { get; set; }
        public DateTime? FecCon { get; set; }
        public string CodIngben { get; set; }
        public DateTime FechaChe { get; set; }
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }
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
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }
        public byte[] Validador { get; set; }
        public Guid Rowguid { get; set; }
        public int? NroTransfNomi { get; set; }

        public virtual SaCuentaIngEgr CoCtaIngrEgrNavigation { get; set; }
        public virtual SaCuentaBancaria CodCtaNavigation { get; set; }
        public virtual PvMovimientoBancoExt PvMovimientoBancoExt { get; set; }
        public virtual ICollection<SaCheque> SaCheque { get; set; }
        public virtual ICollection<SaCobroTpreng> SaCobroTpreng { get; set; }
        public virtual ICollection<SaConcBanco> SaConcBanco { get; set; }
        public virtual ICollection<SaDevolucionCliente> SaDevolucionCliente { get; set; }
        public virtual ICollection<SaDevolucionProveedor> SaDevolucionProveedor { get; set; }
        public virtual ICollection<SaDocumentoCompra> SaDocumentoCompra { get; set; }
        public virtual ICollection<SaDocumentoVenta> SaDocumentoVenta { get; set; }
        public virtual ICollection<SaOrdenPago> SaOrdenPago { get; set; }
        public virtual ICollection<SaPagoTpreng> SaPagoTpreng { get; set; }
        public virtual ICollection<SaTransferenciaEntreCuentas> SaTransferenciaEntreCuentasMovBanComisionNavigation { get; set; }
        public virtual ICollection<SaTransferenciaEntreCuentas> SaTransferenciaEntreCuentasMovBanDestinoNavigation { get; set; }
        public virtual ICollection<SaTransferenciaEntreCuentas> SaTransferenciaEntreCuentasMovBanOrigenNavigation { get; set; }
    }
}
