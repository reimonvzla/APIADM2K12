using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class PvRenglonTicket
    {
        public string CobNum { get; set; }
        public int RengNum { get; set; }
        public int RengNumVale { get; set; }
        public string CoVale { get; set; }
        public int Cantidad { get; set; }
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

        public virtual PvValeAlimentacionReng PvValeAlimentacionReng { get; set; }
        public virtual SaCobroTpreng SaCobroTpreng { get; set; }
    }
}
