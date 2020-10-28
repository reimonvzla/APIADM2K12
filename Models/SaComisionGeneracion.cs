using System;
using System.Collections.Generic;

namespace APIADM2K12.Models
{
    public partial class SaComisionGeneracion
    {
        public SaComisionGeneracion()
        {
            SaComisionResultado = new HashSet<SaComisionResultado>();
        }

        public string CoGeneracion { get; set; }
        public DateTime Fecha { get; set; }
        public string CoComi { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaDesde { get; set; }
        public DateTime FechaHasta { get; set; }
        public string CoVenDesde { get; set; }
        public string CoVenHasta { get; set; }
        public string TipoVenDesde { get; set; }
        public string TipoVenHasta { get; set; }
        public string CoArtDesde { get; set; }
        public string CoArtHasta { get; set; }
        public string CoCatDesde { get; set; }
        public string CoCatHasta { get; set; }
        public string CoLinDesde { get; set; }
        public string CoLinHasta { get; set; }
        public string PAdicional { get; set; }
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

        public virtual SaArticulo CoArtDesdeNavigation { get; set; }
        public virtual SaArticulo CoArtHastaNavigation { get; set; }
        public virtual SaCatArticulo CoCatDesdeNavigation { get; set; }
        public virtual SaCatArticulo CoCatHastaNavigation { get; set; }
        public virtual SaComisionTipo CoComiNavigation { get; set; }
        public virtual SaLineaArticulo CoLinDesdeNavigation { get; set; }
        public virtual SaLineaArticulo CoLinHastaNavigation { get; set; }
        public virtual SaVendedor CoVenDesdeNavigation { get; set; }
        public virtual SaVendedor CoVenHastaNavigation { get; set; }
        public virtual ICollection<SaComisionResultado> SaComisionResultado { get; set; }
    }
}
