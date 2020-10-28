using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaBeneficiario
    {
        public SaBeneficiario()
        {
            SaOrdenPago = new HashSet<SaOrdenPago>();
        }

        public string CodBen { get; set; }
        public string BenDes { get; set; }
        public string Rif { get; set; }
        public string Nit { get; set; }
        public string Telefonos { get; set; }
        public string Direc1 { get; set; }
        public string TipoPer { get; set; }
        public string CoTab { get; set; }
        public bool Inactivo { get; set; }
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

        public virtual SaTabuladorIslr SaTabuladorIslr { get; set; }
        public virtual ICollection<SaOrdenPago> SaOrdenPago { get; set; }
    }
}
