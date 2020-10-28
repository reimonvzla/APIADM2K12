using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaInventarioFisico
    {
        public SaInventarioFisico()
        {
            SaAjuste = new HashSet<SaAjuste>();
            SaResInventario = new HashSet<SaResInventario>();
        }

        public string CoInvfisico { get; set; }
        public string DesInvfisico { get; set; }
        public string CoAlma { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime? Cierre { get; set; }
        public bool ArtCero { get; set; }
        public string AjueNum { get; set; }
        public string CoTipoEnt { get; set; }
        public string CoTipoSal { get; set; }
        public bool Procesado { get; set; }
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
        public virtual SaTipoAjuste CoTipoEntNavigation { get; set; }
        public virtual SaTipoAjuste CoTipoSalNavigation { get; set; }
        public virtual ICollection<SaAjuste> SaAjuste { get; set; }
        public virtual ICollection<SaResInventario> SaResInventario { get; set; }
    }
}
