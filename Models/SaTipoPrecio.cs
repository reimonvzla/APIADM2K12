using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaTipoPrecio
    {
        public SaTipoPrecio()
        {
            PvConfigPuntoVprecio = new HashSet<PvConfigPuntoVprecio>();
            SaArtMargen = new HashSet<SaArtMargen>();
            SaArtPrecio = new HashSet<SaArtPrecio>();
            SaComisionPrecioArticulo = new HashSet<SaComisionPrecioArticulo>();
            SaComisionPrecioCategoria = new HashSet<SaComisionPrecioCategoria>();
            SaComisionPrecioLinea = new HashSet<SaComisionPrecioLinea>();
            SaTipoCliente = new HashSet<SaTipoCliente>();
        }

        public string CoPrecio { get; set; }
        public string DesPrecio { get; set; }
        public bool IncluyeImp { get; set; }
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

        public virtual ICollection<PvConfigPuntoVprecio> PvConfigPuntoVprecio { get; set; }
        public virtual ICollection<SaArtMargen> SaArtMargen { get; set; }
        public virtual ICollection<SaArtPrecio> SaArtPrecio { get; set; }
        public virtual ICollection<SaComisionPrecioArticulo> SaComisionPrecioArticulo { get; set; }
        public virtual ICollection<SaComisionPrecioCategoria> SaComisionPrecioCategoria { get; set; }
        public virtual ICollection<SaComisionPrecioLinea> SaComisionPrecioLinea { get; set; }
        public virtual ICollection<SaTipoCliente> SaTipoCliente { get; set; }
    }
}
