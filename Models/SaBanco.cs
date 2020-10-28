using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaBanco
    {
        public SaBanco()
        {
            SaCobroTpreng = new HashSet<SaCobroTpreng>();
            SaCuentaBancaria = new HashSet<SaCuentaBancaria>();
            SaMovimientoCaja = new HashSet<SaMovimientoCaja>();
        }

        public string CoBan { get; set; }
        public string DesBan { get; set; }
        public string Telefonos { get; set; }
        public int Plazo1 { get; set; }
        public int Plazo2 { get; set; }
        public int Plazo3 { get; set; }
        public int Plazo4 { get; set; }
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
        public decimal? ComisMismoBanco { get; set; }
        public decimal? ComisOtrosBancos { get; set; }

        public virtual SaParametroConc SaParametroConc { get; set; }
        public virtual ICollection<SaCobroTpreng> SaCobroTpreng { get; set; }
        public virtual ICollection<SaCuentaBancaria> SaCuentaBancaria { get; set; }
        public virtual ICollection<SaMovimientoCaja> SaMovimientoCaja { get; set; }
    }
}
