using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaMovimientoCaja
    {
        public SaMovimientoCaja()
        {
            InverseMovNroNavigation = new HashSet<SaMovimientoCaja>();
            PvMovimientoCajaDevolucionExt = new HashSet<PvMovimientoCajaDevolucionExt>();
            SaCobroTpreng = new HashSet<SaCobroTpreng>();
            SaDepositoBancoRengMovAfecCNavigation = new HashSet<SaDepositoBancoReng>();
            SaDepositoBancoRengMovGeneCNavigation = new HashSet<SaDepositoBancoReng>();
            SaDevolucionCliente = new HashSet<SaDevolucionCliente>();
            SaDevolucionProveedor = new HashSet<SaDevolucionProveedor>();
            SaOrdenPago = new HashSet<SaOrdenPago>();
            SaPagoTpreng = new HashSet<SaPagoTpreng>();
        }

        public string MovNum { get; set; }
        public DateTime Fecha { get; set; }
        public string Descrip { get; set; }
        public string CodCaja { get; set; }
        public string CoBan { get; set; }
        public string CoTar { get; set; }
        public string CoVale { get; set; }
        public string CoCtaIngrEgr { get; set; }
        public decimal Tasa { get; set; }
        public string TipoMov { get; set; }
        public string FormaPag { get; set; }
        public string NumPago { get; set; }
        public bool SaldoIni { get; set; }
        public decimal MontoD { get; set; }
        public decimal MontoH { get; set; }
        public string DepNum { get; set; }
        public string Origen { get; set; }
        public string DocNum { get; set; }
        public bool Anulado { get; set; }
        public bool Depositado { get; set; }
        public bool Transferido { get; set; }
        public string MovNro { get; set; }
        public decimal? Aux01 { get; set; }
        public string Aux02 { get; set; }
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
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }
        public string DisCen { get; set; }
        public DateTime FechaChe { get; set; }

        public virtual SaBanco CoBanNavigation { get; set; }
        public virtual SaCuentaIngEgr CoCtaIngrEgrNavigation { get; set; }
        public virtual SaTarjetaCredito CoTarNavigation { get; set; }
        public virtual PvValeAlimentacion CoValeNavigation { get; set; }
        public virtual SaCaja CodCajaNavigation { get; set; }
        public virtual SaMovimientoCaja MovNroNavigation { get; set; }
        public virtual PvMovimientoCajaExt PvMovimientoCajaExt { get; set; }
        public virtual ICollection<SaMovimientoCaja> InverseMovNroNavigation { get; set; }
        public virtual ICollection<PvMovimientoCajaDevolucionExt> PvMovimientoCajaDevolucionExt { get; set; }
        public virtual ICollection<SaCobroTpreng> SaCobroTpreng { get; set; }
        public virtual ICollection<SaDepositoBancoReng> SaDepositoBancoRengMovAfecCNavigation { get; set; }
        public virtual ICollection<SaDepositoBancoReng> SaDepositoBancoRengMovGeneCNavigation { get; set; }
        public virtual ICollection<SaDevolucionCliente> SaDevolucionCliente { get; set; }
        public virtual ICollection<SaDevolucionProveedor> SaDevolucionProveedor { get; set; }
        public virtual ICollection<SaOrdenPago> SaOrdenPago { get; set; }
        public virtual ICollection<SaPagoTpreng> SaPagoTpreng { get; set; }
    }
}
