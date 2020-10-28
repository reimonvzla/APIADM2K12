using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaTipoCliente
    {
        public SaTipoCliente()
        {
            ParEmp = new HashSet<ParEmp>();
            SaCliente = new HashSet<SaCliente>();
            SaDescArticulo = new HashSet<SaDescArticulo>();
            SaDescCategoria = new HashSet<SaDescCategoria>();
            SaDescLinea = new HashSet<SaDescLinea>();
        }

        public string TipCli { get; set; }
        public string DesTipo { get; set; }
        public string CoPrecio { get; set; }
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

        public virtual SaTipoPrecio CoPrecioNavigation { get; set; }
        public virtual SaDescProntoPago SaDescProntoPago { get; set; }
        public virtual ICollection<ParEmp> ParEmp { get; set; }
        public virtual ICollection<SaCliente> SaCliente { get; set; }
        public virtual ICollection<SaDescArticulo> SaDescArticulo { get; set; }
        public virtual ICollection<SaDescCategoria> SaDescCategoria { get; set; }
        public virtual ICollection<SaDescLinea> SaDescLinea { get; set; }
    }
}
