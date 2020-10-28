using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaPagoDocReng
    {
        public SaPagoDocReng()
        {
            InverseRowguidRengOriNavigation = new HashSet<SaPagoDocReng>();
            SaPagoRentenReng = new HashSet<SaPagoRentenReng>();
            SaPagoRetenIvaReng = new HashSet<SaPagoRetenIvaReng>();
        }

        public int RengNum { get; set; }
        public string CobNum { get; set; }
        public string CoTipoDoc { get; set; }
        public string NroDoc { get; set; }
        public string NroFact { get; set; }
        public decimal MontCob { get; set; }
        public decimal DppagoPorcDesc { get; set; }
        public decimal DppagoMonto { get; set; }
        public decimal MontoRetencionIva { get; set; }
        public decimal MontoRetencion { get; set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public Guid? RowguidRengOri { get; set; }
        public Guid? RetenTerceroRowguidOri { get; set; }
        public int? TipoOrigen { get; set; }
        public string GenOrigen { get; set; }
        public string CoSucuIn { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoSucuMo { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SaPago CobNumNavigation { get; set; }
        public virtual SaProveedor RetenTerceroRowguidOriNavigation { get; set; }
        public virtual SaPagoDocReng RowguidRengOriNavigation { get; set; }
        public virtual SaDocumentoCompra SaDocumentoCompra { get; set; }
        public virtual ICollection<SaPagoDocReng> InverseRowguidRengOriNavigation { get; set; }
        public virtual ICollection<SaPagoRentenReng> SaPagoRentenReng { get; set; }
        public virtual ICollection<SaPagoRetenIvaReng> SaPagoRetenIvaReng { get; set; }
    }
}
