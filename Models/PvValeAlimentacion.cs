using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class PvValeAlimentacion
    {
        public PvValeAlimentacion()
        {
            PvValeAlimentacionReng = new HashSet<PvValeAlimentacionReng>();
            SaCobroTpreng = new HashSet<SaCobroTpreng>();
            SaMovimientoCaja = new HashSet<SaMovimientoCaja>();
        }

        public string CoVale { get; set; }
        public string ValeDescrip { get; set; }
        public decimal Comision { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Recargo { get; set; }
        public bool Inactivo { get; set; }
        public byte[] Imagen { get; set; }
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

        public virtual ICollection<PvValeAlimentacionReng> PvValeAlimentacionReng { get; set; }
        public virtual ICollection<SaCobroTpreng> SaCobroTpreng { get; set; }
        public virtual ICollection<SaMovimientoCaja> SaMovimientoCaja { get; set; }
    }
}
