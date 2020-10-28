using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaDocumentoCompra
    {
        public SaDocumentoCompra()
        {
            SaChequeDevueltoCompra = new HashSet<SaChequeDevueltoCompra>();
            SaDevolucionProveedor = new HashSet<SaDevolucionProveedor>();
            SaDocumentoCompraReng = new HashSet<SaDocumentoCompraReng>();
            SaGiroCompraReng = new HashSet<SaGiroCompraReng>();
            SaPagoDocReng = new HashSet<SaPagoDocReng>();
        }

        public string CoTipoDoc { get; set; }
        public string NroDoc { get; set; }
        public string NroFact { get; set; }
        public string CoMone { get; set; }
        public string CoProv { get; set; }
        public string DocOrig { get; set; }
        public string MovBan { get; set; }
        public string NroOrig { get; set; }
        public string NroChe { get; set; }
        public string PorcReca { get; set; }
        public decimal MontoReca { get; set; }
        public string PorcDescGlob { get; set; }
        public decimal MontoDescGlob { get; set; }
        public bool Anulado { get; set; }
        public bool Aut { get; set; }
        public int Pagar { get; set; }
        public string Observa { get; set; }
        public string TipoImp { get; set; }
        public string TipoImp2 { get; set; }
        public string TipoImp3 { get; set; }
        public DateTime FecReg { get; set; }
        public DateTime FecEmis { get; set; }
        public DateTime FecVenc { get; set; }
        public decimal PorcImp { get; set; }
        public decimal PorcImp2 { get; set; }
        public decimal PorcImp3 { get; set; }
        public decimal MontoImp { get; set; }
        public decimal MontoImp2 { get; set; }
        public decimal MontoImp3 { get; set; }
        public decimal Tasa { get; set; }
        public decimal TotalBruto { get; set; }
        public decimal TotalNeto { get; set; }
        public decimal Saldo { get; set; }
        public decimal Adicional { get; set; }
        public decimal Otros1 { get; set; }
        public decimal Otros2 { get; set; }
        public decimal Otros3 { get; set; }
        public string ProPago { get; set; }
        public string Salestax { get; set; }
        public string ProvTer { get; set; }
        public int? RengTer { get; set; }
        public int? TipoOrigen { get; set; }
        public string NumComprobante { get; set; }
        public DateTime? Feccom { get; set; }
        public int? Numcom { get; set; }
        public string DisCen { get; set; }
        public string NControl { get; set; }
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
        public Guid Rowguid { get; set; }
        public byte[] Validador { get; set; }
        public bool? Nac { get; set; }
        public string CoCtaIngrEgr { get; set; }

        public virtual SaCuentaIngEgr CoCtaIngrEgrNavigation { get; set; }
        public virtual SaMoneda CoMoneNavigation { get; set; }
        public virtual SaProveedor CoProvNavigation { get; set; }
        public virtual SaTipoDocumento CoTipoDocNavigation { get; set; }
        public virtual SaTipoDocumento DocOrigNavigation { get; set; }
        public virtual SaMovimientoBanco MovBanNavigation { get; set; }
        public virtual SaProveedor ProvTerNavigation { get; set; }
        public virtual SaNcfinfoDocCompra SaNcfinfoDocCompra { get; set; }
        public virtual ICollection<SaChequeDevueltoCompra> SaChequeDevueltoCompra { get; set; }
        public virtual ICollection<SaDevolucionProveedor> SaDevolucionProveedor { get; set; }
        public virtual ICollection<SaDocumentoCompraReng> SaDocumentoCompraReng { get; set; }
        public virtual ICollection<SaGiroCompraReng> SaGiroCompraReng { get; set; }
        public virtual ICollection<SaPagoDocReng> SaPagoDocReng { get; set; }
    }
}
