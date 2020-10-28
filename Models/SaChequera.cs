﻿using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaChequera
    {
        public SaChequera()
        {
            SaCheque = new HashSet<SaCheque>();
        }

        public string CoChra { get; set; }
        public string ChraDes { get; set; }
        public string CodCta { get; set; }
        public string Status { get; set; }
        public int NumCh { get; set; }
        public DateTime? FechaRe { get; set; }
        public string Respons { get; set; }
        public bool LimUsoRe { get; set; }
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

        public virtual SaCuentaBancaria CodCtaNavigation { get; set; }
        public virtual ICollection<SaCheque> SaCheque { get; set; }
    }
}
