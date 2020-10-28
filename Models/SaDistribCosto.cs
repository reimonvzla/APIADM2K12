using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaDistribCosto
    {
        public SaDistribCosto()
        {
            SaDistribCostoDestinoReng = new HashSet<SaDistribCostoDestinoReng>();
            SaDistribCostoOrigenReng = new HashSet<SaDistribCostoOrigenReng>();
        }

        public string DistribNum { get; set; }
        public bool Anulado { get; set; }
        public DateTime Fecha { get; set; }
        public string Descrip { get; set; }
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
        public bool Procesado { get; set; }

        public virtual ICollection<SaDistribCostoDestinoReng> SaDistribCostoDestinoReng { get; set; }
        public virtual ICollection<SaDistribCostoOrigenReng> SaDistribCostoOrigenReng { get; set; }
    }
}
