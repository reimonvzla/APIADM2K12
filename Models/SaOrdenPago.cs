using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaOrdenPago
    {
        public SaOrdenPago()
        {
            SaOrdenPagoReng = new HashSet<SaOrdenPagoReng>();
        }

        public string OrdNum { get; set; }
        public string Status { get; set; }
        public DateTime Fecha { get; set; }
        public string CodBen { get; set; }
        public string Descrip { get; set; }
        public string FormaPag { get; set; }
        public DateTime FecPag { get; set; }
        public string CodCta { get; set; }
        public string DocNum { get; set; }
        public string CodCaja { get; set; }
        public string MovNumC { get; set; }
        public string MovNumB { get; set; }
        public DateTime? Feccom { get; set; }
        public string DisCen { get; set; }
        public int? Numcom { get; set; }
        public decimal Tasa { get; set; }
        public string CoMone { get; set; }
        public bool Anulado { get; set; }
        public bool SinoReten { get; set; }
        public int Pagar { get; set; }
        public string Origen { get; set; }
        public string OrigenD { get; set; }
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

        public virtual SaMoneda CoMoneNavigation { get; set; }
        public virtual SaBeneficiario CodBenNavigation { get; set; }
        public virtual SaCaja CodCajaNavigation { get; set; }
        public virtual SaCuentaBancaria CodCtaNavigation { get; set; }
        public virtual SaMovimientoBanco MovNumBNavigation { get; set; }
        public virtual SaMovimientoCaja MovNumCNavigation { get; set; }
        public virtual ICollection<SaOrdenPagoReng> SaOrdenPagoReng { get; set; }
    }
}
