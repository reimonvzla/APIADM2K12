using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaResInventario
    {
        public SaResInventario()
        {
            SaResInventarioReng = new HashSet<SaResInventarioReng>();
        }

        public string NumResinv { get; set; }
        public string DesResinv { get; set; }
        public DateTime Fecha { get; set; }
        public string CoInvfisico { get; set; }
        public string CoAlma { get; set; }
        public string CoMone { get; set; }
        public decimal Tasa { get; set; }
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

        public virtual SaAlmacen CoAlmaNavigation { get; set; }
        public virtual SaInventarioFisico CoInvfisicoNavigation { get; set; }
        public virtual SaMoneda CoMoneNavigation { get; set; }
        public virtual ICollection<SaResInventarioReng> SaResInventarioReng { get; set; }
    }
}
