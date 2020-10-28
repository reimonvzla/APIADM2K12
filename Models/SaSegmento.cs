using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaSegmento
    {
        public SaSegmento()
        {
            ParEmpCCoSegNavigation = new HashSet<ParEmp>();
            ParEmpVCoSegNavigation = new HashSet<ParEmp>();
            SaCliente = new HashSet<SaCliente>();
            SaProveedor = new HashSet<SaProveedor>();
        }

        public string CoSeg { get; set; }
        public string SegDes { get; set; }
        public string CCuenta { get; set; }
        public string PCuenta { get; set; }
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

        public virtual ICollection<ParEmp> ParEmpCCoSegNavigation { get; set; }
        public virtual ICollection<ParEmp> ParEmpVCoSegNavigation { get; set; }
        public virtual ICollection<SaCliente> SaCliente { get; set; }
        public virtual ICollection<SaProveedor> SaProveedor { get; set; }
    }
}
