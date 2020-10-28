using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class PvParEmp
    {
        public string CodEmp { get; set; }
        public string CodUsu { get; set; }
        public string CoCtaIngrEgr { get; set; }
        public string CoCtaIngrEgrFacDev { get; set; }
        public string CodCaja { get; set; }
        public bool TfVendedor { get; set; }
        public bool TfNumTurno { get; set; }
        public bool TfConsecutivos { get; set; }
        public bool TfCaja { get; set; }
        public bool TfSucursal { get; set; }
        public bool TfCajero { get; set; }
        public bool TfNumItems { get; set; }
        public bool ManTurno { get; set; }
        public bool ManejoIdentificadores { get; set; }
        public string CoImagen { get; set; }
        public string DescripImagen { get; set; }
        public bool UsoNcr { get; set; }
        public bool FpEfectivo { get; set; }
        public bool FpVale { get; set; }
        public bool FpCheque { get; set; }
        public bool FpTarjd { get; set; }
        public bool FpTarjc { get; set; }
        public decimal? MontoMaxVuelto { get; set; }
        public decimal? MontoMinCheque { get; set; }
        public decimal? MontoMinTarjd { get; set; }
        public decimal? MontoMinTarjc { get; set; }
        public bool DevEfectivo { get; set; }
        public bool DevCheque { get; set; }
        public bool DevTarjeta { get; set; }
        public bool DevNcr { get; set; }
        public bool DevVale { get; set; }
        public string ExpreRegTelefVal { get; set; }
        public string ExpreRegTelefEjm { get; set; }
        public string ExpreRegEmailVal { get; set; }
        public string ExpreRegEmailEjm { get; set; }
        public string TipoCliente { get; set; }
        public string EtiquetaImpuesto { get; set; }
        public string LogoEmpresa { get; set; }
        public bool AutorizaDevEfect { get; set; }
        public int? DiasMaxDev { get; set; }
        public decimal? MontoMinDev { get; set; }
        public decimal? MontoMaxDev { get; set; }
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
        public bool FpDeposito { get; set; }
        public bool FpTransferencia { get; set; }
        public decimal? MontoMinDeposito { get; set; }
        public decimal? MontoMinTransferencia { get; set; }
        public string CoCtaIngrEgrBanco { get; set; }

        public virtual SaCuentaIngEgr CoCtaIngrEgrFacDevNavigation { get; set; }
        public virtual SaCuentaIngEgr CoCtaIngrEgrNavigation { get; set; }
        public virtual SaCaja CodCajaNavigation { get; set; }
    }
}
